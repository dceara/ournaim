using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using Common.Protocol;
using Common;
using Common.ProtocolEntities;
using Common.File_Transfer;

namespace Controller.File_Transfer
{
    public delegate IDictionary<int,string> GetFileListDelegate();

    public delegate void ReceiveFileDelegate(string writeLocation, int fileId);

    public class PeerReceiverConnectionHandler
    {
        private string _peerAddress;
        private ushort _peerPort; 

        public GetFileListDelegate fileListDelegate = null;
        public ReceiveFileDelegate receiveFileDelegate = null;

        public LockableBool toCancel = new LockableBool(false);

        public PeerReceiverConnectionHandler(string peerAddress,ushort peerPort)
        {
            _peerAddress = peerAddress;
            _peerPort = peerPort;
            fileListDelegate = new GetFileListDelegate(GetFileList);
            receiveFileDelegate = new ReceiveFileDelegate(ReceiveFile);
        }

        TcpClient clientTCPConnection = null;
        NetworkStream receiverStream = null;

        private void ConnectToPeer()
        {
            clientTCPConnection = new TcpClient(_peerAddress,_peerPort);
            receiverStream = clientTCPConnection.GetStream();
        }

        public void Run()
        {
            ConnectToPeer();
        }

        /// <summary>
        /// this method should be invoked to request the filelist from the peer
        /// </summary>
        /// <returns></returns>
        private IDictionary<int, string> GetFileList()
        {
            AMessageData messageData = new FileListGetMessageData(new Dictionary<int, string>());
            Message fileListGetMessage = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET), messageData);
            byte[] buffer = fileListGetMessage.Serialize();
            receiverStream.Write(buffer, 0, buffer.Length);

            byte[] headerBuffer = new byte[8];
            int readBytes = receiverStream.Read(headerBuffer, 0, 8);
            if (readBytes < 8)
            {
#warning must test this part!!!!!!!!
                receiverStream.Flush();
                return new Dictionary<int,string>();
            }
            ushort contentLength = AMessageData.ToShort(headerBuffer[6], headerBuffer[7]);
            byte[] rawDataBuffer = new byte[headerBuffer.Length + contentLength];
            Array.Copy(headerBuffer, 0, rawDataBuffer, 0, headerBuffer.Length);
            readBytes = receiverStream.Read(rawDataBuffer, headerBuffer.Length, contentLength);
            if (readBytes != contentLength)
            {
#warning must test this part!!!!!!!!
                receiverStream.Flush();
                return new Dictionary<int, string>();
            }
            Message receivedMessage = new Message(rawDataBuffer);
            if (receivedMessage.Header.ServiceType != ServiceTypes.FILE_LIST_GET)
            {
                return new Dictionary<int, string>();
            }
            FileListGetMessageData fileListMessageData = (FileListGetMessageData)Message.GetMessageData(receivedMessage);
            return fileListMessageData.FileList;
        }

        /// <summary>
        /// this method should be invoked to receive a file from the peer
        /// </summary>
        /// <param name="writeLocation"></param>
        /// <param name="fileId"></param>
        private void ReceiveFile(string writeLocation, int fileId)
        {
            FileStream localFileStream = new FileStream(writeLocation, FileMode.OpenOrCreate);
            int receivedSize = 0;
            byte[] headerBuffer = new byte[8];
            int readBytes = receiverStream.Read(headerBuffer, 0, 8);
            ushort contentLength = AMessageData.ToShort(headerBuffer[6], headerBuffer[7]);
            byte[] contentBuffer = new byte[contentLength];
            readBytes = receiverStream.Read(contentBuffer, 0, contentLength);
            byte[] rawData = new byte[headerBuffer.Length+contentLength];
            Array.Copy(headerBuffer,rawData,headerBuffer.Length);
            Array.Copy(contentBuffer,0,rawData,headerBuffer.Length,contentLength);
            Message receivedMessage = new Message(rawData);
            FileTransferSendMessageData messageData = (FileTransferSendMessageData)Message.GetMessageData(receivedMessage);
            localFileStream.Write(messageData.Content, 0, messageData.Content.Length);
            receivedSize += messageData.Content.Length;
            while (messageData.FileLength > receivedSize)
            {
                lock(this.toCancel)
                {
                    if (this.toCancel.Value)
                    {
                        this.toCancel.Value = false;
                        localFileStream.Close();
                        AMessageData cancelMessageData = new NackMessageData();
                        Message cancelMessage = new Message(new MessageHeader(ServiceTypes.NACK), cancelMessageData);
                        byte[] buffer = cancelMessage.Serialize();
                        receiverStream.Write(buffer, 0, buffer.Length);
                        File.Delete(writeLocation); 
                        return;
                    }
                }
                headerBuffer = new byte[8];
                readBytes = receiverStream.Read(headerBuffer, 0, 8);
                contentLength = AMessageData.ToShort(headerBuffer[6], headerBuffer[7]);
                contentBuffer = new byte[contentLength];
                readBytes = receiverStream.Read(contentBuffer, 0, contentLength);
                rawData = new byte[headerBuffer.Length + contentLength];
                Array.Copy(headerBuffer, rawData, headerBuffer.Length);
                Array.Copy(contentBuffer, 0, rawData, headerBuffer.Length, contentLength);
                receivedMessage = new Message(rawData);
                messageData = (FileTransferSendMessageData)Message.GetMessageData(receivedMessage);
                localFileStream.Write(messageData.Content, 0, messageData.Content.Length);
            }
            localFileStream.Close();
        }
    }

    public delegate void AddItemToFileListDelegate(int fileId,string fileName);
    public delegate void RemoveItemFromFileListDelegate(int fileId);

    public class PeerSenderConnectionHandler
    {
        private string _receiverName;
        private ushort _senderPort;
        private IDictionary<int, string> _fileList;

        private bool _cancelCurrentTransfer = false;

        public AddItemToFileListDelegate addItemToFileListDelegate = null;
        public RemoveItemFromFileListDelegate removeItemFromFileListDelegate = null;

        /// <summary>
        /// creates a copy of the filelist for threading purposes. All the changes on th filelist must be invoked to the connection handler too.
        /// </summary>
        /// <param name="receiverName"></param>
        /// <param name="senderPort"></param>
        /// <param name="fileList"></param>
        public PeerSenderConnectionHandler(string receiverName, ushort senderPort, IDictionary<int,string> fileList)
        {
            this._receiverName = receiverName;
            this._senderPort = senderPort;
            _fileList = new Dictionary<int, string>() ;
            foreach (KeyValuePair<int, string> pair in fileList)
            {
                _fileList.Add(pair.Key, pair.Value);
            }
            addItemToFileListDelegate = new AddItemToFileListDelegate(AddItemToFileList);
            removeItemFromFileListDelegate = new RemoveItemFromFileListDelegate(RemoveItemFromFileList);
        }

        /// <summary>
        /// this method should be invoked if an item has been added to the filelist
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        private void AddItemToFileList(int fileId, string filename)
        {
            _fileList.Add(fileId, filename);
        }

        /// <summary>
        /// this method should be invoked if an item has been Removed from the filelist
        /// </summary>
        /// <param name="fileId"></param>
        private void RemoveItemFromFileList(int fileId)
        {
            _fileList.Remove(fileId);
        }

        TcpClient client = null;
        FileStream currentFileStream = null;
        long currentFilePosition = 0;
        int currentFileId = 0;
        
        public void Run()
        {
            TcpListener listener = new TcpListener(_senderPort);
            listener.Start();
            client = listener.AcceptTcpClient();
            
            while (true)
            {
                if (client.Client.Poll(1, SelectMode.SelectRead))
                {
                    ProccessInputs();
                }
                if (client.Client.Poll(1, SelectMode.SelectWrite))
                {
                    ProccessOutputs();
                }
            }
        }

        private void ProccessOutputs()
        {
            if (_cancelCurrentTransfer)
            {
                _cancelCurrentTransfer = false;
                currentFileStream.Close();
                currentFileStream = null;
                return;
            }
            if (currentFileStream == null)
                return;
            NetworkStream clientStream = client.GetStream();
            byte[] buffer = new byte[AMessageData.MAX_MESSAGE_SIZE];
            long nextPosition = currentFilePosition+AMessageData.MAX_MESSAGE_SIZE > currentFileStream.Length ? 
                (currentFileStream.Length-currentFilePosition) : (currentFilePosition + AMessageData.MAX_MESSAGE_SIZE);
            currentFileStream.Lock(currentFilePosition, nextPosition);
            int readBytes = currentFileStream.Read(buffer, 0, AMessageData.MAX_MESSAGE_SIZE);
            currentFileStream.Lock(currentFilePosition, nextPosition);
            currentFilePosition = nextPosition;

            Message toSendMessage = new Message(new MessageHeader(ServiceTypes.FILE_TRANSFER_SEND), 
                                                new FileTransferSendMessageData(currentFileId, (int)currentFileStream.Length, buffer));

            byte[] toSendBuffer = toSendMessage.Serialize();

            clientStream.Write(toSendBuffer, 0, toSendBuffer.Length);
            
            if(readBytes < AMessageData.MAX_MESSAGE_SIZE)
            {
                currentFileStream.Close();
                currentFileStream = null;
            }
        }

        private void ProccessInputs()
        {
            NetworkStream clientStream = client.GetStream();
            byte[] headerBuffer = new byte[8];
            int readBytes = clientStream.Read(headerBuffer, 0, 8);
            if (readBytes < 8)
            {
#warning must test this part!!!!!!!!
                clientStream.Flush();
                return;
            }
            ushort contentLength = AMessageData.ToShort(headerBuffer[6], headerBuffer[7]);
            byte[] rawDataBuffer = new byte[headerBuffer.Length + contentLength];
            Array.Copy(headerBuffer,0,rawDataBuffer,0,headerBuffer.Length);
            readBytes = clientStream.Read(rawDataBuffer, headerBuffer.Length, contentLength);
            if (readBytes != contentLength)
            {
#warning must test this part!!!!!!!!
                clientStream.Flush();
                return;
            }
            Message receivedMessage = new Message(rawDataBuffer);
            AnalyzeMessage(receivedMessage);
        }

        private void AnalyzeMessage(Message receivedMessage)
        {
            switch (receivedMessage.Header.ServiceType)
            {
                case ServiceTypes.FILE_LIST_GET:
                    SendFileList();
                    break;
                case ServiceTypes.FILE_TRANSFER_GET:
                    StartSendFile(receivedMessage);
                    break;
                case ServiceTypes.NACK:
                    _cancelCurrentTransfer = true;
                    break;
            }
        }

        private void StartSendFile(Message receivedMessage)
        {
            FileTransferGetMessageData messageData = (FileTransferGetMessageData)Message.GetMessageData(receivedMessage);
            currentFileId = messageData.Id;
            currentFileStream = new FileStream(_fileList[currentFileId], FileMode.Open);
            currentFilePosition = 0;
        }

        private void SendFileList()
        {
            AMessageData messageData = new FileListGetMessageData(_fileList);
            Message fileListMessage = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET), messageData);
            byte[] buffer = fileListMessage.Serialize();
            client.GetStream().Write(buffer, 0, buffer.Length);
            
        }
    }
}

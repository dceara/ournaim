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
    #region PeerReceiverConnectionHandler Class

    /// <summary>
    /// This is invoked to get the Peer's file list
    /// </summary>
    /// <returns>The File List</returns>
    public delegate IDictionary<int,string> GetFileListDelegate();

    /// <summary>
    /// This is invoked to receive a specific file from the Peer
    /// </summary>
    /// <param name="writeLocation">The location on the local disk where the received file should be saved</param>
    /// <param name="fileId">The id of the file to be received</param>
    public delegate void ReceiveFileDelegate(string writeLocation, int fileId);


    /// <summary>
    /// This class is used to handle receiving files from peer 2 peer transfers
    /// </summary>
    public class PeerReceiverConnectionHandler
    {

        #region Members
        
        /// <summary>
        /// The Ip address of the Peer
        /// </summary>
        private string _peerAddress;

        /// <summary>
        /// The port of the Peer
        /// </summary>
        private ushort _peerPort; 

        /// <summary>
        /// The delegate to be invoked when requesting the file list from the Peer
        /// </summary>
        public GetFileListDelegate fileListDelegate = null;

        /// <summary>
        /// The delegate to be invoked when requesting a file from the Peer
        /// </summary>
        public ReceiveFileDelegate receiveFileDelegate = null;

        /// <summary>
        /// Is used for cancelling a file transfer
        /// </summary>
        public LockableObject<bool> toCancel = new LockableObject<bool>(false);

        /// <summary>
        /// The current Connection
        /// </summary>
        private TcpClient clientTCPConnection = null;

        /// <summary>
        /// The network stream for the current file transfer
        /// </summary>
        private NetworkStream receiverStream = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="peerAddress">The peer Ip Address</param>
        /// <param name="peerPort">The peer listen port</param>
        public PeerReceiverConnectionHandler(string peerAddress,ushort peerPort)
        {
            _peerAddress = peerAddress;
            _peerPort = peerPort;
            fileListDelegate = new GetFileListDelegate(GetFileList);
            receiveFileDelegate = new ReceiveFileDelegate(ReceiveFile);
        }

        #endregion

        #region Connection Methods
        /// <summary>
        /// Initialises the connection with the peer and initialises the network stream
        /// </summary>
        private void ConnectToPeer()
        {
            clientTCPConnection = new TcpClient(_peerAddress,_peerPort);
            receiverStream = clientTCPConnection.GetStream();
        }

        /// <summary>
        /// Starts the current peer receiver
        /// </summary>
        public void Run()
        {
            ConnectToPeer();
        }
        #endregion

        #region File Transfer Methods

        /// <summary>
        /// This method is invoked to request the filelist from the peer
        /// </summary>
        /// <returns>The peer file list</returns>
        private IDictionary<int, string> GetFileList()
        {
            AMessageData messageData = new FileListGetMessageData(new Dictionary<int, string>());
            Message fileListGetMessage = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET), messageData);
            byte[] buffer = fileListGetMessage.Serialize();
            receiverStream.Write(buffer, 0, buffer.Length);

            byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
            int readBytes = receiverStream.Read(headerBuffer, 0, MessageHeader.HEADER_SIZE);
            if (readBytes < MessageHeader.HEADER_SIZE)
            {
#warning must test this part!!!!!!!!
                receiverStream.Flush();
                return new Dictionary<int,string>();
            }
            ushort contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE-1]);
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
        /// This method is invoked to receive a file from the peer
        /// </summary>
        /// <param name="writeLocation">The location on the local disk where the file is saved</param>
        /// <param name="fileId">The id of the file to be transfered</param>
        private void ReceiveFile(string writeLocation, int fileId)
        {
            FileStream localFileStream = new FileStream(writeLocation, FileMode.OpenOrCreate);
            int receivedSize = 0;
            byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
            int readBytes = receiverStream.Read(headerBuffer, 0, MessageHeader.HEADER_SIZE);
            ushort contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
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
                headerBuffer = new byte[MessageHeader.HEADER_SIZE];
                readBytes = receiverStream.Read(headerBuffer, 0, MessageHeader.HEADER_SIZE);
                contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
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

        #endregion
    }

    #endregion

    #region PeerSenderConnectionHandler Class

    /// <summary>
    /// This is invoked to add a new item to the current file list. This should be invoked every time a new item is added to the global filelist.
    /// </summary>
    /// <param name="fileId">The id of the added file</param>
    /// <param name="fileName">The name of the added file</param>
    public delegate void AddItemToFileListDelegate(int fileId,string fileName);

    /// <summary>
    /// This is invoked to remove an item to the current file list. This should be invokeed every time a new item is being removed from the global filelist.
    /// </summary>
    /// <param name="fileId"></param>
    public delegate void RemoveItemFromFileListDelegate(int fileId);

    /// <summary>
    /// This is invoked to close the current sender peer.
    /// </summary>
    public delegate void CloseSenderDelegate();

    /// <summary>
    /// This class is used to handle sending files in peer 2 peer transfers
    /// </summary>
    public class PeerSenderConnectionHandler
    {
        #region Members

        /// <summary>
        /// The name of the receiver peer
        /// </summary>
        private string _receiverName;

        /// <summary>
        /// The port on which the sender listens
        /// </summary>
        private ushort _senderPort;

        /// <summary>
        /// The current file list
        /// </summary>
        private IDictionary<int, string> _fileList;

        /// <summary>
        /// This is true when the peer cancels the current transfer.
        /// </summary>
        private bool _cancelCurrentTransfer = false;

        /// <summary>
        /// The peer connection
        /// </summary>
        TcpClient client = null;

        /// <summary>
        /// The current file stream. The sender reads from it when sending files
        /// </summary>
        FileStream currentFileStream = null;

        /// <summary>
        /// The current file pointer
        /// </summary>
        long currentFilePosition = 0;

        /// <summary>
        /// The id being transfered.
        /// </summary>
        int currentFileId = 0;

        /// <summary>
        /// used to close the current sender thread
        /// </summary>
        bool _closeSenderPeer = false;

        #endregion 

        #region Method Delegates
        /// <summary>
        /// The delegate used to invoke the method for adding items to the file list
        /// </summary>
        public AddItemToFileListDelegate addItemToFileListDelegate = null;

        /// <summary>
        /// The delegate used to invoke the method for removing items from the file list
        /// </summary>
        public RemoveItemFromFileListDelegate removeItemFromFileListDelegate = null;

        /// <summary>
        /// The delegate used to close the current sender.
        /// </summary>
        public CloseSenderDelegate closeSenderDelegate = null;

        #endregion

        #region Constructors
        
        /// <summary>
        /// Constructor. Creates a copy of the filelist for threading purposes. All the changes on th filelist must be invoked to the connection handler too.
        /// </summary>
        /// <param name="receiverName">Name of the receiver peer</param>
        /// <param name="senderPort">Sender Port</param>
        /// <param name="fileList">Current File List</param>
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
            closeSenderDelegate = new CloseSenderDelegate(CloseSender);
        }

        #endregion

        #region Methods
        /// <summary>
        /// This method should be invoked if an item has been added to the filelist
        /// </summary>
        /// <param name="fileId">The id to be added</param>
        /// <param name="filename">The name to be added</param>
        private void AddItemToFileList(int fileId, string filename)
        {
            _fileList.Add(fileId, filename);
        }

        /// <summary>
        /// This method should be invoked if an item has been Removed from the filelist
        /// </summary>
        /// <param name="fileId">The id of the file to be removed</param>
        private void RemoveItemFromFileList(int fileId)
        {
            _fileList.Remove(fileId);
        }

        /// <summary>
        /// This method is invoked when closing the current sender.
        /// </summary>
        private void CloseSender()
        {
            this._closeSenderPeer = true;
        }

        /// <summary>
        /// starts the sender peer 
        /// </summary>
        public void Run()
        {
            TcpListener listener = new TcpListener(_senderPort);
            listener.Start();
            client = listener.AcceptTcpClient();
            
            while (!_closeSenderPeer)
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
            client.Close();
            if (currentFileStream != null)
            {
                currentFileStream.Close();
            }
        }

        /// <summary>
        /// Writes packets to the receiver peer
        /// </summary>
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

        /// <summary>
        /// Reads packets sent by the receiver peer
        /// </summary>
        private void ProccessInputs()
        {
            NetworkStream clientStream = client.GetStream();
            byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
            int readBytes = clientStream.Read(headerBuffer, 0, MessageHeader.HEADER_SIZE);
            if (readBytes < MessageHeader.HEADER_SIZE)
            {
#warning must test this part!!!!!!!!
                clientStream.Flush();
                return;
            }
            ushort contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
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

        /// <summary>
        /// Handles a received packet according to the service
        /// </summary>
        /// <param name="receivedMessage"></param>
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

        /// <summary>
        /// Starts sending a file according to the request.
        /// </summary>
        /// <param name="receivedMessage">The request issued by the peer to get a specific file</param>
        private void StartSendFile(Message receivedMessage)
        {
            FileTransferGetMessageData messageData = (FileTransferGetMessageData)Message.GetMessageData(receivedMessage);
            currentFileId = messageData.Id;
            currentFileStream = new FileStream(_fileList[currentFileId], FileMode.Open);
            currentFilePosition = 0;
        }

        /// <summary>
        /// Creates a file list packet and sends it to the peer
        /// </summary>
        private void SendFileList()
        {
            AMessageData messageData = new FileListGetMessageData(_fileList);
            Message fileListMessage = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET), messageData);
            byte[] buffer = fileListMessage.Serialize();
            client.GetStream().Write(buffer, 0, buffer.Length);

        }

        #endregion
    }

    #endregion
}

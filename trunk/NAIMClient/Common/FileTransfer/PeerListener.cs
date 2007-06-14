using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using Common.Protocol;
using Common.ProtocolEntities;
using System.IO;

namespace Common.FileTransfer
{
    public delegate void RequestFileList(string contact,Socket contactSocket);

    public delegate void RequestFile(string contact, int fileId, Socket contactSocket);

    public delegate void ProgressChanged(string contact,int fileId, int percentage);

    public delegate void TransferEnded(string contact, int fileId);

    public delegate void CancelTransfer(string contact, int fileId);

    public delegate void RequestedFileListDelegate(IDictionary<int, string> fileList, Socket contactSocket);

    public delegate void RequestedFileDelegate(int fileId, string alias, string localPath, Socket contactSocket);

    public delegate void CancelFileTransferDelegate(string contactName, int fileId);

    public delegate IDictionary<int, string> GetFileListFromPeer(string contact, string address, ushort port);

    public delegate void GetFileFromPeer(string contact, int fileid, string localPath, string address, ushort port, string localUserName);

    public delegate void StopDelegate();

    public class PeerConnectionManager
    {
        private const int _maxConn = 10000;

        private const int _fileListId = -2;

        private List<PeerClientData> _connectedClients = new List<PeerClientData>();

        private List<PeerClientData> _receiverTransfers = new List<PeerClientData>();

        private Socket _listenSocket;

        private int _localPort = 0;

        private bool _toBreak = true;

        #region public Delegates

        public RequestedFileListDelegate requestedFileListDelegate;

        public RequestedFileDelegate requestedFileDelegate;

        public CancelFileTransferDelegate cancelFileTransferDelegate;

        public GetFileListFromPeer getFileListFromPeerDelegate;

        public GetFileFromPeer getFileFromPeerDelegate;

        public StopDelegate stopDelegate;

        #endregion

        #region Events

        public event RequestFileList RequestFileListEvent;

        protected virtual void OnRequestFileList(string contact, Socket contactSocket)
        {
            if (RequestFileListEvent != null)
            {
                RequestFileListEvent(contact, contactSocket);
            }
        }

        public event RequestFile RequestFileEvent;

        protected virtual void OnRequestFile(string contact, int fileId, Socket contactSocket)
        {
            if (RequestFileEvent != null)
            {
                RequestFileEvent(contact, fileId, contactSocket);
            }
        }

        public event ProgressChanged ProgressChangedEvent;

        protected virtual void OnProgressChanged(string contact, int fileId, int percentage)
        {
            if (ProgressChangedEvent != null)
            {
                ProgressChangedEvent(contact, fileId, percentage);
            }
        }

        public event TransferEnded TransferEndedEvent;

        protected virtual void OnTransferEnded(string contact, int fileId)
        {
            if (TransferEndedEvent != null)
            {
                TransferEndedEvent(contact, fileId);
            }
        }

        public event CancelTransfer CancelTransferEvent;

        protected virtual void OnCancelTransfer(string contactName, int fileId)
        {
            if (CancelTransferEvent != null)
            {
                CancelTransferEvent(contactName, fileId);
            }
        }

        #endregion

        #region Public Methods

        private void RequestedFileList(IDictionary<int, string> fileList, Socket contactSocket)
        {
            FileListGetMessageData messageData = new FileListGetMessageData(fileList);
            Message newMessage = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET), messageData);
            contactSocket.Send(newMessage.Serialize());
            foreach (PeerClientData data in _connectedClients)
            {
                if (data.Socket == contactSocket)
                {
                    data.FileId = -1;
                    _connectedClients.Remove(data);
                    data.Socket.Close();
                    break;
                }
            }
        }

        private void RequestedFile(int fileId, string alias, string localPath, Socket contactSocket)
        {
            foreach (PeerClientData data in _connectedClients)
            {
                if (data.Socket == contactSocket)
                {
                    data.FileId = fileId;
                    data.Alias = alias;
                    data.LocalPath = localPath;
                    data.FileStream = new FileStream(localPath, FileMode.Open);
                    break;
                }
            }
        }

        private void CancelFileTransfer(string contactName, int fileId)
        {
            foreach (PeerClientData clientData in _connectedClients)
            {
                if (clientData.UserName == contactName && clientData.FileId == fileId)
                {
                    NackMessageData messageData = new NackMessageData();
                    Message message = new Message(new MessageHeader(ServiceTypes.NACK),messageData);
                    clientData.Socket.Send(message.Serialize());
                    clientData.Socket.Close();
                }
            }
        }
        
        private IDictionary<int, string> GetFileListFromPeer(string contact, string address, ushort port)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(address, port);
            Message message = new Message(new MessageHeader(ServiceTypes.FILE_LIST_GET),new FileListGetMessageData(new byte[]{0,0,0,0}));
            clientSocket.Send(message.Serialize());
            byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
            clientSocket.Receive(headerBuffer);
            ushort contentLen = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
            byte[] rawData = new byte[contentLen];
            clientSocket.Receive(rawData);
            byte[] buffer = new byte[headerBuffer.Length + contentLen];
            Array.Copy(headerBuffer, buffer, headerBuffer.Length);
            Array.Copy(rawData, 0, buffer, headerBuffer.Length, rawData.Length);
            FileListGetMessageData messageData = (FileListGetMessageData)Message.GetMessageData(new Message(buffer));
            return messageData.FileList;
        }
        private void GetFileFromPeer(string contact, int fileid,string localPath,string address, ushort port, string localUserName)
        {
            PeerClientData data =  new PeerClientData(contact,fileid,"","",null);
            data.PeerAddress = address;
            data.PeerPort = port;
            data.LocalUserName = localUserName;
            data.Alias = localPath;
            _receiverTransfers.Add(data);
        }

        private void StopThread()
        {
            _toBreak = true;
        }

        #endregion

        public PeerConnectionManager(int localPort)
        {
            requestedFileListDelegate = new RequestedFileListDelegate(RequestedFileList);
            requestedFileDelegate = new RequestedFileDelegate(RequestedFile);
            cancelFileTransferDelegate = new CancelFileTransferDelegate(CancelFileTransfer);
            stopDelegate = new StopDelegate(this.StopThread);
            this._localPort = localPort;
        }

        #region private Methods

        void CreateListenerConnection()
        {
            _listenSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            _listenSocket.Bind(new IPEndPoint(Dns.Resolve( "localhost").AddressList[0], _localPort));
            _listenSocket.Listen(_maxConn);
        }

        void MainLoop()
        {
            while (!_toBreak)
            {
                //accept new connections
                ArrayList listenList = new ArrayList();
                listenList.Add(this._listenSocket);
                Socket.Select(listenList, null, null, 1);
                for (int i = 0; i < listenList.Count; i++)
                {
                    Socket connectedSocket;
                    try
                    {
                        connectedSocket = ((Socket)listenList[i]).Accept();
                    }
                    catch (SocketException ex)
                    {
                        continue;
                    }
                    byte[] header = new byte[MessageHeader.HEADER_SIZE];
                    int cnt = connectedSocket.Receive(header);
                    if (cnt != MessageHeader.HEADER_SIZE)
                        continue;
                    ushort contentLength = AMessageData.ToShort(header[MessageHeader.HEADER_SIZE - 2], header[MessageHeader.HEADER_SIZE - 1]);
                    byte[] rawdata = new byte[contentLength];
                    cnt = connectedSocket.Receive(rawdata);
                    if (cnt != (int)contentLength)
                        continue;
                    byte[] message = new byte[MessageHeader.HEADER_SIZE + rawdata.Length];
                    Array.Copy(header,message,header.Length);
                    Array.Copy(rawdata,0,message,header.Length,rawdata.Length);
                    Message recMessage = new Message(message);
                    if (recMessage.Header.ServiceType != ServiceTypes.HELLO)
                        continue;
                    HelloMessageData messageData = (HelloMessageData)Message.GetMessageData(recMessage);
                    _connectedClients.Add(new PeerClientData(messageData.UserName,-1,"","",connectedSocket));
                }

                HandleRequests();

                SendData();

                ReceiveData();
            }

            foreach (PeerClientData data in _receiverTransfers)
            {
                if (data.Socket != null)
                {
                    NackMessageData messageData = new NackMessageData();
                    Message message = new Message(new MessageHeader(ServiceTypes.NACK), messageData);
                    data.Socket.Send(message.Serialize());
                    data.Socket.Close();
                    if (data.FileStream != null)
                    {
                        data.FileStream.Close();
                    }
                }
            }
        }

        private void ReceiveData()
        {
            ArrayList receiverSockets = new ArrayList();
            foreach (PeerClientData data in _receiverTransfers)
            {
                if (data.Socket == null)
                {
                    ConnectToPeerServer(data);
                    continue;
                }
                if (data.FileStream == null)
                {
                    data.FileStream = new FileStream(data.Alias, FileMode.OpenOrCreate);
                }
                receiverSockets.Add(data.Socket);
            }
            Socket.Select(receiverSockets, null, null, 1);
            for (int i = 0; i < receiverSockets.Count; i++)
            {
                SaveFileBuffer((Socket)receiverSockets[i]);
            }
        }

        private void SaveFileBuffer(Socket receiverSocket)
        {
            foreach (PeerClientData data in _receiverTransfers)
            {
                if (data.Socket == receiverSocket)
                {
                    byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
                    data.Socket.Receive(headerBuffer);
                    ushort contentLen = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
                    byte[] rawData = new byte[contentLen];
                    data.Socket.Receive(rawData);
                    byte[] buffer= new byte[headerBuffer.Length+contentLen];
                    Array.Copy(buffer,headerBuffer,headerBuffer.Length);
                    Array.Copy(buffer,0,rawData,headerBuffer.Length,rawData.Length);
                    Message recMessage = new Message(buffer);
                    switch (recMessage.Header.ServiceType)
                    {
                        case ServiceTypes.FILE_TRANSFER_SEND:
                            FileTransferSendMessageData messageData = (FileTransferSendMessageData)Message.GetMessageData(recMessage);
                            data.FileStream.Write(messageData.Content, 0, messageData.Content.Length);
                            if (messageData.Content.Length < FileTransferSendMessageData.MAX_MESSAGE_SIZE)
                            {
                                data.FileStream.Close();
                                data.Socket.Close();
                                _receiverTransfers.Remove(data);
                                OnTransferEnded(data.UserName, data.FileId);
                            }
                            else
                            {
                                OnProgressChanged(data.UserName, data.FileId, (int)(data.FileStream.Position / data.FileStream.Length) * 100);
                            }
                            break;
                        case ServiceTypes.NACK:
                            data.FileStream.Close();
                            data.Socket.Close();
                            _receiverTransfers.Remove(data);
                            OnCancelTransfer(data.UserName, data.FileId);
                            break;
                    }
                    break;
                }
            }
        }

        private void ConnectToPeerServer(PeerClientData data)
        {
            data.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            data.Socket.Connect(data.PeerAddress, data.PeerPort);
            Message hello = new Message(new MessageHeader(ServiceTypes.HELLO), new HelloMessageData(data.LocalUserName));
            data.Socket.Send(hello.Serialize());
        }

        private void SendData()
        {
            ArrayList writeSocks = new ArrayList();
            foreach (PeerClientData pair in _connectedClients)
            {
                writeSocks.Add(pair.Socket);
            }
            Socket.Select(null, writeSocks, null, 1);
            for (int i = 0; i < writeSocks.Count; i++)
            {
                SendFileBuffer((Socket)writeSocks[i]);
            }
        }

        private void SendFileBuffer(Socket socket)
        {
            foreach (PeerClientData data in _connectedClients)
            {
                if (data.Socket == socket)
                {
                    byte[] content = new byte[FileTransferSendMessageData.MAX_MESSAGE_SIZE];
                    int cnt = data.FileStream.Read(content, 0, FileTransferSendMessageData.MAX_MESSAGE_SIZE);
                    if (cnt < FileTransferSendMessageData.MAX_MESSAGE_SIZE)
                    {
                        Array.Resize<byte>(ref content, cnt);
                        data.FileStream.Close();
                        OnTransferEnded(data.UserName, data.FileId);
                    }
                    FileTransferSendMessageData messageData = new FileTransferSendMessageData(data.FileId,(int)data.FileStream.Length,content);
                    Message message = new Message(new MessageHeader(ServiceTypes.FILE_TRANSFER_SEND), messageData);
                    socket.Send(message.Serialize());
                    if (cnt < FileTransferSendMessageData.MAX_MESSAGE_SIZE)
                    {
                        socket.Close();
                        _connectedClients.Remove(data);
                    }
                    else
                    {
                        OnProgressChanged(data.UserName, data.FileId, (int)(data.FileStream.Position / data.FileStream.Length) * 100);
                    }
                    break;
                }
            }
        }

        private void HandleRequests()
        {
            ArrayList readSocks = new ArrayList();
            foreach (PeerClientData data in _connectedClients)
            {
                readSocks.Add(data.Socket);
            }
            Socket.Select(readSocks, null, null, 1);
            for (int i = 0; i < readSocks.Count; i++)
            {
                Socket connectedSocket = (Socket)readSocks[i];
                byte[] header = new byte[MessageHeader.HEADER_SIZE];
                int cnt = connectedSocket.Receive(header);
                if (cnt != MessageHeader.HEADER_SIZE)
                    continue;
                ushort contentLength = AMessageData.ToShort(header[MessageHeader.HEADER_SIZE - 2], header[MessageHeader.HEADER_SIZE - 1]);
                byte[] rawdata = new byte[contentLength];
                cnt = connectedSocket.Receive(rawdata);
                if (cnt != (int)contentLength)
                    continue;
                byte[] message = new byte[MessageHeader.HEADER_SIZE + rawdata.Length];
                Array.Copy(header, message, header.Length);
                Array.Copy(rawdata, 0, message, header.Length, rawdata.Length);
                Message recMessage = new Message(message);

                switch (recMessage.Header.ServiceType)
                {
                    case ServiceTypes.FILE_LIST_GET:
                        HandleRequestFileList(connectedSocket, recMessage);
                        return;
                    case ServiceTypes.FILE_TRANSFER_GET:
                        HandleRequestFile(connectedSocket, recMessage);
                        return;
                    case ServiceTypes.NACK:
                        HandleCancelTransfer(connectedSocket);
                        return;
                }
            }
        }

        private void HandleCancelTransfer(Socket connectedSocket)
        {
            foreach (PeerClientData data in _connectedClients)
            {
                if (data.Socket == connectedSocket)
                {
                    _connectedClients.Remove(data);
                    data.Socket.Close();
                    OnCancelTransfer(data.UserName, data.FileId);
                }
            }
        }

        private void HandleRequestFile(Socket connectedSocket, Message recMessage)
        {
            foreach(PeerClientData clientData in _connectedClients)
            {
                if (clientData.Socket == connectedSocket)
                {
                    FileTransferGetMessageData messageData = (FileTransferGetMessageData)Message.GetMessageData(recMessage);
                    clientData.FileId = messageData.Id;
                    break;
                }
            }
        }

        private void HandleRequestFileList(Socket connectedSocket, Message recMessage)
        {
            foreach (PeerClientData clietnData in _connectedClients)
            {
                if (clietnData.Socket == connectedSocket)
                {
                    clietnData.FileId = _fileListId;
                    clietnData.LocalPath = "";
                    clietnData.Alias = "";
                    break;
                }
            }
        }

        #endregion

    }

    class PeerClientData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private int _fileId;

        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }

        private string _localPath;

        public string LocalPath
        {
            get { return _localPath; }
            set { _localPath = value; }
        }

        private string _alias;

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        private Socket _socket;

        public Socket Socket
        {
            get { return _socket; }
            set { _socket = value; }
        }

        private FileStream _fileStream = null;

        public FileStream FileStream
        {
            get { return _fileStream; }
            set { _fileStream = value; }
        }

        private string _peerAddress;

        public string PeerAddress
        {
            get { return _peerAddress; }
            set { _peerAddress = value; }
        }

        private ushort _peerPort;

        public ushort PeerPort
        {
            get { return _peerPort; }
            set { _peerPort = value; }
        }

        private string _localUserName;

        public string LocalUserName
        {
            get { return _localUserName; }
            set { _localUserName = value; }
        }
	

        public PeerClientData(string username, int fileId, string localPath, string alias, Socket socket)
        {
            _userName = username;
            _fileId = fileId;
            _localPath = localPath;
            _alias = alias;
            _socket = socket;
        }
	
    }
}

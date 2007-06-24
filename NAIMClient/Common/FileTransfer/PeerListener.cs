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
    #region Public Delegates

    public delegate void RequestFileList(string contact,Socket contactSocket);

    public delegate void RequestFile(string contact, int fileId, Socket contactSocket);

    public delegate void ProgressChanged(string contact,int fileId, int percentage,float speed);

    public delegate void TransferEnded(string contact, int fileId);

    public delegate void CancelTransfer(string contact, int fileId);

    public delegate void RequestedFileListDelegate(IDictionary<int, string> fileList, Socket contactSocket);

    public delegate void RequestedFileDelegate(int fileId, string alias, string localPath, Socket contactSocket);

    public delegate void CancelFileTransferDelegate(string contactName, int fileId);

    public delegate IDictionary<int, string> GetFileListFromPeer(string contact, string address, ushort port);

    public delegate void GetFileFromPeer(string contact, int fileid, string localPath, string address, ushort port, string localUserName);

    public delegate void StopDelegate();

    public delegate void ProgressChangedDelegate(string contact, int fileId, int percentage,float speed);

    #endregion

    #region PeerConnectionManager

    public class PeerConnectionManager
    {
        #region Constants

        private const int _maxConn = 10000;

        private const int _fileListId = -2;

        #endregion

        #region Fields

        private Dictionary<Socket,PeerClientData> _connectedClients = new Dictionary<Socket,PeerClientData>();

        private Dictionary<Socket,PeerClientData> _receiverTransfers = new Dictionary<Socket,PeerClientData>();

        private Socket _listenSocket;

        private int _localPort = 0;

        private string _localAddress = "127.0.0.1";

        private bool _toBreak = false;

        #endregion

        #region public Delegates

        public RequestedFileListDelegate requestedFileListDelegate;

        public RequestedFileDelegate requestedFileDelegate;

        public CancelFileTransferDelegate cancelFileTransferDelegate;

        public GetFileListFromPeer getFileListFromPeerDelegate;

        public GetFileFromPeer getFileFromPeerDelegate;

        public StopDelegate stopDelegate;

        private ProgressChangedDelegate progressChangedDelegate;

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

        protected virtual void OnProgressChanged(string contact, int fileId, int percentage,float speed)
        {
            //progressChangedDelegate.BeginInvoke(contact, fileId, percentage, null, null);
            if (ProgressChangedEvent != null)
            {
                ProgressChangedEvent(contact, fileId, percentage,speed);
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
            PeerClientData data = _connectedClients[contactSocket];
            data.FileId = -1;
            _connectedClients.Remove(contactSocket);
            data.Socket.Close();
        }

        private void RequestedFile(int fileId, string alias, string localPath, Socket contactSocket)
        {
            PeerClientData data = _connectedClients[contactSocket];
            data.FileId = fileId;
            data.Alias = alias;
            data.LocalPath = localPath;
            data.FileStream = new FileStream(localPath, FileMode.Open, FileAccess.Read);
        }

        private void CancelFileTransfer(string contactName, int fileId)
        {
            foreach (KeyValuePair<Socket, PeerClientData> clientDataPair in _receiverTransfers)
            {
                if (clientDataPair.Value.UserName == contactName && clientDataPair.Value.FileId == fileId)
                {
                    NackMessageData messageData = new NackMessageData();
                    Message message = new Message(new MessageHeader(ServiceTypes.NACK),messageData);
                    clientDataPair.Value.Socket.Send(message.Serialize());
                    clientDataPair.Value.Socket.Close();
                    _receiverTransfers.Remove(clientDataPair.Value.Socket);
                    break;
                }
            }
        }
        
        private IDictionary<int, string> GetFileListFromPeer(string contact, string address, ushort port)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPAddress(Dns.Resolve(address).AddressList[0].Address), port);
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
            ConnectToPeerServer(data);
            _receiverTransfers.Add(data.Socket,data);
        }

        private void StopThread()
        {
            _toBreak = true;
        }

        #endregion

        #region Constructors

        public PeerConnectionManager(int localPort, string address, ProgressChangedDelegate progressChangedDelegate)
        {
            requestedFileListDelegate = new RequestedFileListDelegate(RequestedFileList);
            requestedFileDelegate = new RequestedFileDelegate(RequestedFile);
            cancelFileTransferDelegate = new CancelFileTransferDelegate(CancelFileTransfer);
            stopDelegate = new StopDelegate(this.StopThread);
            getFileFromPeerDelegate = new GetFileFromPeer(this.GetFileFromPeer);
            getFileListFromPeerDelegate = new GetFileListFromPeer(this.GetFileListFromPeer);
            this.progressChangedDelegate = progressChangedDelegate;
            this._localPort = localPort;
            this._localAddress = address;
        }

        #endregion

        #region private Methods

        public ushort CreateListenerConnection(IPAddress address)
        {
            _listenSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            _listenSocket.Bind(new IPEndPoint(address, _localPort));
            _listenSocket.Listen(_maxConn);
            _localAddress = address.ToString();
            return (ushort)((IPEndPoint)_listenSocket.LocalEndPoint).Port;
        }

        public void MainLoop()
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
                    _connectedClients.Add(connectedSocket, new PeerClientData("",-1,"","",connectedSocket));
                }

                HandleRequests();

                SendData();

                ReceiveData();
            }

            foreach (KeyValuePair<Socket, PeerClientData> dataPair in _receiverTransfers)
            {
                if (dataPair.Value.Socket != null)
                {
                    NackMessageData messageData = new NackMessageData();
                    Message message = new Message(new MessageHeader(ServiceTypes.NACK), messageData);
                    dataPair.Value.Socket.Send(message.Serialize());
                    //data.Socket.Close();
                    if (dataPair.Value.FileStream != null)
                    {
                        dataPair.Value.FileStream.Close();
                    }
                }
            }
            _listenSocket.Close();
        }

        private void ReceiveData()
        {
            ArrayList receiverSockets = new ArrayList();
            foreach (KeyValuePair<Socket, PeerClientData> dataPair in _receiverTransfers)
            {
                if (dataPair.Value.FileStream == null)
                {
                    dataPair.Value.FileStream = new FileStream(dataPair.Value.Alias, FileMode.OpenOrCreate);
                    AMessageData requestMessageData = new FileTransferGetMessageData(dataPair.Value.FileId);
                    Message toSend = new Message(new MessageHeader(ServiceTypes.FILE_TRANSFER_GET), requestMessageData);
                    dataPair.Value.Socket.Send(toSend.Serialize());
                }
                if(dataPair.Value.Socket.Connected)
                    receiverSockets.Add(dataPair.Value.Socket);
            }

            if (receiverSockets.Count == 0)
                return;
            
            Socket.Select(receiverSockets, null, null, 1);
            for (int i = 0; i < receiverSockets.Count; i++)
            {
                SaveFileBuffer((Socket)receiverSockets[i]);
            }
        }

        private void SaveFileBuffer(Socket receiverSocket)
        {
            PeerClientData data = _receiverTransfers[receiverSocket];
            byte[] messageBuffer = new byte[MessageHeader.HEADER_SIZE];
            int currentReceived = 0;
            while (currentReceived != MessageHeader.HEADER_SIZE)
            {
                int lastReceived;
                try
                {
                    lastReceived = data.Socket.Receive(messageBuffer, currentReceived, MessageHeader.HEADER_SIZE - currentReceived, SocketFlags.None);
                }
                catch (SocketException ex)
                {
                    data.FileStream.Close();
                    _receiverTransfers.Remove(data.Socket);
                    return;
                }
                //catch (ObjectDisposedException ex)
                //{
                //    data.FileStream.Close();
                //    _receiverTransfers.Remove(data.Socket);
                //    return;
                //}
                currentReceived += lastReceived;
            }
            Message recMessage = new Message(messageBuffer);
            switch (recMessage.Header.ServiceType)
            {
                case ServiceTypes.FILE_TRANSFER_SEND:
                    ushort contentLen = AMessageData.ToShort(messageBuffer[MessageHeader.HEADER_SIZE - 2], messageBuffer[MessageHeader.HEADER_SIZE - 1]);
                    byte[] rawData = new byte[contentLen];
                    currentReceived = 0;
                    while (currentReceived != contentLen)
                    {
                        int lastReceived = data.Socket.Receive(rawData, currentReceived, contentLen - currentReceived, SocketFlags.None);
                        currentReceived += lastReceived;
                    }
                    data.FileStream.Write(rawData, 2 * sizeof(Int32), rawData.Length - 2 * sizeof(Int32));
                    if (rawData.Length < FileTransferSendMessageData.MAX_MESSAGE_SIZE)
                    {
                        data.FileStream.Close();
                        data.Socket.Close();
                        _receiverTransfers.Remove(data.Socket);
                        OnTransferEnded(data.UserName, data.FileId);
                    }
                    else
                    {
                        data.ReadBytes += rawData.Length;
                        double speed = (double)data.ReadBytes / (double)(DateTime.Now.Ticks - data.LastTimeStamp.Ticks);
                        //transform in Bytes/s
                        speed *= Math.Pow((double)10, (double)7);
                        //transform in KiloBytes/s
                        speed /= 1024;
                        if (double.IsInfinity(speed))
                            speed = double.MaxValue;
                        int fileLength = AMessageData.ToInt(rawData, sizeof(Int32));
                        OnProgressChanged(data.UserName, data.FileId, (int)((float)data.ReadBytes / (float)fileLength * 100), (float)speed);
                    }
                    break;
                case ServiceTypes.NACK:
                    data.FileStream.Close();
                    data.Socket.Close();
                    _receiverTransfers.Remove(data.Socket);
                    OnCancelTransfer(data.UserName, data.FileId);
                    break;
            }
        }

        private void ConnectToPeerServer(PeerClientData data)
        {
            data.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            data.Socket.Connect(data.PeerAddress, data.PeerPort);
        }

        private void SendData()
        {
            ArrayList writeSocks = new ArrayList();
            foreach (KeyValuePair<Socket, PeerClientData> pair in _connectedClients)
            {
                if(pair.Value.Socket.Connected)
                    writeSocks.Add(pair.Value.Socket);
            }

            if (writeSocks.Count == 0)
                return;

            Socket.Select(null, writeSocks, null, 1);
            for (int i = 0; i < writeSocks.Count; i++)
            {
                SendFileBuffer((Socket)writeSocks[i]);
            }
        }

        private void SendFileBuffer(Socket socket)
        {
            PeerClientData data = _connectedClients[socket];
            if (data.FileStream == null)
            {
                if (data.LocalPath == "")
                    return;
                data.FileStream = new FileStream(data.LocalPath, FileMode.Open);
            }
            byte[] content = new byte[FileTransferSendMessageData.MAX_MESSAGE_SIZE + 2 * sizeof(Int32)];
            int cnt = data.FileStream.Read(content, 2 * sizeof(Int32), FileTransferSendMessageData.MAX_MESSAGE_SIZE);
            if (cnt < FileTransferSendMessageData.MAX_MESSAGE_SIZE + 2 * sizeof(Int32))
            {
                Array.Resize<byte>(ref content, cnt + 2 * sizeof(Int32));
            }
            byte[] fileIdBuffer = AMessageData.ToByteArray(data.FileId);
            byte[] fileLengthBuffer = AMessageData.ToByteArray((int)data.FileStream.Length);
            Array.Copy(fileIdBuffer, content, fileIdBuffer.Length);
            Array.Copy(fileLengthBuffer, 0, content, fileIdBuffer.Length, fileLengthBuffer.Length);
            try
            {
                socket.Send(new MessageHeader(ServiceTypes.FILE_TRANSFER_SEND).Serialize((ushort)content.Length));
                socket.Send(content);
            }
            catch (SocketException ex)
            {
                data.FileStream.Close();
                _connectedClients.Remove(data.Socket);
                return;
            }
            if (cnt < FileTransferSendMessageData.MAX_MESSAGE_SIZE)
            {
                data.FileStream.Close();
                socket.Close();
                _connectedClients.Remove(data.Socket);
            }
        }

        private void HandleRequests()
        {
            ArrayList readSocks = new ArrayList();
            foreach (KeyValuePair<Socket, PeerClientData> dataPair in _connectedClients)
            {
                if(dataPair.Value.Socket.Connected)
                    readSocks.Add(dataPair.Value.Socket);
            }

            if (readSocks.Count == 0)
                return;

            Socket.Select(readSocks, null, null, 1);
            for (int i = 0; i < readSocks.Count; i++)
            {
                Socket connectedSocket = (Socket)readSocks[i];
                byte[] header = new byte[MessageHeader.HEADER_SIZE];
                int cnt;
                try
                {
                    cnt = connectedSocket.Receive(header);
                }
                catch (SocketException ex)
                {
                    HandleCancelTransfer(connectedSocket);
                    continue;
                }
                if (cnt != MessageHeader.HEADER_SIZE)
                    continue;
                ushort contentLength = AMessageData.ToShort(header[MessageHeader.HEADER_SIZE - 2], header[MessageHeader.HEADER_SIZE - 1]);
                byte[] rawdata = new byte[contentLength];
                if (contentLength > 0)
                {
                    cnt = connectedSocket.Receive(rawdata);
                    if (cnt != (int)contentLength)
                        continue;
                }
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
                    case ServiceTypes.HELLO:
                        HandleHelloMessage(connectedSocket, recMessage);
                        return;
                }
            }
        }

        private void HandleHelloMessage(Socket connectedSocket, Message recMessage)
        {
            HelloMessageData messageData = (HelloMessageData)Message.GetMessageData(recMessage);

            PeerClientData data = _connectedClients[connectedSocket];
            if (data.Socket == connectedSocket)
            {
                data.UserName = messageData.UserName;
            }
        }

        private void HandleCancelTransfer(Socket connectedSocket)
        {
            PeerClientData data = _connectedClients[connectedSocket];
        
            if (data.Socket == connectedSocket)
            {
                _connectedClients.Remove(data.Socket);
                OnCancelTransfer(data.UserName, data.FileId);
                try
                {
                    data.Socket.Close();
                }
                catch (SocketException ex)
                {
                }
            }
        }

        private void HandleRequestFile(Socket connectedSocket, Message recMessage)
        {
            PeerClientData clientData = _connectedClients[connectedSocket];
            if (clientData.Socket == connectedSocket)
            {
                FileTransferGetMessageData messageData = (FileTransferGetMessageData)Message.GetMessageData(recMessage);
                clientData.FileId = messageData.Id;
                OnRequestFile(clientData.UserName, clientData.FileId, connectedSocket);
            }
        }

        private void HandleRequestFileList(Socket connectedSocket, Message recMessage)
        {
            PeerClientData clietnData = _connectedClients[connectedSocket];
            if (clietnData.Socket == connectedSocket)
            {
                clietnData.FileId = _fileListId;
                clietnData.LocalPath = "";
                clietnData.Alias = "";
                OnRequestFileList(clietnData.UserName, connectedSocket);
            }
        }

        #endregion

    }

    #endregion

    #region PeerClientData

    class PeerClientData
    {
        #region Properties

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
	
        private int _readBytes = 0;
        public int ReadBytes
        {
            get
            {
                return _readBytes;
            }
            set
            {
                _readBytes = value;
            }
        }

        private DateTime _lastTimeStamp;

        public DateTime LastTimeStamp
        {
            get { return _lastTimeStamp; }
            set { _lastTimeStamp = value; }
        }
        #endregion

        #region Constructors
        
        public PeerClientData(string username, int fileId, string localPath, string alias, Socket socket)
        {
            _userName = username;
            _fileId = fileId;
            _localPath = localPath;
            _alias = alias;
            _socket = socket;
            _lastTimeStamp = DateTime.Now;
        }

        #endregion

    }

    #endregion
}


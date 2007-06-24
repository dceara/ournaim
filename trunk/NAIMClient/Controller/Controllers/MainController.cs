using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using System.Collections;
using System.Net.Sockets;
using System.Windows.Forms;
using Common;
using Common.ProtocolEntities;
using System.Net;
using Controller.StateObjects;
using Controller.Archive;
using Common.FileTransfer;
using System.Threading;
using Common.ErrorHandling;

namespace Controllers
{
    #region MainController Class

    #region Delegates

    public delegate void InstantiateConversationView(string username);

    public delegate void InstantiateCreateAccountView();

    public delegate void InstantiateFileTransferView();

    public delegate IArchiveView InstantiateArchiveView();

    public delegate IFileListView InstantiateFileListView();

    #endregion

    public class MainController
    {
        #region Members

        private AState currentState = null;

        private IDictionary<string,IConversationController> conversationControllers;

        /// <summary>
        /// contains the messages received from the server
        /// </summary>
        private Queue<Common.Protocol.Message> inputMessageQueue;

        /// <summary>
        /// contains the messages to be sent to the server
        /// </summary>
        private Queue<Common.Protocol.Message> outputMessageQueue;

        private IMainView mainView;

        public IMainView MainView
        {
            get
            {
                return mainView;
            }
            set
            {
                mainView = value;
            }
        }

        private IFileTransferView fileTransferView;

        public IFileTransferView FileTransferView
        {
            get
            {
                return fileTransferView;
            }
        }

        private ICreateAccountView createAccountView;

        public ICreateAccountView CreateAccountView
        {
            get
            {
                return createAccountView;
            }
        }

        private IFileListView fileListView;

        private Socket serverSocket = null;

        private bool toBreak = false;

        private bool mainLoopStarted = false;

        private string server = "127.0.0.1";//"10.6.3.114";

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private int port = 18005;

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        private string currentUserName;

        private string currentPassword;

        private ArchiveManager archiveManager = new ArchiveManager();

        private FileListManager fileListManager = new FileListManager();

        private PeerConnectionManager peerConnectionManager = null;

        private Thread listenThread = null;

        #region Client Peer Connection data
        /// <summary>
        /// the address for accepting peer to peer connections
        /// </summary>
        private string localIpAddress = "127.0.0.1";

        public string LocalIpAddress
        {
            get { return localIpAddress; }
            set { localIpAddress = value; }
        }

        private IPAddress localIp;

        /// <summary>
        /// the port for accepting peer to peer connections
        /// </summary>
        private ushort localPort;

        public ushort LocalPort
        {
            get { return localPort; }
            set { localPort = value; }
        }
	
	
        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// This is called from the main class.
        /// </summary>
        public void Initialise(IMainView mainView)
        {
            this.currentState = new StateInitial();

            currentState.MainView = mainView;
            currentState.OpenConversationEvent += new OpenConversationDelegate(currentState_OpenConversationEvent);

            this.mainView = mainView;
            this.mainView.AddContactEvent += new AddContactEventHandler(mainView_AddContactEvent);
            this.mainView.AddGroupEvent += new AddGroupEventHandler(mainView_AddGroupEvent);
            this.mainView.ChangeContactGroupEvent += new ChangeContactGroupEventHandler(mainView_ChangeContactGroupEvent);
            this.mainView.ChangeStatusEvent += new ChangeStatusEventHandler(mainView_ChangeStatusEvent);
            this.mainView.LoginEvent += new LoginEventHandler(mainView_LoginEvent);
            this.mainView.LogoutEvent += new LogoutEventHandler(mainView_LogoutEvent);
            this.mainView.MainCloseEvent += new MainCloseEventHandler(mainView_MainCloseEvent);
            this.mainView.OpenConversationEvent += new OpenConversationEventHandler(mainView_OpenConversationEvent);
            this.mainView.OpenFileTransferViewEvent += new OpenFileTransferViewEventHandler(mainView_OpenFileTransferViewEvent);
            this.mainView.RemoveContactEvent += new RemoveContactEventHandler(mainView_RemoveContactEvent);
            this.mainView.OpenSignUpViewEvent += new OpenSignUpViewHandler(mainView_OpenSignUpViewEvent);
            this.mainView.OpenArchiveViewEvent += new OpenArchiveViewHandler(mainView_OpenArchiveViewEvent);
            this.mainView.ChangeSettingsEvent += new ChangeSettings(mainView_ChangeSettingsEvent);
            this.mainView.RemoveGroupEvent += new RemoveGroupEventHandler(mainView_RemoveGroupEvent);
            this.mainView.OpenFileListViewEvent += new OpenFileListViewHandler(mainView_OpenFileListViewEvent);            
            this.mainView.Initialise();

            

            this.conversationControllers = new Dictionary<string, IConversationController>();
            this.inputMessageQueue = new Queue<Common.Protocol.Message>();
            this.outputMessageQueue = new Queue<Common.Protocol.Message>();

            currentState.ConversationControllers = conversationControllers;
        }


        public void InitialiseConversation(string userName,IConversationView conversationView)
        {
            ConversationController newConversationController = new ConversationController();
            newConversationController.ReceiverName = userName;
            newConversationController.CurrentClientName = this.currentUserName;
            newConversationController.LocalPort = this.localPort;
            newConversationController.InitialiseController();
            newConversationController.SendServerMessageEvent += new SendServerMessageEventHandler(newConversationController_SendServerMessageEvent);
            newConversationController.DisposeConversationControllerEvent += new DisposeConversationController(newConversationController_DisposeConversationControllerEvent);
            newConversationController.InitialiseView(conversationView);
            this.conversationControllers.Add(userName, newConversationController);
        }

        public void InitialiseCreateAccount(ICreateAccountView newCreateAccountView)
        {
            this.createAccountView = newCreateAccountView;
            currentState.CreateAccountView = newCreateAccountView;
            AState lastState = currentState;
            currentState = currentState.MoveState();
            if (currentState != lastState)
            {
                currentState.OpenConversationEvent+=new OpenConversationDelegate(currentState_OpenConversationEvent);
            }
            lastState = null;
            this.createAccountView.Initialise();
            this.createAccountView.CloseAccountViewEvent += new CloseAccountViewEventHandler(createAccountView_CloseAccountViewEvent);
            this.createAccountView.CreateAccountEvent += new CreateAccountEventHandler(createAccountView_CreateAccountEvent);
            this.createAccountView.ShowView();
        }

        public void InitialiseFileTransferManager(IFileTransferView newFileTransferView)
        {            
            if (this.currentState is StateIdle)
            {
                this.fileTransferView = newFileTransferView;
                ((StateIdle)currentState).InitialiseFileTransferManager(fileTransferView,this.peerConnectionManager,this._downloadedFileLists);


                this.fileTransferView.ViewClosedEvent += new ViewClosedEventHandler(fileTransferView_ViewClosedEvent);
                this.fileTransferView.ContactSelectedEvent += new ContactSelectedEventHandler(fileTransferView_ContactSelectedEvent);
                this.fileTransferView.GetContactListEvent += new GetContactListEventHandler(fileTransferView_GetContactListEvent);
                this.fileTransferView.StartFileTransferEvent += new StartFileTransferEventHandler(fileTransferView_StartFileTransferEvent);
                this.fileTransferView.CancelFileTransferEvent += new CancelFileTransferEventHandler(fileTransferView_CancelFileTransferEvent);
                this.fileTransferView.Initialise(((StateIdle)currentState).OnlineContacts.Keys);
            }
        }

        private void MainLoop()
        {
            if (!CreateServerConnection())
            {
                mainLoopStarted = false;
                toBreak = false;
                ForceEmptyOutputQueue();
                return;
            }

            StartPeerConnectionManager();

            while (true)
            {
                Application.DoEvents();
                if (toBreak)
                {
                    toBreak = false;
                    mainLoopStarted = false;
                    break;
                }
                if (serverSocket.Poll(1, SelectMode.SelectRead))
                {
                    try
                    {
                        byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
                        int n = serverSocket.Receive(headerBuffer);
                        ushort contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
                        byte[] rawData = new byte[contentLength];
                        if (contentLength > 0)
                        {
                            n = serverSocket.Receive(rawData);
                        }
                        byte[] messageBuffer = new byte[headerBuffer.Length + contentLength];
                        Array.Copy(headerBuffer, messageBuffer, headerBuffer.Length);
                        Array.Copy(rawData, 0, messageBuffer, headerBuffer.Length, contentLength);
                        Common.Protocol.Message newMessage = new Common.Protocol.Message(messageBuffer);
                        inputMessageQueue.Enqueue(newMessage);
                    }
                    catch (SocketException ex)
                    {
                        HandleSocketException();
                    }
                }
                ProcessInputQueue();
                Application.DoEvents();
                if (serverSocket.Poll(1, SelectMode.SelectWrite))
                {
                    ProcessOutputQueue();
                }
            }
            CloseServerConnection();
        }

        #endregion

        #region CurrentState Event Handlers

        IConversationController currentState_OpenConversationEvent(string username)
        {
            OnInstantiateConversationView(username);
            return null;
        }

        #endregion

        #region MainView Event Handlers
        void mainView_ChangeStatusEvent(string status)
        {
            AMessageData messageData = new StatusMessageData(this.currentUserName, status);
            Common.Protocol.Message changeStatusMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.STATUS), messageData);
            this.outputMessageQueue.Enqueue(changeStatusMessage);
        }

        void mainView_ChangeContactGroupEvent(string contact, string newgroup)
        {
            if (!(currentState is StateIdle))
                return;
            AMessageData messageData = new AddContactMessageData(this.currentUserName, newgroup, contact);
            Common.Protocol.Message changeContactGroupMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            outputMessageQueue.Enqueue(changeContactGroupMessage);
            
            foreach(KeyValuePair<string,IList<UserListEntry>> pair in ((StateIdle)currentState).ContactsByGroups)
            {
                if (pair.Key == newgroup)
                    continue;
                foreach (UserListEntry entry in pair.Value)
                {
                    if (entry.UserName == contact)
                    {
                        pair.Value.Remove(entry);
                        ((StateIdle)currentState).ContactsByGroups[newgroup].Add(entry);
                        return;
                    }
                }
            }
        }

        void mainView_AddContactEvent(string uname, string group)
        {
            if (!(currentState is StateIdle))
                return;
            if (AState.CheckIfContactExists(uname,((StateIdle)currentState).ContactsByGroups))
            {
                ErrorHandler.HandleError("Contact already in contacts list!", "Error", (IWin32Window)mainView);
                return;
            }
            AMessageData messageData = new AddContactMessageData(this.currentUserName, group, uname);
            Common.Protocol.Message addContactMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            this.outputMessageQueue.Enqueue(addContactMessage);
            ((StateIdle)currentState).ContactsByGroups[group].Add(new UserListEntry(uname));
            mainView.AddContact(uname, group);
            if (fileTransferView != null && ((StateIdle)currentState).OnlineContacts.ContainsKey(uname))
            {
                fileTransferView.AddContact(uname);
            }
        }

        void mainView_AddGroupEvent(string group)
        {
            if (!(currentState is StateIdle))
                return;
            if (AState.CheckIfGroupExists(group, ((StateIdle)currentState).ContactsByGroups))
            {
                ErrorHandler.HandleError("Group already in list!", "Error", (IWin32Window)mainView);
                return;
            }
            ((StateIdle)currentState).ContactsByGroups.Add(group, new List<UserListEntry>());
            mainView.AddGroup(group);
        }

        void mainView_RemoveContactEvent(string username)
        {
            if (!(currentState is StateIdle))
                return;
            IDictionary<string,IList<UserListEntry>> contactsByGroups = ((StateIdle)currentState).ContactsByGroups;
            foreach(KeyValuePair<string,IList<UserListEntry>> pair in contactsByGroups)
            {
                bool found = false;
                foreach (UserListEntry entry in pair.Value)
                {
                    if (entry.UserName == username)
                    {
                        found = true;
                        pair.Value.Remove(entry);
                        break;
                    }
                }
                if(found)
                    break;
            }
            AMessageData messageData = new RemoveContactMessageData(this.currentUserName, username);
            Common.Protocol.Message removeContactMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.REMOVE_CONTACT), messageData);
            this.outputMessageQueue.Enqueue(removeContactMessage);
            mainView.RemoveContact(username);
            if (fileTransferView != null && ((StateIdle)currentState).OnlineContacts.ContainsKey(username))
            {
                fileTransferView.RemoveContact(username); 
            }
        }

        void mainView_OpenFileTransferViewEvent()
        {
            if (this.fileTransferView == null)
            {
                OnInstantiateFileTransferView();
            }
            this.fileTransferView.ShowView();
        }

        void mainView_OpenConversationEvent(string userName)
        {
            OnInstantiateConversationView(userName);
        }

        void mainView_MainCloseEvent()
        {
            if(currentState is StateIdle)
                fileListManager.SaveFileList();

            StopPeerConnectionManager();

            if (currentState is StateIdle)
            {
                AState lastState = currentState;
                currentState = currentState.MoveState();
                if (currentState != lastState)
                {
                    currentState.OpenConversationEvent+=new OpenConversationDelegate(currentState_OpenConversationEvent);
                }
                lastState = null;
            }

            EmptyCurrentStateOutputBuffer();

            inputMessageQueue.Clear();

            ProcessOutputQueue();

            toBreak = true;

            mainLoopStarted = false;
        }

        void mainView_OpenArchiveViewEvent(string contactName)
        {
            IArchiveView archiveView = OnInstantiateArchiveView();
            if (archiveView == null)
                return;
            archiveView.ShowDialog(archiveManager.GetMessageArchive(), contactName);
        }

        void mainView_OpenFileListViewEvent()
        {
            fileListView = OnInstantiateFileListView();
            fileListView.AddFileEvent += new AddFileDelegate(fileListView_AddFileEvent);
            fileListView.RemoveFileEvent += new RemoveFileDelegate(fileListView_RemoveFileEvent);
            fileListView.Initialise(fileListManager.FileList);
            fileListView.ShowView();
        }

        void mainView_LogoutEvent()
        {
            fileListManager.SaveFileList();

            StopPeerConnectionManager();

            foreach (KeyValuePair<string,IConversationController> pair in conversationControllers)
            {
                pair.Value.CloseView();
            }
            conversationControllers.Clear();

            this.mainView.LoginEvent -= mainView_LoginEvent;

            currentState = currentState.MoveState();

            this.mainView.LoginEvent += mainView_LoginEvent;

            EmptyCurrentStateOutputBuffer();
            
            inputMessageQueue.Clear();

            ProcessOutputQueue();

            toBreak = true;

            mainLoopStarted = false;

            mainView.Initialise();

            if(fileTransferView!=null)
                fileTransferView.CloseView();
            
            fileTransferView = null;
        }

        private void StopPeerConnectionManager()
        {
            if (peerConnectionManager == null)
                return;
            startedDownloads.Clear();
            peerConnectionManager.stopDelegate.Invoke();
            this.peerConnectionManager.CancelTransferEvent -= peerConnectionManager_CancelTransferEvent;
            this.peerConnectionManager.ProgressChangedEvent -= peerConnectionManager_ProgressChangedEvent;
            this.peerConnectionManager.RequestFileEvent -= peerConnectionManager_RequestFileEvent;
            this.peerConnectionManager.RequestFileListEvent -= peerConnectionManager_RequestFileListEvent;
            this.peerConnectionManager.TransferEndedEvent -= peerConnectionManager_TransferEndedEvent;
            this.peerConnectionManager = null;
            try
            {
                listenThread.Abort();
            }
            catch (ThreadAbortException ex)
            {
            }
        }


        void mainView_LoginEvent(string userName, string password)
        {
            this.archiveManager.UserName = userName;
            this.fileListManager.UserName = userName;
            this._downloadedFileLists = new Dictionary<string, IDictionary<int, string>>();
            this.currentUserName = userName;
            this.currentPassword = password;
            //StartPeerConnectionManager();

            this.currentState.PeerConnectionManagerThread = this.listenThread;

            EmptyCurrentStateOutputBuffer();

            if (mainLoopStarted == false)
            {
                mainLoopStarted = true;
                MainLoop();
            }
        }

        private void StartPeerConnectionManager()
        {
            peerConnectionManager = new PeerConnectionManager(0,localIpAddress,new ProgressChangedDelegate(this.peerConnectionManager_ProgressChangedEvent));
            peerConnectionManager.CancelTransferEvent += new CancelTransfer(peerConnectionManager_CancelTransferEvent);
            peerConnectionManager.ProgressChangedEvent += new ProgressChanged(peerConnectionManager_ProgressChangedEvent);
            peerConnectionManager.RequestFileEvent += new RequestFile(peerConnectionManager_RequestFileEvent);
            peerConnectionManager.RequestFileListEvent += new RequestFileList(peerConnectionManager_RequestFileListEvent);
            peerConnectionManager.TransferEndedEvent += new TransferEnded(peerConnectionManager_TransferEndedEvent);

            listenThread = new Thread(new ParameterizedThreadStart(StartPeer));
            listenThread.Start();
        }

        void StartPeer(object param)
        {
            localPort = peerConnectionManager.CreateListenerConnection(localIp);
            peerConnectionManager.MainLoop();
        }
        
        void mainView_OpenSignUpViewEvent()
        {
            OnInstantiateCreateAccountView();
            if (mainLoopStarted == false)
            {
                mainLoopStarted = true;
                MainLoop();
            }
        }

        void mainView_ChangeSettingsEvent(string adr, string port)
        {
            this.server = adr;
            this.port = Int32.Parse(port);
        }

        void mainView_RemoveGroupEvent(string group)
        {
            if (!(currentState is StateIdle))
                return;
            IList<UserListEntry> groupList = ((StateIdle)currentState).ContactsByGroups[group];
            if (groupList.Count > 0)
            {
                ErrorHandler.HandleError("Cannot delete group! The group is not empty!", "Error", (IWin32Window)mainView);
                return;
            }
            ((StateIdle)currentState).ContactsByGroups.Remove(group);
            AMessageData messageData = new RemoveGroupMessageData(this.currentUserName, group);
            Common.Protocol.Message message = new Common.Protocol.Message(new MessageHeader(ServiceTypes.REMOVE_GROUP), messageData);
            this.outputMessageQueue.Enqueue(message);
            mainView.RemoveGroup(group);
        }

       
        #endregion

        #region CreateAccountView Event Handlers

        void createAccountView_CreateAccountEvent(string userName,string password)
        {
            EmptyCurrentStateOutputBuffer();

            this.createAccountView.CloseView();

            this.createAccountView = null;
        }

        void createAccountView_CloseAccountViewEvent()
        {
            this.createAccountView.CloseView();
            this.mainView.ShowView();
            currentState = currentState.MoveState();
            if (currentState is StateIdle)
            {
                ((StateIdle)currentState).PeerConnectionManager = peerConnectionManager;
            }
        }

        #endregion

        #region ConversationControllers Event Handlers

        void newConversationController_SendServerMessageEvent(Common.Protocol.Message message)
        {
            if (message.Header.ServiceType == ServiceTypes.TEXT)
            {
                ArchiveMessage(message);
            }
            this.outputMessageQueue.Enqueue(message);
        }

        private void ArchiveMessage(Common.Protocol.Message message)
        {
            TextMessageData messageData = new TextMessageData(message.Data);
            archiveManager.SaveMessage(messageData.Receiver, messageData.Text);
        }

        void newConversationController_DisposeConversationControllerEvent(string name)
        {
            conversationControllers.Remove(name);            
        }

        #endregion

        #region Main Controller Events
        public event InstantiateConversationView InstantiateConversationViewEvent;

        protected virtual void OnInstantiateConversationView(string userName)
        {
            if (InstantiateConversationViewEvent != null)
            {
                InstantiateConversationViewEvent(userName);
            }
        }

        public event InstantiateCreateAccountView InstantiateCreateAccountViewEvent;

        protected virtual void OnInstantiateCreateAccountView()
        {
            if (InstantiateCreateAccountViewEvent != null)
            {
                InstantiateCreateAccountViewEvent();
            }
        }

        public event InstantiateFileTransferView InstantiateFileTransferViewEvent;

        protected virtual void OnInstantiateFileTransferView()
        {
            if (InstantiateFileTransferViewEvent != null)
            {
                InstantiateFileTransferViewEvent();
            }
        }

        public event InstantiateArchiveView InstantiateArchiveViewEvent;

        protected virtual IArchiveView OnInstantiateArchiveView()
        {
            if (InstantiateArchiveViewEvent != null)
            {
                return InstantiateArchiveViewEvent();
            }
            return null;
        }

        public event InstantiateFileListView InstantiateFileListViewEvent;

        protected virtual IFileListView OnInstantiateFileListView()
        {
            if (InstantiateFileListViewEvent != null)
            {
                return InstantiateFileListViewEvent();
            }
            return null;
        }
        #endregion

        #region MainController Methods

        private void ForceEmptyOutputQueue()
        {
            outputMessageQueue.Clear();
        }

        private void ProcessOutputQueue()
        {
            while (outputMessageQueue.Count > 0)
            {
                Common.Protocol.Message firstMessage = outputMessageQueue.Dequeue();

                SendServerMessage(firstMessage);
            }
        }

        private void ProcessInputQueue()
        {
            while (inputMessageQueue.Count > 0)
            {
                Common.Protocol.Message firstMessage = inputMessageQueue.Dequeue();
                AState lastState = currentState;

                mainView.LoginEvent -= this.mainView_LoginEvent;

                currentState = currentState.AnalyzeMessage(firstMessage);
                if (currentState != lastState)
                {
                    currentState.OpenConversationEvent+=new OpenConversationDelegate(currentState_OpenConversationEvent);
                }
                lastState = null;
                if (currentState is StateIdle)
                {
                    ((StateIdle)currentState).UserName = this.currentUserName;
                    ((StateIdle)currentState).Ip = this.localIpAddress;
                    ((StateIdle)currentState).Port = this.localPort;
                }
                if (currentState.ToCloseConnection)
                {
                    toBreak = true;
                }
                if (currentState.Disconected)
                {
                    StopPeerConnectionManager();
                    mainView.Initialise();
                }
                mainView.LoginEvent += this.mainView_LoginEvent;
            }
            EmptyCurrentStateOutputBuffer();
        }

        private void CloseServerConnection()
        {
            if (serverSocket != null)
            {
                serverSocket.Close();
                serverSocket = null;
            }
        }

        private bool CreateServerConnection()
        {
            IPHostEntry hostEntry = null;
            
            try
            {
                hostEntry = Dns.GetHostEntry(server);
                if (hostEntry.AddressList.Length <= 0)
                {
                    return false;
                }
           
                foreach (IPAddress address in hostEntry.AddressList)
                {
                    IPEndPoint ipe = new IPEndPoint(address, port);
                    Socket tempSocket =
                        new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    tempSocket.Connect(ipe);

                    if (tempSocket.Connected)
                    {
                        serverSocket = tempSocket;
                        localIpAddress = ((IPEndPoint)serverSocket.LocalEndPoint).Address.ToString();
                        localIp = ((IPEndPoint)serverSocket.LocalEndPoint).Address;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (SocketException ex)
            {
                ErrorHandler.HandleError("The connection with the server could not be established !", "Connection Error", (IWin32Window)mainView);
                return false;
            }
            return true;
        }

        private void SendServerMessage(Common.Protocol.Message message)
        {
            try
            {
                serverSocket.Send(message.Serialize());
            }
            catch(SocketException ex)
            {
                HandleSocketException();
            }
        }

        private void HandleSocketException()
        {
            ErrorHandler.HandleError("The connection with the server has been lost!", "Connection Error", (IWin32Window)mainView);

            toBreak = true;
            mainLoopStarted = false;

            StopPeerConnectionManager();

            mainView.LoginEvent -= this.mainView_LoginEvent;
            this.currentState = new StateInitial();

            currentState.MainView = mainView;
            currentState.OpenConversationEvent += new OpenConversationDelegate(currentState_OpenConversationEvent);

            foreach (KeyValuePair<string,IConversationController> controller in conversationControllers)
            {
                controller.Value.CloseView();
            }
            conversationControllers.Clear();
            if (fileListView != null)
            {
                fileListView.CloseView();
            }

            if (fileTransferView != null)
            {
                fileTransferView.CloseView();
            }

            currentState.ConversationControllers = conversationControllers;

            mainView.LoginEvent += new LoginEventHandler(this.mainView_LoginEvent);

            mainView.Initialise();
        }

        private void EmptyCurrentStateOutputBuffer()
        {

            foreach (Common.Protocol.Message message in currentState.OutputMessagesList)
            {
                this.outputMessageQueue.Enqueue(message);
            }
            currentState.OutputMessagesList.Clear();
        }
        #endregion

        #region FileListView Event handlers


        void fileListView_RemoveFileEvent(string name)
        {
            int i = 0;
            foreach (KeyValuePair<int, KeyValuePair<string, string>> pair in this.fileListManager.FileList)
            {
                if (pair.Value.Key == name)
                {
                    for (int j = i + 1; j < fileListManager.FileList.Count; j++)
                    {
                        fileListManager.FileList[j] = new KeyValuePair<int, KeyValuePair<string, string>>(fileListManager.FileList[j].Key - 1, fileListManager.FileList[j].Value);
                    }
                    this.fileListManager.FileList.Remove(pair); 
                    break;
                }
                i++;
            }
            this.fileListManager.SaveFileList();
        }

        void fileListView_AddFileEvent(string name, string alias)
        {
            int newIndex = 0;
            if(fileListManager.FileList.Count > 0)
                newIndex = fileListManager.FileList[fileListManager.FileList.Count - 1].Key + 1;
            this.fileListManager.FileList.Add(new KeyValuePair<int, KeyValuePair<string, string>>(newIndex, new KeyValuePair<string, string>(name, alias)));
            this.fileListManager.SaveFileList();
        }



        #endregion

        #region File Transfer View Event Handlers

        IDictionary<string, IDictionary<int, string>> _downloadedFileLists;

        void fileTransferView_ViewClosedEvent()
        {
            fileTransferView.HideView();
        }

        void fileTransferView_GetContactListEvent(string contact)
        {
            if (((StateIdle)currentState).MadeConnectionRequests.ContainsKey(contact))
            {
                ConnectionDataMessageData data = ((StateIdle)currentState).MadeConnectionRequests[contact];
                IDictionary<int, string> receivedFileList = peerConnectionManager.getFileListFromPeerDelegate.Invoke(contact, data.IpAddress, data.Port);
                _downloadedFileLists[contact] = receivedFileList;
            }
            else
            {
                AMessageData messageData = new ConnectionDataRequestedMessageData(this.currentUserName, contact);
                Common.Protocol.Message connDataMessage = new Common.Protocol.Message(new MessageHeader(ServiceTypes.CONNECTION_REQ), messageData);
                this.outputMessageQueue.Enqueue(connDataMessage);
                ((StateIdle)currentState).PendingConnectionRequests.Add(new KeyValuePair<string, ConnectionDataMessageData>(contact, null));
                return;
            }
            IDictionary<int, string> fileList = _downloadedFileLists[contact];
            IList<string> toReturn = new List<string>();
            foreach (KeyValuePair<int, string> pair in fileList)
            {
                toReturn.Add(pair.Value);
            }
            fileTransferView.LoadList(contact, toReturn);
        }

        void fileTransferView_ContactSelectedEvent(string contact)
        {
            if (!_downloadedFileLists.ContainsKey(contact))
                return;
            IDictionary<int, string> fileList = _downloadedFileLists[contact];
            IList<string> toReturn = new List<string>();
            foreach (KeyValuePair<int, string> pair in fileList)
            {
                toReturn.Add(pair.Value);
            }
            fileTransferView.LoadList(contact, toReturn);
        }


        void fileTransferView_CancelFileTransferEvent(string contact, string file)
        {
            fileTransferView.CancelFileTransfer(contact, file);
        }

        IList<KeyValuePair<string, KeyValuePair<int, string>>> startedDownloads = new List<KeyValuePair<string, KeyValuePair<int, string>>>();

        void fileTransferView_StartFileTransferEvent(string contact, string file, string writeLocation)
        {
            IDictionary<int,string> fileList = _downloadedFileLists[contact];
            int fileId = -1;
            foreach(KeyValuePair<int,string> pair in fileList)
            {
                if(file == pair.Value)
                {
                    fileId = pair.Key;
                    break;
                }
            }
            if(fileId == -1)
                return;

            fileTransferView.StartFileTransfer(contact, file);

            if (TransferAlreadyExists(contact, fileId))
            {
                ErrorHandler.HandleError("Transfer Already in Progress", "Error", (IWin32Window)mainView);
                return;
            }

            startedDownloads.Add(new KeyValuePair<string, KeyValuePair<int, string>>(contact, new KeyValuePair<int, string>(fileId, file)));
            ConnectionDataMessageData connectionData = ((StateIdle)currentState).MadeConnectionRequests[contact];
            peerConnectionManager.getFileFromPeerDelegate(contact, fileId, writeLocation + "\\" + file, connectionData.IpAddress, connectionData.Port, currentUserName);
        }

        private bool TransferAlreadyExists(string contact, int fileid)
        {
            foreach (KeyValuePair<string, KeyValuePair<int, string>> pair in startedDownloads)
            {
                if (pair.Key == contact && pair.Value.Key == fileid)
                {
                    return true;
                }
            }
            return false;
        }
               

        #endregion

        #region PeerConnectionManager handlers

        void peerConnectionManager_ProgressChangedEvent(string contact, int fileId, int percentage,float speed)
        {            
            foreach (KeyValuePair<string, KeyValuePair<int, string>> download in startedDownloads)
            {
                if (download.Key == contact && download.Value.Key == fileId)
                {
                    fileTransferView.UpdateTransferProgress(contact, download.Value.Value, percentage, speed);
                    break;
                }
            }
        }

        void peerConnectionManager_CancelTransferEvent(string contact, int fileId)
        {
            peerConnectionManager.cancelFileTransferDelegate(contact, fileId);
            foreach (KeyValuePair<string, KeyValuePair<int, string>> download in startedDownloads)
            {
                if (download.Key == contact && download.Value.Key == fileId)
                {
                    fileTransferView.FileTransferFinished(contact, download.Value.Value);
                    startedDownloads.Remove(download);
                    break;
                }
            }
        }

        void peerConnectionManager_TransferEndedEvent(string contact, int fileId)
        {
            foreach (KeyValuePair<string, KeyValuePair<int, string>> download in startedDownloads)
            {
                if (download.Key == contact && download.Value.Key == fileId)
                {
                    fileTransferView.FileTransferFinished(contact, download.Value.Value);
                    startedDownloads.Remove(download);
                    break;
                }
            }
        }

        void peerConnectionManager_RequestFileListEvent(string contact, Socket contactSocket)
        {
            IList<KeyValuePair<int,KeyValuePair<string,string>>> fileList = fileListManager.FileList;
            IDictionary<int,string> toReturn = new Dictionary<int,string>();
            foreach(KeyValuePair<int,KeyValuePair<string,string>> pair in fileList)
            {
                toReturn.Add(pair.Key,pair.Value.Value);
            }
            peerConnectionManager.requestedFileListDelegate.Invoke(toReturn, contactSocket);
        }

        void peerConnectionManager_RequestFileEvent(string contact, int fileId, Socket contactSocket)
        {
            string fileName = "";
            foreach (KeyValuePair<int, KeyValuePair<string, string>> pair in fileListManager.FileList)
            {
                if (pair.Key == fileId)
                {
                    fileName = pair.Value.Value;
                    break;
                }
            }

            peerConnectionManager.requestedFileDelegate.Invoke(fileId, fileName, fileListManager.FileList[fileId].Value.Key, contactSocket);
        }


        #endregion
    }

    #endregion
}

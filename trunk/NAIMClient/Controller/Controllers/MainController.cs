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

namespace Controllers
{
    #region MainController Class

    #region Delegates

    public delegate void InstantiateConversationView(string username);

    public delegate void InstantiateCreateAccountView();

    public delegate void InstantiateFileTransferView();

    public delegate IArchiveView InstantiateArchiveView();

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

        private Socket serverSocket = null;

        private bool toBreak = false;

        private bool mainLoopStarted = false;

        private string server = "localhost";//"10.6.3.114";

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

        #region Client Peer Connection data
        /// <summary>
        /// the address for accepting peer to peer connections
        /// </summary>
        private string localIpAddress = "localhost";

        public string LocalIpAddress
        {
            get { return localIpAddress; }
            set { localIpAddress = value; }
        }

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
            this.mainView.Initialise();

            this.conversationControllers = new Dictionary<string,IConversationController>();
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
                ((StateIdle)currentState).InitialiseFileTransferManager(newFileTransferView);
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
                    byte[] headerBuffer = new byte[MessageHeader.HEADER_SIZE];
                    int n = serverSocket.Receive(headerBuffer);
                    ushort contentLength = AMessageData.ToShort(headerBuffer[MessageHeader.HEADER_SIZE - 2], headerBuffer[MessageHeader.HEADER_SIZE - 1]);
                    byte[] rawData = new byte[contentLength];
                    if (contentLength > 0)
                    {
                        n = serverSocket.Receive(rawData);
                    }
                    byte[] messageBuffer = new byte[headerBuffer.Length+contentLength];
                    Array.Copy(headerBuffer, messageBuffer, headerBuffer.Length);
                    Array.Copy(rawData, 0, messageBuffer,headerBuffer.Length, contentLength);
                    Common.Protocol.Message newMessage = new Common.Protocol.Message(messageBuffer);
                    inputMessageQueue.Enqueue(newMessage);
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
            AMessageData messageData = new AddContactMessageData(this.currentUserName, newgroup, contact);
            Common.Protocol.Message changeContactGroupMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            outputMessageQueue.Enqueue(changeContactGroupMessage);
#warning to change user group in GUI too
        }

        void mainView_AddContactEvent(string uname, string group)
        {
            if (!(currentState is StateIdle))
                return;
            if (AState.CheckIfContactExists(uname,((StateIdle)currentState).ContactsByGroups))
            {
                MessageBox.Show("Contact already in contacts list!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            AMessageData messageData = new AddContactMessageData(this.currentUserName, group, uname);
            Common.Protocol.Message addContactMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            this.outputMessageQueue.Enqueue(addContactMessage);
            ((StateIdle)currentState).ContactsByGroups[group].Add(new UserListEntry(uname));
            mainView.AddContact(uname, group);
        }

        void mainView_AddGroupEvent(string group)
        {
            if (!(currentState is StateIdle))
                return;
            if (AState.CheckIfGroupExists(group, ((StateIdle)currentState).ContactsByGroups))
            {
                MessageBox.Show("Group already in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        void mainView_OpenFileTransferViewEvent()
        {
            if (this.fileTransferView == null)
            {
                OnInstantiateFileTransferView();
            }
            else
            {
                this.fileTransferView.ShowView();
            }
        }

        void mainView_OpenConversationEvent(string userName)
        {
            OnInstantiateConversationView(userName);
        }

        void mainView_MainCloseEvent()
        {
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

        void mainView_OpenArchiveViewEvent(string username)
        {
            IArchiveView archiveView = OnInstantiateArchiveView();
            if (archiveView == null)
                return;
            archiveView.ShowDialog(archiveManager.GetMessageArchive());
        }

        void mainView_LogoutEvent()
        {
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

        }


        void mainView_LoginEvent(string userName, string password)
        {
            this.archiveManager.UserName = userName;
            this.fileListManager.UserName = userName;
            this.currentUserName = userName;
            this.currentPassword = password;

            EmptyCurrentStateOutputBuffer();

            if (mainLoopStarted == false)
            {
                mainLoopStarted = true;
                MainLoop();
            }
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
                MessageBox.Show("Cannot delete group! The group is not empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    mainView.Initialise();
                }
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
                MessageBox.Show("The connection with the server could not be established !","Connection Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SendServerMessage(Common.Protocol.Message message)
        {
            serverSocket.Send(message.Serialize());
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
    }

    #endregion
}

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

namespace Controllers
{
    public delegate void InstantiateConversationView(string username);

    public delegate void InstantiateCreateAccountView();

    public delegate void InstantiateFileTransferView();

    public class MainController
    {
        /// <summary>
        /// this is for debugging purposes only. Should be set on true if testing without a server!!!
        /// </summary>
        private bool withoutServerMode = false;

        private AState currentState = null;

        private IDictionary<string,IConversationController> conversationControllers;

        /// <summary>
        /// contains the messages received from the server
        /// </summary>
        private IList<Common.Protocol.Message> inputMessageQueue;

        /// <summary>
        /// contains the messages to be sent to the server
        /// </summary>
        private IList<Common.Protocol.Message> outputMessageQueue;

        private IMainView mainView;

        private Socket serverSocket = null;

        private bool toBreak = false;

        private bool mainLoopStarted = false;

        private string server;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private int port;

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        private string currentUserName;

        private string currentPassword;

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

        /// <summary>
        /// This is called from the main class.
        /// </summary>
        public void Initialise(IMainView mainView)
        {
            this.currentState = new StateInitial();

            currentState.MainView = mainView;

            this.mainView = mainView;
            this.mainView.AddContactEvent += new AddContactEventHandler(mainView_AddContactEvent);
            this.mainView.ChangeContactGroupEvent += new ChangeContactGroupEventHandler(mainView_ChangeContactGroupEvent);
            this.mainView.ChangeStatusEvent += new ChangeStatusEventHandler(mainView_ChangeStatusEvent);
            this.mainView.LoginEvent += new LoginEventHandler(mainView_LoginEvent);
            this.mainView.LogoutEvent += new LogoutEventHandler(mainView_LogoutEvent);
            this.mainView.MainCloseEvent += new MainCloseEventHandler(mainView_MainCloseEvent);
            this.mainView.OpenConversationEvent += new OpenConversationEventHandler(mainView_OpenConversationEvent);
            this.mainView.OpenFileTransferViewEvent += new OpenFileTransferViewEventHandler(mainView_OpenFileTransferViewEvent);
            this.mainView.RemoveContactEvent += new RemoveContactEventHandler(mainView_RemoveContactEvent);
            this.mainView.OpenSignUpViewEvent += new OpenSignUpViewHandler(mainView_OpenSignUpViewEvent);
            this.mainView.Initialise();

            this.conversationControllers = new Dictionary<string,IConversationController>();
            this.inputMessageQueue = new List<Common.Protocol.Message>();
            this.outputMessageQueue = new List<Common.Protocol.Message>();

            
            
            currentState.ConversationControllers = conversationControllers;

            //if (!withoutServerMode)
            //{
            //    if (!CreateServerConnection())
            //    {
            //        MessageBox.Show("Eroare la conectarea la server!!!");
            //        return;
            //    }
            //}

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
            currentState = currentState.MoveState();
            this.createAccountView.Initialise();
            this.createAccountView.CloseAccountViewEvent += new CloseAccountViewEventHandler(createAccountView_CloseAccountViewEvent);
            this.createAccountView.CreateAccountEvent += new CreateAccountEventHandler(createAccountView_CreateAccountEvent);
            this.createAccountView.ShowView();
        }

        public void InitialiseFileTransferManager(IFileTransferView newFileTransferView)
        {
            if (this.currentState is StateIdle)
            {
                ((StateIdle)currentState).InitialiseFileTransferManager(newFileTransferView);
            }
        }

        private void MainLoop()
        {
            if (!CreateServerConnection())
            {
                MessageBox.Show("Eroare la conectarea la server!!!");
                return;
            }

            while (true)
            {
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
                    inputMessageQueue.Add(newMessage);
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

        #region MainView Event Handlers
        void mainView_ChangeStatusEvent(string status)
        {
            AMessageData messageData = new StatusMessageData(this.currentUserName, status);
            Common.Protocol.Message changeStatusMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.STATUS), messageData);
            this.outputMessageQueue.Add(changeStatusMessage);
            mainView.ChangeStatus(status);
        }

        void mainView_ChangeContactGroupEvent(string contact, string newgroup)
        {
            AMessageData messageData = new AddContactMessageData(this.currentUserName, newgroup, contact);
            Common.Protocol.Message changeContactGroupMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            outputMessageQueue.Add(changeContactGroupMessage);
#warning to change user group in GUI too
        }

        void mainView_AddContactEvent(string uname, string group)
        {
            AMessageData messageData = new AddContactMessageData(this.currentUserName, group, uname);
            Common.Protocol.Message addContactMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.ADD_CONTACT), messageData);
            this.outputMessageQueue.Add(addContactMessage);
#warning to add user in group in GUI too

        }
        void mainView_RemoveContactEvent(string username)
        {
            AMessageData messageData = new RemoveContactMessageData(this.currentUserName, username);
            Common.Protocol.Message removeContactMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.REMOVE_CONTACT), messageData);
            this.outputMessageQueue.Add(removeContactMessage);
#warning to remove user from GUI too
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
            global::System.Windows.Forms.MessageBox.Show("NOW EXITING");
            toBreak = true;
        }

        void mainView_LogoutEvent()
        {
            global::System.Windows.Forms.MessageBox.Show("NOW SIGNING OFF!");
            foreach (KeyValuePair<string,IConversationController> pair in conversationControllers)
            {
                pair.Value.CloseView();
            }
            conversationControllers.Clear();

            currentState = currentState.MoveState();

            EmptyCurrentStateOutputBuffer();
            
            if (!withoutServerMode)
            {
                //clear the input messages
                inputMessageQueue.Clear();

                //process the output queue
                ProcessOutputQueue();
            }

            toBreak = true;
            mainLoopStarted = false;

            mainView.Initialise();

        }



        void mainView_LoginEvent(string userName, string password)
        {
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
        }

        #endregion

        #region ConversationControllers Event Handlers

        void newConversationController_SendServerMessageEvent(Common.Protocol.Message message)
        {
            this.outputMessageQueue.Add(message);
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
        #endregion


        #region MainController Methods
        
        private void ProcessOutputQueue()
        {
#warning OUTPUT QUEUE NOT IMPLEMENTED
            while (outputMessageQueue.Count > 0)
            {
                Common.Protocol.Message firstMessage = outputMessageQueue[0];

                SendServerMessage(firstMessage);

                outputMessageQueue.RemoveAt(0);
            }
        }

        private void ProcessInputQueue()
        {
            while (inputMessageQueue.Count > 0)
            {
                Common.Protocol.Message firstMessage = inputMessageQueue[0];
                currentState = currentState.AnalyzeMessage(firstMessage);
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
                inputMessageQueue.RemoveAt(0);
            }
            EmptyCurrentStateOutputBuffer();
        }

        private void CloseServerConnection()
        {
            serverSocket.Close();
        }

        private bool CreateServerConnection()
        {
            IPHostEntry hostEntry = null;

            hostEntry = Dns.GetHostEntry("localhost");
            port = 18005;

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
                this.outputMessageQueue.Add(message);
            }
            currentState.OutputMessagesList.Clear();
        }
        #endregion

    }
}

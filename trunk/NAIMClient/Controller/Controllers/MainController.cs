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

namespace Controllers
{
    public delegate void InstantiateConversationView(string username);

    public delegate void InstantiateCreateAccountView();

    public delegate void InstantiateFileTransferView();

    public class MainController
    {
        private bool withoutServerMode = true;


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

            if (!withoutServerMode)
            {
                if (!CreateServerConnection())
                {
                    MessageBox.Show("Eroare la conectarea la server!!!");
                }
            }

        }
        public void InitialiseConversation(string userName,IConversationView conversationView)
        {
            ConversationController newConversationController = new ConversationController();
            newConversationController.Name = userName;
            newConversationController.SendServerMessageEvent += new SendServerMessageEventHandler(newConversationController_SendServerMessageEvent);
            newConversationController.DisposeConversationControllerEvent += new DisposeConversationController(newConversationController_DisposeConversationControllerEvent);
            newConversationController.InitialiseView(conversationView);
            this.conversationControllers.Add(userName, newConversationController);
        }

        public void InitialiseCreateAccount(ICreateAccountView newCreateAccountView)
        {
            this.createAccountView = newCreateAccountView;
            this.createAccountView.Initialise();
            this.createAccountView.CloseAccountViewEvent += new CloseAccountViewEventHandler(createAccountView_CloseAccountViewEvent);
            this.createAccountView.CreateAccountEvent += new CreateAccountEventHandler(createAccountView_CreateAccountEvent);
            this.createAccountView.ShowView();
        }

        public void InitialiseFileTransferManager(IFileTransferView newFileTransferView)
        {
            this.fileTransferView = newFileTransferView;
            this.fileTransferView.Initialise();
            this.fileTransferView.CancelFileTransferEvent += new CancelFileTransferEventHandler(fileTransferView_CancelFileTransferEvent);
            this.fileTransferView.FileTransferCloseViewEvent += new FileTransferCloseViewEventHandler(fileTransferView_FileTransferCloseViewEvent);
            this.fileTransferView.GetFileListEvent += new GetFileListEventHandler(fileTransferView_GetFileListEvent);
            this.fileTransferView.StartFileTransferEvent += new StartFileTransferEventHandler(fileTransferView_StartFileTransferEvent);
            this.fileTransferView.CloseFileTransferViewEvent += new CloseFileTransferViewEventHandler(fileTransferView_CloseFileTransferViewEvent);
            this.fileTransferView.ShowView();
        }

        private void MainLoop()
        {
            while (true)
            {
                if (toBreak)
                {
                    toBreak = false;
                    break;
                }
                if (!withoutServerMode)
                {
                    if (serverSocket.Poll(1, SelectMode.SelectRead))
                    {
                        byte[] receivedBuffer = new byte[ushort.MaxValue];
                        int n = serverSocket.Receive(receivedBuffer);
                        byte[] messageBuffer = new byte[n];
                        Array.Copy(receivedBuffer, messageBuffer, n);
                        Common.Protocol.Message newMessage = new Common.Protocol.Message(messageBuffer);
                        inputMessageQueue.Add(newMessage);
                    }
                }
                ProcessInputQueue();

                Application.DoEvents();
                if (!withoutServerMode)
                {
                    if (serverSocket.Poll(1, SelectMode.SelectWrite))
                    {
                        ProcessOutputQueue();
                    }
                }
            }
        }

        #region MainView Event Handlers
        void mainView_ChangeStatusEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void mainView_ChangeContactGroupEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void mainView_AddContactEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        void mainView_RemoveContactEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
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

        void mainView_MainCloseEvent(object eventArgs)
        {
            global::System.Windows.Forms.MessageBox.Show(eventArgs.ToString());
            toBreak = true;
        }

        void mainView_LogoutEvent(object eventArgs)
        {
            global::System.Windows.Forms.MessageBox.Show(eventArgs.ToString());
            foreach (KeyValuePair<string,IConversationController> pair in conversationControllers)
            {
                pair.Value.CloseView();
            }
            conversationControllers.Clear();
            mainView.Initialise();

            //clear the input messages
            inputMessageQueue.Clear();

            //process the output queue
            ProcessOutputQueue();
        }

        

        void mainView_LoginEvent(string userName, string password)
        {
            System.Windows.Forms.MessageBox.Show("AUTENTIFICARE USER "+userName+" CU PAROLA "+password);
            mainView.AfterSignIn();
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
            System.Windows.Forms.MessageBox.Show("Creare cont: Username = "+userName+" ,Password = "+password);

            AMessageData signupMessageData = new SignUpMessageData(userName,password);

            Common.Protocol.Message signupMessage = new Common.Protocol.Message(new MessageHeader(ServiceTypes.SIGNUP), signupMessageData);

            inputMessageQueue.Add(signupMessage);

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
            throw new Exception("The method or operation is not implemented.");
        }

        void newConversationController_DisposeConversationControllerEvent(string name)
        {
            conversationControllers.Remove(name);            
        }

        #endregion

        #region FileTransferView Event Handlers
        
        void fileTransferView_CancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void fileTransferView_FileTransferCloseViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void fileTransferView_GetFileListEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void fileTransferView_StartFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void fileTransferView_CloseFileTransferViewEvent()
        {
            this.fileTransferView = null;
            this.mainView.ShowView();
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
        }

        private void ProcessInputQueue()
        {
#warning INPUT QUEUE NOT IMPLEMENTED
            while (inputMessageQueue.Count > 0)
            {
                Common.Protocol.Message firstMessage = inputMessageQueue[0];
                inputMessageQueue.RemoveAt(0);
            }
        }

        private bool CreateServerConnection()
        {
            IPHostEntry hostEntry = null;

            hostEntry = Dns.GetHostEntry("localhost");
            port = 10000;

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
            throw new System.NotImplementedException();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using System.Collections;

namespace Controllers
{
    public delegate void InstantiateConversationView(string username);

    public class MainController
    {
        private IDictionary<string,IConversationController> conversationControllers;

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
            this.mainView.Initialise();

            this.conversationControllers = new Dictionary<string,IConversationController>();
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

        

        private void SendServerMessage(Packet message)
        {
            throw new System.NotImplementedException();
        }

        private void MainLoop()
        {
            throw new System.NotImplementedException();
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

        void mainView_OpenFileTransferViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void mainView_OpenConversationEvent(string userName)
        {
            OnInstantiateConversationView(userName);
        }

        void mainView_MainCloseEvent(object eventArgs)
        {
            global::System.Windows.Forms.MessageBox.Show(eventArgs.ToString());
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
        }

        void mainView_LoginEvent(string userName, string password)
        {
            System.Windows.Forms.MessageBox.Show("AUTENTIFICARE USER "+userName+" CU PAROLA "+password);
            mainView.AfterSignIn();
        }
        #endregion

        #region ConversationControllers Event Handlers
        void newConversationController_SendServerMessageEvent(Packet message)
        {
            throw new Exception("The method or operation is not implemented.");
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
        #endregion
    }
}

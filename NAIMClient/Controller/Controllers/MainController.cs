using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;

namespace Controllers
{
    public class MainController
    {
        private IList<IConversationController> conversationControllers;

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
        }

        private void InitialiseConversation(string userName)
        {
            throw new System.NotImplementedException();
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
        #endregion
    }
}

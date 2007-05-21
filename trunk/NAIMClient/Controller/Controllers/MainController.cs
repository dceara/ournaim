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
        private IFileTransferView fileTransferView;
        private ICreateAccountView createAccountView;

        private IMainView mainView;

        public IMainView MainView
        {
            get { return mainView; }
            set { mainView = value; }
        }


        /// <summary>
        /// This is called from the main class.
        /// </summary>
        public void Initialise()
        {
            throw new System.NotImplementedException();
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
    }
}

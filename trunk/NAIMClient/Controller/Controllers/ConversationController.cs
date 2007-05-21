using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;

namespace Controllers
{
    class ConversationController : IConversationController
    {
        private IConversationView conversationView;
        private string name;
        #region IConversationController Members

        public event SendServerMessageEventHandler SendServerMessageEvent;

        public void OnSendServerMessage(Packet message)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ReceiveServerMessage(Packet message)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        /// <summary>
        /// This creates a new thread where the file will be transfered
        /// </summary>
        private void StartPeer2PeerReceiver(string filename, ConnectionDetails connectionDetails)
        {
            throw new System.NotImplementedException();
        }

        private void StartPeer2PeerSender(string filename, ConnectionDetails connectionDetails)
        {
            throw new System.NotImplementedException();
        }

        #region IConversationController Members


        public void InitialiseView(IConversationView view)
        {
            throw new Exception("The method or operation is not implemented.");
        }


        public string Name
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion
    }
}

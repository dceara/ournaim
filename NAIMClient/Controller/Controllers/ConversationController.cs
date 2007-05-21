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
            if (SendServerMessageEvent != null)
            {
                SendServerMessageEvent(message);
            }
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
            this.conversationView = view;
            view.Initialise(this.name);
            conversationView.CancelFileTransferEvent += new CancelFileTransferEventHandler(conversationView_CancelFileTransferEvent);
            conversationView.CloseEvent += new CloseEventDelegate(conversationView_CloseEvent);
            conversationView.ShowView();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public event DisposeConversationController DisposeConversationControllerEvent;

        public void OnDisposeConversationController(string userName)
        {
            if (DisposeConversationControllerEvent != null)
            {
                DisposeConversationControllerEvent(userName);
            }
        }

        public void CloseView()
        {
            conversationView.CloseView();
        }

        #endregion

        #region ConversationView Event handlers

        void conversationView_CloseEvent(object eventArgs)
        {
            OnDisposeConversationController(this.name);
        }

        void conversationView_CancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using Common.ProtocolEntities;

namespace Controllers
{
    class ConversationController : IConversationController
    {
        private IConversationView conversationView;
        private string name;
        #region IConversationController Members

        public event SendServerMessageEventHandler SendServerMessageEvent;

        public void OnSendServerMessage(Message message)
        {
            if (SendServerMessageEvent != null)
            {
                SendServerMessageEvent(message);
            }
        }

        public void ReceiveServerMessage(Message message)
        {
            switch (message.Header.ServiceType)
            {
                case Common.ServiceTypes.CONNECTION_DATA:
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
                    break;
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        public void ReceiveTextMessage(TextMessageData messageData)
        {
            conversationView.AddMessage(messageData.Text);
        }

        #endregion

        /// <summary>
        /// This creates a new thread where the file will be transfered
        /// </summary>
        private void StartPeer2PeerReceiver(string filename, string senderUserName)
        {

            throw new System.NotImplementedException();
        }

        private void StartPeer2PeerSender(string filename, string receiverUserName)
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

        void conversationView_CloseEvent()
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

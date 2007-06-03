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
        private string receiverName;
        private string currentClientName;
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
#warning not implemented yet
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
#warning not implemented yet
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
            view.Initialise(this.receiverName);
            conversationView.CancelFileTransferEvent += new CancelFileTransferEventHandler(conversationView_CancelFileTransferEvent);
            conversationView.CloseEvent += new CloseEventDelegate(conversationView_CloseEvent);
            conversationView.SendMessageEvent += new SendMessageDelegate(conversationView_SendMessageEvent);
            conversationView.StartFileTransferEvent += new StartFileTransferEventHandler(conversationView_StartFileTransferEvent);
            conversationView.ShowView();
        }

        public string ReceiverName
        {
            get
            {
                return receiverName;
            }
            set
            {
                this.receiverName = value;
            }
        }

        public string CurrentClientName
        {
            get
            {
                return this.currentClientName;
            }
            set
            {
                this.currentClientName = value;
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
            OnDisposeConversationController(this.receiverName);
        }

        void conversationView_CancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void conversationView_StartFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void conversationView_SendMessageEvent(string messageText)
        {
            AMessageData messageData = new TextMessageData(this.currentClientName, this.receiverName, messageText);
            Message toSend = new Message(new MessageHeader(Common.ServiceTypes.TEXT), messageData);
            OnSendServerMessage(toSend);
        }
        #endregion

    }
}

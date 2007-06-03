using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common;
using Common.ProtocolEntities;
using Common.Interfaces;

namespace Controller.StateObjects
{
    public class StateIdle:AState
    {
        public StateIdle()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.PING, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.TEXT, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.USER_CONNECTED, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.USER_DISCONNECTED, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.CONNECTION_DATA, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.CONNECTION_REQ, typeof(StateIdle));
        }

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            AMessageData messageData = Message.GetMessageData(message);
            switch (message.Header.ServiceType)
            {
                case Common.ServiceTypes.PING:
                    Message response = new Message(new MessageHeader(ServiceTypes.ACK), new AckMessageData());
                    _outputMessagesList.Add(response);
                    break;
                case Common.ServiceTypes.TEXT:
                    RedirectTextMessageToConversationController((TextMessageData)messageData);
                    break;
                case Common.ServiceTypes.USER_CONNECTED:
                    UserConnectedMessageData userConnectedData = (UserConnectedMessageData)messageData;
                    _mainView.ClientOnline(userConnectedData.UserName, userConnectedData.Status);
                    break;
                case Common.ServiceTypes.USER_DISCONNECTED:
                    UserDisconnectedMessageData userDisconenctedData = (UserDisconnectedMessageData)messageData;
                    _mainView.ClientOffline(userDisconenctedData.UserName);
                    break;
                case Common.ServiceTypes.CONNECTION_DATA:
                    RedirectMessageToConversationController(message,((ConnectionDataMessageData)messageData).Sender);
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
                    RedirectMessageToConversationController(message,((ConnectionDataMessageData)messageData).Sender);
                    break;
            }
            return this;
        }

        

        protected override void InitializeMainViewEventHandlers()
        {
        }

        protected override void InitializeConversationControllersHandlers()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeAccountViewHandlers()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        public override AState MoveState()
        {
            AState newState = new StateInitial();
            newState.MainView = _mainView;
            return newState;
        }


        private void RedirectTextMessageToConversationController(TextMessageData message)
        {
            string senderName = message.Sender;
            IConversationController conversationController = _conversationControllers[senderName];
            if (conversationController != null)
            {
                conversationController.ReceiveTextMessage(message);
            }
        }

        private void RedirectMessageToConversationController(Message message, string sender)
        {
            IConversationController conversationController = _conversationControllers[sender];
            conversationController.ReceiveServerMessage(message);
        }

        
    }
}

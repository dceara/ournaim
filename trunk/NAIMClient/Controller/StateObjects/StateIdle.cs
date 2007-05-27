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
            switch (message.Header.ServiceType)
            {
                case Common.ServiceTypes.PING:
                    Message response = new Message(new MessageHeader(ServiceTypes.ACK), new AckMessageData());
                    _outputMessagesList.Add(response);
                    break;
                case Common.ServiceTypes.TEXT:
                    RedirectMessageToConversationController(message);
                    break;
                case Common.ServiceTypes.USER_CONNECTED:
                    break;
                case Common.ServiceTypes.USER_DISCONNECTED:
                    break;
                case Common.ServiceTypes.CONNECTION_DATA:
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
                    break;
            }
            return this;
        }

        

        protected override void InitializeMainViewEventHandlers()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeConversationControllersHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeAccountViewHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override AState MoveState()
        {
            throw new Exception("The method or operation is not implemented.");
        }


        private void RedirectMessageToConversationController(Common.Protocol.Message message)
        {
            TextMessageData messageData = (TextMessageData)(Message.GetMessageData(message));
            string senderName = messageData.Sender;
            IConversationController conversationController = _conversationControllers[senderName];
            conversationController.ReceiveTextMessage(messageData);
        }
    }
}

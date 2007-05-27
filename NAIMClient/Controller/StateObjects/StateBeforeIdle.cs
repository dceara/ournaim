using System;
using System.Collections.Generic;
using System.Text;
using Common.ProtocolEntities;
using Common.Protocol;

namespace Controller.StateObjects
{
    public class StateBeforeIdle:AState
    {
        public StateBeforeIdle()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.USER_LIST, typeof(StateIdle));
        }

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            UserListMessageData messageData = (UserListMessageData)Message.GetMessageData(message);
            return null;
        }

        protected override void InitializeMainViewEventHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeConversationControllersHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override AState MoveState()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeAccountViewHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}

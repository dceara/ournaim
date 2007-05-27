using System;
using System.Collections.Generic;
using System.Text;

namespace Controller.StateObjects
{
    public class StateIdle:AState
    {
        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeMainViewEventHandlers()
        {
            throw new Exception("The method or operation is not implemented.");
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

       
    }
}

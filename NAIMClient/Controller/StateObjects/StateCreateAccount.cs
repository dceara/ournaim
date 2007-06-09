using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common.ProtocolEntities;

namespace Controller.StateObjects
{
    public class StateCreateAccount:AState
    {
        private bool _signUpAlreadySent = false;

        public StateCreateAccount()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.ACK, typeof(StateInitial));
            _transitionsTable.Add(Common.ServiceTypes.NACK, typeof(StateCreateAccount));
        }

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            if (message.Header.ServiceType == Common.ServiceTypes.NACK)
            {
                _signUpAlreadySent = false;
                this.ToCloseConnection = true;
                return this;
            }
            if (_signUpAlreadySent && message.Header.ServiceType == Common.ServiceTypes.ACK)
            {
                AState nextState = GetNextState(message.Header.ServiceType);
                nextState.ToCloseConnection = true;
                return nextState;
            }
            return this;
        }

        protected override void InitializeMainViewEventHandlers()
        {
        }

        protected override void InitializeConversationControllersHandlers()
        {
        }

        protected override void InitializeAccountViewHandlers()
        {
            this._createAccountView.CreateAccountEvent += new Common.Interfaces.CreateAccountEventHandler(_createAccountView_CreateAccountEvent);
        }

        void _createAccountView_CreateAccountEvent(string userName, string password)
        {
            System.Windows.Forms.MessageBox.Show("Creare cont in state object: Username = " + userName + " ,Password = " + password);

            AMessageData signupMessageData = new SignUpMessageData(userName, password);

            Common.Protocol.Message signupMessage = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.SIGNUP), signupMessageData);

            _signUpAlreadySent = true;

            _outputMessagesList.Add(signupMessage);

        }

        public override AState MoveState()
        {
            throw new Exception("The method or operation is not implemented.");
        }

    }
}

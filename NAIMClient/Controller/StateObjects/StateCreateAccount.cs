using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common.ProtocolEntities;

namespace Controller.StateObjects
{
    public class StateCreateAccount:AState
    {
        #region Members

        private bool _signUpAlreadySent = false;

        #endregion

        #region Constructors

        public StateCreateAccount()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.ACK, typeof(StateInitial));
            _transitionsTable.Add(Common.ServiceTypes.NACK, typeof(StateInitial));
        }
        #endregion

        #region AState Methods

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            if (message.Header.ServiceType == Common.ServiceTypes.NACK)
            {
                System.Windows.Forms.MessageBox.Show("User Name already registered in the system!","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                AState nextState = GetNextState(message.Header.ServiceType);
                _signUpAlreadySent = false;
                this.ToCloseConnection = true;
                return nextState;
            }
            if (_signUpAlreadySent && message.Header.ServiceType == Common.ServiceTypes.ACK)
            {
                AState nextState = GetNextState(message.Header.ServiceType);
                ClearCurrentEventHandlers();
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

        protected override void ClearCurrentEventHandlers()
        {
            this._createAccountView.CreateAccountEvent -= _createAccountView_CreateAccountEvent;
        }
        #endregion
    }
}

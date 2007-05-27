using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;

namespace Controller.StateObjects
{
    public class StateInitial:AState
    {
        private bool _signInAlreadySent = false;

        public StateInitial()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.ACK, typeof(StateBeforeIdle));
            _transitionsTable.Add(Common.ServiceTypes.NACK, typeof(StateInitial));
        }

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            if (message.Header.ServiceType == Common.ServiceTypes.NACK)
            {
                _signInAlreadySent = false;
                return GetNextState(message.Header.ServiceType);
            }
            if (_signInAlreadySent && message.Header.ServiceType == Common.ServiceTypes.ACK)
            {
                return GetNextState(message.Header.ServiceType);
            }
            return this;
        }

        protected override void InitializeMainViewEventHandlers()
        {
            this._mainView.LoginEvent += new LoginEventHandler(mainView_LoginEvent);
        }

        

        protected override void InitializeConversationControllersHandlers()
        {
        }

        public override AState MoveState()
        {
            AState newState = new StateCreateAccount();
            newState.MainView = _mainView;
            newState.ConversationControllers = _conversationControllers;
            newState.CreateAccountView = _createAccountView;
            return newState;
        }

        void mainView_LoginEvent(string userName, string password)
        {
            System.Windows.Forms.MessageBox.Show("AUTENTIFICARE USER " + userName + " CU PAROLA " + password);
            _mainView.AfterSignIn();
        }

        protected override void InitializeAccountViewHandlers()
        {
        }
    }
}

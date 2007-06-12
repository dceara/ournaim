using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using Common.ProtocolEntities;
using Common;

namespace Controller.StateObjects
{
    public class StateInitial:AState
    {
        #region Members

        private bool _signInAlreadySent = false; 
        
        #endregion

        #region Constructors

        public StateInitial()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.ACK, typeof(StateBeforeIdle));
            _transitionsTable.Add(Common.ServiceTypes.NACK, typeof(StateInitial));
        }
        
        #endregion

        #region AState Methods

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            if (message.Header.ServiceType == Common.ServiceTypes.NACK)
            {
                _signInAlreadySent = false;
                ClearCurrentEventHandlers();
                return GetNextState(message.Header.ServiceType);
            }
            if (_signInAlreadySent && message.Header.ServiceType == Common.ServiceTypes.ACK)
            {
                _mainView.AfterSignIn();
                ClearCurrentEventHandlers();
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
            ClearCurrentEventHandlers();
            AState newState = new StateCreateAccount();
            newState.MainView = _mainView;
            newState.ConversationControllers = _conversationControllers;
            newState.CreateAccountView = _createAccountView;
            return newState;
        }

        protected override void InitializeAccountViewHandlers()
        {
        }

        protected override void ClearCurrentEventHandlers()
        {
            this._mainView.LoginEvent -= mainView_LoginEvent;
        }

        #endregion

        #region Main View Event Handlers

        void mainView_LoginEvent(string userName, string password)
        {
            AMessageData loginMessageData = new LoginMessageData(userName, password, DefaultStatuses.AVAILABLE );
            Message message = new Message(new MessageHeader(Common.ServiceTypes.LOGIN), loginMessageData);

            _outputMessagesList.Add(message);
            _signInAlreadySent = true;
        }
        #endregion
    }
}

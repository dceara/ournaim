using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using Common.ProtocolEntities;
using Common;
using System.Threading;
using Common.ErrorHandling;
using System.Windows.Forms;

namespace Controller.StateObjects
{
    public class StateInitial:AState
    {
        #region Members

        private bool _signInAlreadySent = false;
        private string _userName;

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
                ErrorHandler.HandleError("Incorect Username or Password!", "Authentication Error", (IWin32Window)_mainView);
                _signInAlreadySent = false;
                ClearCurrentEventHandlers();
                try
                {
                    this._peerConnectionManagerThread.Abort();
                }
                catch (ThreadAbortException ex)
                {
                }
                return GetNextState(message.Header.ServiceType);
            }
            if (_signInAlreadySent && message.Header.ServiceType == Common.ServiceTypes.ACK)
            {
                _mainView.AfterSignIn(_userName);
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
            Common.Protocol.Message message = new Common.Protocol.Message(new MessageHeader(Common.ServiceTypes.LOGIN), loginMessageData);

            _outputMessagesList.Add(message);
            _signInAlreadySent = true;
            _userName = userName;
        }
        #endregion
    }
}

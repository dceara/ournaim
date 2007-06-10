using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common;
using Common.Interfaces;

namespace Controller.StateObjects
{
    public abstract class AState
    {
        #region Properties and Members

        /// <summary>
        /// keeps the messages that don't corespond to the current state
        /// </summary>
        protected IList<Message> _ignoredMessages;

        public IList<Message> IgnoredMessages
        {
            get
            {
                return _ignoredMessages;
            }
        }

        protected IList<Message> _outputMessagesList;

        public IList<Message> OutputMessagesList
        {
            get
            {
                return this._outputMessagesList;
            }
        }

        public bool ToCloseConnection = false;

        /// <summary>
        /// keeps the relationship between the possible inputs and the next states
        /// </summary>
        protected IDictionary<ServiceTypes, Type> _transitionsTable;

        protected IMainView _mainView;

        public IMainView MainView
        {
            set
            {
                this._mainView = value;
                InitializeMainViewEventHandlers();
            }
        }

        protected IDictionary<string, IConversationController> _conversationControllers;

        public IDictionary<string, IConversationController> ConversationControllers
        {
            set
            {
                this._conversationControllers = value;
                InitializeConversationControllersHandlers();

            }
        }

        protected ICreateAccountView _createAccountView;

        public ICreateAccountView CreateAccountView
        {
            set
            {
                this._createAccountView = value;
                InitializeAccountViewHandlers();
            }
        }
        #endregion

        #region Constructors

        public AState()
        {
            _ignoredMessages = new List<Message>();
            _transitionsTable = new Dictionary<ServiceTypes, Type>();
            _outputMessagesList = new List<Message>();
        }

        #endregion

        #region Methods

        public AState AddMessage(Message message)
        {
            if (!CheckMessageType(message))
            {
                _ignoredMessages.Add(message);
                return this;
            }
            return AnalyzeMessage(message);
        }

        private bool CheckMessageType(Message message)
        {
            if (_transitionsTable.ContainsKey(message.Header.ServiceType))
                return true;
            return false;
        }

        protected AState GetNextState(ServiceTypes type)
        {
            Type nextType = _transitionsTable[type];
            AState state = (AState)nextType.Assembly.CreateInstance(nextType.FullName);
            state.MainView = this._mainView;
            state.ConversationControllers = this._conversationControllers;
            return state;
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// analyzes the received message
        /// </summary>
        /// <param name="message"></param>
        /// <returns>the next state</returns>
        public abstract AState AnalyzeMessage(Message message);

        protected abstract void InitializeMainViewEventHandlers();

        protected abstract void InitializeConversationControllersHandlers();

        protected abstract void InitializeAccountViewHandlers();

        public abstract AState MoveState();

        #endregion
    }
}

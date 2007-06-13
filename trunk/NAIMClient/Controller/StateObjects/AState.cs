using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common;
using Common.Interfaces;

namespace Controller.StateObjects
{
    public delegate IConversationController OpenConversationDelegate(string username);

    public abstract class AState
    {
        #region Events

        public event OpenConversationDelegate OpenConversationEvent;

        protected virtual IConversationController OnOpenConversationEvent(string username)
        {
            if(OpenConversationEvent!=null)
            {
                return OpenConversationEvent(username);
            }
            return null;
        }

        #endregion

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

        public bool Disconected = false;
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
        

        protected abstract void InitializeMainViewEventHandlers();

        protected abstract void InitializeConversationControllersHandlers();

        protected abstract void InitializeAccountViewHandlers();

        protected abstract void ClearCurrentEventHandlers();

        public abstract AState MoveState();

        public abstract AState AnalyzeMessage(Message message);

        #endregion

        #region Static Methods

        public static bool CheckIfContactExists(string username, IDictionary<string,IList<UserListEntry>> contactsByGroups)
        {
            foreach (KeyValuePair<string, IList<UserListEntry>> pair in contactsByGroups)
            {
                foreach (UserListEntry entry in pair.Value)
                {
                    if (entry.UserName == username)
                        return true;
                }
            }
            return false;
        }

        public static bool CheckIfGroupExists(string groupName, IDictionary<string, IList<UserListEntry>> contactsByGroups)
        {
            return contactsByGroups.ContainsKey(groupName);
        }

        #endregion
    }
}

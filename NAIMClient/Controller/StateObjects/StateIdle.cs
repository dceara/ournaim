using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common;
using Common.ProtocolEntities;
using Common.Interfaces;
using System.Windows.Forms;
using Common.FileTransfer;

namespace Controller.StateObjects
{
    public class StateIdle:AState
    {
        #region Properties

        private IDictionary<string, IList<UserListEntry>> _contactsByGroups;

        public IDictionary<string, IList<UserListEntry>> ContactsByGroups
        {
            get { return _contactsByGroups; }
            set { _contactsByGroups = value; }
        }

        private IDictionary<string, UserListEntry> _onlineContacts;

        public IDictionary<string, UserListEntry> OnlineContacts
        {
            get { return _onlineContacts; }
            set { _onlineContacts = value; }
        }

        private IFileTransferView _fileTransferView;

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        private string _ip;

        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private ushort _port;

        public ushort Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private IDictionary<string,ConnectionDataMessageData> _madeConnectionRequests;

        public IDictionary<string, ConnectionDataMessageData> MadeConnectionRequests
        {
            get
            {
                return this._madeConnectionRequests;
            }
        }

        private IDictionary<string, ConnectionDataMessageData> _pendingConnectionRequests;

        public IDictionary<string, ConnectionDataMessageData> PendingConnectionRequests
        {
            get
            {
                return this._madeConnectionRequests;
            }
        }

        private PeerConnectionManager _peerConnectionManager;

        private IDictionary<string, IDictionary<int, string>> _doawnloadedFileLists;

        #endregion

        #region Constructors

        public StateIdle()
            : base()
        {
            _transitionsTable.Add(Common.ServiceTypes.PING, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.TEXT, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.USER_CONNECTED, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.USER_DISCONNECTED, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.CONNECTION_DATA, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.CONNECTION_REQ, typeof(StateIdle));
            _transitionsTable.Add(Common.ServiceTypes.DISCONNECT, typeof(StateInitial));
            _madeConnectionRequests = new Dictionary<string, ConnectionDataMessageData>();
            _pendingConnectionRequests = new Dictionary<string, ConnectionDataMessageData>();
        }
        
        #endregion

        #region AState Methods

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            AMessageData messageData = Common.Protocol.Message.GetMessageData(message);
            switch (message.Header.ServiceType)
            {
                case Common.ServiceTypes.PING:
                    HandlePingMessage();
                    break;
                case Common.ServiceTypes.TEXT:
                    RedirectTextMessageToConversationController((TextMessageData)messageData);
                    break;
                case Common.ServiceTypes.USER_CONNECTED:
                    HandleUserConnectedMessage((UserConnectedMessageData)messageData);
                    break;
                case Common.ServiceTypes.STATUS:
                    HandleStatusMessage((StatusMessageData)messageData);
                    break;
                case Common.ServiceTypes.USER_DISCONNECTED:
                    HandleUserDisconnectedMessage((UserDisconnectedMessageData)messageData);
                    break;
                case Common.ServiceTypes.CONNECTION_DATA:
                    RedirectMessageToConversationController(message, ((ConnectionDataMessageData)messageData).Sender);
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
                    SendConnectionDataResponse((ConnectionDataRequestedMessageData)messageData);
                    RedirectMessageToConversationController(message, ((ConnectionDataRequestedMessageData)messageData).SenderUserName);
                    break;
                case Common.ServiceTypes.DISCONNECT:
                    AState newState = new StateInitial();
                    newState.MainView = _mainView;
                    newState.ToCloseConnection = true;
                    newState.Disconected = true;
                    MessageBox.Show("You're not worthy! You have been signed out because you were logged in on another computer",
                        "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return newState;
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
        }

        public override AState MoveState()
        {
            ClearCurrentEventHandlers();
            AState newState = new StateInitial();
            newState.MainView = _mainView;
            newState.ConversationControllers = _conversationControllers;
            ToCloseConnection = true;
            AMessageData messageData = new LogoutMessageData(this._userName);
            Common.Protocol.Message signoutMessage = new Common.Protocol.Message(new MessageHeader(ServiceTypes.LOGOUT), messageData);
            newState.OutputMessagesList.Add(signoutMessage);
            return newState;
        }

        protected override void ClearCurrentEventHandlers()
        {
        }

        #endregion

        #region Methods

        private void HandleUserDisconnectedMessage(UserDisconnectedMessageData userDisconnectedData)
        {
            _mainView.ClientOffline(userDisconnectedData.UserName);
            if (_fileTransferView != null)
            {
                _fileTransferView.ContactOffline(userDisconnectedData.UserName);
            }
            _onlineContacts.Remove(userDisconnectedData.UserName);
        }

        private void HandlePingMessage()
        {
            Common.Protocol.Message response = new Common.Protocol.Message(new MessageHeader(ServiceTypes.PING), new PingMessageData());
            _outputMessagesList.Add(response);
        }

        private void HandleUserConnectedMessage(UserConnectedMessageData messageData)
        {
            UserConnectedMessageData userConnectedData = (UserConnectedMessageData)messageData;
            if (!_onlineContacts.ContainsKey(userConnectedData.UserName))
            {
                string groupName = GetGroupName(userConnectedData.UserName);
                _mainView.ClientOnline(userConnectedData.UserName, userConnectedData.Status);
                if (_fileTransferView != null)
                {
                    _fileTransferView.ContactOnline(userConnectedData.UserName);
                }
                _onlineContacts.Add(userConnectedData.UserName, new UserListEntry(userConnectedData.UserName, userConnectedData.Status));
            }
            else
            {
                UserListEntry contact = _onlineContacts[userConnectedData.UserName];
                _mainView.ChangeClientStatus(userConnectedData.UserName, userConnectedData.Status);
                contact.Status = userConnectedData.Status;
            }
        }

        private void HandleStatusMessage(StatusMessageData messageData)
        {
            StatusMessageData statusData = (StatusMessageData)messageData;
            UserListEntry contact = _onlineContacts[statusData.UserName];
            if (contact != null)
            {
                _mainView.ChangeClientStatus(statusData.UserName, statusData.Status);
                contact.Status = statusData.Status;
            }
            else
            {
                // TODO: Throw an exception ?
                // NOTTODO: No exception.... This must be a server bug... :p
            }
        }

        private void SendConnectionDataResponse(ConnectionDataRequestedMessageData receivedMessageData)
        {
            AMessageData messageData = new ConnectionDataMessageData(this._userName, receivedMessageData.SenderUserName, this._ip, this._port);
            Common.Protocol.Message response = new Common.Protocol.Message(new MessageHeader(ServiceTypes.CONNECTION_DATA), messageData);
            _outputMessagesList.Add(response);
        }

        private string GetGroupName(string username)
        {
            foreach (KeyValuePair<string, IList<UserListEntry>> entry in _contactsByGroups)
            {
                IList<UserListEntry> list = entry.Value;
                bool found = false;
                foreach (UserListEntry user in list)
                {
                    if (user.UserName == username)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    return entry.Key;
            }
            throw new Exception("User isn't in my contacts list!");
        }

        private void RedirectTextMessageToConversationController(TextMessageData message)
        {
            string senderName = message.Sender;
            if (!_conversationControllers.ContainsKey(senderName))
            {
                OnOpenConversationEvent(senderName);
            }
            IConversationController conversationController = _conversationControllers[senderName];
            if (conversationController != null)
            {
                conversationController.ReceiveTextMessage(message);
            }
        }

        private void RedirectMessageToConversationController(Common.Protocol.Message message, string sender)
        {
            //TODO:
            //ConnectionDataMessageData messageData = (ConnectionDataMessageData)Common.Protocol.Message.GetMessageData(message);
            //if (_pendingConnectionRequests.ContainsKey(messageData.Sender))
            //{
            //    _pendingConnectionRequests.Remove(messageData.Sender);
            //}
            //if (_madeConnectionRequests.ContainsKey(messageData.Sender))
            //{
            //    _madeConnectionRequests.Remove(messageData.Sender);
            //}
            //_madeConnectionRequests.Add(messageData.Sender, messageData);
            //IDictionary<int,string> fileList = _peerConnectionManager.getFileListFromPeerDelegate(messageData.Sender, messageData.IpAddress, messageData.Port);


        }



        public void InitialiseFileTransferManager(IFileTransferView newFileTransferView, PeerConnectionManager peerConnectionManager, IDictionary<string,IDictionary<int,string>> downloadedFileLists)
        {
            this._fileTransferView = newFileTransferView;
            this._peerConnectionManager = peerConnectionManager;
            this._doawnloadedFileLists = downloadedFileLists;
        }

        #endregion

        #region FileTransferView Event Handlers

        #endregion

    }
}

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

        private IList<string> _groupNames;

        private IDictionary<string, IList<UserListEntry>> _contactsByGroups;

        private IDictionary<string,UserListEntry> _contacts;

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            UserListMessageData messageData = (UserListMessageData)Message.GetMessageData(message);
            IList<string> groupNames = new List<string>();
            IDictionary<string,IList<UserListEntry>> contactsByGroups = new Dictionary<string,IList<UserListEntry>>();

            _contacts = new Dictionary<string,UserListEntry>();

            foreach (GroupEntry groupEntry in messageData.GroupsList)
            {
                groupNames.Add(groupEntry.Name);
                IList<UserListEntry> contacts = new List<UserListEntry>();
                foreach (UserListEntry entry in groupEntry.Users)
                {
                    contacts.Add(entry);
                    if(entry.Availability)
                        _contacts.Add(entry.UserName,entry);
                }
                contactsByGroups.Add(groupEntry.Name, contacts);
            }
            _mainView.SetGroupSource(groupNames, contactsByGroups);
            
            
            this._groupNames = groupNames;
            this._contactsByGroups = contactsByGroups;
            AState nextState = GetNextState(message.Header.ServiceType);
            if (nextState is StateIdle)
            {
                ((StateIdle)nextState).ContactsByGroups = contactsByGroups;
                ((StateIdle)nextState).OnlineContacts = _contacts;
            }
            return nextState;
        }

        protected override void InitializeMainViewEventHandlers()
        {
        }

        protected override void InitializeConversationControllersHandlers()
        {
        }

        public override AState MoveState()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void InitializeAccountViewHandlers()
        {
        }
    }
}

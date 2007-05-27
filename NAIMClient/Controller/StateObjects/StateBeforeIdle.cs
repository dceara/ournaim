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

        public override AState AnalyzeMessage(Common.Protocol.Message message)
        {
            UserListMessageData messageData = (UserListMessageData)Message.GetMessageData(message);
            IList<string> groupNames = new List<string>();
            IDictionary<string,IList<UserListEntry>> contactsByGroups = new Dictionary<string,IList<UserListEntry>>();
            foreach (GroupEntry groupEntry in messageData.GroupsList)
            {
                groupNames.Add(groupEntry.Name);
                IList<UserListEntry> contacts = new List<UserListEntry>();
                foreach (UserListEntry entry in groupEntry.Users)
                {
                    contacts.Add(entry);
                }
                contactsByGroups.Add(groupEntry.Name, contacts);
            }
            //groupNames.Add("grup1");
            //groupNames.Add("grup2");
            //IList<UserListEntry> list1 = new List<UserListEntry>();
            //list1.Add(new UserListEntry("ion", "a"));
            //list1.Add(new UserListEntry("dod", "b"));
            //IList<UserListEntry> list2 = new List<UserListEntry>();
            //list2.Add(new UserListEntry("andi", "c"));
            //list2.Add(new UserListEntry("alex", "d"));

            //contactsByGroups.Add("grup1", list1);
            //contactsByGroups.Add("grup2", list2);

            _mainView.SetGroupSource(groupNames, contactsByGroups);
            return GetNextState(message.Header.ServiceType);
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

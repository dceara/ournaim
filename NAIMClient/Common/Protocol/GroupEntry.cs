using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public class GroupEntry
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private IList<UserListEntry> _users;

        public IList<UserListEntry> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public GroupEntry(string name)
        {
            _name = name;
            _users = new List<UserListEntry>();
        }
	
    }
}

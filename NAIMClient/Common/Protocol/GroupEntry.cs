using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    #region GroupEntry Class

    /// <summary>
    /// This is used to hold information about a group of contacts.
    /// </summary>
    public class GroupEntry
    {
        #region Properties

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

        #endregion

        #region Constructors

        public GroupEntry(string name)
        {
            _name = name;
            _users = new List<UserListEntry>();
        }
        #endregion
    }

    #endregion
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    #region UserListEntry Class
    /// <summary>
    /// Holds information about a contact.
    /// </summary>
    public class UserListEntry
    {
        #region Properties

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private bool _availability;

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region Constructors

        public UserListEntry()
        {
            _userName = string.Empty;
            _status = string.Empty;
        }
        public UserListEntry(string userName)
        {
            _userName = userName;
            _availability = false;
            _status = string.Empty;
        }
        public UserListEntry(string userName, string status)
        {
            _userName = userName;
            _availability = true;
            _status = status;
        }
        #endregion
    }

    #endregion
}

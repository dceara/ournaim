using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    class UserListMessageData:AMessageData
    {

        private int _userCount;

        public int UserCount
        {
            get { return _userCount; }
            set { _userCount = value; }
        }

        private UserListEntry[] _usersList;

        public UserListEntry[] UsersList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }
	

        public UserListMessageData(byte[] data):
            base(data)
        {
        }

        protected override void Deserialize()
        {
            _userCount = _data[0];
            int index = 1;
            _usersList = new UserListEntry[_userCount];
            for (int i = 0; i < _userCount; i++)
            {
                UserListEntry entry = new UserListEntry();
                index = GetNextUserListEntry(index, ref entry);
                _usersList[i] = entry;
            }
        }

        public override byte[] Serialize()
        {
            throw new Exception("This method should be implemented by the server.");
        }

        private int GetNextUserListEntry(int index, ref UserListEntry entry)
        {
            int unameLen = _data[index];
            entry.UserName = AMessageData.ToString(_data, index + 1, unameLen);
            bool availability = false;
            index += unameLen + 1;
            if (_data[index] == 1)
                availability = true;
            entry.Availability = availability;
            if (availability)
            {
                index++;
                int statusLen = _data[index];
                index++;
                entry.Status = AMessageData.ToString(_data, index, statusLen);
            }
            return index + 1;
        }
    }
}

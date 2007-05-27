using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class UserListMessageData:AMessageData
    {

        private byte _groupCount;

        public byte GroupCount
        {
            get { return _groupCount; }
            set { _groupCount = value; }
        }

        private GroupEntry[] _groupsList;

        public GroupEntry[] GroupsList
        {
            get { return _groupsList; }
            set { _groupsList = value; }
        }
	

        public UserListMessageData(byte[] data):
            base(data)
        {
        }

        protected override void Deserialize()
        {
            _groupCount = _data[0];
            int index = 1;
            _groupsList = new GroupEntry[_groupCount];
            for (int i = 0; i < _groupCount; i++)
            {
                string name = AMessageData.ToString(_data, index + 1, _data[index]);
                index += _data[index] + 1;
                GroupEntry entry = new GroupEntry(name);
                int userCnt = _data[index++];
                UserListEntry userEntry = new UserListEntry();
                index = GetNextUserListEntry(index, ref userEntry);
                entry.Users.Add(userEntry);
                _groupsList[i] = entry;
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

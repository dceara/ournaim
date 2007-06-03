using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class AddContactMessageData: AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _newContact;

        public string NewContact
        {
            get { return _newContact; }
            set { _newContact = value; }
        }
	
        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
	

        public AddContactMessageData(byte[] data)
            :base(data)
        {
        }

        public AddContactMessageData(string userName, string group,string newContact)
        {
            _userName = userName;
            _group = group;
            _newContact = newContact;
        }

        protected override void Deserialize()
        {
            throw new Exception("This method should be implemented by the server.");
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] group = AMessageData.ToByteArray(_group);
            byte[] newContact = AMessageData.ToByteArray(_newContact);
            byte unameLen = (byte)uname.Length;
            byte groupLen = (byte)group.Length;
            byte newContactLen = (byte)newContact.Length;
            byte[] toReturn = new byte[unameLen + groupLen + newContactLen + 3];
            toReturn[0] = unameLen;
            Array.Copy(uname, 0, toReturn, 1, unameLen);
            toReturn[unameLen + 1] = newContactLen;
            Array.Copy(newContact, 0, toReturn, unameLen + 2, newContactLen);
            toReturn[unameLen + newContactLen + 2] = groupLen;
            Array.Copy(group, 0, toReturn, unameLen + newContactLen + 3, groupLen);
            return toReturn;
        }
    }
}

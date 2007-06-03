using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
   
    public class RemoveContactMessageData : AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _oldContact;

        public string OldContact
        {
            get { return _oldContact; }
            set { _oldContact = value; }
        }


        public RemoveContactMessageData(byte[] data)
            :base (data)
        {
        }

        public RemoveContactMessageData(string userName, string oldCOntact)
        {
            _userName = userName;
            _oldContact = oldCOntact;
        }

        protected override void Deserialize()
        {
            throw new Exception("This method should be implemented by the server.");
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] oldContact = AMessageData.ToByteArray(_oldContact);
            byte unameLen = (byte)uname.Length;
            byte oldContactLen = (byte)oldContact.Length;
            byte[] toReturn = new byte[unameLen + oldContactLen + 2];
            toReturn[0] = unameLen;
            Array.Copy(uname, 0, toReturn, 1, unameLen);
            toReturn[unameLen + 1] = oldContactLen;
            Array.Copy(oldContact, 0, toReturn, unameLen + 2, oldContactLen);
            return toReturn;
        }
    }
}

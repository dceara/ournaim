using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class LoginMessageData : AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
	

        public LoginMessageData(byte[] data)
            :base(data)
        {
        }

        public LoginMessageData(string userName, string password,string status)
        {
            _userName = userName;
            _password = password;
            _status = status;
        }

        protected override void Deserialize()
        {
            throw new Exception("This method should be implemented by the server");
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] pass = AMessageData.ToByteArray(_password);
            byte[] status = AMessageData.ToByteArray(_status);
            byte unameLen = (byte)uname.Length;
            byte passLen = (byte)pass.Length;
            byte statusLen = (byte)status.Length;
            byte[] toReturn = new byte[unameLen + passLen + +statusLen + 3];
            toReturn[0] = unameLen;
            Array.Copy(uname, 0, toReturn, 1, unameLen);
            toReturn[unameLen+1] = passLen;
            Array.Copy(pass, 0, toReturn, unameLen + 2, passLen);
            toReturn[unameLen + passLen + 2] = statusLen;
            Array.Copy(status, 0, toReturn, unameLen + passLen + 3, statusLen);

            return toReturn;
        }
    }
}

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


        public LoginMessageData(byte[] data)
            :base(data)
        {
        }

        public LoginMessageData(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        protected override void Deserialize()
        {
            throw new Exception("This method should be implemented by the server");
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] pass = AMessageData.ToByteArray(_password);
            byte unameLen = (byte)uname.Length;
            byte passLen = (byte)pass.Length;
            byte[] toReturn = new byte[unameLen + passLen + 2];
            toReturn[0] = unameLen;
            Array.Copy(uname, 0, toReturn, 1, unameLen);
            toReturn[unameLen+1] = passLen;
            Array.Copy(pass, 0, toReturn, unameLen + 2, passLen);
            return toReturn;
        }
    }
}

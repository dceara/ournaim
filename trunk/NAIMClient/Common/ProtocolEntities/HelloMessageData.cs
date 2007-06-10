using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    /// <summary>
    /// [Deprecated]
    /// </summary>
    [Obsolete]
    class HelloMessageData : AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
	
        public HelloMessageData(byte[] data)
            :base(data)
        {
        }

        public HelloMessageData(string userName)
        {
            _userName = userName;
        }

        protected override void Deserialize()
        {
            int unameLen = _data[0];
            _userName = AMessageData.ToString(_data, 1, unameLen);
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] toReturn = new byte[uname.Length + 1];
            toReturn[0] = (byte)uname.Length;
            Array.Copy(uname, 0, toReturn, 1, uname.Length);
            return toReturn;
        }
    }
}

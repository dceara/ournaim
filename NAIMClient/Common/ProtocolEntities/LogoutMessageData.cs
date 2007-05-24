using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class LogoutMessageData : AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
	

        public LogoutMessageData(byte[] data)
            :base(data)
        {
        }

        public LogoutMessageData(string userName)
        {
            this._userName = userName;
        }

        protected override void Deserialize()
        {
            throw new Exception("The method should not be called from the client!");
        }

        public override byte[] Serialize()
        {
            return AMessageData.ToByteArray(_userName);
        }
    }
}

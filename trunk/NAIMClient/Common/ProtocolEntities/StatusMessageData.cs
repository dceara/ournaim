using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class StatusMessageData : AMessageData
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
	
        public StatusMessageData(byte[] data)
            :base(data)
        {
        }

        public StatusMessageData(string userName, string status)
        {
            this._userName = userName;
            this._status = status;
        }

        protected override void Deserialize()
        {
            int unameLen = _data[0];
            _userName = AMessageData.ToString(_data, 1, unameLen);
            int statusLen = _data[_userName.Length + 1];
            _status = AMessageData.ToString(_data, unameLen + 2, +statusLen);
        }

        public override byte[] Serialize()
        {
            throw new Exception("This method should be implemented by the server!");
        }
    }
}

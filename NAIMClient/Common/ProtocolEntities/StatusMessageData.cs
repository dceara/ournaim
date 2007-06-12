using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class StatusMessageData : AMessageData
    {
        #region Properties

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

        #endregion

        #region Constructors

        public StatusMessageData(byte[] data)
            :base(data)
        {
        }

        public StatusMessageData(string userName, string status)
        {
            this._userName = userName;
            this._status = status;
        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            int unameLen = _data[0];
            _userName = AMessageData.ToString(_data, 1, unameLen);
            int statusLen = _data[_userName.Length + 1];
            _status = AMessageData.ToString(_data, unameLen + 2, +statusLen);
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] status = AMessageData.ToByteArray(_status);
            byte[] toReturn = new byte[uname.Length + status.Length + 2];
            toReturn[0] = (byte)uname.Length;
            Array.Copy(uname, 0, toReturn, 1, uname.Length);
            toReturn[uname.Length + 1] = (byte)status.Length;
            Array.Copy(status, 0, toReturn, uname.Length + 2, status.Length);
            return toReturn;
        }

        #endregion
    }
}

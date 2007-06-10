using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class UserDisconnectedMessageData : AMessageData
    {
        #region Properties

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        #endregion

        #region Constructors

        public UserDisconnectedMessageData(byte[] data)
            :base (data)
        {
        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            int unameLen = _data[0];
            _userName = AMessageData.ToString(_data, 1, unameLen);
        }

        public override byte[] Serialize()
        {
            throw new Exception("This method should be implemented by the server!");
        }
        #endregion
    }
}

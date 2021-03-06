using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class LogoutMessageData : AMessageData
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

        public LogoutMessageData(byte[] data)
            :base(data)
        {
        }

        public LogoutMessageData(string userName)
        {
            this._userName = userName;
        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            throw new Exception("The method should not be called from the client!");
        }

        public override byte[] Serialize()
        {
            byte[] toReturn = new byte[_userName.Length + 1];
            toReturn[0] = (byte)_userName.Length;
            byte[] uname = AMessageData.ToByteArray(_userName);
            Array.Copy(uname,0,toReturn,1,uname.Length);
            return toReturn;
        }
        #endregion
    }
}

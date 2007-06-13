using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class RemoveGroupMessageData:AMessageData
    {
        #region Properties

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _oldGroup;

        public string OldGroup
        {
            get { return _oldGroup; }
            set { _oldGroup = value; }
        }

        #endregion

        #region Constructors

        public RemoveGroupMessageData(byte[] data)
            :base (data)
        {
        }

        public RemoveGroupMessageData(string userName, string oldGroup)
        {
            _userName = userName;
            _oldGroup = oldGroup;
        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            throw new Exception("This method should be implemented by the server.");
        }

        public override byte[] Serialize()
        {
            byte[] uname = AMessageData.ToByteArray(_userName);
            byte[] oldGroup = AMessageData.ToByteArray(_oldGroup);
            byte unameLen = (byte)uname.Length;
            byte oldGrouptLen = (byte)oldGroup.Length;
            byte[] toReturn = new byte[unameLen + oldGrouptLen + 2];
            toReturn[0] = unameLen;
            Array.Copy(uname, 0, toReturn, 1, unameLen);
            toReturn[unameLen + 1] = oldGrouptLen;
            Array.Copy(oldGroup, 0, toReturn, unameLen + 2, oldGrouptLen);
            return toReturn;
        }

        #endregion
    }
}

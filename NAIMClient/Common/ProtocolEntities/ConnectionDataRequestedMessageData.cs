using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class ConnectionDataRequestedMessageData : AMessageData
    {
        private string _senderUserName;

        public string SenderUserName
        {
            get { return _senderUserName; }
            set { _senderUserName = value; }
        }

        private string _requestedUser;

        public string RequestedUser
        {
            get { return _requestedUser; }
            set { _requestedUser = value; }
        }
	

        public ConnectionDataRequestedMessageData(byte[] data)
            : base(data)
        {
        }

        public ConnectionDataRequestedMessageData(string senderUsername, string requestedUser)
        {
            _senderUserName = senderUsername;
            _requestedUser = requestedUser;
        }

        protected override void Deserialize()
        {
            int senderUnameLen = _data[0];
            int reqUserLen = _data[senderUnameLen+1];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < senderUnameLen; i++)
            {
                sb.Append((char)_data[i + 1]);
            }
            int index = senderUnameLen + 2;
            _senderUserName = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0; i < reqUserLen; i++)
            {
                sb.Append((char)_data[index+i]);
            }
            _requestedUser = sb.ToString();            
        }

        public override byte[] Serialize()
        {
            byte[] senderUname = AMessageData.ToByteArray(_senderUserName);
            byte[] requestedUser = AMessageData.ToByteArray(_requestedUser);
            byte senderUnameLen = (byte)senderUname.Length;
            byte requestedUserLen = (byte)requestedUser.Length;
            byte[] toReturn = new byte[senderUnameLen + requestedUserLen + 2];
            toReturn[0] = senderUnameLen;
            Array.Copy(senderUname, 0, toReturn, 1, senderUnameLen);
            toReturn[senderUnameLen + 1] = requestedUserLen;
            Array.Copy(requestedUser, 0, toReturn, senderUnameLen + 2, requestedUserLen);
            return toReturn;
        }
    }
}

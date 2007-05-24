using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using System.Net;

namespace Common.ProtocolEntities
{
    public class FileTransferGetMessageData : AMessageData
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public FileTransferGetMessageData(byte[] data)
            :base(data)
        {
        }

        public FileTransferGetMessageData(int id)
        {
            _id = id;
        }

        protected override void Deserialize()
        {
            _id = IPAddress.NetworkToHostOrder( AMessageData.ToInt(_data) );
        }

        public override byte[] Serialize()
        {
            byte[] toReturn = new byte[4];
            Array.Copy(AMessageData.ToByteArray(IPAddress.HostToNetworkOrder(_id)), toReturn, 4);
            return toReturn;
        }
    }
}

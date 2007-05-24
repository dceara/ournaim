using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class PingMessageData : AMessageData
    {
        public PingMessageData(byte[] data)
            :base(data)
        {
        }

        protected override void Deserialize()
        {
        }

        public override byte[] Serialize()
        {
            throw new Exception("The method or operation is implemented by the server.");
        }
    }
}

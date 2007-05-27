using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class AckMessageData:AMessageData
    {
        public AckMessageData(byte[] data)
            :base (data)
        {
            
        }

        public AckMessageData()
        {
        }

        protected override void Deserialize()
        {
        }

        public override byte[] Serialize()
        {
            return new byte[0];
        }
    }
}

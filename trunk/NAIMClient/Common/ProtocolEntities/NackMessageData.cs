using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
#warning DE DISCUTAT CODURILE DE EROARE
    public class NackMessageData : AMessageData
    {
        public NackMessageData(byte[] data)
            :base(data)
        {
        }

        public NackMessageData()
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

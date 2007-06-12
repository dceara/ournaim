using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class PingMessageData : AMessageData
    {
        #region Constructors

        public PingMessageData(byte[] data)
            : base(data)
        {
        }

        public PingMessageData() 
        {

        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
        }

        public override byte[] Serialize()
        {
            return new byte[0];
        }

        #endregion
    }
}

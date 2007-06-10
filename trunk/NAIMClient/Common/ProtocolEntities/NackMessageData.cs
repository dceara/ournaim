using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class NackMessageData : AMessageData
    {
        #region Constructors

        public NackMessageData(byte[] data)
            :base(data)
        {
        }

        public NackMessageData()
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

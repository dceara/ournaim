using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class AckMessageData:AMessageData
    {
        #region Constructors

        public AckMessageData(byte[] data)
            :base (data)
        {

        }
        #endregion

        public AckMessageData()
        {
        }

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

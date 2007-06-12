using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class DisconnectMessageData:AMessageData
    {
        #region Constructors

        public DisconnectMessageData(byte[] data)
            : base(data)
        {
        }

        public DisconnectMessageData() 
        {

        }

        #endregion


        #region AMessageData Methods

        protected override void Deserialize()
        {
        }

        public override byte[] Serialize()
        {
            throw new Exception("The method or operation is not implemented.");
        } 
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class FileListGetMessageData:AMessageData
    {
        public FileListGetMessageData(byte[] data)
            :base(data)
        {
        }
        protected override void Deserialize()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override byte[] Serialize()
        {
            return new byte[0];
        }
    }
}

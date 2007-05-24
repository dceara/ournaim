using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class FileTransferSendMessageData : AMessageData
    {
        private const int MAXLENGTH = 256;

        private int _fileId;

        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }

        private int _fileLength;

        public int FileLength
        {
            get { return _fileLength; }
            set { _fileLength = value; }
        }

        private byte[] _content;

        public byte[] Content
        {
            get { return _content; }
            set { _content = value; }
        }
	

        public FileTransferSendMessageData(byte[] data)
            :base(data)
        {
        }

        public FileTransferSendMessageData(int fileId, int fileLength, byte[] content)
        {
            _fileId = fileId;
            _fileLength = fileLength;
            _content = new byte[content.Length];
            Array.Copy(content, _content, content.Length);
        }

        protected override void Deserialize()
        {
            _fileId = AMessageData.ToInt(_data);
            _fileLength = AMessageData.ToInt(_data, 4);
            _content = new byte[_data.Length - 8];
            Array.Copy(_data, 8, _content, 0, _data.Length - 8);
        }

        public override byte[] Serialize()
        {
            byte[] toReturn = new byte[_content.Length + 8];
            byte[] fileId = AMessageData.ToByteArray(_fileId);
            byte[] fileLength = AMessageData.ToByteArray(_fileLength);
            Array.Copy(fileId, toReturn, 4);
            Array.Copy(fileLength, 0, toReturn, 4, 4);
            Array.Copy(_content, 0, toReturn, 8, _content.Length);
            return toReturn;
        }
    }
}

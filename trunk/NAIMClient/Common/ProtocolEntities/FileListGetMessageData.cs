using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class FileListGetMessageData:AMessageData
    {
        #region Properties

        int _idsCount;

        public int IdsCount
        {
            get
            {
                return _idsCount;
            }
        }

        private IDictionary<int, string> _filelist;

        public IDictionary<int, string> FileList
        {
            get
            {
                return _filelist;
            }
        }

        #endregion

        #region Constructors

        public FileListGetMessageData(byte[] data)
            :base(data)
        {
        }

        public FileListGetMessageData(IDictionary<int, string> filelist)
        {
            _idsCount = filelist.Count;
            _filelist = filelist;
        }

        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            _idsCount = AMessageData.ToInt(_data);
            _filelist = new Dictionary<int, string>();
            int index = 1;
            for (int i = 0; i < _idsCount; i++)
            {
                int key = AMessageData.ToInt(_data, index);
                index += 4;
                int nameLen = _data[index++];
                string value = AMessageData.ToString(_data, index, nameLen);
                index += nameLen;
                KeyValuePair<int, string> newPair = new KeyValuePair<int, string>(key,value);
                _filelist.Add(newPair);
            }
        }

        public override byte[] Serialize()
        {
            byte[] idCnt = AMessageData.ToByteArray(_idsCount);
            byte[] toReturn = new byte[idCnt.Length];
            Array.Copy(idCnt, toReturn, idCnt.Length);
            foreach (KeyValuePair<int, string> pair in _filelist)
            {
                byte[] itemId = AMessageData.ToByteArray(pair.Key);
                byte[] itemName = AMessageData.ToByteArray(pair.Value);
                int oldLen = toReturn.Length;
                Array.Resize<byte>(ref toReturn, toReturn.Length + itemId.Length + itemName.Length + 1);
                Array.Copy(itemId, 0, toReturn, oldLen, itemId.Length);
                toReturn[oldLen + itemId.Length] = (byte)itemName.Length;
                Array.Copy(itemName, 0, toReturn, oldLen + itemId.Length + 1, itemName.Length);
            }
            return new byte[0];
        }
        #endregion
    }
}

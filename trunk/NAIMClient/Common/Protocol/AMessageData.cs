using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public abstract class AMessageData
    {
        public const int MAX_MESSAGE_SIZE = 512;

        protected byte[] _data;

        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        protected abstract void Deserialize();

        public abstract byte[] Serialize();

        public AMessageData(byte[] data)
        {
            _data = new byte[data.Length];
            Array.Copy(data, _data, data.Length);
            Deserialize();
        }

        public AMessageData()
        {
            _data = new byte[0];
        }

        public static byte[] ToByteArray(string str)
        {
            char[] charArray = str.ToCharArray();
            byte[] toReturn = new byte[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                toReturn[i] = (byte)charArray[i];
            }
            return toReturn;
        }
        
        public static byte[] ToByteArray(ushort value)
        {
            byte[] toReturn = new byte[sizeof(ushort)];
            toReturn[0] = (byte)(value >> 8);
            toReturn[1] = (byte)(value % (byte.MaxValue + 1));
            return toReturn;
        }

        public static byte[] ToByteArray(int value)
        {
            byte[] toReturn = new byte[sizeof(Int32)];
            toReturn[0] = (byte)(value >> 24);
            toReturn[1] = (byte)(value >> 16);
            toReturn[2] = (byte)(value >> 8);
            toReturn[3] = (byte)(value % (byte.MaxValue + 1));
            return toReturn;
        }

        public static ushort ToShort(byte first, byte second)
        {
            ushort toReturn = (ushort)((ushort)(first<<8) + (ushort)second);
            return toReturn;
        }

        public static string ToString(byte[] data, int startIndex, int length)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i<length;i++)
            {
                sb.Append((char)data[i + startIndex]);
            }
            return sb.ToString();
        }

        public static int ToInt(byte[] data)
        {
            return ToInt(data, 0);
        }

        public static int ToInt(byte[] data,int startIndex)
        {
            return (int)((int)(data[startIndex] << 24) + (int)(data[startIndex + 1] << 16) + (int)(data[startIndex + 2] << 8) + (int)(data[startIndex + 3]));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    #region AMessageData Abstract Class

    public abstract class AMessageData
    {
        #region Constants

        /// <summary>
        /// this is the maximum data size for file transfer packets
        /// </summary>
        public const int MAX_MESSAGE_SIZE = 504;

        #endregion

        #region Properties

        protected byte[] _data;

        /// <summary>
        /// sets/gets the data field of the message
        /// </summary>
        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Is called from the base constructor and deserializes the data field according to the service type
        /// </summary>
        protected abstract void Deserialize();

        /// <summary>
        /// Creates the byte array for the current packet. It is implemented by the inheriting classes
        /// </summary>
        /// <returns></returns>
        public abstract byte[] Serialize();

        #endregion

        #region Constructors

        /// <summary>
        /// Initialises the message data object and deserializes the data field
        /// </summary>
        /// <param name="data"></param>
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

        #endregion

        #region Static Methods Used for serializing and deserializing the Data field

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

        #endregion
    }

    #endregion
}

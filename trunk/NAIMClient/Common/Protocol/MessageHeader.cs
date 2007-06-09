using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public class MessageHeader
    {

        private const string _header = "NAIM";

        public string Header
        {
            get { return _header; }
        }

        private ServiceTypes _serviceType;

        public ServiceTypes ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        public MessageHeader(ServiceTypes service)
        {
            _serviceType = service;
        }


        public byte[] Serialize(ushort contentLength)
        {
            byte[] toreturn = new byte[8];
            byte[] header = AMessageData.ToByteArray(_header);
            Array.Copy(header, toreturn, header.Length);
            byte[] service = AMessageData.ToByteArray((ushort)_serviceType);
            toreturn[header.Length] = service[0];
            toreturn[header.Length+1] = service[1];
            byte[] contentLen = AMessageData.ToByteArray(contentLength);
            Array.Copy(contentLen, 0, toreturn, header.Length + 2, contentLen.Length);
            return toreturn;
        }
    }
}

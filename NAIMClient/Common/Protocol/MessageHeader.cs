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


        public byte[] Serialize()
        {
            byte[] toreturn = new byte[5];
            byte[] header = AMessageData.ToByteArray(_header);
            Array.Copy(header, toreturn, header.Length);
            toreturn[4] = (byte)_serviceType;
            return toreturn;
        }
    }
}

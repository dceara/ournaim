using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using System.Net;

namespace Common.ProtocolEntities
{
    public class ConnectionDataMessageData : AMessageData
    {
        #region Properties

        private string _sender;

        public string Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        private string _receiver;

        public string Receiver
        {
            get { return _receiver; }
            set { _receiver = value; }
        }
	

        private string _ipAddress;

        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        private ushort _port;

        public ushort Port
        {
            get { return _port; }
            set { _port = value; }
        }

        #endregion

        #region Constructors
        
        public ConnectionDataMessageData(byte[] data)
        {
            _data = new byte[data.Length];
            Array.Copy(data, _data, data.Length);
            Deserialize();
        }
        public ConnectionDataMessageData(string sender,string receiver,string ip, ushort port)
        {
            this._sender = sender;
            this._receiver = receiver;
            this._ipAddress = ip;
            this._port = port;
        }
        #endregion

        #region AMessageData Methods

        protected override void Deserialize()
        {
            int senderLen = _data[0];
            int receiverLen = _data[senderLen + 1];
            _sender = AMessageData.ToString(_data, 1, senderLen);
            _receiver = AMessageData.ToString(_data, senderLen + 2, receiverLen);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<3;i++)
            {
                sb.AppendFormat("{0}.", _data[i+senderLen+receiverLen+3]);
            }
            sb.Append(_data[senderLen + receiverLen + 6]);
            _ipAddress = sb.ToString();
            _port = (ushort)IPAddress.NetworkToHostOrder(AMessageData.ToShort(_data[senderLen + receiverLen + 7], _data[senderLen + receiverLen + 8]));
        }

        public override byte[] Serialize()
        {
            byte[] sender = AMessageData.ToByteArray(_sender);
            byte[] receiver = AMessageData.ToByteArray(_receiver);
            byte[] toReturn = new byte[sender.Length + receiver.Length + 9];
            IPAddress ip = IPAddress.Parse(_ipAddress);
            byte[] addr = ip.GetAddressBytes(); 
            ushort netPort = (ushort)IPAddress.HostToNetworkOrder((short)_port);
            byte[] port = AMessageData.ToByteArray(netPort);
            toReturn[0] = (byte)sender.Length;
            Array.Copy(sender, 0, toReturn, 1, sender.Length);
            toReturn[sender.Length + 1] = (byte)receiver.Length;
            Array.Copy(receiver, 0, toReturn, sender.Length + 2, receiver.Length);
            Array.Copy(addr,0, toReturn, sender.Length+receiver.Length+3,4);
            Array.Copy(port, 0, toReturn, sender.Length + receiver.Length + 7, 2);
            return toReturn;
        }
        #endregion
    }
}

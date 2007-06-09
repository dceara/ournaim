using System;
using System.Collections.Generic;
using System.Text;
using Common.ProtocolEntities;
using Common.ProtocolExceptions;

namespace Common.Protocol
{
    public class Message
    {
        private MessageHeader _header;

        public MessageHeader Header
        {
            get { return _header; }
            set { _header = value; }
        }

        private byte[] _data;

        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Message(MessageHeader header, byte[] data)
        {
            _header = header;
            _data = data;
        }

        public Message(byte[] rawData)
        {
            ushort service = AMessageData.ToShort(rawData[4], rawData[5]);
            _header = new MessageHeader((ServiceTypes)service);
            _data = new byte[rawData.Length - MessageHeader.HEADER_SIZE];
            Array.Copy(rawData, MessageHeader.HEADER_SIZE, _data, 0, rawData.Length - MessageHeader.HEADER_SIZE);
        }

        public Message(MessageHeader header, AMessageData messageData)
        {
            _header = header;
            _data = messageData.Serialize();
        }

        public static AMessageData GetMessageData(Message mes)
        {
            switch (mes._header.ServiceType)
            {
                case ServiceTypes.ACK:
                    return new AckMessageData(mes._data);
                case ServiceTypes.NACK:
                    return new NackMessageData(mes._data);
                case ServiceTypes.PING:
                    return new PingMessageData(mes._data);
                case ServiceTypes.CONNECTION_DATA:
                    return new ConnectionDataMessageData(mes._data);
                case ServiceTypes.CONNECTION_REQ:
                    return new ConnectionDataRequestedMessageData(mes._data);
                case ServiceTypes.USER_LIST:
                    return new UserListMessageData(mes._data);
                case ServiceTypes.USER_CONNECTED:
                    return new UserConnectedMessageData(mes._data);
                case ServiceTypes.USER_DISCONNECTED:
                    return new UserDisconnectedMessageData(mes._data);
                case ServiceTypes.SIGNUP:
                    return new SignUpMessageData(mes._data);
                case ServiceTypes.FILE_TRANSFER_GET:
                    return new FileTransferGetMessageData(mes._data);
                case ServiceTypes.FILE_TRANSFER_SEND:
                    return new FileTransferSendMessageData(mes._data);
                case ServiceTypes.HELLO:
                    return new HelloMessageData(mes._data);
                case ServiceTypes.LOGIN:
                    return new LoginMessageData(mes._data);
                case ServiceTypes.LOGOUT:
                    return new LogoutMessageData(mes._data);
                case ServiceTypes.TEXT:
                    return new TextMessageData(mes._data);
                case ServiceTypes.FILE_LIST_GET:
                    return new FileListGetMessageData(mes._data);
                case ServiceTypes.ADD_CONTACT:
                    return new AddContactMessageData(mes._data);
                case ServiceTypes.REMOVE_CONTACT:
                    return new RemoveContactMessageData(mes._data);
                case ServiceTypes.STATUS:
                    return new StatusMessageData(mes._data);
            }
            throw new UnknownServiceException();
        }
        public byte[] Serialize()
        {
            byte[] header = _header.Serialize((ushort)_data.Length);
            byte[] toReturn = new byte[_data.Length + header.Length];
            Array.Copy(header, toReturn, header.Length);
            Array.Copy(_data, 0, toReturn, header.Length, _data.Length);
            return toReturn;
        }
    }
}

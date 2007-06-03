using System;

namespace Common
{
    public enum ServiceTypes:byte
    {
        ACK = 0,
        NACK = 1,
        PING = 2,
        SIGNUP = 3,
        LOGIN = 4,
        LOGOUT = 5,
        TEXT = 6,
        USER_LIST = 7,
        USER_CONNECTED = 8,
        USER_DISCONNECTED = 9,
        CONNECTION_REQ = 10,
        CONNECTION_DATA = 11,

        HELLO = 12,
        FILE_TRANSFER_SEND = 13,
        FILE_TRANSFER_GET = 14,
        FILE_LIST_GET = 15,
        ADD_CONTACT = 16,
        REMOVE_CONTACT = 17,
    }
    public static class DefaultStatuses
    {
        public const string AVAILABLE = "Available";
        public const string INVISIBLE = "Invisible";
    }
}

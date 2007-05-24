using System;

namespace Common
{
    public enum ServiceTypes
    {
        LOGIN,
        LOGOUT,
        ACK,
        NACK,
        PING,
        ADD_CONTACT,
        REMOVE_CONTACT,
        CONNECTION_DATA,
        CONNECTION_REQ,
        USER_LIST,
        USER_CONNECTED,
        USER_DISCONNECTED,
        SIGNUP,
        TEXT,

        FILE_TRANSFER_SEND,
        FILE_TRANSFER_GET,
        FILE_LIST_GET,
        HELLO,
        

    }
}

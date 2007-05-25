using System;

namespace Common
{
    public enum ServiceTypes:byte
    {
        LOGIN                   = 1,
        LOGOUT                  = 2,
        ACK                     = 3,
        NACK                    = 4,
        PING                    = 5,
        ADD_CONTACT             = 6,
        REMOVE_CONTACT          = 7,
        CONNECTION_DATA         = 8,
        CONNECTION_REQ          = 9,
        USER_LIST               = 10,
        USER_CONNECTED          = 11,
        USER_DISCONNECTED       = 12,
        SIGNUP                  = 13,
        TEXT                    = 14,

        FILE_TRANSFER_SEND      = 15,
        FILE_TRANSFER_GET       = 16,
        FILE_LIST_GET           = 17,
        HELLO                   = 18,
        

    }
}

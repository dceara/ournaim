using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public enum ServiceType
    {
        LOGIN = 1,
        LOGOUT = 2,
        TEXT = 3,
        ACK = 4,
        NACK = 5,
        PING = 6,
        FILE_TRANSFER = 7,
        CONNECTION_DATA = 8,
    }
}

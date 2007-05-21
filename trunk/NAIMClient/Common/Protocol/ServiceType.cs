using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public enum ServiceType
    {
        LOGIN               ,
        LOGOUT              ,
        TEXT                ,
        ACK                 ,
        NACK                ,
        PING                ,
        CONNECTION_DATA     ,
        CONNECTION_REQ      ,
        USER_LIST           ,
        USER_CONNECTED      ,
        USER_DISCONNECTED   ,
        SIGN_UP             ,


        FILE_TRANSFER_SEND  ,
        FILE_TRANSFER_GET   ,
        FILE_LIST_GET       ,
        HELLO               ,


    }
    public enum ErrorType
    {

    }
}

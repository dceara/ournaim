using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    public interface IConversationController
    {
        event SendServerMessageEventHandler SendServerMessageEvent;

        string Name
        {
            get;
            set;
        }

        void OnSendServerMessage(Packet message);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void ReceiveServerMessage(Packet message);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void InitialiseView(IConversationView view);
    }

    public delegate void SendServerMessageEventHandler(Packet message);
}

using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    public delegate void DisposeConversationController(string name);

    public interface IConversationController
    {
        event SendServerMessageEventHandler SendServerMessageEvent;

        event DisposeConversationController DisposeConversationControllerEvent;

        string Name
        {
            get;
            set;
        }

        void OnSendServerMessage(Message message);

        void OnDisposeConversationController(string userName);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void ReceiveServerMessage(Message message);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void InitialiseView(IConversationView view);

        void CloseView();
    }

    public delegate void SendServerMessageEventHandler(Message message);
}

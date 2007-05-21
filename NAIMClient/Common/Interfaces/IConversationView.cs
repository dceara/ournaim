using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public delegate void SendMessageDelegate(object eventArgs);

    public interface IConversationView
    {
        event SendMessageDelegate SendMessageEvent;

        event CloseEventDelegate CloseEvent;

        event StartFileTransferEventHandler StartFileTransferEvent;

        event CancelFileTransferEventHandler CancelFileTransferEvent;

        void OnSendMessageEvent(object SendMessageEventArgs);

        void AddMessage(string message);

        void Initialise(string caption);

        void OnCloseEvent(object eventArgs);

        void OnStartFileTransferEvent(object eventArgs);

        void OnCancelFileTransferEvent(object eventArgs);

        void ShowView();

        void CloseView();
    }

    public delegate void CloseEventDelegate(object eventArgs);

    public delegate void StartFileTransferEventHandler(object eventArgs);

    public delegate void CancelFileTransferEventHandler(object eventArgs);
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public delegate void SendMessageDelegate(string message);

    public interface IConversationView
    {
        event SendMessageDelegate SendMessageEvent;

        event CloseEventDelegate CloseEvent;

        event StartFileTransferEventHandler StartFileTransferEvent;

        event CancelFileTransferEventHandler CancelFileTransferEvent;

        string CurrentUserName
        {
            set;
        }

        void OnSendMessageEvent(string message);

        void AddMessage(string message);

        void Initialise(string caption);

        void OnCloseEvent();

        void OnStartFileTransferEvent(string fileName, string writeLocation);

        void OnCancelFileTransferEvent(string filename);

        void ShowView();

        void CloseView();

    }

    public delegate void CloseEventDelegate();

    public delegate void StartFileTransferEventHandler(string fileName, string writeLocation);

    public delegate void CancelFileTransferEventHandler(string filename);
}

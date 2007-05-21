using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public class ConversationView : Form,IConversationView
    {
        #region IConversationView Members

        public event SendMessageDelegate SendMessageEvent;

        public event CloseEventDelegate CloseEvent;

        public event StartFileTransferEventHandler StartFileTransferEvent;

        public event CancelFileTransferEventHandler CancelFileTransferEvent;

        public void OnSendMessageEvent(object SendMessageEventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void AddMessage(string message)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Initialise()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCloseEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnStartFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}

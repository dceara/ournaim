using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class ConversationView : Form,IConversationView
    {
        public ConversationView()
        {
            InitializeComponent();
        }

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

        public void Initialise(string caption)
        {
            this.Text = caption;
        }

        public void OnCloseEvent(object eventArgs)
        {
            if (CloseEvent != null)
            {
                CloseEvent(eventArgs);
            }
        }

        public void OnStartFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ShowView()
        {
            this.Show();
        }

        #endregion

        #region GUI Event Handlers

        private void ConversationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseEvent("INCHIDERE FEREASTRA DE CONVERSATIE!!");
        }
        #endregion
    }
}

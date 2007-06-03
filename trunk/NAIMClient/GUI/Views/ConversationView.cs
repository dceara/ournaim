using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class ConversationView : Form,IConversationView
    {
        private bool cancelCloseEvent = false;

        public ConversationView()
        {
            InitializeComponent();
        }

        #region IConversationView Members

        public event SendMessageDelegate SendMessageEvent;

        public event CloseEventDelegate CloseEvent;

        public event StartFileTransferEventHandler StartFileTransferEvent;

        public event CancelFileTransferEventHandler CancelFileTransferEvent;

        public void OnSendMessageEvent(string message)
        {
            if (SendMessageEvent != null)
            {
                SendMessageEvent(message);
            }
        }

        public void AddMessage(string message)
        {
            this.txtMessageList.Text = txtMessageList.Text + "\n" + this.Text + ": " + message;
        }

        public void Initialise(string caption)
        {
            this.Text = caption;
        }

        public void OnCloseEvent()
        {
            if (!cancelCloseEvent && CloseEvent != null)
            {
                CloseEvent();
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
        public void CloseView()
        {
            this.cancelCloseEvent = true;
            this.Close();
        }

        private string currentUserName;
        public string CurrentUserName
        {
            set
            {
                currentUserName = value;
            }
        }
        
        #endregion

        #region GUI Event Handlers

        private void ConversationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseEvent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = this.txtMessage.Text;
            this.txtMessageList.Text = txtMessageList.Text + "\n" + this.currentUserName + ": " + message;
            OnSendMessageEvent(message);
        }
        #endregion
       
    }
}

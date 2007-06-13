using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class ConversationView : Form,IConversationView
    {
        #region Members

        private bool cancelCloseEvent = false;

        #endregion

        #region Constructors

        public ConversationView()
        {
            InitializeComponent();
        }
        
        #endregion

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
            if (message == "") return;
            if (this.txtMessageList.Text != "")
            {
                this.txtMessageList.Text += "\r\n";
            }
            this.txtMessageList.Text += this.Text + ": " + message;
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

        public void OnStartFileTransferEvent(string fileName, string writeLocation)
        {
            if (StartFileTransferEvent != null)
            {
                StartFileTransferEvent(fileName,writeLocation);
            }
        }

        public void OnCancelFileTransferEvent(string fileName)
        {
            if (CancelFileTransferEvent != null)
            {
                CancelFileTransferEvent(fileName);
            }
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
            SendMessage();
        }
        void SendMessage()
        {
            string message = this.txtMessage.Text;
            if (message == "") return;
            if (this.txtMessageList.Text != "")
            {
                this.txtMessageList.Text += "\r\n";
            }
            this.txtMessageList.Text += this.currentUserName + ": " + message;
            this.txtMessage.ResetText();
            this.txtMessageList.ReadOnly = false;
            this.txtMessageList.Focus();
            this.txtMessageList.ScrollToCaret();
            this.txtMessageList.Refresh();
            this.txtMessageList.ReadOnly = true;
            this.txtMessageList.Select(0, 0);
            this.txtMessage.Focus();
            OnSendMessageEvent(message);
        }
        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendMessage();
            }
        }
        #endregion       
    }
}

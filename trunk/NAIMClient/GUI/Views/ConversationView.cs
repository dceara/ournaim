using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using System.Drawing;

namespace GUI
{
    public partial class ConversationView : Form,IConversationView
    {
        #region Members

        private bool cancelCloseEvent = false;

        private Color _userColor = Color.Gray;
        private Color _contactColor = Color.Navy;
        private Color _textColor = Color.Black;

        private Font _usersFont = new Font("Tahoma", 8, FontStyle.Bold);
        private Font _textFont = new Font("Arial", 10, FontStyle.Regular);

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

            txtMessageList.SelectionStart = txtMessageList.TextLength;
            
            txtMessageList.SelectionColor = _contactColor;
            txtMessageList.SelectionFont = _usersFont;
            txtMessageList.AppendText(Text + ": ");
            txtMessageList.SelectionColor = _textColor;
            txtMessageList.SelectionFont = _textFont;
            txtMessageList.AppendText(message + "\r\n");            
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

            txtMessageList.SelectionStart = txtMessageList.TextLength;

            IDataObject clipContent = Clipboard.GetDataObject();

            Clipboard.SetImage(Resources.progress_bar_texture);

            txtMessageList.SelectionColor = _userColor;
            txtMessageList.SelectionFont = _usersFont;
            txtMessageList.AppendText(currentUserName + ": ");

            txtMessageList.ReadOnly = false;
            txtMessageList.Paste();
            txtMessageList.ReadOnly = true;

            txtMessageList.SelectionColor = _textColor;
            txtMessageList.SelectionFont = _textFont;
            txtMessageList.AppendText(message + "\r\n");
            txtMessageList.ScrollToCaret();

            txtMessage.Clear();
            txtMessage.Focus();

            Clipboard.SetDataObject(clipContent);

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

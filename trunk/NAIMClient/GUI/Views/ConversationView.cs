using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using GUI.Controls;
using System.Drawing;

namespace GUI
{
    public partial class ConversationView : Form,IConversationView
    {
        #region Constants

        private const string BUZZ = "<ding>";

        private const string BUZZ_TEXT = "BUZZ!";

        private const int BUZZ_CNT = 500;

        private const int BUZZ_MOVE = 4;

        #endregion

        #region Members

        private bool cancelCloseEvent = false;

        private Color _userColor = Color.Gray;
        private Color _contactColor = Color.Navy;
        private Color _textColor = Color.Black;
        private Color _buzzColor = Color.Red;

        private Font _usersFont = new Font("Tahoma", 8, FontStyle.Bold);
        private Font _textFont = new Font("Arial", 10, FontStyle.Regular);
        private Font _buzzFont = new Font("Tahoma", 12, FontStyle.Bold);

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
            if (message == BUZZ)
            {
                HandleBuzz();
                return;
            }

            message = message.Replace(BUZZ + BUZZ, BUZZ);

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


        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (!e.Alt) && (!e.Shift))
            {
                if (e.KeyCode == Keys.G)
                {
                    OnSendMessageEvent(BUZZ);

                    txtMessage.Clear();
                    txtMessageList.SelectionStart = txtMessageList.TextLength;

                    txtMessageList.SelectionColor = _userColor;
                    txtMessageList.SelectionFont = _usersFont;
                    txtMessageList.AppendText(currentUserName + ": ");


                    txtMessageList.SelectionColor = _buzzColor;
                    txtMessageList.SelectionFont = _buzzFont;
                    txtMessageList.AppendText(BUZZ_TEXT + "\r\n");
                    txtMessageList.ScrollToCaret();

                    txtMessage.Clear();
                    txtMessage.Focus();
                    e.Handled = true;

                    BuzzWindow();
                }
            }
        }


        void SendMessage()
        {
            string message = this.txtMessage.Text;


            if (message == "") return;

            txtMessageList.SelectionStart = txtMessageList.TextLength;

            txtMessageList.SelectionColor = _userColor;
            txtMessageList.SelectionFont = _usersFont;
            txtMessageList.AppendText(currentUserName + ": ");


            txtMessageList.SelectionColor = _textColor;
            txtMessageList.SelectionFont = _textFont;
            txtMessageList.AppendText(message + "\r\n");
            txtMessageList.ScrollToCaret();

            txtMessage.Clear();
            txtMessage.Focus();

            message = message.Replace(BUZZ, BUZZ + BUZZ);

            OnSendMessageEvent(message);
        }
        #endregion

        #region Private Methods

        private void HandleBuzz()
        {
            txtMessageList.SelectionStart = txtMessageList.TextLength;

            txtMessageList.SelectionColor = _contactColor;
            txtMessageList.SelectionFont = _usersFont;
            txtMessageList.AppendText(Text + ": ");
            txtMessageList.SelectionColor = _buzzColor;
            txtMessageList.SelectionStart = txtMessageList.TextLength;
            txtMessageList.SelectionFont = _buzzFont;
            txtMessageList.AppendText(BUZZ_TEXT + "\r\n");

            BuzzWindow();
        }

        private void BuzzWindow()
        {
            for (int i = 0; i < BUZZ_CNT;  i++)
            {
                int dir = i % 4;
                switch (dir)
                {
                    case 0:
                        this.Location = new Point(this.Location.X - BUZZ_MOVE, this.Location.Y);
                        break;
                    case 1:
                        this.Location = new Point(this.Location.X, this.Location.Y - BUZZ_MOVE);
                        break;
                    case 2:
                        this.Location = new Point(this.Location.X + BUZZ_MOVE, this.Location.Y);
                        break;
                    case 3:
                        this.Location = new Point(this.Location.X, this.Location.Y + BUZZ_MOVE);
                        break;
                }
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class MainView : Form,IMainView
    {
        private Button btnSignOut;

        public MainView()
        {
            InitializeComponent();
        }

        #region IMainView Members

        public event LoginEventHandler LoginEvent;

        public event LogoutEventHandler LogoutEvent;

        public event ChangeStatusEventHandler ChangeStatusEvent;

        public event AddContactEventHandler AddContactEvent;

        public event RemoveContactEventHandler RemoveContactEvent;

        public event ChangeContactGroupEventHandler ChangeContactGroupEvent;

        public event OpenConversationEventHandler OpenConversationEvent;

        public event OpenFileTransferViewEventHandler OpenFileTransferViewEvent;

        public event MainCloseEventHandler MainCloseEvent;

        public event OpenSignUpViewHandler OpenSignUpViewEvent;

        public void OnOpenSignUpViewEvent()
        {
            if (OpenSignUpViewEvent != null)
            {
                OpenSignUpViewEvent();
            }
        }

        public void OnLoginEvent(string userName, string password)
        {
            if (LoginEvent != null)
            {
                LoginEvent(userName, password);
            }
        }

        public void OnLogoutEvent(object eventArgs)
        {
            if (LogoutEvent != null)
            {
                LogoutEvent(eventArgs);
            }
        }

        public void OnChangeStatusEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnAddContactEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnRemoveContactEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnChangeContactGroupEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnOpenConversationEvent(string userName)
        {
            if (OpenConversationEvent != null)
            {
                OpenConversationEvent(userName);
            }
        }

        public void OnOpenFileTransferViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ChangeClientStatus(string userName, string newStatus)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ClientOnline(string userName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ClientOffline(string userName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnMainClose(object eventArgs)
        {
            if (MainCloseEvent != null)
            {
                MainCloseEvent(eventArgs);
            }
        }
        public void AfterSignIn()
        {
            this.btnSignOut.Visible         = true;
            this.btnAddConversation.Visible = true;
            this.lblPassword.Visible        = false;
            this.lblUserName.Visible        = false;
            this.txtPassword.Visible        = false;
            this.txtUserName.Visible        = false;
            this.btnSignUp.Visible          = false;
            this.btnSignIn.Visible          = false;
        }

        public void Initialise()
        {
            this.btnSignOut.Visible         = false;
            this.btnAddConversation.Visible = false;
            this.lblPassword.Visible        = true;
            this.lblUserName.Visible        = true;
            this.txtPassword.Visible        = true;
            this.txtUserName.Visible        = true;
            this.btnSignUp.Visible          = true;
            this.btnSignIn.Visible          = true;
        }

        public void ShowView()
        {
            this.Show();
        }
        #endregion

        #region GUI Events
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OnLogoutEvent("TEST LOGOUT EVENT");
        }
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnMainClose("MAIN FORM CLOSING.... CLOSING APPLICATION!!");
        }

#warning HARDCODED FOR NOW
        int i = 0;
        private void btnAddConversation_Click(object sender, EventArgs e)
        {
            OnOpenConversationEvent("USER NOU" + i++);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OnLoginEvent(txtUserName.Text, txtPassword.Text);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            OnOpenSignUpViewEvent();
        }
        #endregion

    }
}

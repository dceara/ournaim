using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using GUI.Views;
using System.Drawing;

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

        public void OnLogoutEvent()
        {
            if (LogoutEvent != null)
            {
                LogoutEvent();
            }
        }

        public void OnChangeStatusEvent(String eventArgs)
        {
            //throw new Exception("The method or operation is not implemented.");
            if (ChangeStatusEvent != null)
            {
                ChangeStatusEvent(eventArgs);
            }
        }

        public void OnAddContactEvent(string username, string group)
        {
            if (AddContactEvent != null)
            {
                AddContactEvent(username, group);
            }
        }

        public void OnRemoveContactEvent(string username)
        {
            if (RemoveContactEvent != null)
            {
                RemoveContactEvent(username);
            }
        }

        public void OnChangeContactGroupEvent(string userName, string newGroup)
        {
            if (ChangeContactGroupEvent!=null)
            {
                ChangeContactGroupEvent(userName, newGroup);
            }
        }

        public void OnOpenConversationEvent(string userName)
        {
            if (OpenConversationEvent != null)
            {
                OpenConversationEvent(userName);
            }
        }

        public void OnOpenFileTransferViewEvent()
        {
            if (OpenFileTransferViewEvent != null)
            {
                OpenFileTransferViewEvent();
            }
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

        public void OnMainClose()
        {
            if (MainCloseEvent != null)
            {
                MainCloseEvent();
            }
        }
        public void AfterSignIn()
        {
            ChangeControlsVisibility(false);
            
            ChangeMenuVisibility(true);
        }

        public void Initialise()
        {
            ChangeControlsVisibility(true);

            ChangeMenuVisibility(false);
        }

        public void ShowView()
        {
            this.Show();
        }

        public void ChangeStatus(string status)
        {
            this.status_button.Text = status;
        }
        #endregion

        #region GUI Events
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OnLogoutEvent();
        }
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnMainClose();
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
        private void btnFileManager_Click(object sender, EventArgs e)
        {
            OnOpenFileTransferViewEvent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatusDialog statusDialog = new ChangeStatusDialog();
            DialogResult result = statusDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OnChangeStatusEvent(statusDialog.Status);
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            StatusesView statusesView = new StatusesView();
            statusesView.StartLocation = status_button.PointToScreen(new Point(status_button.Left,status_button.Top));
            if (statusesView.ShowDialog() == DialogResult.OK)
            {
                OnChangeStatusEvent(statusesView.Status);
            }
            else
            {
                if (statusesView.DialogResult == DialogResult.Retry)
                {
                    ChangeStatusDialog dialog = new ChangeStatusDialog();
                    
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        OnChangeStatusEvent(dialog.Status);
                    }
                }
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactDialog addContactDialog = new AddContactDialog();
            DialogResult result = addContactDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                OnAddContactEvent(addContactDialog.Username, addContactDialog.Group);
            }
        }

        #endregion



        #region Utils
        private void ChangeMenuVisibility(bool value)
        {
            this.contactsToolStripMenuItem.Visible = value;
            this.statusToolStripMenuItem.Visible = value;
            this.accountInformationToolStripMenuItem.Visible = value;
            this.shareFilesToolStripMenuItem.Visible = value;
            this.fileTransferManagerToolStripMenuItem.Visible = value;
            this.signOutToolStripMenuItem.Visible = value;
        }

        private void ChangeControlsVisibility(bool value)
        {
            this.btnSignOut.Visible = !value;
            this.btnAddConversation.Visible = !value;
            this.lblPassword.Visible = value;
            this.lblUserName.Visible = value;
            this.txtPassword.Visible = value;
            this.txtUserName.Visible = value;
            this.btnSignUp.Visible = value;
            this.btnSignIn.Visible = value;
            this.status_button.Visible = !value;
            this.status_label.Visible = !value;
        }
        #endregion



       


    }
}

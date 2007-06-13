using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using GUI.Views;
using System.Drawing;
using Common.Protocol;

namespace GUI
{
    public partial class MainView : Form, IMainView
    {
        #region Members


        private IList<string> groupNames;

        #endregion

        #region Constructors

        public MainView()
        {
            InitializeComponent();

            ctvContacts.Initialize();
            ctvContacts.ContactTreeAddContactToGroup += new GUI.Controls.ContactTreeAddContactToGroup(ctvContacts_ContactTreeAddContactToGroup);

            cbStatuses.SelectedIndex = 0;
        }

        #endregion

        #region IMainView Members

        public event LoginEventHandler LoginEvent;

        public event LogoutEventHandler LogoutEvent;

        public event ChangeStatusEventHandler ChangeStatusEvent;

        public event AddContactEventHandler AddContactEvent;

        public event AddGroupEventHandler AddGroupEvent;

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

        public void OnAddGroupEvent(string group)
        {
            if (AddGroupEvent != null)
            {
                AddGroupEvent(group);
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
            if (ChangeContactGroupEvent != null)
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
            ctvContacts.ChangeContactStatus(userName, newStatus);
        }

        public void ClientOnline(string userName, string status)
        {
            ctvContacts.ContactOnline(userName, status);
        }

        public void ClientOffline(string userName)
        {
            ctvContacts.ContactOffline(userName);
        }

        public void OnMainClose()
        {
            if (MainCloseEvent != null)
            {
                MainCloseEvent();
            }
        }
        public void AfterSignIn(string userName)
        {
            ChangeControlsVisibility(false);

            ChangeMenuVisibility(true);

            lblStatus.Text = userName + " - ";
            cbStatuses.Location = new Point(lblStatus.Location.X + lblStatus.Width, cbStatuses.Location.Y);
            cbStatuses.Width = ctvContacts.Location.X + ctvContacts.Width - cbStatuses.Location.X;
            cbStatuses.Refresh();
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

        public void SetGroupSource(IList<string> groupNames, IDictionary<string, IList<UserListEntry>> contactsByGroups)
        {
            ctvContacts.LoadContacts(groupNames, contactsByGroups);
        }

        public void AddGroup(string groupName)
        {
            //TODO add group to tree
        }

        public void RemoveContact(string contactName)
        {
            //TODO remove contact from tree
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
                cbStatuses.Items.Add(statusDialog.Status);
                cbStatuses.SelectedIndex = cbStatuses.Items.Count - 1;
            }
        }

        private void cbStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
#warning remove hadcoding
            if (cbStatuses.SelectedIndex == 5)
            {
                ChangeStatusDialog statusDialog = new ChangeStatusDialog();
                DialogResult result = statusDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbStatuses.Items.Add(statusDialog.Status);
                    cbStatuses.SelectedIndex = cbStatuses.Items.Count - 1;
                }
            }
            else
            {
                OnChangeStatusEvent(cbStatuses.SelectedItem.ToString());
            }
        }

        void ctvContacts_ContactTreeAddContactToGroup(string group)
        {
            AddContactDialog addContactDialog = new AddContactDialog(ctvContacts.GetGroups(), group);
            DialogResult result = addContactDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ctvContacts.AddContact(addContactDialog.Username, addContactDialog.Group);
                OnAddContactEvent(addContactDialog.Username, addContactDialog.Group);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactDialog addContactDialog = new AddContactDialog(ctvContacts.GetGroups());
            DialogResult result = addContactDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ctvContacts.AddContact(addContactDialog.Username, addContactDialog.Group);
                OnAddContactEvent(addContactDialog.Username, addContactDialog.Group);
            }
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupView addGroupView = new AddGroupView();
            DialogResult result = addGroupView.ShowDialog();
            if (result == DialogResult.OK)
            {
                OnAddGroupEvent(addGroupView.Groupname);
            }
        }

        private void ctvContacts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
                return;
            OnOpenConversationEvent(e.Node.Name);
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
            this.lblPassword.Visible = value;
            this.lblUserName.Visible = value;
            this.txtPassword.Visible = value;
            this.txtUserName.Visible = value;
            this.btnSignUp.Visible = value;
            this.btnSignIn.Visible = value;
            this.lblStatus.Visible = !value;
            this.cbStatuses.Visible = !value;
            this.ctvContacts.Visible = !value;
        }
        #endregion
    }
}

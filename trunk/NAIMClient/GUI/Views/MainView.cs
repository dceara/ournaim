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

        public void OnLoginEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
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

        public void OnOpenConversationEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
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

        public void Initialise()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnMainClose(object eventArgs)
        {
            if (MainCloseEvent != null)
            {
                MainCloseEvent("MAIN FORM CLOSING.... CLOSING APPLICATION!!");
            }
        }

        #endregion

        #region GUI Events
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OnLogoutEvent("TEST LOGOUT EVENT");
        }
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnMainClose(e);
        }
        #endregion

    }
}

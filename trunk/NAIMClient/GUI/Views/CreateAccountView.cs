using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class CreateAccountView : Form,ICreateAccountView
    {
        private bool cancelCloseEvent = false;

        public CreateAccountView()
        {
            InitializeComponent();
        }

        #region ICreateAccountView Members

        public event CreateAccountEventHandler CreateAccountEvent;

        public event CloseAccountViewEventHandler CloseAccountViewEvent;

        public void OnCreateAccountEvent(string userName,string Password)
        {
            if (CreateAccountEvent != null)
            {
                CreateAccountEvent(userName, Password);
            }
        }

        public void Initialise()
        {
        }

        public void OnCloseAccountViewEvent()
        {
            if (!cancelCloseEvent && CloseAccountViewEvent != null)
            {
                CloseAccountViewEvent();
            }
        }

        public void ShowView()
        {
            this.ShowDialog();
        }
        public void CloseView()
        {
            this.cancelCloseEvent = true;
            this.Close();
        }

        #endregion

        #region GUI Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnCreateAccountEvent(txtUserName.Text, txtPassword.Text);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCloseAccountViewEvent();
        }
        private void CreateAccountView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseAccountViewEvent();
        }
        #endregion
    }
}

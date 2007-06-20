using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class CreateAccountView : Form,ICreateAccountView
    {
        #region Members

        private bool cancelCloseEvent = false;

        #endregion

        #region Constructors

        public CreateAccountView()
        {
            InitializeComponent();
        }

        #endregion

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
            if (this.txtUserName.Text == string.Empty)
            {
                MessageBox.Show("The User Name cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(this.txtUserName.Text.Contains(" "))
            {
                MessageBox.Show("The User Name cannot contain spaces!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (this.txtPassword.Text != this.txtPasswordAgain.Text)
            {
                MessageBox.Show("The passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

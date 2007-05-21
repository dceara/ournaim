using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI
{
    public partial class CreateAccountView : Form,ICreateAccountView
    {
        public CreateAccountView()
        {
            InitializeComponent();
        }

        #region ICreateAccountView Members

        public event CreateAccountEventHandler CreateAccountEvent;

        public event CloseAccountViewEventHandler CloseAccountViewEvent;

        public void OnCreateAccountEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Initialise()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCloseAccountViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ShowView()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.ErrorHandling;

namespace GUI.Views
{
    public partial class AddGroupView : Form
    {
        public delegate void DialogClosedDelegate(string group);        

        #region Properties
		
        public String Group
        {
            get { return this.txtGroupName.Text; }
        }
	    #endregion

        #region COnstructors

        public AddGroupView()
        {
            InitializeComponent();
        }
        #endregion

        #region GUI Events

        private void AddGroupView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && this.txtGroupName.Text == String.Empty)
            {
                ErrorHandler.HandleError("The Group Name cannot be empty!", "Error", this);
                e.Cancel = true;
            }
        }
        #endregion

        #region Threading

        public static void Show(object stateInfo)
        {
            object[] args = stateInfo as object[];
            if (args == null)
                return;
            if (args.Length < 2)
                return;
            IWin32Window parent = args[0] as IWin32Window;
            if (parent == null)
                return;
            DialogClosedDelegate callback = args[1] as DialogClosedDelegate;
            if (callback == null)
                return;
            AddGroupView addGroupDialog = new AddGroupView();
            DialogResult result = addGroupDialog.ShowDialog((IWin32Window)parent);
            if (result != DialogResult.OK)
            {
                return;
            }
            callback(addGroupDialog.Group);
        }

        #endregion


    }
}
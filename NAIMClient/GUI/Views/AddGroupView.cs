using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AddGroupView : Form
    {

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
                e.Cancel = true;
                MessageBox.Show("The Group Name cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
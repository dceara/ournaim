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
		
        public String Groupname
        {
            get { return this.groupname_textBox.Text; }
        }
	    #endregion

        #region COnstructors

        public AddGroupView()
        {
            InitializeComponent();
        }
        #endregion
    }
}
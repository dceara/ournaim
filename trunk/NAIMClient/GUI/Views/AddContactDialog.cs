using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AddContactDialog : Form
    {
        #region Properties

        public string Username
        {
            get { return this.usernickname.Text; }
        }

        public string Group
        {
            get { return group_comboBox.Text; }
        }

        #endregion

        #region Constructors

        public AddContactDialog(string[] groups)
        {
            InitializeComponent();

            foreach(string group in groups)
            {
                group_comboBox.Items.Add(group);
            }
        }
        
        #endregion

    }
}
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

        public string Username
        {
            get { return this.usernickname.Text; }
        }

        public string Group
        {
            get { return group_comboBox.Text; }
        }
	




        public AddContactDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
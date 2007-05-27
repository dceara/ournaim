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

        public String Groupname
        {
            get { return this.groupname_textBox.Text; }
        }
	
        public AddGroupView()
        {
            InitializeComponent();
        }
    }
}
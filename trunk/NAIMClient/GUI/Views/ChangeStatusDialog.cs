using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class ChangeStatusDialog : Form
    {
       
        public ChangeStatusDialog()
        {
            InitializeComponent();
        }

        public string Status
        {
            get { return txtStatus.Text; }
        }
	
       
        
    }
}
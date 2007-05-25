using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class StatusesView : Form
    {
        private Point startLocation = new Point(-1, -1);

        public Point StartLocation
        {
            get { return startLocation; }
            set { startLocation = value; }
        }


        private string status;
        public string Status
        {
            get
            {
                return status;
            }
        }
	
        public StatusesView()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = (string)(listBox1.Items[listBox1.SelectedIndex]);
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void ChangeStatusDialog_Shown(object sender, EventArgs e)
        {
            if (startLocation.X != -1 && startLocation.Y != -1)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = startLocation;
            }
        }
        
    }
}
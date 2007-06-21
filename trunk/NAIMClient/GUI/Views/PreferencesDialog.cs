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
    public partial class PreferencesDialog : Form
    {
                        
        public string ServerAdress
        {
            get { return this.textBoxServAdr.Text; }
        }


        public string Port
        {
            get { return this.textBoxPort.Text; }
        }
	
	

        public PreferencesDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PreferencesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                int res;
                if (this.textBoxServAdr.Text == "" || this.textBoxPort.Text == "" || Int32.TryParse(textBoxPort.Text, out res) == false)
                {
                    ErrorHandler.HandleError("Fill in the server address and the port!", "Error", this);
                    e.Cancel = true;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.Dialogs
{
    public partial class NewItemDialog : Form
    {
        public NewItemDialog()
        {
            InitializeComponent();
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Enabled = false;
        }

        public string FileName
        {
            get { return textBoxName.Text; }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOK.PerformClick();
        }
    }
}
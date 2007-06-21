using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Common.ErrorHandling
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        internal void ShowDialog(IWin32Window parent, string errorMessage, string caption)
        {
            this.Text = caption;
            this.lblError.Text = errorMessage;
            this.ShowDialog(parent);
        }
    }
}
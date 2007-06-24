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

        private void lblError_TextChanged(object sender, EventArgs e)
        {
            Graphics graphics = lblError.CreateGraphics();
            SizeF stringSize = graphics.MeasureString(lblError.Text, lblError.Font);
            
            if (stringSize.Width > (float)this.lblError.Size.Width)
            {
                this.Size = new Size(this.Size.Width + (int)(stringSize.Width - (float)this.lblError.Size.Width), this.Size.Height);
                this.lblError.Size = new Size(this.lblError.Size.Width + (int)(stringSize.Width - (float)this.lblError.Size.Width), this.lblError.Size.Height);
                this.btnOk.Location = new Point(this.lblError.Location.X + this.lblError.Size.Width / 2 - this.btnOk.Size.Width / 2, this.btnOk.Location.Y);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FileListAliasChooser : Form
    {
        public FileListAliasChooser()
        {
            InitializeComponent();
        }

        public string Alias
        {
            get
            {
                return this.txtAlias.Text;
            }
        }

        private void FileListAliasChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtAlias.Text == "" || this.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Please write an alias for the selected file!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Projects;
using System.IO;
using SchemeGuiEditor.Services;

namespace SchemeGuiEditor
{
    public partial class NewProjectDialog : Form
    {
        private bool valid = true;
        public string ProjectName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string ProjectLocation
        {
            get { return textBoxLocation.Text; }
            set { textBoxLocation.Text = value; }
        }

        public NewProjectDialog()
        {
            InitializeComponent();
        }

        private void NewProjectDialog_Load(object sender, EventArgs e)
        {
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Enabled = false;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ProjectLocation = fbd.SelectedPath;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (ProjectLocation != string.Empty && ProjectName != string.Empty)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(textBoxLocation.Text,textBoxName.Text)))
            {
                MessageService.ShowError(Strings.ProjectAlreadyExists);
                valid = false;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!valid)
            {
                valid = true;
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
    }
}
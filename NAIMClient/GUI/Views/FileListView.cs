using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI.Views
{
    public partial class FileListView : Form,IFileListView
    {
        public FileListView()
        {
            InitializeComponent();
        }

        #region IFileListView Members

        public event AddFileDelegate AddFileEvent;

        public void OnAddFile(string name, string alias)
        {
            if (AddFileEvent != null)
            {
                AddFileEvent(name, alias);
            }
        }

        public event RemoveFileDelegate RemoveFileEvent;

        public void OnRemoveFile(string name)
        {
            if (RemoveFileEvent != null)
            {
                RemoveFileEvent(name);
            }
        }

        public void Initialise(IList<KeyValuePair<int, KeyValuePair<string, string>>> fileList)
        {
            foreach (KeyValuePair<int, KeyValuePair<string, string>> pair in fileList)
            {
                this.listViewFileList.Items.Add(new ListViewItem(new string[] { pair.Value.Key, pair.Value.Value }));
                this.listViewFileList.Update();
            }
        }

        public void ShowView()
        {
            this.Show();
        }

        #endregion

        #region GUI

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filename = openFileDialog.FileName;
            foreach (ListViewItem item in listViewFileList.Items)
            {
                if (item.SubItems[0].Text == filename)
                {
                    MessageBox.Show("The file is already in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            FileListAliasChooser aliasChooser = new FileListAliasChooser();
            aliasChooser.ShowDialog();
            string alias = aliasChooser.Alias;
            OnAddFile(filename, alias);
            this.listViewFileList.Items.Add(new ListViewItem(new string[] { filename, alias }));
            this.listViewFileList.Update();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (listViewFileList.SelectedItems.Count == 0)
                return;
            foreach (ListViewItem item in listViewFileList.SelectedItems)
            {
                listViewFileList.Items.Remove(item);
                OnRemoveFile(item.SubItems[0].Text);
            }
        }

        #endregion
    }
}
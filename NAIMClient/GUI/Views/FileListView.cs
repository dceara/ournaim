using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using GUI.Controls;
using System.Threading;

namespace GUI.Views
{
    public delegate void DialogClosedDelegate(IOpenDialogEventArgs args);

    public partial class FileListView : Form, IFileListView, IOpenFileOnOtherThread
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

        public void dialogClosed(IOpenDialogEventArgs args) 
        {
            string filePath = ((OpenFileEventArgs)args).FilePath;
            string alias = ((OpenFileEventArgs)args).Alias;
            if (this.InvokeRequired)
            {
                DialogClosedDelegate dcd = dialogClosed;
                this.Invoke(dcd, new object[] {args});
            }
            else
            {
                foreach (ListViewItem item in listViewFileList.Items)
                {
                    if (item.SubItems[0].Text == filePath)
                    {
                        MessageBox.Show("The file is already in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                OnAddFile(filePath, alias);
                this.listViewFileList.Items.Add(new ListViewItem(new string[] { filePath, alias }));
                this.listViewFileList.Update();
            }
        }

        public void ShowView()
        {
            this.Show();
        }

        #endregion

        #region GUI

        public void transferString(string filePath)
        {
 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileOnOtherThread ofoot = new OpenFileOnOtherThread(this);
            ThreadPool.QueueUserWorkItem(new WaitCallback(ofoot.Show));
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
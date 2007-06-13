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
            throw new Exception("The method or operation is not implemented.");
        }

        public void ShowView()
        {
            this.Show();
        }

        #endregion
    }
}
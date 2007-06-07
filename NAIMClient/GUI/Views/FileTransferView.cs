using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using Common.Protocol;
namespace GUI
{
    public partial class FileTransferView : Form,IFileTransferView
    {
        public FileTransferView()
        {
            InitializeComponent();
        }

        #region IFileTransferView Members

        public event FileTransferCloseViewEventHandler FileTransferCloseViewEvent;

        public event GetFileListEventHandler GetFileListEvent;

        public event StartFileTransferGenericEventHandler StartFileTransferEvent;

        public event CancelFileTransferGenericEventHandler CancelFileTransferEvent;

        public event CloseFileTransferViewEventHandler CloseFileTransferViewEvent;

        public void Initialise()
        {
        }
 
        public void SetClientsListSource(IDictionary<string, IList<UserListEntry>> contactsByGroups)
        {
            if (contactsByGroups != null)
            {
                foreach (KeyValuePair<string, IList<UserListEntry>> pair in contactsByGroups)
                {
                    foreach (UserListEntry entry in pair.Value)
                    {
                        if (entry.Availability)
                        {
                            this.listBoxContacts.Items.Add(entry.UserName);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < 5; i++)
                {
                    this.listBoxContacts.Items.Add(i.ToString());
                }
            }
        }

        public void ClientOnline(string username)
        {
            this.listBoxContacts.Items.Add(username);
        }

        public void ClientOffline(string username)
        {
            this.listBoxContacts.Items.Remove(username);
        }

        public void OnFileTransferCloseViewEvent(object eventArgs)
        {
            if (FileTransferCloseViewEvent != null)
            {
                FileTransferCloseViewEvent(eventArgs);
            }
        }

        /// <summary>
        /// this is called by the controller when a transfer is initiated in the conversation view
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="fileName"></param>
        public void StartFileTransfer(string userName, string fileName)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        /// <summary>
        /// this is called by the controller when a transfer is canceled in the conversation view
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="fileName"></param>
        public void CancelFileTransfer(string userName, string fileName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnGetFileListEvent(string username)
        {
            if (GetFileListEvent != null)
            {
                GetFileListEvent(username);
            }
        }

        public void ShowFileList(IList<string> fileList)
        {
            this.listBoxFileList.Items.Clear();
            foreach (string value in fileList)
            {
                listBoxFileList.Items.Add(value);
            }
        }

        public void OnStartFileTransferEvent(string username, string filename,string writeLocation)
        {
            if (StartFileTransferEvent != null)
            {
                StartFileTransferEvent(username, filename, writeLocation);
            }
        }

        public void OnCancelFileTransferEvent(string username, string filename)
        {
            if (CancelFileTransferEvent != null)
            {
                CancelFileTransferEvent(username,filename);
            }
        }

        public void ChangeFileTransferProgress(int percentage)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCloseFileTransferViewEvent()
        {
            if (CloseFileTransferViewEvent != null)
            {
                CloseFileTransferViewEvent();
            }
        }

        public void ShowView()
        {
            this.Focus();
            this.Show();
        }

        #endregion

        #region GUI Events
        private void FileTransferView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseFileTransferViewEvent();
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxContacts.SelectedIndex;
            if (index != -1)
            {
                OnGetFileListEvent((string)listBoxContacts.Items[listBoxContacts.SelectedIndex]);
                groupBoxPeer.Text = (string)listBoxContacts.Items[listBoxContacts.SelectedIndex];
            }
            else
            {
                groupBoxPeer.Text = "";
            }
            
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (listBoxFileList.SelectedIndex != -1)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OnStartFileTransferEvent(groupBoxPeer.Text, (string)listBoxFileList.Items[listBoxFileList.SelectedIndex], saveFileDialog.FileName);
                }
            }
        }
        #endregion

        
    }
}

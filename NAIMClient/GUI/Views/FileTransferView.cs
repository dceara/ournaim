using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using Common.Protocol;
using System.IO;
namespace GUI
{
    public partial class FileTransferView : Form,IFileTransferView
    {

        #region Constructors

        public FileTransferView()
        {
            InitializeComponent();            
        }

        #endregion

        #region Delegates

        private delegate void StartFileTransferDelegate(string contact, string file);
        private delegate void CancelFileTrasnferDelegate(string contact, string file);
        private delegate void UpdateTransferProgressDelegate(string contact, string file, int progress);
        private delegate void FileTransferFinishedDelegate(string contact, string file);

        #endregion

        #region IFileTransferView Members

        protected void OnViewClosed()
        {
            if (ViewClosedEvent != null)
            {
                ViewClosedEvent();
            }
        }

        protected void OnContactSelected(string contact)
        {
            if (ContactSelectedEvent != null)
            {
                ContactSelectedEvent(contact);
            }
        }

        protected void OnGetContactList(string contact)
        {
            if (GetContactListEvent != null)
            {
                GetContactListEvent(contact);
            }
        }

        protected void OnStartFileTransfer(string contact, string file, string writeLocation)
        {
            if (StartFileTransferEvent != null)
            {
                StartFileTransferEvent(contact, file,writeLocation);
            }
        }

        protected void OnCancelFileTransfer(string contact, string file)
        {   
            if (CancelFileTransferEvent != null)
            {
                CancelFileTransferEvent(contact, file);
            }
        }

        public void Initialise(ICollection<string> contacts)
        {
            foreach (string contact in contacts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = contact;
                lvi.Name = contact;
                lwContacts.Items.Add(lvi);
            }
        }

        public void AddContact(string contact)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = contact;
            lvi.Name = contact;
            lwContacts.Items.Add(lvi);
        }

        public void RemoveContact(string contact)
        {
            ListViewItem lvi = lwContacts.Items[contact];
            lwContacts.Items.Remove(lvi);
        }

        public void ContactOnline(string contact) {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = contact;
            lvi.Name = contact;
            lwContacts.Items.Add(lvi);
        }

        public void ContactOffline(string contact) {
            ListViewItem lvi = lwContacts.Items[contact];
            lwContacts.Items.Remove(lvi);
        }

        public void StartFileTransfer(string contact, string file)
        {
            if (this.InvokeRequired)
            {
                StartFileTransferDelegate sftd = StartFileTransfer;
                this.Invoke(sftd, new object[] { contact, file });
            }
            else
            {
                ListViewItem temp = lwStatus.Items[contact + " " + file];
                if (temp != null)
                {
                    if (temp.SubItems["progress"].Text.CompareTo("Finished") == 0 ||
                        temp.SubItems["progress"].Text.CompareTo("Canceled") == 0)
                    {
                        temp.SubItems["progress"].Text = "0";
                    }
                }
                else
                {
                    ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[3];

                    subItems[0] = new ListViewItem.ListViewSubItem();
                    subItems[0].Name = "contact";
                    subItems[0].Text = contact;

                    subItems[1] = new ListViewItem.ListViewSubItem();
                    subItems[1].Name = "file";
                    subItems[1].Text = file;

                    subItems[2] = new ListViewItem.ListViewSubItem();
                    subItems[2].Name = "progress";
                    subItems[2].Text = "0";

                    ListViewItem lvi = new ListViewItem(subItems, 0);

                    lvi.Name = contact + " " + file;
                    lwStatus.Items.Add(lvi);
                }
            }
        }

        public void CancelFileTransfer(string contact, string file)
        {
            if (this.InvokeRequired)
            {
                CancelFileTrasnferDelegate cftd = CancelFileTransfer;
                this.Invoke(cftd, new object[] { contact, file });
            }
            else
            {
                ListViewItem lvi = lwStatus.Items[contact + " " + file];
                if (lvi != null)
                {
                    lvi.SubItems["progress"].Text = "Canceled";
                }
            }
        }

        public void UpdateTransferProgress(string contact, string file, int progress)
        {
            if (this.InvokeRequired)
            {
                UpdateTransferProgressDelegate utpd = UpdateTransferProgress;
                this.Invoke(utpd, new object[] { contact, file, progress });
            }
            else
            {
                ListViewItem lvi = lwStatus.Items[contact + " " + file];
                if (lvi != null)
                {
                    ListViewItem.ListViewSubItem progressItem = lvi.SubItems["progress"];
                    if (progressItem.Text.CompareTo("" + progress) != 0)
                    {
                        progressItem.Text = "" + progress;
                    }
                }
            }            
        }

        public void FileTransferFinished(string contact, string file)
        {
            if (this.InvokeRequired)
            {
                FileTransferFinishedDelegate ftfd = FileTransferFinished;
                this.Invoke(ftfd, new object[] { contact, file });
            }
            else
            {
                ListViewItem lvi = lwStatus.Items[contact + " " + file];
                if (lvi != null)
                {
                    lvi.SubItems["progress"].Text = "Finished";
                }
            }
        }

        public void LoadList(string contact, IList<string> list) 
        {
            if (lwContacts.Items.ContainsKey(contact))
            {
                if (lwContacts.SelectedItems[0].Name != contact)
                {
                    lwContacts.SelectedItems[0].Selected = false;
                }

                lwContacts.Items[contact].Selected = true;

                foreach (string alias in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Name = alias;
                    lvi.Text = alias;
                    lwFileList.Items.Add(lvi);
                }
            }
        }

        private void ClearFileList() 
        {
            lwFileList.Items.Clear();
        }

        public void ShowView() 
        {
            this.Show();
        }

        public void HideView() 
        {
            this.Hide();
        }

        public void CloseView() 
        {
            this.Close();
        }

        #endregion

        #region Events
        
        public event ViewClosedEventHandler ViewClosedEvent;
        public event ContactSelectedEventHandler ContactSelectedEvent;
        public event GetContactListEventHandler GetContactListEvent;
        public event StartFileTransferEventHandler StartFileTransferEvent;
        public event CancelFileTransferEventHandler CancelFileTransferEvent;

        #endregion

        private void FileTransferView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            OnViewClosed();
        }

        private void lwContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwContacts.SelectedIndices.Count > 0) 
            {
                ClearFileList();
                OnContactSelected(lwContacts.SelectedItems[0].Name);
            }
        }

        private void lwContacts_ItemActivate(object sender, EventArgs e)
        {
            if (lwContacts.SelectedIndices.Count > 0)
            {
                ClearFileList();
                OnGetContactList(lwContacts.SelectedItems[0].Name);
            }
        }

        private void lwFileList_ItemActivate(object sender, EventArgs e)
        {
            if (lwFileList.SelectedIndices.Count > 0 && lwContacts.SelectedIndices.Count > 0)
            {
                string writeLocation = GetWriteLocation();
                if (writeLocation != null)
                {
                    OnStartFileTransfer(lwContacts.SelectedItems[0].Name, lwFileList.SelectedItems[0].Name, writeLocation);
                }
            }
        }

        private string GetWriteLocation()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            return browserDialog.SelectedPath;            
        }


        #region GUI Events

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using Common.Protocol;
using System.IO;
namespace GUI
{
    internal delegate void GUIUpdateProgressDelegate (object parameters);
    public partial class FileTransferView : Form,IFileTransferView
    {

        GUIUpdateProgressDelegate updateTransferDelegate;

        #region Constructors

        public FileTransferView()
        {
            InitializeComponent();
            updateTransferDelegate = new GUIUpdateProgressDelegate(this.InternalUpdateTransferProgress);
        }

        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
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
            ListViewItem lvi = new ListViewItem(new string[] { contact, file, "0" });
            lvi.Name = contact + file;
            lwFileList.Items.Add(lvi);            
        }

        public void CancelFileTransfer(string contact, string file)
        {
            if (lwFileList.Items.ContainsKey(contact + file))
            {

            }
        }

        public void UpdateTransferProgress(string contact, string file, int progress)
        {
            this.lwStatus.BeginInvoke(updateTransferDelegate, new object[] { contact, file, progress });
            //this.lwStatus.Invoke(InternalUpdateTransferProgress(new object[]{contact,file,progress}));
            
        }

        private void InternalUpdateTransferProgress(object parameters)
        {
            string contact = (string)((object[])parameters)[0];
            string file = (string)((object[])parameters)[1];
            int progress = (int)((object[])parameters)[2];
            ListViewItem item = this.lwStatus.Items[contact + "_" + file];
            item.SubItems[2].Text = progress.ToString();
        }

        public void FileTransferFinished(string contact, string file)
        {

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
                OnStartFileTransfer(lwContacts.SelectedItems[0].Name, lwFileList.SelectedItems[0].Name,writeLocation);
                ListViewItem newDownload = new ListViewItem(new string[]{lwContacts.SelectedItems[0].Name,lwFileList.SelectedItems[0].Name,"0"});
                newDownload.Name = lwContacts.SelectedItems[0].Name+"_"+lwFileList.SelectedItems[0].Name;
                lwStatus.Items.Add(newDownload);
            }
        }

        private string GetWriteLocation()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() != DialogResult.OK)
            {
                return "Downloads/";
            }
            return browserDialog.SelectedPath;            
        }


        #region GUI Events

        #endregion

    }
}

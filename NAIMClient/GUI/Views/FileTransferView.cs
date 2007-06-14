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
        #region Constructors
        
        public FileTransferView()
        {
            InitializeComponent();
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

        protected void OnStartFileTransfer(string contact, string file)
        {
            if (StartFileTransferEvent != null)
            {
                StartFileTransferEvent(contact, file);
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

        }


        #region GUI Events

        #endregion

    }
}

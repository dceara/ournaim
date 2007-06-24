using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
using Common.Protocol;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace GUI
{
    public partial class FileTransferView : Form,IFileTransferView
    {
        private TextureBrush progressBrush = new TextureBrush(Resources.progress_bar_texture);
        private TextureBrush progressBackBrush = new TextureBrush(Resources.progress_bar_back_texture);
        private Font progressTextFont = new Font("Arial", 8, FontStyle.Bold);
        private SolidBrush progressTextBrush = new SolidBrush(Color.White);

        #region Constructors

        public FileTransferView()
        {
            InitializeComponent();

            progressBrush.TranslateTransform(0, 3);
            progressBackBrush.TranslateTransform(0, 3);
            //progressBrush.WrapMode = WrapMode.Tile;
            //progressBackBrush.WrapMode = WrapMode.Tile;
        }

        #endregion

        #region Delegates

        private delegate void StartFileTransferDelegate(string contact, string file, string location);
        private delegate void CancelFileTrasnferDelegate(string contact, string file);
        private delegate void UpdateTransferProgressDelegate(string contact, string file, int progress, float speed);
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
                StartFileTransferEvent(contact, file, writeLocation);
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

        public void StartFileTransfer(string contact, string file, string location)
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
                    ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[5];

                    subItems[0] = new ListViewItem.ListViewSubItem();
                    subItems[0].Name = "contact";
                    subItems[0].Text = contact;

                    subItems[1] = new ListViewItem.ListViewSubItem();
                    subItems[1].Name = "file";
                    subItems[1].Text = file;

                    subItems[2] = new ListViewItem.ListViewSubItem();
                    subItems[2].Name = "speed";
                    subItems[2].Text = "0 kB/s";

                    subItems[3] = new ListViewItem.ListViewSubItem();
                    subItems[3].Name = "progress";
                    subItems[3].Text = "0";
                    subItems[3].Tag = (int)0;

                    subItems[4] = new ListViewItem.ListViewSubItem();
                    subItems[4].Name = "location";
                    subItems[4].Text = location;

                    ListViewItem lvi = new ListViewItem(subItems, 0);

                    lvi.Name = contact + " " + file;
                    lwStatus.Items.Insert(0, lvi);
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
                    lvi.SubItems["progress"].Tag = (int)0;
                }
            }
        }

        public void UpdateTransferProgress(string contact, string file, int progress, float speed)
        {
            if (this.InvokeRequired)
            {
                UpdateTransferProgressDelegate utpd = UpdateTransferProgress;
                this.Invoke(utpd, new object[] { contact, file, progress, speed });
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
                        progressItem.Tag = (int)progress;
                    }


                    ListViewItem.ListViewSubItem speedItem = lvi.SubItems["speed"];
                    if (DateTime.Now.Millisecond > 980 && speedItem.Text.CompareTo("" + (int)speed + " kB/s") != 0)
                    {
                        speedItem.Text = "" + (int)speed + " kB/s";
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
                    lvi.SubItems["progress"].Tag = (int)0;
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

        private void lwStatus_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lwStatus_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.SubItem.Name.CompareTo("progress") == 0)
            {
                if (e.SubItem.Text.CompareTo("Finished") == 0)
                {
                    e.Graphics.FillRectangle(progressBrush, e.Bounds);
                    string progressText = "Finished";
                    SizeF textSize = e.Graphics.MeasureString(progressText, progressTextFont);
                    PointF textLocation = new PointF(e.Bounds.Left + 5, (float)e.Bounds.Top + ((float)e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString("Finished", progressTextFont, progressTextBrush, textLocation);
                }
                else if (e.SubItem.Text.CompareTo("Canceled") == 0)
                {
                    e.Graphics.FillRectangle(progressBackBrush, e.Bounds);
                    string progressText = "Canceled";
                    SizeF textSize = e.Graphics.MeasureString(progressText, progressTextFont);
                    PointF textLocation = new PointF(e.Bounds.Left + 3, (float)e.Bounds.Top + ((float)e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString("Finished", progressTextFont, progressTextBrush, textLocation);
                }
                else
                {
                    int progress = (int)e.SubItem.Tag;

                    Rectangle progressBar = e.Bounds;
                    progressBar.Width = e.Bounds.Width * progress / 100;

                    e.Graphics.FillRectangle(progressBackBrush, e.Bounds);
                    e.Graphics.FillRectangle(progressBrush, progressBar);

                    string progressText = "" + progress + "%";
                    SizeF textSize = e.Graphics.MeasureString(progressText, progressTextFont);
                    PointF textLocation = new PointF((float)e.Bounds.Left + ((float)e.Bounds.Width - textSize.Width) / 2, (float)e.Bounds.Top + ((float)e.Bounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(progressText, progressTextFont, progressTextBrush, textLocation);
                }
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void lwStatus_MouseDown(object sender, MouseEventArgs e)
        {
            tsmiCancel.Enabled = false;
            tsmiRestart.Enabled = false;

            if (lwStatus.SelectedIndices.Count > 0)
            {
                cmsStatus.Visible = true;
            }
            else
            {
                cmsStatus.Visible = false;
            }

            foreach(ListViewItem lvi in lwStatus.SelectedItems)
            {
                if (lvi.SubItems["progress"].Text.CompareTo("Finished") == 0 ||
                    lvi.SubItems["progress"].Text.CompareTo("Canceled") == 0)
                {
                    tsmiRestart.Enabled = true;
                }
                else
                {
                    tsmiCancel.Enabled = true;
                }

                if (tsmiCancel.Enabled == true && tsmiRestart.Enabled == true)
                {
                    break;
                }
            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lwStatus.SelectedItems)
            {
                ListViewItem.ListViewSubItem lvsi = lvi.SubItems["progress"];
                if (lvsi != null &&
                    lvsi.Text.CompareTo("Finished") != 0 &&
                    lvsi.Text.CompareTo("Canceled") != 0)
                {
                    OnCancelFileTransfer(lvi.SubItems["contact"].Text, lvi.SubItems["file"].Text);
                }
            }
        }

        private void tsmiRestart_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lwStatus.SelectedItems)
            {
                ListViewItem.ListViewSubItem lvsi = lvi.SubItems["progress"];
                if (lvsi != null && 
                    (lvsi.Text.CompareTo("Finished") == 0 ||
                     lvsi.Text.CompareTo("Canceled") == 0))
                {
                    OnStartFileTransfer(lvi.SubItems["contact"].Text, lvi.SubItems["file"].Text, lvi.SubItems["location"].Text);
                }
            }
        }


        #region GUI Events

        #endregion

    }
}

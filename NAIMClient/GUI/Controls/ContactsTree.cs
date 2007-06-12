using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Common.Protocol;

namespace GUI.Controls
{
    public class ContactsTree : TreeView
    {
        Color   DEFAULT_GROUPS_COLOR            = Color.RoyalBlue;
        Color   DEFAULT_ONLINE_CONTACT_COLOR    = Color.Black;
        Color   DEFAULT_OFFLINE_CONTACT_COLOR   = Color.Black;
        Color   DEFAULT_INVISIBLE_CONTACT_COLOR = Color.Black;
        Font    DEFAULT_GROUPS_FONT             = new Font("Arial", 9, FontStyle.Bold);        
        Font    DEFAULT_ONLINE_CONTACT_FONT     = new Font("Arial", 9, FontStyle.Bold);
        Font    DEFAULT_OFFLINE_CONTACT_FONT    = new Font("Arial", 9, FontStyle.Regular);
        Font    DEFAULT_INVISIBLE_CONTACT_FONT  = new Font("Arial", 9, FontStyle.Italic);

        private Color _groupsColor;
        public Color GroupsColor
        {
            get { return _groupsColor; }
            set { _groupsColor = value; }
        }

        private Color _onlineContactColor;
        public Color OnlineContactColor
        {
            get { return _onlineContactColor; }
            set { _onlineContactColor = value; }
        }

        private Color _offlineContactColor;
        public Color OfflineContactColor
        {
            get { return _offlineContactColor; }
            set { _offlineContactColor = value; }
        }

        private Color _invisibleContactColor;
        public Color InvisibleContactColor
        {
            get { return _invisibleContactColor; }
            set { _invisibleContactColor = value; }
        }

        private Font _groupsFont;
        public Font GroupsFont
        {
            get { return _groupsFont; }
            set { _groupsFont = value; }
        }

        private Font _onlineContactFont;
        public Font OnlineContactFont
        {
            get { return _onlineContactFont; }
            set { _onlineContactFont = value; }
        }

        private Font _offlineContactFont;
        public Font OfflineContactFont
        {
            get { return _offlineContactFont; }
            set { _offlineContactFont = value; }
        }

        private Font _invisibleContactFont;
        public Font InvisibleContactFont
        {
            get { return _invisibleContactFont; }
            set { _invisibleContactFont = value; }
        }



        private System.ComponentModel.IContainer components;
        private ContextMenuStrip cmsContacts;
        private ToolStripMenuItem tsmiDeleteContact;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSendMessage;


        ImageList icons = new ImageList();


        public ContactsTree() {
            _groupsColor = DEFAULT_GROUPS_COLOR;
            _onlineContactColor = DEFAULT_ONLINE_CONTACT_COLOR;
            _offlineContactColor = DEFAULT_OFFLINE_CONTACT_COLOR;
            _invisibleContactColor = DEFAULT_INVISIBLE_CONTACT_COLOR;

            _groupsFont = DEFAULT_GROUPS_FONT;
            _onlineContactFont = DEFAULT_ONLINE_CONTACT_FONT;
            _offlineContactFont = DEFAULT_OFFLINE_CONTACT_FONT;
            _invisibleContactFont = DEFAULT_INVISIBLE_CONTACT_FONT;

            this.ImageList = icons;

        }

        public void Initialize() {
            icons.Images.Add(Icons.IconNoImage);
            icons.Images.Add(Icons.IconOnline);
            icons.Images.Add(Icons.IconOffline);

            InitializeComponent();
        }

        public void LoadContacts(IList<string> groupNames, IDictionary<string,IList<UserListEntry>> contactsByGroups) {
            Nodes.Clear();

            BeginUpdate();

            foreach (string group in groupNames)
            {
                TreeNode groupNode = new TreeNode();                
                groupNode.ForeColor = _groupsColor;
                groupNode.Name = group;
                groupNode.NodeFont = _groupsFont;
                groupNode.Text = group;
                groupNode.ImageIndex = -1;
                groupNode.SelectedImageIndex = -1;
                int nodeIndex = Nodes.Add(groupNode);


                IList<UserListEntry> contacts = contactsByGroups[group];

                foreach (UserListEntry contact in contacts)
                {
                    TreeNode contactNode = new TreeNode();
                    contactNode.Name = contact.UserName;
                    contactNode.ContextMenuStrip = cmsContacts;

                    if (contact.Availability)
                    {
                        contactNode.NodeFont = _onlineContactFont;
                        contactNode.ForeColor = _onlineContactColor;
                        contactNode.ImageIndex = 1;
                        contactNode.SelectedImageIndex = 1;
                        contactNode.Text = contact.UserName + " - " + contact.Status;
                        contactNode.ToolTipText = contact.Status;
                    }
                    else
                    {
                        contactNode.NodeFont = _offlineContactFont;
                        contactNode.ForeColor = _offlineContactColor;
                        contactNode.ImageIndex = 2;
                        contactNode.SelectedImageIndex = 2;
                        contactNode.Text = contact.UserName;
                    }
                    Nodes[nodeIndex].Nodes.Add(contactNode);
                }

                Nodes[nodeIndex].Expand();
            }

            // Reset the cursor to the default for all controls.
            Cursor.Current = Cursors.Default;

            // Begin repainting the TreeView.
            EndUpdate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            TreeNode selectedNode = GetNodeAt(e.Location);
            SelectedNode = selectedNode;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsContacts
            // 
            this.cmsContacts.BackColor = System.Drawing.Color.MintCream;
            this.cmsContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSendMessage,
            this.toolStripSeparator1,
            this.tsmiDeleteContact});
            this.cmsContacts.Name = "contextMenuStrip1";
            this.cmsContacts.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsContacts.ShowImageMargin = false;
            this.cmsContacts.Size = new System.Drawing.Size(195, 54);
            // 
            // tsmiDeleteContact
            // 
            this.tsmiDeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiDeleteContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiDeleteContact.Name = "tsmiDeleteContact";
            this.tsmiDeleteContact.Size = new System.Drawing.Size(194, 22);
            this.tsmiDeleteContact.Text = "Delete contact";
            this.tsmiDeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiSendMessage
            // 
            this.tsmiSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiSendMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiSendMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsmiSendMessage.Name = "tsmiSendMessage";
            this.tsmiSendMessage.Size = new System.Drawing.Size(194, 22);
            this.tsmiSendMessage.Text = "Send instant message...";
            this.tsmiSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactsTree
            // 
            this.LineColor = System.Drawing.Color.Black;
            this.cmsContacts.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

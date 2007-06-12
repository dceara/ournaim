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
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip cmsContacts;
        private ToolStripMenuItem tsmiDeleteContact;
    
        public Font InvisibleContactFont
        {
            get { return _invisibleContactFont; }
            set { _invisibleContactFont = value; }
        }

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
            this.cmsContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsContacts
            // 
            this.cmsContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteContact});
            this.cmsContacts.Name = "contextMenuStrip1";
            this.cmsContacts.Size = new System.Drawing.Size(156, 26);
            // 
            // tsmiDeleteContact
            // 
            this.tsmiDeleteContact.Name = "tsmiDeleteContact";
            this.tsmiDeleteContact.Size = new System.Drawing.Size(155, 22);
            this.tsmiDeleteContact.Text = "Delete contact";
            this.cmsContacts.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

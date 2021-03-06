using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Common.Protocol;
using System.Collections;

namespace GUI.Controls
{
    public delegate void ContactTreeAddContactToGroup(string group);
    public delegate void ContactTreeRemoveContact(string contact);
    public delegate void ContactTreeAddGroup();
    public delegate void ContactTreeRemoveGroup(string contact);
    public delegate void ContactTreeMoveContact(string contact, string destinationGroup);
    public delegate void ContactTreeSendInstantMessage(string contact);

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

        string  DEFAULT_GROUP_IMAGE             = "face";

        #region Properties
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

        private string _groupImage;
        public string GroupImage
        {
            get { return _groupImage; }
            set { _groupImage = value; }
        }
        #endregion

        private int _onlineContactImageIndex = 1;
        private int _offlineContactImageIndex = 2;
        private int _groupImageIndex;
        private bool _showingOfflineContacts = true;

        private System.ComponentModel.IContainer components;
        private ContextMenuStrip cmsContacts;
        private ToolStripMenuItem tsmiDeleteContact;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSendMessage;
        private ContextMenuStrip cmsGroups;
        private ToolStripMenuItem tsmiAddContact;
        private ToolStripMenuItem tsmiChangeIcon;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiDeleteGroup;


        ImageList _icons = new ImageList();
        private ToolStripMenuItem tsmiAddGroup;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        TreeNode _offlineContactsRoot = new TreeNode();


        #region Events

        public event ContactTreeAddContactToGroup ContactTreeAddContactToGroup;
        public event ContactTreeRemoveContact ContactTreeRemoveContact;
        public event ContactTreeRemoveGroup ContactTreeRemoveGroup;
        public event ContactTreeMoveContact ContactTreeMoveContact;
        public event ContactTreeAddGroup ContactTreeAddGroup;
        public event ContactTreeSendInstantMessage ContactTreeSendInstantMessage;

        #endregion

        #region Constructor

        public ContactsTree() {
            _groupsColor = DEFAULT_GROUPS_COLOR;
            _onlineContactColor = DEFAULT_ONLINE_CONTACT_COLOR;
            _offlineContactColor = DEFAULT_OFFLINE_CONTACT_COLOR;
            _invisibleContactColor = DEFAULT_INVISIBLE_CONTACT_COLOR;

            _groupsFont = DEFAULT_GROUPS_FONT;
            _onlineContactFont = DEFAULT_ONLINE_CONTACT_FONT;
            _offlineContactFont = DEFAULT_OFFLINE_CONTACT_FONT;
            _invisibleContactFont = DEFAULT_INVISIBLE_CONTACT_FONT;

            _groupImage = DEFAULT_GROUP_IMAGE;

            ItemDrag += new ItemDragEventHandler(ContactsTree_ItemDrag);
            DragEnter += new DragEventHandler(ContactsTree_DragEnter);
            DragDrop += new DragEventHandler(ContactsTree_DragDrop);

            _icons.ImageSize = new Size(16, 16);

            this.ImageList = _icons;

        }
        
        #endregion

        #region Members
        public void Initialize() {
           
            _icons.Images.Add("noimage", Icons.IconNoImage);
            _icons.Images.Add("online", Icons.IconOnline);
            _icons.Images.Add("offline", Icons.IconOffline);
            _icons.Images.Add("bunny", Icons.bunny);
            _icons.Images.Add("face", Icons.face);
            _icons.Images.Add("flower", Icons.flower);
            _icons.Images.Add("globe", Icons.globe);
            _icons.Images.Add("group", Icons.group);
            _icons.Images.Add("hypo", Icons.hypo);
            _icons.Images.Add("nova", Icons.nova);
            _icons.Images.Add("polka", Icons.polka);
            _icons.Images.Add("rotten", Icons.rotten);
            _icons.Images.Add("trek", Icons.trek);

            _groupImageIndex = _icons.Images.IndexOfKey(_groupImage);
            if (_groupImageIndex == -1)
                _groupImageIndex = 0;



            InitializeComponent();

            toolStripMenuItem1.Image = Icons.bunny.ToBitmap();
            toolStripMenuItem1.Text = "bunny";
            toolStripMenuItem2.Image = Icons.face.ToBitmap();
            toolStripMenuItem2.Text = "face";
            toolStripMenuItem3.Image = Icons.flower.ToBitmap();
            toolStripMenuItem3.Text = "flower";
            toolStripMenuItem4.Image = Icons.globe.ToBitmap();
            toolStripMenuItem4.Text = "globe";
            toolStripMenuItem5.Image = Icons.group.ToBitmap();
            toolStripMenuItem5.Text = "group";
            toolStripMenuItem6.Image = Icons.hypo.ToBitmap();
            toolStripMenuItem6.Text = "hypo";
            toolStripMenuItem7.Image = Icons.nova.ToBitmap();
            toolStripMenuItem7.Text = "nova";
            toolStripMenuItem8.Image = Icons.polka.ToBitmap();
            toolStripMenuItem8.Text = "polka";
            toolStripMenuItem9.Image = Icons.rotten.ToBitmap();
            toolStripMenuItem9.Text = "rotten";
            toolStripMenuItem10.Image = Icons.trek.ToBitmap();
            toolStripMenuItem10.Text = "trek";
        }

        public void Clear() 
        {
            Nodes.Clear();
            _offlineContactsRoot.Nodes.Clear();
            _showingOfflineContacts = true;
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
                groupNode.ImageIndex = _groupImageIndex;
                groupNode.SelectedImageIndex = _groupImageIndex;
                groupNode.ContextMenuStrip = cmsGroups;
                int nodeIndex = Nodes.Add(groupNode);
                int offlineNodeIndex = _offlineContactsRoot.Nodes.Add((TreeNode)groupNode.Clone());

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
                        contactNode.ImageIndex = _onlineContactImageIndex;
                        contactNode.SelectedImageIndex = _onlineContactImageIndex;
                        contactNode.Text = contact.UserName + " - " + contact.Status;
                        contactNode.ToolTipText = contact.Status;
                        
                        Nodes[nodeIndex].Nodes.Add(contactNode);
                    }
                    else
                    {
                        contactNode.NodeFont = _offlineContactFont;
                        contactNode.ForeColor = _offlineContactColor;
                        contactNode.ImageIndex = _offlineContactImageIndex;
                        contactNode.SelectedImageIndex = _offlineContactImageIndex;
                        contactNode.Text = contact.UserName;

                        if (_showingOfflineContacts)
                        {
                            Nodes[nodeIndex].Nodes.Add(contactNode);
                        }
                        else
                        {
                            _offlineContactsRoot.Nodes[offlineNodeIndex].Nodes.Add(contactNode);
                        }
                    }

                }

                Nodes[nodeIndex].Expand();
            }

            // Reset the cursor to the default for all controls.
            Cursor.Current = Cursors.Default;

            // Begin repainting the TreeView.
            EndUpdate();
        }

        public void ChangeContactStatus(string contact, string status) {
            BeginUpdate();
            foreach (TreeNode group in Nodes) {
                TreeNode contactNode = group.Nodes[contact];
                if (contactNode != null && contactNode.ImageIndex == _onlineContactImageIndex) {
                    contactNode.Text = contact + " - " + status;
                    contactNode.ToolTipText = status;
                    break;
                }
            }
            EndUpdate();
        }

        public void AddContact(string contact, string group) {
            BeginUpdate();
            TreeNode contactNode = new TreeNode();
            contactNode.Name = contact;
            contactNode.NodeFont = _offlineContactFont;
            contactNode.ForeColor = _offlineContactColor;
            contactNode.ImageIndex = _offlineContactImageIndex;
            contactNode.SelectedImageIndex = _offlineContactImageIndex;
            contactNode.Text = contact;
            contactNode.ContextMenuStrip = cmsContacts;

            TreeNode groupNode = Nodes[group];
            if (groupNode != null && Nodes[group].Nodes[contact] == null)
            {
                if (_showingOfflineContacts)
                {
                    groupNode.Nodes.Add(contactNode);
                    groupNode.Expand();
                }
                else
                {
                    TreeNode offlineGroupNode = _offlineContactsRoot.Nodes[group];
                    if (offlineGroupNode != null && _offlineContactsRoot.Nodes[group].Nodes[contact] == null)
                    {
                        offlineGroupNode.Nodes.Add(contactNode);
                    }
                }
            }
            EndUpdate();
        }

        public void RemoveContact(string contact)
        {
            foreach (TreeNode group in Nodes)
            {
                if (group.Nodes[contact] != null)
                {
                    group.Nodes.Remove(group.Nodes[contact]);
                    return;
                }
            }
            foreach (TreeNode group in _offlineContactsRoot.Nodes)
            {
                if (group.Nodes[contact] != null)
                {
                    group.Nodes.Remove(group.Nodes[contact]);
                    return;
                }
            }
        }

        public void AddGroup(string group)
        {
            BeginUpdate();
            TreeNode groupNode = new TreeNode();
            groupNode.ForeColor = _groupsColor;
            groupNode.Name = group;
            groupNode.NodeFont = _groupsFont;
            groupNode.Text = group;
            groupNode.ImageIndex = _groupImageIndex;
            groupNode.SelectedImageIndex = _groupImageIndex;
            groupNode.ContextMenuStrip = cmsGroups;
            int nodeIndex = Nodes.Add(groupNode);
            int offlineNodeIndex = _offlineContactsRoot.Nodes.Add((TreeNode)groupNode.Clone());
            EndUpdate();
        }

        public void RemoveGroup(string group)
        {
            if (Nodes[group].Nodes.Count == 0) 
            {
                Nodes.Remove(Nodes[group]);
            }
        }

        public void ContactOnline(string contact, string status) {
            BeginUpdate();
            foreach (TreeNode group in Nodes)
            {
                TreeNode contactNode = group.Nodes[contact];
                if (contactNode != null)
                {
                    contactNode.NodeFont = _onlineContactFont;
                    contactNode.ForeColor = _onlineContactColor;
                    contactNode.ImageIndex = _onlineContactImageIndex;
                    contactNode.SelectedImageIndex = _onlineContactImageIndex;
                    contactNode.Text = contact + " - " + status;
                    contactNode.ToolTipText = status;

                    break;
                }
            }
            
            // if the node is in the offline tree than _showOfflineContacts is true
            foreach (TreeNode group in _offlineContactsRoot.Nodes)
            {
                TreeNode contactNode = group.Nodes[contact];
                if (contactNode != null)
                {
                    contactNode.NodeFont = _onlineContactFont;
                    contactNode.ForeColor = _onlineContactColor;
                    contactNode.ImageIndex = _onlineContactImageIndex;
                    contactNode.SelectedImageIndex = _onlineContactImageIndex;
                    contactNode.Text = contact + " - " + status;
                    contactNode.ToolTipText = status;

                    group.Nodes.Remove(contactNode);
                    Nodes[group.Name].Nodes.Add(contactNode);
                    Nodes[group.Name].Expand();

                    break;
                }
            }
            EndUpdate();
        }

        public void ContactOffline(string contact)
        {
            BeginUpdate();
            foreach (TreeNode group in Nodes)
            {
                TreeNode contactNode = group.Nodes[contact];
                if (contactNode != null)
                {
                    contactNode.NodeFont = _offlineContactFont;
                    contactNode.ForeColor = _offlineContactColor;
                    contactNode.ImageIndex = _offlineContactImageIndex;
                    contactNode.SelectedImageIndex = _offlineContactImageIndex;
                    contactNode.Text = contact;
                    contactNode.ToolTipText = string.Empty;
                }

                if (!_showingOfflineContacts)
                {
                    group.Nodes.Remove(contactNode);
                    _offlineContactsRoot.Nodes[group.Name].Nodes.Add(contactNode);
                    group.Expand();
                }
            }
            EndUpdate();
        }

        public string[] GetGroups() {
            string[] groups = new string[Nodes.Count];
            
            for (int i = 0; i < Nodes.Count; ++i) 
            {
                groups[i] = Nodes[i].Name;
            }

            return groups;
        }

        public void ShowHideOfflineContacts() 
        {            
            BeginUpdate();
         
            if (_showingOfflineContacts)
            {
                foreach (TreeNode group in Nodes) 
                {
                    for (int i = group.Nodes.Count - 1; i >= 0; --i)
                    {
                        TreeNode contact = group.Nodes[i];
                        if (contact.ImageIndex == _offlineContactImageIndex)
                        {
                            contact.Remove();
                            _offlineContactsRoot.Nodes[group.Name].Nodes.Add(contact);
                        }
                    }
                }

                _showingOfflineContacts = false;
            }
            else
            {
                foreach (TreeNode group in _offlineContactsRoot.Nodes)
                {
                    for (int i = group.Nodes.Count - 1; i >= 0; --i)
                    {
                        TreeNode contact = group.Nodes[i];
                        contact.Remove();
                        Nodes[group.Name].Nodes.Add(contact);
                    }                 
                }

                _showingOfflineContacts = true;
            }

            EndUpdate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            TreeNode selectedNode = GetNodeAt(e.Location);
            SelectedNode = selectedNode;
            if (selectedNode != null && selectedNode.Level == 0) 
            {
                if (selectedNode.Nodes.Count > 0 || _offlineContactsRoot.Nodes[selectedNode.Name].Nodes.Count > 0) 
                {
                    tsmiDeleteGroup.Enabled = false;
                }
                else
                {
                    tsmiDeleteGroup.Enabled = true;
                }
            }
        }

        protected void OnAddContactToGroup(string group) 
        {
            if (ContactTreeAddContactToGroup != null) 
            {
                ContactTreeAddContactToGroup(group);
            }
        }

        protected void OnRemoveContact(string contact)
        {
            if (ContactTreeRemoveContact != null)
            {
                ContactTreeRemoveContact(contact);
            }
        }

        protected void OnAddGroup()
        {
            if (ContactTreeAddGroup != null)
            {
                ContactTreeAddGroup();
            }
        }

        protected void OnRemoveGroup (string group)
        {
            if (ContactTreeRemoveGroup != null)
            {
                ContactTreeRemoveGroup(group);
            }
        }

        protected void OnMoveContact(string contact, string destinationGroup)
        {
            if (ContactTreeMoveContact != null)
            {
                ContactTreeMoveContact(contact, destinationGroup);
            }
        }

        protected void OnSendInstantMessage(string contact)
        {
            if (ContactTreeSendInstantMessage != null)
            {
                ContactTreeSendInstantMessage(contact);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsContacts.SuspendLayout();
            this.cmsGroups.SuspendLayout();
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
            // tsmiSendMessage
            // 
            this.tsmiSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiSendMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiSendMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsmiSendMessage.Name = "tsmiSendMessage";
            this.tsmiSendMessage.Size = new System.Drawing.Size(194, 22);
            this.tsmiSendMessage.Text = "Send instant message...";
            this.tsmiSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiSendMessage.Click += new System.EventHandler(this.tsmiSendMessage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiDeleteContact
            // 
            this.tsmiDeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmiDeleteContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiDeleteContact.Name = "tsmiDeleteContact";
            this.tsmiDeleteContact.Size = new System.Drawing.Size(194, 22);
            this.tsmiDeleteContact.Text = "Delete contact";
            this.tsmiDeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiDeleteContact.Click += new System.EventHandler(this.tsmiDeleteContact_Click);
            // 
            // cmsGroups
            // 
            this.cmsGroups.BackColor = System.Drawing.Color.MintCream;
            this.cmsGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddContact,
            this.tsmiAddGroup,
            this.tsmiChangeIcon,
            this.toolStripSeparator2,
            this.tsmiDeleteGroup});
            this.cmsGroups.Name = "cmsGroups";
            this.cmsGroups.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsGroups.ShowImageMargin = false;
            this.cmsGroups.Size = new System.Drawing.Size(154, 98);
            // 
            // tsmiAddContact
            // 
            this.tsmiAddContact.BackColor = System.Drawing.Color.MintCream;
            this.tsmiAddContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiAddContact.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAddContact.Name = "tsmiAddContact";
            this.tsmiAddContact.Size = new System.Drawing.Size(153, 22);
            this.tsmiAddContact.Text = "Add Contact...";
            this.tsmiAddContact.Click += new System.EventHandler(this.tsmiAddContact_Click);
            // 
            // tsmiAddGroup
            // 
            this.tsmiAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAddGroup.Name = "tsmiAddGroup";
            this.tsmiAddGroup.Size = new System.Drawing.Size(153, 22);
            this.tsmiAddGroup.Text = "Add Group...";
            this.tsmiAddGroup.Click += new System.EventHandler(this.tsmiAddGroup_Click);
            // 
            // tsmiChangeIcon
            // 
            this.tsmiChangeIcon.BackColor = System.Drawing.Color.MintCream;
            this.tsmiChangeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiChangeIcon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.tsmiChangeIcon.Name = "tsmiChangeIcon";
            this.tsmiChangeIcon.Size = new System.Drawing.Size(153, 22);
            this.tsmiChangeIcon.Text = "Change Group Icon";
            this.tsmiChangeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // tsmiDeleteGroup
            // 
            this.tsmiDeleteGroup.BackColor = System.Drawing.Color.MintCream;
            this.tsmiDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiDeleteGroup.Name = "tsmiDeleteGroup";
            this.tsmiDeleteGroup.Size = new System.Drawing.Size(153, 22);
            this.tsmiDeleteGroup.Text = "Delete Group";
            this.tsmiDeleteGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiDeleteGroup.Click += new System.EventHandler(this.tsmiDeleteGroup_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem6.Text = "toolStripMenuItem6";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem7.Text = "toolStripMenuItem7";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem8.Text = "toolStripMenuItem8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem9.Text = "toolStripMenuItem9";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem10.Text = "toolStripMenuItem10";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // ContactsTree
            // 
            this.LineColor = System.Drawing.Color.Black;
            this.cmsContacts.ResumeLayout(false);
            this.cmsGroups.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        #region Event Handlers

        void ContactsTree_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);
                TreeNode sourceNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (destinationNode.TreeView == sourceNode.TreeView)
                {
                    if (destinationNode.Level == 0 && sourceNode.Parent != destinationNode)
                    {
                        sourceNode.Remove();

                        destinationNode.Nodes.Add(sourceNode);
                        // there's a bug in Nodes.Add i think, or Treenode.Clone.
                        // Clone doesn't copy the width of the node and when the node is added the
                        // width is not set appropriately.
                        sourceNode.Text = sourceNode.Text;
                        destinationNode.Expand();
                        OnMoveContact(sourceNode.Name, destinationNode.Name);
                    }
                    else if (destinationNode.Level == 1 && destinationNode.Parent != sourceNode.Parent)
                    {
                        sourceNode.Remove();

                        destinationNode.Parent.Nodes.Add(sourceNode);
                        sourceNode.Text = sourceNode.Text;
                        destinationNode.Parent.Expand();
                        OnMoveContact(sourceNode.Name, destinationNode.Parent.Name);
                    }
                }
            }
        }

        void ContactsTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void ContactsTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (((TreeNode)e.Item).Parent != null)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void tsmiAddContact_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                OnAddContactToGroup(SelectedNode.Name);
            }
        }

        private void tsmiDeleteContact_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                OnRemoveContact(SelectedNode.Name);
            }
        }

        private void tsmiAddGroup_Click(object sender, EventArgs e)
        {
            OnAddGroup();
        }

        private void tsmiDeleteGroup_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                OnRemoveGroup(SelectedNode.Name);
            }            
        }

        private void tsmiSendMessage_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                OnSendInstantMessage(SelectedNode.Name);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("bunny");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("bunny");
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("trek");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("trek");
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("face");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("face");
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("flower");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("flower");
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("globe");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("globe");
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("group");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("group");
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("hypo");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("hypo");
            }

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("nova");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("nova");
            }

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("polka");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("polka");
            }

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                SelectedNode.ImageIndex = _icons.Images.IndexOfKey("rotten");
                SelectedNode.SelectedImageIndex = _icons.Images.IndexOfKey("rotten");
            }

        }

        #endregion
    }
}

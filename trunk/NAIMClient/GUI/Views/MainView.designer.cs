using System.Windows.Forms;
namespace GUI
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTransferManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOfflineContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatuses = new System.Windows.Forms.ComboBox();
            this.pictureBoxPoza = new System.Windows.Forms.PictureBox();
            this.ctvContacts = new GUI.Controls.ContactsTree();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Location = new System.Drawing.Point(168, 385);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 21);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(84, 293);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(159, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "ana";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(84, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "pass";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(84, 271);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 19);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(84, 316);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Location = new System.Drawing.Point(84, 385);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 21);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.accountInformationToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.shareFilesToolStripMenuItem,
            this.fileTransferManagerToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.statusToolStripMenuItem.Text = "&Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.accountInformationToolStripMenuItem.Text = "Account &Information";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // shareFilesToolStripMenuItem
            // 
            this.shareFilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.shareFilesToolStripMenuItem.Name = "shareFilesToolStripMenuItem";
            this.shareFilesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shareFilesToolStripMenuItem.Text = "Share &Files";
            // 
            // fileTransferManagerToolStripMenuItem
            // 
            this.fileTransferManagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.fileTransferManagerToolStripMenuItem.Name = "fileTransferManagerToolStripMenuItem";
            this.fileTransferManagerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fileTransferManagerToolStripMenuItem.Text = "File &Transfer Manager";
            this.fileTransferManagerToolStripMenuItem.Click += new System.EventHandler(this.btnFileManager_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.signOutToolStripMenuItem.Text = "Sign &Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.showOfflineContactsToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contactsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.addToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addToolStripMenuItem.Text = "&Add Contact";
            this.addToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.addToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.addGroupToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addGroupToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addGroupToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addGroupToolStripMenuItem.Text = "Add &Group";
            this.addGroupToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGroupToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.addGroupToolStripMenuItem_Click);
            // 
            // showOfflineContactsToolStripMenuItem
            // 
            this.showOfflineContactsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.showOfflineContactsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showOfflineContactsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showOfflineContactsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showOfflineContactsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showOfflineContactsToolStripMenuItem.Name = "showOfflineContactsToolStripMenuItem";
            this.showOfflineContactsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showOfflineContactsToolStripMenuItem.Text = "Show O&ffline Contacts";
            this.showOfflineContactsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showOfflineContactsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.showOfflineContactsToolStripMenuItem.Click += new System.EventHandler(this.showOfflineContactsToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.viewArchiveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewArchiveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewArchiveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewArchiveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewArchiveToolStripMenuItem.Text = "&View Archive";
            this.viewArchiveToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewArchiveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.deleteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteToolStripMenuItem.Text = "&Delete Contact";
            this.deleteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // cbStatuses
            // 
            this.cbStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatuses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStatuses.FormattingEnabled = true;
            this.cbStatuses.Items.AddRange(new object[] {
            "Available",
            "Busy",
            "Stepped Out",
            "Be Right Back",
            "Not At My Desk",
            "New Status Message..."});
            this.cbStatuses.Location = new System.Drawing.Point(55, 27);
            this.cbStatuses.Name = "cbStatuses";
            this.cbStatuses.Size = new System.Drawing.Size(260, 21);
            this.cbStatuses.TabIndex = 15;
            this.cbStatuses.SelectedIndexChanged += new System.EventHandler(this.cbStatuses_SelectedIndexChanged);
            // 
            // pictureBoxPoza
            // 
            this.pictureBoxPoza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPoza.Location = new System.Drawing.Point(84, 89);
            this.pictureBoxPoza.Name = "pictureBoxPoza";
            this.pictureBoxPoza.Size = new System.Drawing.Size(159, 133);
            this.pictureBoxPoza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoza.TabIndex = 16;
            this.pictureBoxPoza.TabStop = false;
            // 
            // ctvContacts
            // 
            this.ctvContacts.AllowDrop = true;
            this.ctvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctvContacts.GroupImage = "group";
            this.ctvContacts.GroupsColor = System.Drawing.Color.RoyalBlue;
            this.ctvContacts.GroupsFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ctvContacts.HotTracking = true;
            this.ctvContacts.ImageIndex = 0;
            this.ctvContacts.Indent = 19;
            this.ctvContacts.InvisibleContactColor = System.Drawing.Color.Black;
            this.ctvContacts.InvisibleContactFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.ctvContacts.ItemHeight = 20;
            this.ctvContacts.Location = new System.Drawing.Point(6, 54);
            this.ctvContacts.Name = "ctvContacts";
            this.ctvContacts.OfflineContactColor = System.Drawing.Color.Black;
            this.ctvContacts.OfflineContactFont = new System.Drawing.Font("Arial", 9F);
            this.ctvContacts.OnlineContactColor = System.Drawing.Color.Black;
            this.ctvContacts.OnlineContactFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ctvContacts.SelectedImageIndex = 0;
            this.ctvContacts.ShowLines = false;
            this.ctvContacts.ShowNodeToolTips = true;
            this.ctvContacts.Size = new System.Drawing.Size(316, 648);
            this.ctvContacts.TabIndex = 14;
            this.ctvContacts.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctvContacts_NodeMouseDoubleClick);
            // 
            // MainView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(327, 706);
            this.Controls.Add(this.pictureBoxPoza);
            this.Controls.Add(this.cbStatuses);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ctvContacts);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(335, 733);
            this.Name = "MainView";
            this.Text = "NAIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button btnSignIn;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnSignUp;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem shareFilesToolStripMenuItem;
        private ToolStripMenuItem fileTransferManagerToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem contactsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem addGroupToolStripMenuItem;
        private ToolStripMenuItem showOfflineContactsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private Label lblStatus;
        private GUI.Controls.ContactsTree ctvContacts;
        private ComboBox cbStatuses;
        private ToolStripMenuItem viewArchiveToolStripMenuItem;
        private PictureBox pictureBoxPoza;
    }
}

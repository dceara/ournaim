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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Contact1"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaptionText, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Contact2"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaptionText, null);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAddConversation = new System.Windows.Forms.Button();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.status_label = new System.Windows.Forms.Label();
            this.status_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Location = new System.Drawing.Point(67, 227);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(83, 23);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAddConversation
            // 
            this.btnAddConversation.Location = new System.Drawing.Point(12, 389);
            this.btnAddConversation.Name = "btnAddConversation";
            this.btnAddConversation.Size = new System.Drawing.Size(125, 24);
            this.btnAddConversation.TabIndex = 1;
            this.btnAddConversation.Text = "Add Conversation View";
            this.btnAddConversation.UseVisualStyleBackColor = true;
            this.btnAddConversation.Click += new System.EventHandler(this.btnAddConversation_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(110, 201);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(80, 21);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(57, 84);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(104, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(57, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(104, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(76, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 19);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(81, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(29, 201);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 20);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(219, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
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
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.statusToolStripMenuItem.Text = "&Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.accountInformationToolStripMenuItem.Text = "Account &Information";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // shareFilesToolStripMenuItem
            // 
            this.shareFilesToolStripMenuItem.Name = "shareFilesToolStripMenuItem";
            this.shareFilesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shareFilesToolStripMenuItem.Text = "Share &Files";
            // 
            // fileTransferManagerToolStripMenuItem
            // 
            this.fileTransferManagerToolStripMenuItem.Name = "fileTransferManagerToolStripMenuItem";
            this.fileTransferManagerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fileTransferManagerToolStripMenuItem.Text = "File &Transfer Manager";
            this.fileTransferManagerToolStripMenuItem.Click += new System.EventHandler(this.btnFileManager_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.signOutToolStripMenuItem.Text = "Sign &Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.showOfflineContactsToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addToolStripMenuItem.Text = "&Add Contacts";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addGroupToolStripMenuItem.Text = "Add &Group";
            // 
            // showOfflineContactsToolStripMenuItem
            // 
            this.showOfflineContactsToolStripMenuItem.Name = "showOfflineContactsToolStripMenuItem";
            this.showOfflineContactsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showOfflineContactsToolStripMenuItem.Text = "Show O&ffline Contacts";
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewArchiveToolStripMenuItem.Text = "&View Archive";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
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
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(42, 286);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(130, 57);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(26, 30);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(37, 13);
            this.status_label.TabIndex = 12;
            this.status_label.Text = "Status";
            // 
            // status_button
            // 
            this.status_button.Location = new System.Drawing.Point(67, 25);
            this.status_button.Name = "status_button";
            this.status_button.Size = new System.Drawing.Size(115, 23);
            this.status_button.TabIndex = 13;
            this.status_button.Text = "Available";
            this.status_button.UseVisualStyleBackColor = true;
            this.status_button.Click += new System.EventHandler(this.status_button_Click);
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(219, 426);
            this.Controls.Add(this.status_button);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnAddConversation);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "NAIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button btnAddConversation;
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
        private ToolStripMenuItem viewArchiveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ListView listView1;
        private Label status_label;
        private Button status_button;
    }
}
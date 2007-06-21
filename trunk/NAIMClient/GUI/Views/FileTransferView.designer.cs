using System.Windows.Forms;
namespace GUI
{
    public partial class FileTransferView : Form
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lwContacts = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lwFileList = new System.Windows.Forms.ListView();
            this.chFLFile = new System.Windows.Forms.ColumnHeader();
            this.lwStatus = new System.Windows.Forms.ListView();
            this.chFTClient = new System.Windows.Forms.ColumnHeader();
            this.chFTFile = new System.Windows.Forms.ColumnHeader();
            this.chFTProgress = new System.Windows.Forms.ColumnHeader();
            this.chFTSpeed = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lwContacts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(818, 580);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // lwContacts
            // 
            this.lwContacts.BackColor = System.Drawing.SystemColors.Window;
            this.lwContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwContacts.FullRowSelect = true;
            this.lwContacts.Location = new System.Drawing.Point(0, 0);
            this.lwContacts.MultiSelect = false;
            this.lwContacts.Name = "lwContacts";
            this.lwContacts.Size = new System.Drawing.Size(272, 580);
            this.lwContacts.TabIndex = 0;
            this.lwContacts.UseCompatibleStateImageBehavior = false;
            this.lwContacts.View = System.Windows.Forms.View.List;
            this.lwContacts.ItemActivate += new System.EventHandler(this.lwContacts_ItemActivate);
            this.lwContacts.SelectedIndexChanged += new System.EventHandler(this.lwContacts_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lwFileList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lwStatus);
            this.splitContainer2.Size = new System.Drawing.Size(542, 580);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.TabIndex = 0;
            // 
            // lwFileList
            // 
            this.lwFileList.AllowColumnReorder = true;
            this.lwFileList.BackColor = System.Drawing.SystemColors.Window;
            this.lwFileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFLFile});
            this.lwFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwFileList.Location = new System.Drawing.Point(0, 0);
            this.lwFileList.Name = "lwFileList";
            this.lwFileList.Size = new System.Drawing.Size(542, 421);
            this.lwFileList.TabIndex = 0;
            this.lwFileList.UseCompatibleStateImageBehavior = false;
            this.lwFileList.View = System.Windows.Forms.View.Details;
            this.lwFileList.ItemActivate += new System.EventHandler(this.lwFileList_ItemActivate);
            // 
            // chFLFile
            // 
            this.chFLFile.Text = "File";
            this.chFLFile.Width = 540;
            // 
            // lwStatus
            // 
            this.lwStatus.AllowColumnReorder = true;
            this.lwStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lwStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFTClient,
            this.chFTFile,
            this.chFTSpeed,
            this.chFTProgress});
            this.lwStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwStatus.FullRowSelect = true;
            this.lwStatus.Location = new System.Drawing.Point(0, 0);
            this.lwStatus.Name = "lwStatus";
            this.lwStatus.OwnerDraw = true;
            this.lwStatus.Size = new System.Drawing.Size(542, 155);
            this.lwStatus.TabIndex = 0;
            this.lwStatus.UseCompatibleStateImageBehavior = false;
            this.lwStatus.View = System.Windows.Forms.View.Details;
            this.lwStatus.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lwStatus_DrawSubItem);
            this.lwStatus.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lwStatus_DrawColumnHeader);
            // 
            // chFTClient
            // 
            this.chFTClient.Text = "Client";
            this.chFTClient.Width = 85;
            // 
            // chFTFile
            // 
            this.chFTFile.Text = "File";
            this.chFTFile.Width = 250;
            // 
            // chFTProgress
            // 
            this.chFTProgress.Text = "Progress";
            this.chFTProgress.Width = 144;
            // 
            // chFTSpeed
            // 
            this.chFTSpeed.Text = "Speed";
            this.chFTSpeed.Width = 61;
            // 
            // FileTransferView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(818, 580);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "FileTransferView";
            this.Text = "File Transfer Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileTransferView_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private SaveFileDialog saveFileDialog;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListView lwFileList;
        private ListView lwStatus;
        private ListView lwContacts;
        private ColumnHeader chFLFile;
        private ColumnHeader chFTClient;
        private ColumnHeader chFTFile;
        private ColumnHeader chFTProgress;
        private ColumnHeader chFTSpeed;

    }
}
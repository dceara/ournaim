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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.groupBoxPeer = new System.Windows.Forms.GroupBox();
            this.listBoxFileList = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxPeer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxContacts);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(9, 18);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(118, 537);
            this.listBoxContacts.TabIndex = 0;
            this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
            // 
            // groupBoxPeer
            // 
            this.groupBoxPeer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPeer.Controls.Add(this.btnDownload);
            this.groupBoxPeer.Controls.Add(this.listBoxFileList);
            this.groupBoxPeer.Location = new System.Drawing.Point(148, 4);
            this.groupBoxPeer.Name = "groupBoxPeer";
            this.groupBoxPeer.Size = new System.Drawing.Size(662, 572);
            this.groupBoxPeer.TabIndex = 1;
            this.groupBoxPeer.TabStop = false;
            // 
            // listBoxFileList
            // 
            this.listBoxFileList.FormattingEnabled = true;
            this.listBoxFileList.Location = new System.Drawing.Point(6, 18);
            this.listBoxFileList.Name = "listBoxFileList";
            this.listBoxFileList.Size = new System.Drawing.Size(140, 537);
            this.listBoxFileList.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(162, 21);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(94, 26);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FileTransferView
            // 
            this.ClientSize = new System.Drawing.Size(818, 580);
            this.Controls.Add(this.groupBoxPeer);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileTransferView";
            this.Text = "File Transfer Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileTransferView_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPeer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBoxPeer;
        private ListBox listBoxContacts;
        private ListBox listBoxFileList;
        private SaveFileDialog saveFileDialog;
        private Button btnDownload;

    }
}
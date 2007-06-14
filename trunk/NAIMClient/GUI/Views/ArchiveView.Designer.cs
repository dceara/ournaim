namespace GUI.Views
{
    partial class ArchiveView
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
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.colLstContactsName = new System.Windows.Forms.ColumnHeader();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.colLstViewMsgsDate = new System.Windows.Forms.ColumnHeader();
            this.colLstViewMsgs = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewContacts
            // 
            this.listViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLstContactsName});
            this.listViewContacts.Location = new System.Drawing.Point(0, 0);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(289, 650);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            this.listViewContacts.SelectedIndexChanged += new System.EventHandler(this.listViewContacts_SelectedIndexChanged);
            // 
            // colLstContactsName
            // 
            this.colLstContactsName.Text = "Name";
            this.colLstContactsName.Width = 238;
            // 
            // listViewMessages
            // 
            this.listViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLstViewMsgsDate,
            this.colLstViewMsgs});
            this.listViewMessages.Location = new System.Drawing.Point(3, 0);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(578, 650);
            this.listViewMessages.TabIndex = 1;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // colLstViewMsgsDate
            // 
            this.colLstViewMsgsDate.Text = "Date";
            this.colLstViewMsgsDate.Width = 98;
            // 
            // colLstViewMsgs
            // 
            this.colLstViewMsgs.Text = "Message";
            this.colLstViewMsgs.Width = 198;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewContacts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewMessages);
            this.splitContainer1.Size = new System.Drawing.Size(877, 650);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 2;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(901, 674);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ArchiveView";
            this.Text = "Archive";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.ColumnHeader colLstContactsName;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader colLstViewMsgsDate;
        private System.Windows.Forms.ColumnHeader colLstViewMsgs;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
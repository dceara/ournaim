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
            this.SuspendLayout();
            // 
            // listViewContacts
            // 
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLstContactsName});
            this.listViewContacts.Location = new System.Drawing.Point(25, 11);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(243, 637);
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
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLstViewMsgsDate,
            this.colLstViewMsgs});
            this.listViewMessages.Location = new System.Drawing.Point(274, 11);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(602, 637);
            this.listViewMessages.TabIndex = 1;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // colLstViewMsgsDate
            // 
            this.colLstViewMsgsDate.Text = "Date";
            this.colLstViewMsgsDate.Width = 112;
            // 
            // colLstViewMsgs
            // 
            this.colLstViewMsgs.Text = "Message";
            this.colLstViewMsgs.Width = 485;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(901, 658);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.listViewContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ArchiveView";
            this.Text = "Archive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.ColumnHeader colLstContactsName;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader colLstViewMsgsDate;
        private System.Windows.Forms.ColumnHeader colLstViewMsgs;
    }
}
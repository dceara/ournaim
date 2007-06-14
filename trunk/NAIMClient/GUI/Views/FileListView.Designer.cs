namespace GUI.Views
{
    partial class FileListView
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
            this.listViewFileList = new System.Windows.Forms.ListView();
            this.colLstViewName = new System.Windows.Forms.ColumnHeader();
            this.colLstViewAlias = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFileList
            // 
            this.listViewFileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLstViewName,
            this.colLstViewAlias});
            this.listViewFileList.GridLines = true;
            this.listViewFileList.Location = new System.Drawing.Point(131, 12);
            this.listViewFileList.Name = "listViewFileList";
            this.listViewFileList.Size = new System.Drawing.Size(509, 315);
            this.listViewFileList.TabIndex = 0;
            this.listViewFileList.UseCompatibleStateImageBehavior = false;
            this.listViewFileList.View = System.Windows.Forms.View.Details;
            // 
            // colLstViewName
            // 
            this.colLstViewName.Text = "Name";
            this.colLstViewName.Width = 252;
            // 
            // colLstViewAlias
            // 
            this.colLstViewAlias.Text = "Alias";
            this.colLstViewAlias.Width = 252;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(13, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add File";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFile.Location = new System.Drawing.Point(12, 46);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(91, 28);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // FileListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(661, 340);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewFileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FileListView";
            this.Text = "File List Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFileList;
        private System.Windows.Forms.ColumnHeader colLstViewName;
        private System.Windows.Forms.ColumnHeader colLstViewAlias;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveFile;
    }
}
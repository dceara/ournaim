namespace GUI.Views
{
    partial class PreferencesDialog
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
            this.categorylistBox = new System.Windows.Forms.ListBox();
            this.categorylabel = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.portlabel = new System.Windows.Forms.Label();
            this.ServAdrlabel = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectionlabel = new System.Windows.Forms.Label();
            this.serversettingsgb = new System.Windows.Forms.GroupBox();
            this.textBoxServAdr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.serversettingsgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorylistBox
            // 
            this.categorylistBox.FormattingEnabled = true;
            this.categorylistBox.Items.AddRange(new object[] {
            "Connection"});
            this.categorylistBox.Location = new System.Drawing.Point(12, 28);
            this.categorylistBox.Name = "categorylistBox";
            this.categorylistBox.Size = new System.Drawing.Size(120, 329);
            this.categorylistBox.TabIndex = 0;
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel.Location = new System.Drawing.Point(12, 9);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(58, 15);
            this.categorylabel.TabIndex = 1;
            this.categorylabel.Text = "Category:";
            this.categorylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(145, 406);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(251, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Location = new System.Drawing.Point(6, 39);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(32, 13);
            this.portlabel.TabIndex = 5;
            this.portlabel.Text = "Port :";
            // 
            // ServAdrlabel
            // 
            this.ServAdrlabel.AutoSize = true;
            this.ServAdrlabel.Location = new System.Drawing.Point(136, 39);
            this.ServAdrlabel.Name = "ServAdrlabel";
            this.ServAdrlabel.Size = new System.Drawing.Size(78, 13);
            this.ServAdrlabel.TabIndex = 6;
            this.ServAdrlabel.Text = "Server address";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(52, 35);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.connectionlabel);
            this.panel1.Location = new System.Drawing.Point(149, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 29);
            this.panel1.TabIndex = 9;
            // 
            // connectionlabel
            // 
            this.connectionlabel.AutoSize = true;
            this.connectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionlabel.Location = new System.Drawing.Point(3, 5);
            this.connectionlabel.Name = "connectionlabel";
            this.connectionlabel.Size = new System.Drawing.Size(94, 18);
            this.connectionlabel.TabIndex = 0;
            this.connectionlabel.Text = "Connection";
            // 
            // serversettingsgb
            // 
            this.serversettingsgb.Controls.Add(this.textBoxServAdr);
            this.serversettingsgb.Controls.Add(this.portlabel);
            this.serversettingsgb.Controls.Add(this.textBoxPort);
            this.serversettingsgb.Controls.Add(this.ServAdrlabel);
            this.serversettingsgb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.serversettingsgb.Location = new System.Drawing.Point(149, 75);
            this.serversettingsgb.Name = "serversettingsgb";
            this.serversettingsgb.Size = new System.Drawing.Size(310, 87);
            this.serversettingsgb.TabIndex = 10;
            this.serversettingsgb.TabStop = false;
            this.serversettingsgb.Text = "Server Settings";
            // 
            // textBoxServAdr
            // 
            this.textBoxServAdr.Location = new System.Drawing.Point(228, 35);
            this.textBoxServAdr.Name = "textBoxServAdr";
            this.textBoxServAdr.Size = new System.Drawing.Size(78, 20);
            this.textBoxServAdr.TabIndex = 1;
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 441);
            this.Controls.Add(this.serversettingsgb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.categorylistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PreferencesDialog";
            this.Text = "PreferencesDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.serversettingsgb.ResumeLayout(false);
            this.serversettingsgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox categorylistBox;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.Label ServAdrlabel;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label connectionlabel;
        private System.Windows.Forms.GroupBox serversettingsgb;
        private System.Windows.Forms.TextBox textBoxServAdr;
    }
}
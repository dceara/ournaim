namespace GUI.Views
{
    partial class AddContactDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s NAIM id:";
            // 
            // usernickname
            // 
            this.usernickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernickname.Location = new System.Drawing.Point(16, 35);
            this.usernickname.Name = "usernickname";
            this.usernickname.Size = new System.Drawing.Size(192, 20);
            this.usernickname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group";
            // 
            // group_comboBox
            // 
            this.group_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Location = new System.Drawing.Point(227, 34);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(121, 21);
            this.group_comboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(185, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(273, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddContactDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(365, 124);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernickname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddContactDialog";
            this.Text = "AddContactDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}
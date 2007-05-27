namespace GUI.Views
{
    partial class AddGroupView
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
            this.groupname_textBox = new System.Windows.Forms.TextBox();
            this.gropuname_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupname_textBox
            // 
            this.groupname_textBox.Location = new System.Drawing.Point(85, 11);
            this.groupname_textBox.Name = "groupname_textBox";
            this.groupname_textBox.Size = new System.Drawing.Size(100, 20);
            this.groupname_textBox.TabIndex = 0;
            // 
            // gropuname_label
            // 
            this.gropuname_label.AutoSize = true;
            this.gropuname_label.Location = new System.Drawing.Point(14, 14);
            this.gropuname_label.Name = "gropuname_label";
            this.gropuname_label.Size = new System.Drawing.Size(65, 13);
            this.gropuname_label.TabIndex = 1;
            this.gropuname_label.Text = "Group name";
            // 
            // add_button
            // 
            this.add_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.add_button.Location = new System.Drawing.Point(6, 48);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Ok";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(112, 48);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // AddGroupView
            // 
            this.AcceptButton = this.add_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(199, 83);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.gropuname_label);
            this.Controls.Add(this.groupname_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGroupView";
            this.Text = "AddGroupView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupname_textBox;
        private System.Windows.Forms.Label gropuname_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
    }
}
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.gropuname_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Location = new System.Drawing.Point(77, 7);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(110, 20);
            this.txtGroupName.TabIndex = 0;
            // 
            // gropuname_label
            // 
            this.gropuname_label.AutoSize = true;
            this.gropuname_label.Location = new System.Drawing.Point(3, 9);
            this.gropuname_label.Name = "gropuname_label";
            this.gropuname_label.Size = new System.Drawing.Size(68, 13);
            this.gropuname_label.TabIndex = 1;
            this.gropuname_label.Text = "Group name:";
            // 
            // add_button
            // 
            this.add_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Location = new System.Drawing.Point(6, 48);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Ok";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Location = new System.Drawing.Point(112, 48);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // AddGroupView
            // 
            this.AcceptButton = this.add_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(199, 83);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.gropuname_label);
            this.Controls.Add(this.txtGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGroupView";
            this.Text = "AddGroupView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddGroupView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label gropuname_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
    }
}
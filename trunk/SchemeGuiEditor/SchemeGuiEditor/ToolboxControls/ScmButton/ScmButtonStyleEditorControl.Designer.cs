namespace SchemeGuiEditor.ToolboxControls
{
    partial class ScmButtonStyleEditorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxDeleted = new System.Windows.Forms.CheckBox();
            this.checkBoxBorder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxDeleted
            // 
            this.checkBoxDeleted.AutoSize = true;
            this.checkBoxDeleted.Location = new System.Drawing.Point(3, 26);
            this.checkBoxDeleted.Name = "checkBoxDeleted";
            this.checkBoxDeleted.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDeleted.TabIndex = 3;
            this.checkBoxDeleted.Text = "Deleted";
            this.checkBoxDeleted.UseVisualStyleBackColor = true;
            this.checkBoxDeleted.CheckedChanged += new System.EventHandler(this.checkBoxDeleted_CheckedChanged);
            // 
            // checkBoxBorder
            // 
            this.checkBoxBorder.AutoSize = true;
            this.checkBoxBorder.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBorder.Name = "checkBoxBorder";
            this.checkBoxBorder.Size = new System.Drawing.Size(57, 17);
            this.checkBoxBorder.TabIndex = 2;
            this.checkBoxBorder.Text = "Border";
            this.checkBoxBorder.UseVisualStyleBackColor = true;
            this.checkBoxBorder.CheckedChanged += new System.EventHandler(this.checkBoxBorder_CheckedChanged);
            // 
            // ScmButtonStyleEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.checkBoxDeleted);
            this.Controls.Add(this.checkBoxBorder);
            this.Name = "ScmButtonStyleEditorControl";
            this.Size = new System.Drawing.Size(110, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDeleted;
        private System.Windows.Forms.CheckBox checkBoxBorder;
    }
}

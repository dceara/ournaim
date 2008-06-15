namespace SchemeGuiEditor.ToolboxControls
{
    partial class ScmStyleEditorControl
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
            this.SuspendLayout();
            // 
            // checkBoxDeleted
            // 
            this.checkBoxDeleted.AutoSize = true;
            this.checkBoxDeleted.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDeleted.Name = "checkBoxDeleted";
            this.checkBoxDeleted.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDeleted.TabIndex = 4;
            this.checkBoxDeleted.Text = "Deleted";
            this.checkBoxDeleted.UseVisualStyleBackColor = true;
            this.checkBoxDeleted.CheckedChanged += new System.EventHandler(this.checkBoxDeleted_CheckedChanged);
            // 
            // ScmMessageStyleEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.checkBoxDeleted);
            this.Name = "ScmMessageStyleEditorControl";
            this.Size = new System.Drawing.Size(87, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDeleted;
    }
}

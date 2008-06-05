namespace SchemeGuiEditor.ToolboxControls
{
    partial class ScmFrameStyleEditorControl
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
            this.checkBoxNoResizeBorder = new System.Windows.Forms.CheckBox();
            this.checkBoxNoCaption = new System.Windows.Forms.CheckBox();
            this.checkBoxNoSystemMenu = new System.Windows.Forms.CheckBox();
            this.checkBoxFloating = new System.Windows.Forms.CheckBox();
            this.checkBoxMdiParent = new System.Windows.Forms.CheckBox();
            this.checkBoxMdiChild = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxNoResizeBorder
            // 
            this.checkBoxNoResizeBorder.AutoSize = true;
            this.checkBoxNoResizeBorder.Location = new System.Drawing.Point(3, 3);
            this.checkBoxNoResizeBorder.Name = "checkBoxNoResizeBorder";
            this.checkBoxNoResizeBorder.Size = new System.Drawing.Size(109, 17);
            this.checkBoxNoResizeBorder.TabIndex = 0;
            this.checkBoxNoResizeBorder.Text = "No Resize Border";
            this.checkBoxNoResizeBorder.UseVisualStyleBackColor = true;
            this.checkBoxNoResizeBorder.CheckedChanged += new System.EventHandler(this.checkBoxNoResizeBorder_CheckedChanged);
            // 
            // checkBoxNoCaption
            // 
            this.checkBoxNoCaption.AutoSize = true;
            this.checkBoxNoCaption.Location = new System.Drawing.Point(3, 26);
            this.checkBoxNoCaption.Name = "checkBoxNoCaption";
            this.checkBoxNoCaption.Size = new System.Drawing.Size(79, 17);
            this.checkBoxNoCaption.TabIndex = 1;
            this.checkBoxNoCaption.Text = "No Caption";
            this.checkBoxNoCaption.UseVisualStyleBackColor = true;
            this.checkBoxNoCaption.CheckedChanged += new System.EventHandler(this.checkBoxNoCaption_CheckedChanged);
            // 
            // checkBoxNoSystemMenu
            // 
            this.checkBoxNoSystemMenu.AutoSize = true;
            this.checkBoxNoSystemMenu.Location = new System.Drawing.Point(3, 49);
            this.checkBoxNoSystemMenu.Name = "checkBoxNoSystemMenu";
            this.checkBoxNoSystemMenu.Size = new System.Drawing.Size(107, 17);
            this.checkBoxNoSystemMenu.TabIndex = 2;
            this.checkBoxNoSystemMenu.Text = "No System Menu";
            this.checkBoxNoSystemMenu.UseVisualStyleBackColor = true;
            this.checkBoxNoSystemMenu.CheckedChanged += new System.EventHandler(this.checkBoxNoSystemMenu_CheckedChanged);
            // 
            // checkBoxFloating
            // 
            this.checkBoxFloating.AutoSize = true;
            this.checkBoxFloating.Location = new System.Drawing.Point(3, 72);
            this.checkBoxFloating.Name = "checkBoxFloating";
            this.checkBoxFloating.Size = new System.Drawing.Size(63, 17);
            this.checkBoxFloating.TabIndex = 3;
            this.checkBoxFloating.Text = "Floating";
            this.checkBoxFloating.UseVisualStyleBackColor = true;
            this.checkBoxFloating.CheckedChanged += new System.EventHandler(this.checkBoxFloating_CheckedChanged);
            // 
            // checkBoxMdiParent
            // 
            this.checkBoxMdiParent.AutoSize = true;
            this.checkBoxMdiParent.Location = new System.Drawing.Point(3, 95);
            this.checkBoxMdiParent.Name = "checkBoxMdiParent";
            this.checkBoxMdiParent.Size = new System.Drawing.Size(77, 17);
            this.checkBoxMdiParent.TabIndex = 4;
            this.checkBoxMdiParent.Text = "Mdi Parent";
            this.checkBoxMdiParent.UseVisualStyleBackColor = true;
            this.checkBoxMdiParent.CheckedChanged += new System.EventHandler(this.checkBoxMdiParent_CheckedChanged);
            // 
            // checkBoxMdiChild
            // 
            this.checkBoxMdiChild.AutoSize = true;
            this.checkBoxMdiChild.Location = new System.Drawing.Point(3, 118);
            this.checkBoxMdiChild.Name = "checkBoxMdiChild";
            this.checkBoxMdiChild.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMdiChild.TabIndex = 5;
            this.checkBoxMdiChild.Text = "Mdi Child";
            this.checkBoxMdiChild.UseVisualStyleBackColor = true;
            this.checkBoxMdiChild.CheckedChanged += new System.EventHandler(this.checkBoxMdiChild_CheckedChanged);
            // 
            // ScmFrameStyleEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.checkBoxMdiChild);
            this.Controls.Add(this.checkBoxMdiParent);
            this.Controls.Add(this.checkBoxFloating);
            this.Controls.Add(this.checkBoxNoSystemMenu);
            this.Controls.Add(this.checkBoxNoCaption);
            this.Controls.Add(this.checkBoxNoResizeBorder);
            this.Name = "ScmFrameStyleEditorControl";
            this.Size = new System.Drawing.Size(112, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNoResizeBorder;
        private System.Windows.Forms.CheckBox checkBoxNoCaption;
        private System.Windows.Forms.CheckBox checkBoxNoSystemMenu;
        private System.Windows.Forms.CheckBox checkBoxFloating;
        private System.Windows.Forms.CheckBox checkBoxMdiParent;
        private System.Windows.Forms.CheckBox checkBoxMdiChild;

    }
}

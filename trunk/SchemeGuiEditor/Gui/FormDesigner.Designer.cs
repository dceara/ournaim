namespace SchemeGuiEditor.Gui
{
    partial class FormDesigner
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AllowDrop = true;
            this.panelContainer.BackColor = System.Drawing.SystemColors.Window;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(604, 520);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.DragOver += new System.Windows.Forms.DragEventHandler(this.panelContainer_DragOver);
            this.panelContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelContainer_DragDrop);
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // FormDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 520);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormDesigner";
            this.TabText = "Form Designer";
            this.Text = "Form Designer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;



    }
}
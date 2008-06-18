namespace SchemeGuiEditor.ToolboxControls
{
    partial class ScmVerticalPanel
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
            SchemeGuiEditor.ToolboxControls.ContainerAlignment containerAlignment1 = new SchemeGuiEditor.ToolboxControls.ContainerAlignment();
            this.layoutManagerContainer1 = new SchemeGuiEditor.ToolboxControls.VerticalLayoutManagerContainer();
            this.SuspendLayout();
            // 
            // layoutManagerContainer1
            // 
            this.layoutManagerContainer1.Alignment = containerAlignment1;
            this.layoutManagerContainer1.Border = 0;
            this.layoutManagerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutManagerContainer1.Location = new System.Drawing.Point(0, 0);
            this.layoutManagerContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutManagerContainer1.Name = "layoutManagerContainer1";
            this.layoutManagerContainer1.Size = new System.Drawing.Size(562, 413);
            this.layoutManagerContainer1.Spacing = 0;
            this.layoutManagerContainer1.TabIndex = 0;
            // 
            // ScmVerticalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutManagerContainer1);
            this.Name = "ScmVerticalPanel";
            this.Size = new System.Drawing.Size(562, 413);
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalLayoutManagerContainer layoutManagerContainer1;
    }
}

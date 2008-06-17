namespace SchemeGuiEditor.ToolboxControls
{
    partial class ScmHorizontalPanel
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
            this.layoutManagerContainer1 = new SchemeGuiEditor.ToolboxControls.HorizontalLayoutManagerContainer();
            this.SuspendLayout();
            // 
            // layoutManagerContainer1
            // 
            this.layoutManagerContainer1.Border = 0;
            this.layoutManagerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutManagerContainer1.Location = new System.Drawing.Point(0, 0);
            this.layoutManagerContainer1.Name = "layoutManagerContainer1";
            this.layoutManagerContainer1.Size = new System.Drawing.Size(412, 343);
            this.layoutManagerContainer1.Spacing = 0;
            this.layoutManagerContainer1.TabIndex = 0;
            this.layoutManagerContainer1.Click += new System.EventHandler(this.layoutManagerContainer1_Click);
            // 
            // ScmHorizontalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutManagerContainer1);
            this.Name = "ScmHorizontalPanel";
            this.Size = new System.Drawing.Size(412, 343);
            this.ResumeLayout(false);

        }

        #endregion

        private HorizontalLayoutManagerContainer layoutManagerContainer1;

    }
}

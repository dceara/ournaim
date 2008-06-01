namespace SchemeGuiEditor.Gui
{
    partial class ToolWindow
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripFloatingOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabbedDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFloatingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripFloatingOptions
            // 
            this.contextMenuStripFloatingOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floatingToolStripMenuItem,
            this.dockableToolStripMenuItem,
            this.tabbedDocumentToolStripMenuItem,
            this.autoHideToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.contextMenuStripFloatingOptions.Name = "contextMenuStrip1";
            this.contextMenuStripFloatingOptions.ShowCheckMargin = true;
            this.contextMenuStripFloatingOptions.ShowImageMargin = false;
            this.contextMenuStripFloatingOptions.Size = new System.Drawing.Size(173, 114);
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            this.autoHideToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.autoHideToolStripMenuItem.Text = "Auto Hide";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            // 
            // floatingToolStripMenuItem
            // 
            this.floatingToolStripMenuItem.Name = "floatingToolStripMenuItem";
            this.floatingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.floatingToolStripMenuItem.Text = "Floating";
            // 
            // dockableToolStripMenuItem
            // 
            this.dockableToolStripMenuItem.Name = "dockableToolStripMenuItem";
            this.dockableToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dockableToolStripMenuItem.Text = "Dockable";
            // 
            // tabbedDocumentToolStripMenuItem
            // 
            this.tabbedDocumentToolStripMenuItem.Name = "tabbedDocumentToolStripMenuItem";
            this.tabbedDocumentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tabbedDocumentToolStripMenuItem.Text = "Tabbed Document";
            // 
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "ToolWindow";
            this.TabPageContextMenuStrip = this.contextMenuStripFloatingOptions;
            this.TabText = "ToolWindow";
            this.Text = "ToolWindow";
            this.contextMenuStripFloatingOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripFloatingOptions;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabbedDocumentToolStripMenuItem;
    }
}
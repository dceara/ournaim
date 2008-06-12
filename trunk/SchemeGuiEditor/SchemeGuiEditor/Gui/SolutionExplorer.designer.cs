namespace SchemeGuiEditor.Gui
{
    partial class SolutionExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorer));
            this.projectTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProjectFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lalalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProject.SuspendLayout();
            this.contextMenuStripProjectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectTreeView
            // 
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.ImageIndex = 0;
            this.projectTreeView.ImageList = this.imageList1;
            this.projectTreeView.Indent = 19;
            this.projectTreeView.Location = new System.Drawing.Point(0, 24);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.SelectedImageIndex = 0;
            this.projectTreeView.Size = new System.Drawing.Size(245, 297);
            this.projectTreeView.TabIndex = 0;
            this.projectTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTreeView_NodeMouseDoubleClick);
            this.projectTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.projectTreeView_AfterLabelEdit);
            this.projectTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectTreeView_BeforeExpand);
            this.projectTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectTreeView_BeforeCollapse);
            this.projectTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTreeView_NodeMouseClick);
            this.projectTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectTreeView_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FolderClosed");
            this.imageList1.Images.SetKeyName(1, "FolderOpened");
            this.imageList1.Images.SetKeyName(2, "Solution");
            this.imageList1.Images.SetKeyName(3, "SourceFile");
            // 
            // contextMenuStripProject
            // 
            this.contextMenuStripProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuStripProject.Name = "contextMenuStrip1";
            this.contextMenuStripProject.Size = new System.Drawing.Size(153, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.existingItemToolStripMenuItem,
            this.newFolderToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // existingItemToolStripMenuItem
            // 
            this.existingItemToolStripMenuItem.Name = "existingItemToolStripMenuItem";
            this.existingItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.existingItemToolStripMenuItem.Text = "Existing Item";
            this.existingItemToolStripMenuItem.Click += new System.EventHandler(this.existingItemToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // contextMenuStripProjectFile
            // 
            this.contextMenuStripProjectFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lalalaToolStripMenuItem});
            this.contextMenuStripProjectFile.Name = "contextMenuStripProjectFile";
            this.contextMenuStripProjectFile.Size = new System.Drawing.Size(110, 26);
            // 
            // lalalaToolStripMenuItem
            // 
            this.lalalaToolStripMenuItem.Name = "lalalaToolStripMenuItem";
            this.lalalaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.lalalaToolStripMenuItem.Text = "lalala";
            // 
            // SolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(245, 322);
            this.Controls.Add(this.projectTreeView);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolutionExplorer";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 1);
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRight;
            this.TabText = "Solution Explorer";
            this.Text = "Solution Explorer";
            this.contextMenuStripProject.ResumeLayout(false);
            this.contextMenuStripProjectFile.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.TreeView projectTreeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProject;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjectFile;
        private System.Windows.Forms.ToolStripMenuItem lalalaToolStripMenuItem;
    }
}
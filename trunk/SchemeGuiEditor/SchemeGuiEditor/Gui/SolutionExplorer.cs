using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SchemeGuiEditor.Projects;
using SchemeGuiEditor.Constants;
using SchemeGuiEditor.Utils;
using SchemeGuiEditor.Dialogs;

namespace SchemeGuiEditor.Gui
{
    public partial class SolutionExplorer : ToolWindow
    {
        public event EventHandler<DataEventArgs<ProjectFile>> OpenFile;

        public SolutionExplorer()
        {
            InitializeComponent();
            projectTreeView.LabelEdit = true;
            ProjectManager.Instance.ProjectChanged += new EventHandler<DataEventArgs<Project>>(Instance_ProjectChanged);
        }

        #region Private Methods
        private TreeNode CreateTreeNode(ProjectItem projectItem)
        {
            TreeNode node = new TreeNode(projectItem.Name);
            foreach (ProjectDirectory directory in projectItem.Directorys)
            {
                TreeNode dirNode = CreateTreeNode(directory);
                dirNode.ImageKey = GuiConstants.ImageFolderClosed;
                dirNode.SelectedImageKey = GuiConstants.ImageFolderClosed;
                node.Nodes.Add(dirNode);
            }
            foreach (ProjectFile file in projectItem.Files)
            {
                node.Nodes.Add(CreateTreeNode(file));
            }
            node.Tag = projectItem;
            return node;
        }

        private TreeNode CreateTreeNode(ProjectFile projectFile)
        {
            TreeNode node = new TreeNode(projectFile.Name);
            node.ImageKey = GuiConstants.ImageSourceFile;
            node.SelectedImageKey = GuiConstants.ImageSourceFile;
            node.Tag = projectFile;
            return node;
        }
        #endregion

        #region Event Handlers
        void Instance_ProjectChanged(object sender, DataEventArgs<Project> e)
        {
            projectTreeView.Nodes.Clear();
            TreeNode node = CreateTreeNode(e.Data);
            node.ImageKey = GuiConstants.ImageSolution;
            node.SelectedImageKey = GuiConstants.ImageSolution;
            node.Expand();
            projectTreeView.Nodes.Add(node);
        }

        void projectTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            projectTreeView.SelectedNode = e.Node;
        }

        void projectTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is ProjectItem)
            {
                projectTreeView.ContextMenuStrip = contextMenuStripProject;
            }
            else
            {
                if (e.Node.Tag is ProjectFile)
                    projectTreeView.ContextMenuStrip = contextMenuStripProjectFile;
            }
        }

        void projectTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                e.Node.ImageKey = GuiConstants.ImageFolderOpen;
                e.Node.SelectedImageKey = GuiConstants.ImageFolderOpen;
            }
        }

        void projectTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                e.Node.ImageKey = GuiConstants.ImageFolderClosed;
                e.Node.SelectedImageKey = GuiConstants.ImageFolderClosed;
            }
        }

        void projectTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                ProjectDirectory dir = e.Node.Tag as ProjectDirectory;
                if (e.Label == null || !ProjectManager.Instance.Rename(e.Label,dir))
                    e.CancelEdit = true;
            }
        }

        void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectItem projectItem = projectTreeView.SelectedNode.Tag as ProjectItem;
            ProjectDirectory newDir = ProjectManager.Instance.AddNewProjectDirectory(projectItem);
            TreeNode newNode = CreateTreeNode(newDir);
            projectTreeView.SelectedNode.Nodes.Add(newNode);
            newNode.ImageKey = GuiConstants.ImageFolderClosed;
            newNode.SelectedImageKey = GuiConstants.ImageFolderClosed;
            projectTreeView.SelectedNode = newNode;
            newNode.BeginEdit();
        }

        void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItemDialog newItemDialog = new NewItemDialog();
            if (newItemDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectItem projectItem = projectTreeView.SelectedNode.Tag as ProjectItem;
                ProjectFile file = ProjectManager.Instance.AddNewProjectFile(
                    newItemDialog.FileName + ConstantNames.SourceFileExtension, projectItem);
                if (file != null)
                {
                    TreeNode newNode = CreateTreeNode(file);
                    projectTreeView.SelectedNode.Nodes.Add(newNode);
                    projectTreeView.SelectedNode.Expand();
                }
            }
        }

        void projectTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(e.Node.Tag is ProjectFile))
                return;

            ProjectFile currentFile = e.Node.Tag as ProjectFile;
            if (OpenFile!=null)
                OpenFile(this,new DataEventArgs<ProjectFile>(currentFile));

        }

        private void existingItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Scheme files (*.scm, *.ss)| *.scm ; *.ss";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ProjectItem projectItem = projectTreeView.SelectedNode.Tag as ProjectItem;
                ProjectFile file = ProjectManager.Instance.AddExistingProjectFile(ofd.FileName,projectItem);
                TreeNode newNode = CreateTreeNode(file);
                projectTreeView.SelectedNode.Nodes.Add(newNode);
            }
        }
        #endregion
    }
}
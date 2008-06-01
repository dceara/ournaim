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

        void Instance_ProjectChanged(object sender, DataEventArgs<Project> e)
        {
            projectTreeView.Nodes.Clear();
            TreeNode node = CreateTreeNode(e.Data);
            node.ImageKey = GuiConstants.ImageSolution;
            node.SelectedImageKey = GuiConstants.ImageSolution;
            projectTreeView.Nodes.Add(node);
        }

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

        private void projectTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            projectTreeView.SelectedNode = e.Node;
        }

        private void projectTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
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

        private void projectTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                e.Node.ImageKey = GuiConstants.ImageFolderOpen;
                e.Node.SelectedImageKey = GuiConstants.ImageFolderOpen;
            }
        }

        private void projectTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                e.Node.ImageKey = GuiConstants.ImageFolderClosed;
                e.Node.SelectedImageKey = GuiConstants.ImageFolderClosed;
            }
        }

        private void projectTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag is ProjectDirectory)
            {
                ProjectDirectory dir = e.Node.Tag as ProjectDirectory;
                if (e.Label == null || !ProjectManager.Instance.Rename(e.Label,dir))
                    e.CancelEdit = true;
            }
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItemDialog newItemDialog = new NewItemDialog();
            if (newItemDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectItem projectItem = projectTreeView.SelectedNode.Tag as ProjectItem;
                ProjectFile file = ProjectManager.Instance.AddNewProjectFile(
                    newItemDialog.FileName + ConstantNames.SourceFileExtension, projectItem);
                TreeNode newNode = CreateTreeNode(file);
                projectTreeView.SelectedNode.Nodes.Add(newNode);

            }

        }

        private void projectTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(e.Node.Tag is ProjectFile))
                return;

            ProjectFile currentFile = e.Node.Tag as ProjectFile;
            if (OpenFile!=null)
                OpenFile(this,new DataEventArgs<ProjectFile>(currentFile));
            
        }


    }
}
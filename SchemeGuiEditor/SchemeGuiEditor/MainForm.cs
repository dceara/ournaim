using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.IO.IsolatedStorage;
using SchemeGuiEditor.Services;
using SchemeGuiEditor.Projects;
using SchemeGuiEditor.Gui;
using SchemeGuiEditor.Utils;
using SchemeGuiEditor.ToolboxControls;

namespace SchemeGuiEditor
{
    public partial class MainForm : Form
    {
        PropertyWindow _propertyWindow;
        SolutionExplorer _solutionExplorer;
        ToolWindow _activeToolWindow;
        Toolbox _toolbox;
        Dictionary<string, FormDesigner> _formDesigners;

        public MainForm()
        {
            InitializeComponent();
            InitialiseServices();
        }

        #region Private Methods
        private void InitialiseServices()
        {
            _propertyWindow = new PropertyWindow();
            _toolbox = new Toolbox();
            _solutionExplorer = new SolutionExplorer();
            _formDesigners = new Dictionary<string, FormDesigner>();

            _propertyWindow.SelectedControlChanged += new EventHandler<DataEventArgs<IScmControl>>(_propertyWindow_SelectedControlChanged);
            _solutionExplorer.OpenFile += new EventHandler<DataEventArgs<ProjectFile>>(_solutionExplorer_OpenFile);
            dockPanel.ActiveContentChanged += new EventHandler(dockPanel_ActiveContentChanged);

            MessageService.MainForm = this;
        }

        private void CreateBasicLayout()
        {
            _propertyWindow.Show(dockPanel);
            _toolbox.Show(dockPanel);
            _solutionExplorer.Show(dockPanel);
        }

        private bool LoadLayout()
        {
            IsolatedStorageFile isoStore = null;
            Stream stream = null;
            string isolatedSettingsFile = System.IO.Path.Combine(ConstantNames.IsolatedStorageFolder, ConstantNames.SettingsFileName);
            try
            {
                isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                stream = new IsolatedStorageFileStream(isolatedSettingsFile, FileMode.Open, isoStore);
                dockPanel.LoadFromXml(stream, new DeserializeDockContent(GetContentFromPersistString));
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (null != stream)
                    stream.Close();
                if (null != isoStore)
                    isoStore.Close();
            }
            return true;
        }

        private void SaveLayout()
        {
            IsolatedStorageFile isoStore = null;
            Stream stream = null;
            string isolatedSettingsFile = System.IO.Path.Combine(ConstantNames.IsolatedStorageFolder, ConstantNames.SettingsFileName);
            try
            {
                isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if (!Array.Exists<string>(isoStore.GetDirectoryNames(ConstantNames.IsolatedStorageFolder),
                    delegate(string s)
                    {
                        return 0 == String.CompareOrdinal(s, ConstantNames.IsolatedStorageFolder);
                    }))
                    isoStore.CreateDirectory(ConstantNames.IsolatedStorageFolder);
                stream = new IsolatedStorageFileStream(isolatedSettingsFile, FileMode.Create, isoStore);
                dockPanel.SaveAsXml(stream, Encoding.Unicode);
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                if (null != isoStore)
                    isoStore.Close();
                if (null != stream)
                    stream.Close();
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(SolutionExplorer).ToString())
                return _solutionExplorer;

            if (persistString == typeof(Toolbox).ToString())
                return _toolbox;

            if (persistString == typeof(PropertyWindow).ToString())
                return _propertyWindow;

            return null;
        }

        private void OpenProject()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.sprj|*.sprj";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                ProjectManager.Instance.LoadProject(openFileDialog.FileName);
        }

        #endregion

        #region Event Handlers
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (!LoadLayout())
                CreateBasicLayout();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveLayout();
        }

        private void _solutionExplorer_OpenFile(object sender, DataEventArgs<ProjectFile> e)
        {
            if (!_formDesigners.ContainsKey(e.Data.Name))
            {
                FormDesigner designer = new FormDesigner(e.Data);
                _formDesigners.Add(e.Data.Name, designer);
                designer.SelectedItemChanged += new EventHandler<DataEventArgs<object>>(designer_SelectedItemChanged);
                designer.Show(dockPanel, DockState.Document);
            }
            else
            {
                _formDesigners[e.Data.Name].Show(dockPanel);
            }
        }

        void _propertyWindow_SelectedControlChanged(object sender, DataEventArgs<IScmControl> e)
        {
            if (_activeToolWindow is FormDesigner)
            {
                (_activeToolWindow as FormDesigner).SelectControl(e.Data as Control,false);
            }
        }

        private void designer_SelectedItemChanged(object sender, DataEventArgs<object> e)
        {
            _propertyWindow.SelectItem(e.Data);
        }

        private void dockPanel_ActiveContentChanged(object sender, EventArgs e)
        {
            if (dockPanel.ActiveContent != null && dockPanel.ActiveContent is FormDesigner 
                && dockPanel.ActiveContent != _activeToolWindow)
            {
                FormDesigner activeToolWindow = dockPanel.ActiveContent as FormDesigner;
                _propertyWindow.LoadPropertyItems(activeToolWindow.GetPropertiesObjects());
                _activeToolWindow = dockPanel.ActiveContent as ToolWindow;
            }
        }

        #endregion

        #region Menu Items Event Handlers
        private void menuItemNewProject_Click(object sender, EventArgs e)
        {
            NewProjectDialog newProjectDialog = new NewProjectDialog();
            if (newProjectDialog.ShowDialog() == DialogResult.OK)
                ProjectManager.Instance.CreateProject(newProjectDialog.ProjectName, newProjectDialog.ProjectLocation);
        }

        private void menuItemOpenProject_Click(object sender, EventArgs e)
        {
            OpenProject();
        }
        #endregion


        




        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menuItemSolutionExplorer_Click(object sender, System.EventArgs e)
        {
			_solutionExplorer.Show(dockPanel);
		}

		private void menuItemPropertyWindow_Click(object sender, System.EventArgs e)
		{
			_propertyWindow.Show(dockPanel);
		}

        private void menuItemToolbox_Click(object sender, System.EventArgs e)
        {
            _toolbox.Show(dockPanel);
        }



        private void menuItemOutputWindow_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemTaskList_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemAbout_Click(object sender, System.EventArgs e)
        {
        }


        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemOpen_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemFile_Popup(object sender, System.EventArgs e)
        {
        }

        private void menuItemClose_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemCloseAll_Click(object sender, System.EventArgs e)
        {
        }

        private void CloseAllDocuments()
        {
        }

        private void menuItemToolBar_Click(object sender, System.EventArgs e)
        {
            toolBar.Visible = menuItemToolBar.Checked = !menuItemToolBar.Checked;
        }

        private void menuItemStatusBar_Click(object sender, System.EventArgs e)
        {
            statusBar.Visible = menuItemStatusBar.Checked = !menuItemStatusBar.Checked;
        }

        private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolBarButtonNew)
                menuItemNew_Click(null, null);
            else if (e.ClickedItem == toolBarButtonOpen)
                menuItemOpen_Click(null, null);
            else if (e.ClickedItem == toolBarButtonSolutionExplorer)
                menuItemSolutionExplorer_Click(null, null);
            else if (e.ClickedItem == toolBarButtonPropertyWindow)
                menuItemPropertyWindow_Click(null, null);
            else if (e.ClickedItem == toolBarButtonToolbox)
                menuItemToolbox_Click(null, null);
            else if (e.ClickedItem == toolBarButtonOutputWindow)
                menuItemOutputWindow_Click(null, null);
            else if (e.ClickedItem == toolBarButtonTaskList)
                menuItemTaskList_Click(null, null);
            else if (e.ClickedItem == toolBarButtonLayoutByCode)
                menuItemLayoutByCode_Click(null, null);
            else if (e.ClickedItem == toolBarButtonLayoutByXml)
                menuItemLayoutByXml_Click(null, null);
        }

        private void menuItemNewWindow_Click(object sender, System.EventArgs e)
        {
            MainForm newWindow = new MainForm();
            newWindow.Text = newWindow.Text + " - New";
            newWindow.Show();
        }

        private void menuItemTools_Popup(object sender, System.EventArgs e)
        {
            menuItemLockLayout.Checked = !this.dockPanel.AllowEndUserDocking;
        }

        private void menuItemLockLayout_Click(object sender, System.EventArgs e)
        {
            dockPanel.AllowEndUserDocking = !dockPanel.AllowEndUserDocking;
        }

        private void menuItemLayoutByCode_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItemLayoutByXml_Click(object sender, System.EventArgs e)
        {
        }

        private void CloseAllContents()
        {
        }

        private void SetSchema(object sender, System.EventArgs e)
        {
            CloseAllContents();

            menuItemSchemaVS2005.Checked = (sender == menuItemSchemaVS2005);
            menuItemSchemaVS2003.Checked = (sender == menuItemSchemaVS2003);
        }

        private void SetDocumentStyle(object sender, System.EventArgs e)
        {
            DocumentStyle oldStyle = dockPanel.DocumentStyle;
            DocumentStyle newStyle;
            if (sender == menuItemDockingMdi)
                newStyle = DocumentStyle.DockingMdi;
            else if (sender == menuItemDockingWindow)
                newStyle = DocumentStyle.DockingWindow;
            else if (sender == menuItemDockingSdi)
                newStyle = DocumentStyle.DockingSdi;
            else
                newStyle = DocumentStyle.SystemMdi;

            if (oldStyle == newStyle)
                return;

            if (oldStyle == DocumentStyle.SystemMdi || newStyle == DocumentStyle.SystemMdi)
                CloseAllDocuments();

            dockPanel.DocumentStyle = newStyle;
            menuItemDockingMdi.Checked = (newStyle == DocumentStyle.DockingMdi);
            menuItemDockingWindow.Checked = (newStyle == DocumentStyle.DockingWindow);
            menuItemDockingSdi.Checked = (newStyle == DocumentStyle.DockingSdi);
            menuItemSystemMdi.Checked = (newStyle == DocumentStyle.SystemMdi);
            menuItemLayoutByCode.Enabled = (newStyle != DocumentStyle.SystemMdi);
            menuItemLayoutByXml.Enabled = (newStyle != DocumentStyle.SystemMdi);
            toolBarButtonLayoutByCode.Enabled = (newStyle != DocumentStyle.SystemMdi);
            toolBarButtonLayoutByXml.Enabled = (newStyle != DocumentStyle.SystemMdi);
        }

        private void menuItemCloseAllButThisOne_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                Form activeMdi = ActiveMdiChild;
                foreach (Form form in MdiChildren)
                {
                    if (form != activeMdi)
                        form.Close();
                }
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    if (!document.DockHandler.IsActivated)
                        document.DockHandler.Close();
                }
            }
        }

        private void menuItemShowDocumentIcon_Click(object sender, System.EventArgs e)
        {
            dockPanel.ShowDocumentIcon = menuItemShowDocumentIcon.Checked = !menuItemShowDocumentIcon.Checked;
        }

        private void showRightToLeft_Click(object sender, EventArgs e)
        {
            CloseAllContents();
            if (showRightToLeft.Checked)
            {
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
            }
            else
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
           // m_solutionExplorer.RightToLeftLayout = this.RightToLeftLayout;
            showRightToLeft.Checked = !showRightToLeft.Checked;
        }

        private void exitWithoutSavingLayout_Click(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolBarButtonOpen_Click(object sender, EventArgs e)
        {
            OpenProject();
        }




    }
}
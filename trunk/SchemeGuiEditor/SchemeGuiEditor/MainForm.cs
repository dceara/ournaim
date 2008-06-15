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
                designer.DesignerClosed += new EventHandler(designer_DesignerClosed);
                designer.Show(dockPanel, DockState.Document);
            }
            else
            {
                _formDesigners[e.Data.Name].Show(dockPanel);
            }
        }

        private void designer_DesignerClosed(object sender, EventArgs e)
        {
            FormDesigner designer = sender as FormDesigner;
            designer.SelectedItemChanged -= new EventHandler<DataEventArgs<object>>(designer_SelectedItemChanged);
            designer.DesignerClosed -= new EventHandler(designer_DesignerClosed);
            _formDesigners.Remove(designer.DesignerName);
        }

        private void _propertyWindow_SelectedControlChanged(object sender, DataEventArgs<IScmControl> e)
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
                ProjectManager.Instance.CreateProject(newProjectDialog.ProjectName, newProjectDialog.ProjectLocation,newProjectDialog.ProjectType);
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

        private void menuItemNewWindow_Click(object sender, System.EventArgs e)
        {
            MainForm newWindow = new MainForm();
            newWindow.Text = newWindow.Text + " - New";
            newWindow.Show();
        }

        private void toolBarButtonOpen_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (_activeToolWindow as FormDesigner).SaveDesignerData();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (_activeToolWindow != null)
                    (_activeToolWindow as FormDesigner).DeleteSelectedControl();
            }
        }
                        
    }
}
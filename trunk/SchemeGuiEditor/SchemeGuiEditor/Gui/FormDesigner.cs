using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Projects;
using SchemeGuiEditor.Utils;
using Silver.UI;
using SchemeGuiEditor.ToolboxControls;
using SchemeGuiEditor.ParserComponents;
using System.IO;

namespace SchemeGuiEditor.Gui
{
    public partial class FormDesigner : ToolWindow
    {
        public event EventHandler<DataEventArgs<Object>> SelectedItemChanged;
        public event EventHandler DesignerClosed;

        #region Private Members
        private ProjectFile _projectFile;
        private PickBox _pickBox;
        private Control _selectedColtrol;
        private IScmContainer _startContainer;
        private Control _startParent;
        private bool _dragging;
        private Point _startLocation;
        private List<IScmControlProperties> _propertyObjects;
        private List<object> _loadedItems;
        #endregion

        public FormDesigner(ProjectFile projectFile)
        {
            InitializeComponent();
            _loadedItems = ScmLoader.LoadScmData(projectFile.FullPath);
            _projectFile = projectFile;
            _pickBox = new PickBox(panelContainer);
            _propertyObjects = new List<IScmControlProperties>();
            this.Text = projectFile.Name;
            this.TabText = projectFile.Name;
            DisplayScmControls();
        }

        public string DesignerName
        {
            get { return _projectFile.Name; }
        }
               
        #region Public Methods
        public List<IScmControlProperties> GetPropertiesObjects()
        {
            return _propertyObjects;
        }

        public void SaveDesignerData()
        {
            string scmCode = "";
            FileStream stream = File.Open(_projectFile.FullPath,FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Control ctrl in panelContainer.Controls)
            {
                if (!(ctrl is IScmControl))
                    continue;

                scmCode += GetScmCode(ctrl as IScmControl);
            }
            writer.Write(scmCode);
            writer.Close();
            stream.Close();
        }

        public void SelectControl(Control ctrl,bool throwEvent)
        {
            if (_selectedColtrol != ctrl)
            {
                if (_selectedColtrol != null)
                {
                    _selectedColtrol.MouseDown -= new MouseEventHandler(ctrl_MouseDown);
                    _selectedColtrol.MouseMove -= new MouseEventHandler(ctrl_MouseMove);
                    _selectedColtrol.MouseUp -= new MouseEventHandler(ctrl_MouseUp);
                }

                ctrl.MouseDown += new MouseEventHandler(ctrl_MouseDown);
                ctrl.MouseMove += new MouseEventHandler(ctrl_MouseMove);
                ctrl.MouseUp += new MouseEventHandler(ctrl_MouseUp);

                _selectedColtrol = ctrl;
                if (throwEvent && SelectedItemChanged != null)
                    SelectedItemChanged(this,
                        new DataEventArgs<object>((_selectedColtrol as IScmControl).ScmPropertyObject));
            }
            ctrl.BringToFront();
            _pickBox.SelectControl(ctrl);
        }

        public void DeleteSelectedControl()
        {
            if (_selectedColtrol != null)
                DeleteControl(_selectedColtrol);
        }
        #endregion

        #region Private Methods

        private string GetScmCode(IScmControl ctrl)
        {
            string code = "";
            IScmControlProperties scmContolProperties = ctrl.ScmPropertyObject;

            if (_loadedItems.Contains(scmContolProperties))
                code += GetPrecedingScmData(scmContolProperties);
            code += scmContolProperties.ToScmCode();

            if (ctrl is IScmContainer)
            {
                List<IScmControl> childControls = (ctrl as IScmContainer).LayoutManager.GetChildControls();
                foreach (IScmControl child in childControls)
                    code += GetScmCode(child);
            }
            return code;
        }

        private string GetPrecedingScmData(IScmControlProperties scmContolProperties)
        {
            string code = "";
            int index = _loadedItems.IndexOf(scmContolProperties);
            int startIndex =0;
            
            if (index > 0)
            {
                startIndex = index - 1;

                while (_loadedItems[startIndex] is ScmBlock || _loadedItems[startIndex] is ScmComment)
                    startIndex--;

                startIndex++;
            }

            for (int i = startIndex; i < index; i++)
            {
                if (_loadedItems[i] is ScmBlock)
                {
                    code += (_loadedItems[i] as ScmBlock).ToScmCode(0);
                }
                else
                    code += (_loadedItems[i] as ScmComment).ToScmCode(0);
            }

            return code;
        }

        private IScmContainer GetContainerAt(Point location)
        {
            foreach (Control ctrl in panelContainer.Controls)
            {
                if (ctrl is IScmContainer && ctrl.Bounds.Contains(location))
                    return ctrl as IScmContainer;
            }
            return null;
        }

        private void DisplayScmControls()
        {
            Dictionary<string,IScmControl> scmControls = new Dictionary<string,IScmControl>();
            foreach (object obj in _loadedItems)
            {
                if (obj is IScmControlProperties)
                {
                    IScmControlProperties ctrlProp = obj as IScmControlProperties;
                    scmControls.Add(ctrlProp.Name, ctrlProp.Control);
                    _propertyObjects.Add(ctrlProp);
                }
            }

            foreach (IScmControlProperties property in _propertyObjects)
            {
                Control ctrl = property.Control as Control;
                IScmControl parent;
                if (scmControls.ContainsKey(property.Parent))
                {
                    parent = scmControls[property.Parent];
                    if (parent is IScmContainer)
                    {
                        (parent as IScmContainer).LayoutManager.AddControl(ctrl);
                        ctrl.Click += new EventHandler(ctrl_Click);
                    }
                }
                else
                {
                    if (ctrl is IScmContainer)
                    {
                        panelContainer.Controls.Add(ctrl);
                        ctrl.Click += new EventHandler(ctrl_Click);
                    }
                }
            }
        }

        private void DeleteControl(Control _selectedColtrol)
        {
            if (_selectedColtrol is IScmContainer)
            {
                List<IScmControl> childs = (_selectedColtrol as IScmContainer).LayoutManager.GetChildControls();
                foreach (IScmControl ctrl in childs)
                    DeleteControl(ctrl as Control);
            }
            _propertyObjects.Remove((_selectedColtrol as IScmControl).ScmPropertyObject);
            if (_selectedColtrol is ScmFrame)
                panelContainer.Controls.Remove(_selectedColtrol);
            else
            {
                Control parent = _selectedColtrol.Parent;
                IScmContainer container;
                while (!(parent is IScmContainer))
                    parent = parent.Parent;
                container = parent as IScmContainer;
                parent = _selectedColtrol.Parent;
                container.LayoutManager.RemoveControl(_selectedColtrol);
                container.LayoutManager.RemoveContainer(parent);
            }
            _pickBox.SelectControl(null);
            if (SelectedItemChanged != null)
                SelectedItemChanged(this, new DataEventArgs<object>(null));
        }


        private string GetDefaultName(IScmControlProperties iScmControlProperties)
        {
            string name = iScmControlProperties.DefaultControlName;
            int i = 0;
            bool exists = true;
            MatchUtil matchUtil = new MatchUtil();

            while (exists)
            {
                i++;
                matchUtil.MatchString = name + i.ToString();
                exists = _propertyObjects.Exists(new Predicate<IScmControlProperties>(matchUtil.Match));
            }

            return name + i.ToString();
        }
        #endregion

        #region Event Handlers
        private void panelContainer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ToolBoxItem)))
            {
                ToolBoxItem toolBoxItem = e.Data.GetData(typeof(ToolBoxItem)) as ToolBoxItem;
                if (toolBoxItem.Object is Type)
                {
                    Control ctrl = Activator.CreateInstance(toolBoxItem.Object as Type) as Control;
                    IScmControl scmCtrl = ctrl as IScmControl;
                    scmCtrl.SetInitialProperties();
                    string name = GetDefaultName(scmCtrl.ScmPropertyObject);
                    scmCtrl.ScmPropertyObject.Name = name;
                    scmCtrl.ScmPropertyObject.Label = name;
                    if (ctrl is ScmFrame)
                    {
                        panelContainer.Controls.Add(ctrl);
                    }
                    else
                    {
                        Point location = panelContainer.PointToClient(new Point(e.X, e.Y));
                        IScmContainer container = GetContainerAt(location);
                        if (container == null)
                            return;
                        container.LayoutManager.AddControl(ctrl,new Point(e.X,e.Y));
                        scmCtrl.ScmPropertyObject.Parent = container.ScmPropertyObject.Name;
                    }
                    ctrl.Click += new EventHandler(ctrl_Click);
                    _propertyObjects.Add(scmCtrl.ScmPropertyObject);
                    SelectControl(ctrl,true);
                }
            }
        }

        private void panelContainer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Silver.UI.ToolBoxItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void ctrl_MouseUp(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            _dragging = false;

            if (!(ctrl is ScmFrame) && _startContainer != null)
            {
                panelContainer.Controls.Remove(ctrl);

                panelContainer.SuspendLayout();
                IScmContainer newParent = GetContainerAt(ctrl.Location);
                if (newParent == null|| newParent == ctrl)
                {
                    _startContainer.LayoutManager.AddControl(ctrl, _startLocation);
                }
                else
                {
                    bool sameParent;
                    newParent.LayoutManager.AddControl(ctrl,panelContainer.PointToScreen(ctrl.Location),out sameParent);
                    (ctrl as IScmControl).ScmPropertyObject.Parent = newParent.ScmPropertyObject.Name;
                    if (!sameParent)
                        _startContainer.LayoutManager.RemoveContainer(_startParent);
                }
                _startContainer = null;
                SelectControl(ctrl,true);
                Console.WriteLine(ctrl.Location.X + " - " + ctrl.Location.Y);
                panelContainer.ResumeLayout(false);
            }
        }

        private void ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                _pickBox.MoveControl(e);
            }
        }

        private void ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            _pickBox.StartMove(e);
            _dragging = true;

            if (!(ctrl is ScmFrame))
            {
                _startLocation = ctrl.Parent.PointToScreen(ctrl.Location);
                Control parent = ctrl.Parent;
                while (!(parent is IScmContainer))
                    parent = parent.Parent;
                _startContainer = parent as IScmContainer;
                _startParent = ctrl.Parent;
                _startContainer.LayoutManager.RemoveControl(ctrl);

                ctrl.Location = panelContainer.PointToClient(_startLocation);
                panelContainer.Controls.Add(ctrl);
                ctrl.BringToFront();
                ctrl.Capture = true;
            }
        }

        private void ctrl_Click(object sender, EventArgs e)
        {
            SelectControl(sender as Control,true);
        }

        private void FormDesigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DesignerClosed != null)
                DesignerClosed(this, EventArgs.Empty);
        }
        #endregion
    }

    public class MatchUtil
    {
        private string _matchString;

        public string MatchString
        {
            get { return _matchString; }
            set { _matchString = value; }
        }

        public Predicate<IScmControlProperties> Match
        {
            get { return IsMatch; }
        }

        private bool IsMatch(IScmControlProperties properties)
        {
            if (properties.Name == MatchString)
                return true;
            return false;
        }
    }
}
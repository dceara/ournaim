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

namespace SchemeGuiEditor.Gui
{
    public partial class FormDesigner : ToolWindow
    {
        public event EventHandler<DataEventArgs<Object>> SelectedItemChanged;

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
               
        #region Public Methods
        public List<IScmControlProperties> GetPropertiesObjects()
        {
            return _propertyObjects;
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
        #endregion

        #region Private Methods
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

        private void SaveDesignerData()
        {
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
                    (ctrl as IScmControl).SetInitialProperties();
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
                    }
                    ctrl.Click += new EventHandler(ctrl_Click);
                    _propertyObjects.Add((ctrl as IScmControl).ScmPropertyObject);
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
        #endregion

    }
}
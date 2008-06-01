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

namespace SchemeGuiEditor.Gui
{
    public partial class FormDesigner : ToolWindow
    {
        #region Members
        private ProjectFile _projectFile;
        private PickBox _pickBox;
        private Control _selectedColtrol;
        private Control _startParent;
        private bool _dragging;
        private Point _startLocation;
        private List<object> _propertyObjects;
        #endregion

        public FormDesigner(ProjectFile projectFile)
        {
            InitializeComponent();
            _projectFile = projectFile;
            _pickBox = new PickBox();
            _propertyObjects = new List<object>();
            this.Text = projectFile.Name;
            this.TabText = projectFile.Name;
        }

        public override List<object> GetPropertiesObjects()
        {
            return _propertyObjects;
        }

        #region Private Methods
        private void SelectControl(Control ctrl)
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
            }
            ctrl.BringToFront();
            _pickBox.SelectControl(ctrl);
        }

        private ScmContainer GetContainerAt(Point location)
        {
            foreach (Control ctrl in panelContainer.Controls)
            {
                if (ctrl is ScmContainer && ctrl.Bounds.Contains(location))
                    return ctrl as ScmContainer;
            }
            return null;
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
                    if (ctrl is ScmFrame)
                    {
                        panelContainer.Controls.Add(ctrl);
                    }
                    else
                    {
                        Point location = panelContainer.PointToClient(new Point(e.X, e.Y));
                        ScmContainer container = GetContainerAt(location);
                        if (container == null)
                            return;
                        container.AddControl(ctrl,new Point(e.X,e.Y));
                    }
                    ctrl.Click += new EventHandler(ctrl_Click);
                    _propertyObjects.Add((ctrl as IScmControl).ScmPropertyObject);
                    SelectControl(ctrl);
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

            if (!(ctrl is ScmFrame) && _startParent != null)
            {
                ScmContainer newParent = GetContainerAt(ctrl.Location);
                if (newParent == null|| newParent == ctrl)
                {
                    ctrl.Location = _startLocation;
                    ctrl.Parent = _startParent;
                }
                else
                {
                    panelContainer.Controls.Remove(ctrl);
                    newParent.AddControl(ctrl,panelContainer.PointToScreen(ctrl.Location));
                }
                _startParent = null;
                SelectControl(ctrl);
            }
        }

        private void ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse move " + sender.GetType().Name);

            if (_dragging)
                _pickBox.MoveControl(e);
        }

        private void ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse down " + sender.GetType().Name);
            Control ctrl = sender as Control;
            if (!(ctrl is ScmFrame))
            {
                _startLocation = ctrl.Location;
                _startParent = ctrl.Parent;
                Console.WriteLine("mouse down startParent: " + _startParent.GetType().ToString());
                _startParent.Controls.Remove(ctrl);
                ctrl.Location = panelContainer.PointToClient(_startParent.PointToScreen(ctrl.Location));
                panelContainer.Controls.Add(ctrl);
                ctrl.BringToFront();
                ctrl.Capture = true;
            }
            _dragging = true;
            _pickBox.StartMove(e);
        }

        private void ctrl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mouse click " + sender.GetType().Name);

            SelectControl(sender as Control);
        }
        #endregion

    }
}
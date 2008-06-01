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
        private ProjectFile _projectFile;
        private List<Object> _propertyItems;
        private PickBox _pickBox;
        private Control _selectedColtrol;
        private Control _startParent;
        private bool _dragging;
        private Point _startLocation;

        public FormDesigner(ProjectFile projectFile)
        {
            InitializeComponent();
            _projectFile = projectFile;
            _pickBox = new PickBox();
            this.Text = projectFile.Name;
            this.TabText = projectFile.Name;
        }

        void panelContainer_DragDrop(object sender, DragEventArgs e)
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
                        container.AddControl(ctrl,location);
                    }
                    ctrl.Click += new EventHandler(ctrl_Click);
                    SelectControl(ctrl);
                }
            }
        }

        protected void AddControl(Control ctrl)
        {
            if (ctrl != null)
            {
                panelContainer.Controls.Add(ctrl);
                ctrl.Click += new EventHandler(ctrl_Click);
                if (_selectedColtrol == null)
                    SelectControl(ctrl);
            }
        }

        private void SelectControl(Control ctrl)
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

            _pickBox.SelectControl(ctrl);
        }

        void ctrl_MouseUp(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            _dragging = false;

            if (!(ctrl is ScmFrame))
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
                    ctrl.Location= new Point(ctrl.Location.X- newParent.Location.X,ctrl.Location.Y-newParent.Location.Y);
                    newParent.AddControl(ctrl);
                }
            }
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

        void ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
                _pickBox.MoveControl(e);
        }

        void ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            if (!(ctrl is ScmFrame))
            {
                _startLocation = ctrl.Location;
                _startParent = ctrl.Parent;
                _startParent.Controls.Remove(ctrl);
                ctrl.Location = panelContainer.PointToClient(_startParent.PointToScreen(ctrl.Location));
                panelContainer.Controls.Add(ctrl);
                ctrl.BringToFront();
                _pickBox.SelectControl(ctrl);
            }
            _dragging = true;
            _pickBox.StartMove(e);
        }

        void ctrl_Click(object sender, EventArgs e)
        {
            _pickBox.SelectControl(sender as Control);
        }

        protected Control CreateControl(Type controlType)
        {
            Control ctrl = Activator.CreateInstance(controlType) as Control;

            return ctrl;
        }

        private void panelContainer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Silver.UI.ToolBoxItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
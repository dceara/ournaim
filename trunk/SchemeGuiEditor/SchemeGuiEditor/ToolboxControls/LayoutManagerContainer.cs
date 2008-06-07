using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.ToolboxControls;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class LayoutManagerContainer : UserControl
    {
        private ContainerAlignment _alignment;
        private int _spacing;

        public LayoutManagerContainer()
        {
            InitializeComponent();
            _alignment = new ContainerAlignment(HorizontalAlign.Center, VerticalAlign.Top);
            _alignment.AlignmentChanged += new EventHandler(_alignment_AlignmentChanged);
            ResetLayoutPanel();
        }

        #region Properties
        public ContainerAlignment Alignment
        {
            get { return _alignment; }
            set 
            {
                if (_alignment.HorizontalAlignment != value.HorizontalAlignment ||
                    _alignment.VerticalAlignment != value.VerticalAlignment)
                {
                    _alignment = value;
                    ResetLayoutPanel();
                }
            }
        }

        public int Spacing
        {
            get { return _spacing; }
            set
            {
                if (_spacing != value)
                {
                    _spacing = value;
                    SetControlsSpacing();
                }
            }
        }
        #endregion

        #region Public methods
        public void AddControl(Control ctrl, Point screenPosition)
        {
            bool sameParent;
            AddControl(ctrl, screenPosition, out sameParent);
        }

        public void AddControl(Control ctrl, Point screenPosition,out bool sameParent)
        {
            Console.WriteLine("Add Control " + screenPosition.X + " " + screenPosition.Y);
            Point clientPosition = tableLayoutPanel1.PointToClient(screenPosition);
            Panel existingContainer = tableLayoutPanel1.GetChildAtPoint(clientPosition) as Panel;
            if (existingContainer != null && existingContainer.Controls.Count == 0)
            {
                ctrl.Location = existingContainer.PointToClient(screenPosition);
                existingContainer.AutoSize = true;
                existingContainer.Controls.Add(ctrl);
                sameParent = true;
            }
            else
            {
                int rowIndex;
                if (tableLayoutPanel1.Controls.Count == 0)
                {
                    rowIndex = 1;
                }
                else
                {
                    Control nearestContainer = FindNearestContainer(clientPosition);
                    rowIndex = tableLayoutPanel1.GetRow(nearestContainer);
                    tableLayoutPanel1.RowCount += 1;
                    if (nearestContainer.Location.Y < clientPosition.Y)
                        rowIndex += 1;
                    tableLayoutPanel1.RowStyles.Insert(rowIndex, new RowStyle(SizeType.AutoSize));
                }
                Panel containerPanel = new Panel();
                ctrl.Location = new Point(0, 0);
                containerPanel.Margin = new Padding(0);
                containerPanel.AutoSize = true;
                containerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                containerPanel.Controls.Add(ctrl);
                for (int i = rowIndex; i < tableLayoutPanel1.RowCount - 2; i++)
                {
                    Control cellControl = tableLayoutPanel1.GetControlFromPosition(1, i);
                    tableLayoutPanel1.SetRow(cellControl, i+1);
                }
                tableLayoutPanel1.Controls.Add(containerPanel, 1, rowIndex);
                sameParent = false;
            }
            SetControlsSpacing();
        }

        public void RemoveControl(Control ctrl)
        {
            Panel parent = ctrl.Parent as Panel;
            Size size = new Size(parent.Width, parent.Height);
            parent.AutoSize = false;
            parent.Size = size;
            parent.Controls.Remove(ctrl);
        }

        public void RemoveContainer(Control ctrl)
        {
            if (ctrl.Controls.Count == 0)
            {
                int rowIndex = tableLayoutPanel1.GetRow(ctrl);

                tableLayoutPanel1.Controls.Remove(ctrl);
                tableLayoutPanel1.RowStyles.RemoveAt(rowIndex);

                for (int i = rowIndex + 1; i < tableLayoutPanel1.RowCount - 1; i++)
                {
                    Control cellControl = tableLayoutPanel1.GetControlFromPosition(1, i);
                    tableLayoutPanel1.SetRow(cellControl, i - 1);
                }

                tableLayoutPanel1.RowCount -= 1;
                SetControlsSpacing();
            }
        }

        public Size ComputeMinSize()
        {
            int width = 124;
            int height = 30;

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                height += ctrl.Height;
                if (ctrl.Width > width)
                    width = ctrl.Width;
            }
            return new Size(width, height);
        }
        #endregion

        #region Private Methods
        private void SetControlsSpacing()
        {
            foreach (Control panelContainer in tableLayoutPanel1.Controls)
            {
                int rowIndex = tableLayoutPanel1.GetRow(panelContainer);
                if (rowIndex < tableLayoutPanel1.RowCount - 2)
                    panelContainer.Padding = new Padding(0, 0, 0, _spacing);
                if (rowIndex == tableLayoutPanel1.RowCount - 2)
                    panelContainer.Padding = new Padding(0);
            }
        }

        private void ResetLayoutPanel()
        {
            switch (_alignment.HorizontalAlignment)
            {
                case HorizontalAlign.Left:
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;
                    tableLayoutPanel1.ColumnStyles[2].Width = 100;
                    break;
                case HorizontalAlign.Center:
                    tableLayoutPanel1.ColumnStyles[0].Width = 50;
                    tableLayoutPanel1.ColumnStyles[2].Width = 50;
                    break;
                case HorizontalAlign.Right:
                    tableLayoutPanel1.ColumnStyles[0].Width = 100;
                    tableLayoutPanel1.ColumnStyles[2].Width = 0;
                    break;
            }
            switch (_alignment.VerticalAlignment)
            {
                case VerticalAlign.Top:
                    tableLayoutPanel1.RowStyles[0].Height = 0;
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].Height = 100;
                    break;
                case VerticalAlign.Center:
                    tableLayoutPanel1.RowStyles[0].Height = 50;
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].Height = 50;
                    break;
                case VerticalAlign.Bottom:
                    tableLayoutPanel1.RowStyles[0].Height = 100;
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].Height = 0;
                    break;
            }
        }

        private Control FindNearestContainer(Point clientPosition)
        {
            Control nearestContainer = null;
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl.Location.Y > clientPosition.Y)
                {
                    if (nearestContainer == null || nearestContainer.Location.Y > ctrl.Location.Y)
                        nearestContainer = ctrl;
                }
                else
                {
                    if (nearestContainer == null || nearestContainer.Location.Y < ctrl.Location.Y)
                        nearestContainer = ctrl;
                }
            }
            return nearestContainer;
        }
        #endregion

        #region EventHandlers
        void _alignment_AlignmentChanged(object sender, EventArgs e)
        {
            ResetLayoutPanel();
        }
        #endregion
    }
}

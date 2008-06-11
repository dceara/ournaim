using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.ToolboxControls;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class LayoutManagerContainer : UserControl
    {
        public event EventHandler ContentSizeChanged;
        private ContainerAlignment _alignment;
        private int _spacing;
        private int _strechRowCount;

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
        
        public void AddControl(Control ctrl)
        {
            Point location = ctrl.Location;
            //right bottom corner of the container - to add the control at the last position
            Point screenLocation = tableLayoutPanel1.PointToScreen(new Point(tableLayoutPanel1.Width, tableLayoutPanel1.Height));
            AddControl(ctrl, screenLocation);
            ctrl.Location = location;
        }

        public void AddControl(Control ctrl, Point screenPosition)
        {
            bool sameParent;
            AddControl(ctrl, screenPosition, out sameParent);
        }

        public void AddControl(Control ctrl, Point screenPosition,out bool sameParent)
        {
            Point clientPosition = tableLayoutPanel1.PointToClient(screenPosition);
            Panel existingContainer = tableLayoutPanel1.GetChildAtPoint(clientPosition) as Panel;
            if (existingContainer != null && existingContainer.Controls.Count == 0)
            {
                ctrl.Location = existingContainer.PointToClient(screenPosition);
                tableLayoutPanel1.GetColumnSpan(existingContainer);
                existingContainer.AutoSize = true;
                existingContainer.Controls.Add(ctrl);
                ctrl.Margin = new Padding(0, 0, ctrl.Location.X, ctrl.Location.Y);
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
                ctrl.Location = new Point(2, 2);
                containerPanel.Margin = new Padding(0);
                containerPanel.AutoSize = true;
                containerPanel.BackColor = Color.Aquamarine;
                containerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                containerPanel.Controls.Add(ctrl);
                for (int i = rowIndex; i < tableLayoutPanel1.RowCount - 2; i++)
                {
                    Control cellControl = tableLayoutPanel1.GetControlFromPosition(1, i);
                    tableLayoutPanel1.SetRow(cellControl, i+1);
                }
                tableLayoutPanel1.Controls.Add(containerPanel, 1, rowIndex);
                IScmControlProperties ctrlProp = (ctrl as IScmControl).ScmPropertyObject;
                if (ctrlProp.StretchableHeight)
                    StrechHeight(ctrl);
                if (ctrlProp.StretchableWidth)
                    StrechWidth(ctrl);
                sameParent = false;
            }
            (ctrl as IScmControl).StrechChanged += new EventHandler<DataEventArgs<StrechDirection>>(LayoutManagerContainer_StrechChanged);
            (ctrl as IScmControl).ContentSizeChanged += new EventHandler(LayoutManagerContainer_SizeChanged);
            SetControlsSpacing();
            LayoutManagerContainer_SizeChanged(this, EventArgs.Empty);
        }

        void LayoutManagerContainer_SizeChanged(object sender, EventArgs e)
        {
            if (ContentSizeChanged != null)
                ContentSizeChanged(this, EventArgs.Empty);
        }

        public void RemoveControl(Control ctrl)
        {
            Panel parent = ctrl.Parent as Panel;
            Size size = new Size(parent.Width, parent.Height);
            parent.AutoSize = false;
            parent.Size = size;
            parent.Controls.Remove(ctrl);
            (ctrl as IScmControl).StrechChanged -= new EventHandler<DataEventArgs<StrechDirection>>(LayoutManagerContainer_StrechChanged);
            (ctrl as IScmControl).ContentSizeChanged -= new EventHandler(LayoutManagerContainer_SizeChanged);
        }

        public void RemoveContainer(Control ctrl)
        {
            if (ctrl.Controls.Count == 0)
            {
                int rowIndex = tableLayoutPanel1.GetRow(ctrl);

                tableLayoutPanel1.Controls.Remove(ctrl);
                if (tableLayoutPanel1.RowStyles[rowIndex].SizeType == SizeType.Percent)
                {
                    _strechRowCount--;
                    if (_strechRowCount == 0)
                    {
                        ResetVerticalAlignment(_alignment.VerticalAlignment);
                    }
                }
                tableLayoutPanel1.RowStyles.RemoveAt(rowIndex);

                for (int i = rowIndex + 1; i < tableLayoutPanel1.RowCount - 1; i++)
                {
                    Control cellControl = tableLayoutPanel1.GetControlFromPosition(1, i);
                    tableLayoutPanel1.SetRow(cellControl, i - 1);
                }

                tableLayoutPanel1.RowCount -= 1;
                SetControlsSpacing();
                LayoutManagerContainer_SizeChanged(this, EventArgs.Empty);
            }
        }

        public Size ComputeMinSize()
        {
            int width = 124;
            int height = 30;

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                height += ctrl.Height + 2;
                if (ctrl.Width > width && tableLayoutPanel1.GetColumnSpan(ctrl) == 1)
                    width = ctrl.Width + 8;
            }
            return new Size(width, height);
        }


        public List<IScmControl> GetChildControls()
        {
            List<IScmControl> ctrls = new List<IScmControl>();

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                ctrls.Add(ctrl.Controls[0] as IScmControl);
            }
            return ctrls;
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
            ResetHorizontalAlignment(_alignment.HorizontalAlignment);
            ResetVerticalAlignment(_alignment.VerticalAlignment);
        }

        private void ResetVerticalAlignment(VerticalAlign align)
        {
            switch (align)
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

        private void ResetHorizontalAlignment(HorizontalAlign align)
        {
            switch (align)
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

        private void StrechWidth(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            int span = tableLayoutPanel1.GetColumnSpan(pnl);
            if (span == 1) //not streched
            {
                tableLayoutPanel1.SetColumn(pnl, 0);
                tableLayoutPanel1.SetColumnSpan(pnl, 3);
                ctrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                pnl.Width = tableLayoutPanel1.Width;
                pnl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            }
            else
            {
                ctrl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                pnl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                tableLayoutPanel1.SetColumnSpan(pnl, 1);
                tableLayoutPanel1.SetColumn(pnl, 1);
            }
            Console.WriteLine("change rowspan :" + span);
        }

        private void StrechHeight(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            int row = tableLayoutPanel1.GetRow(pnl);
            RowStyle rowStyle = tableLayoutPanel1.RowStyles[row];
            if (rowStyle.SizeType == SizeType.AutoSize)
            {
                rowStyle.SizeType = SizeType.Percent;
                rowStyle.Height = 100;
                if (_strechRowCount == 0)
                {
                    tableLayoutPanel1.RowStyles[0].Height = 0;
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].Height = 0;
                }
                _strechRowCount++;
            }
            else
            {
                rowStyle.SizeType = SizeType.AutoSize;
                _strechRowCount--;
                if (_strechRowCount == 0)
                {
                    ResetVerticalAlignment(_alignment.VerticalAlignment);
                }
            }
        }
        #endregion

        #region EventHandlers
        void _alignment_AlignmentChanged(object sender, EventArgs e)
        {
            ResetLayoutPanel();
        }

        void LayoutManagerContainer_StrechChanged(object sender, DataEventArgs<StrechDirection> e)
        {
            if (e.Data == StrechDirection.Horizontal)
                StrechWidth(sender as Control);
            else
                StrechHeight(sender as Control);
        }
               
        #endregion

    }
}

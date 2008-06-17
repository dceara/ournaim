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
    public partial class VerticalLayoutManagerContainer : UserControl, ILayoutManager
    {
        public event EventHandler<DataEventArgs<int>> MinWidthChanged;
        public event EventHandler<DataEventArgs<int>> MinHeightChanged;

        #region Private Members
        private ContainerAlignment _alignment;
        private int _spacing;
        private int _strechRowCount;
        private int _minHeight;
        private int _minWidth;
        private int _border;
        #endregion

        #region Constructor
        public VerticalLayoutManagerContainer()
        {
            InitializeComponent();
            _alignment = new ContainerAlignment(HorizontalAlign.Center, VerticalAlign.Top);
            _alignment.AlignmentChanged += new EventHandler<DataEventArgs<AlignmentType>>(_alignment_AlignmentChanged);
            ResetAlignment();
        }
        #endregion

        #region Properties
        [Browsable(false)]
        public ContainerAlignment Alignment
        {
            get { return _alignment; }
            set
            {
                if (_alignment.HorizontalAlignment != value.HorizontalAlignment)
                    ResetHorizontalAlignment(value.HorizontalAlignment);
                if (_alignment.VerticalAlignment != value.VerticalAlignment)
                    ResetVerticalAlignment(value.VerticalAlignment);
                _alignment = value;
            }
        }

        [Browsable(false)]
        public int Spacing
        {
            get { return _spacing; }
            set
            {
                if (_spacing != value)
                {
                    _spacing = value;
                    //RecomputeVerticalSizes();
                    AlignAllControls();
                }
            }
        }

        [Browsable(false)]
        public int Border
        {
            get { return _border; }
            set 
            { 
                _border = value;
                this.Padding = new Padding(value);
            }
        }

        #endregion

        #region Public methods
        
        public void AddControl(Control ctrl)
        {
            //right bottom corner of the container - to add the control at the last position
            Point screenLocation = tableLayoutPanel1.PointToScreen(new Point(tableLayoutPanel1.Width, tableLayoutPanel1.Height));
            AddControl(ctrl, screenLocation);
        }

        public void AddControl(Control ctrl, Point screenPosition)
        {
            bool sameParent;
            AddControl(ctrl, screenPosition, out sameParent);
        }

        public void AddControl(Control ctrl, Point screenPosition,out bool sameParent)
        {
            sameParent = false;
            Point clientPosition = tableLayoutPanel1.PointToClient(screenPosition);
            Panel existingContainer = tableLayoutPanel1.GetChildAtPoint(clientPosition) as Panel;

            if (existingContainer != null && (existingContainer.Controls.Count == 0 || (existingContainer.Controls[0] is IScmContainer)))
            {
                if (existingContainer.Controls.Count == 0)
                {
                    existingContainer.Controls.Add(ctrl);
                    AlignControl(existingContainer, ctrl);
                    sameParent = true;
                }
                else
                {
                        IScmContainer container = existingContainer.Controls[0] as IScmContainer;
                        container.LayoutManager.AddControl(ctrl, screenPosition, out sameParent);
                }
            }
            else
            {
                int rowIndex;
                IScmContainee scmCtrl = (ctrl as IScmContainee);
                Control nearestContainer = FindNearestContainer(clientPosition);
                if (nearestContainer != null)
                {
                    rowIndex = tableLayoutPanel1.GetRow(nearestContainer);
                    if (nearestContainer.Location.Y < clientPosition.Y)
                        rowIndex += 1;
                }
                else
                    rowIndex = 1;

                tableLayoutPanel1.RowCount += 1;
                tableLayoutPanel1.RowStyles.Insert(rowIndex, new RowStyle(SizeType.Absolute, ctrl.Height + 2*scmCtrl.VerticalMargin));
                MoveControls(rowIndex);
                AddControlToCell(rowIndex, ctrl);
                RecomputeVerticalSizes();
                SetHorizontalPosition(ctrl);
                if (scmCtrl.StretchableHeight)
                    StrechHeight(ctrl);
                if (scmCtrl.StretchableWidth)
                    StrechWidth(ctrl);
                scmCtrl.ScmContainer = this.Parent as IScmContainer;
                sameParent = false;   
            }
        }

        public void SetHorizontalPosition(Control ctrl)
        {
            IScmContainee scmCtrl = ctrl as IScmContainee;
            int width = scmCtrl.MinWidth + 2* scmCtrl.HorizontalMargin;
            
            if (tableLayoutPanel1.ColumnStyles[1].Width < width)
            {
                tableLayoutPanel1.ColumnStyles[1].Width = width;
                AlignAllControls();
                _minWidth = width;
                RaiseWidthChanged();
            }
            else
            {
                int minwidth = RecomputeMinWidth();
                if (minwidth != _minWidth)
                {
                    _minWidth = minwidth;
                    tableLayoutPanel1.ColumnStyles[1].Width = minwidth;
                    AlignAllControls();
                    RaiseWidthChanged();
                }
                else
                    AlignControl(ctrl.Parent as Panel, ctrl);
            }
        }

        public void SetVerticalPozition(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            RecomputeVerticalSizes();
            AlignControl(pnl, ctrl);
        }

        public void RemoveControl(Control ctrl)
        {
            Panel parent = ctrl.Parent as Panel;
            parent.Controls.Remove(ctrl);
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
                RecomputeVerticalSizes();
                RecomputeHorizontalSizes();
            }
        }

        public void StrechWidth(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            IScmContainee scmCtrl = ctrl as IScmContainee;
            if (scmCtrl.StretchableWidth)
            {
                ctrl.Width = pnl.Width - 2 * scmCtrl.HorizontalMargin;
                ctrl.Anchor = ctrl.Anchor | AnchorStyles.Right;
                tableLayoutPanel1.SetColumn(pnl, 0);
                tableLayoutPanel1.SetColumnSpan(pnl, 3);
            }
            else
            {
                ctrl.Anchor = ctrl.Anchor & ~AnchorStyles.Right;
                tableLayoutPanel1.SetColumnSpan(pnl, 1);
                tableLayoutPanel1.SetColumn(pnl, 1);
            }
            SetHorizontalPosition(ctrl);
        }

        public void StrechHeight(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            IScmContainee scmCtrl = ctrl as IScmContainee;
            int row = tableLayoutPanel1.GetRow(pnl);
            RowStyle rowStyle = tableLayoutPanel1.RowStyles[row];
            if (scmCtrl.StretchableHeight)
            {
                ctrl.Anchor = ctrl.Anchor | AnchorStyles.Bottom;
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
                ctrl.Anchor = ctrl.Anchor & ~AnchorStyles.Bottom;
                rowStyle.SizeType = SizeType.Absolute;
                _strechRowCount--;
                if (_strechRowCount == 0)
                {
                    ResetVerticalAlignment(_alignment.VerticalAlignment);
                }
                RecomputeVerticalSizes();
            }
        }

        public List<IScmControl> GetChildControls()
        {
            List<IScmControl> ctrls = new List<IScmControl>();

            for (int i = 1; i < tableLayoutPanel1.RowCount - 1; i++)
            {
                Control pnl = tableLayoutPanel1.GetControlFromPosition(1, i);
                if (pnl.Controls.Count > 0)
                    ctrls.Add(pnl.Controls[0] as IScmControl);
            }
            return ctrls;
        }
        #endregion

        #region Private Methods

        private void RecomputeVerticalSizes()
        {
            int totalHeight = 0;
            foreach (Control pnl in tableLayoutPanel1.Controls)
            {
                if (pnl.Controls.Count == 0)
                    continue;

                IScmContainee scmControl = pnl.Controls[0] as IScmContainee;
                int rowIndex = tableLayoutPanel1.GetRow(pnl);
                int height = scmControl.VerticalMargin * 2 + scmControl.MinHeight;
                if (rowIndex < tableLayoutPanel1.RowCount - 2)
                    height += _spacing;
                if (!scmControl.StretchableHeight)
                    tableLayoutPanel1.RowStyles[rowIndex].Height = height;
                totalHeight += height;
            }
            _minHeight = totalHeight;
            RaiseHeightChenged();
        }

        private void RecomputeHorizontalSizes()
        {
            int minwidth = RecomputeMinWidth();
            if (minwidth != _minWidth)
            {
                _minWidth = minwidth;
                tableLayoutPanel1.ColumnStyles[1].Width = minwidth;
                AlignAllControls();
                RaiseWidthChanged();
            }
        }

        private int RecomputeMinWidth()
        {
            int maxWidth = 0;
            foreach (Control pnl in tableLayoutPanel1.Controls)
            {
                if (pnl.Controls.Count == 0)
                    continue;

                IScmContainee scmCtrl = pnl.Controls[0] as IScmContainee;
                int width = 2 * scmCtrl.HorizontalMargin + scmCtrl.MinWidth;
                if (width > maxWidth)
                    maxWidth = width;
            }
            return maxWidth;
        }

        private void AlignAllControls()
        {
            foreach (Control pnl in tableLayoutPanel1.Controls)
                AlignControl(pnl as Panel);
        }

        private void AlignControl(Panel panel)
        {
            if (panel.Controls.Count > 0)
                AlignControl(panel, panel.Controls[0]);
        }

        private void AlignControl(Panel parent, Control ctrl)
        {
            IScmContainee scmCtrl = ctrl as IScmContainee;
            if (scmCtrl.StretchableWidth)
            {
                ctrl.Location = new Point(scmCtrl.HorizontalMargin, scmCtrl.VerticalMargin);
                return;
            }
            switch (_alignment.HorizontalAlignment)
            {
                case HorizontalAlign.Center:
                    ctrl.Location = new Point(parent.Width / 2 - scmCtrl.MinWidth / 2, scmCtrl.VerticalMargin);
                    break;
                case HorizontalAlign.Left:
                    ctrl.Location = new Point(scmCtrl.HorizontalMargin, scmCtrl.VerticalMargin);
                    break;
                case HorizontalAlign.Right:
                    ctrl.Location = new Point(parent.Width - scmCtrl.MinWidth - scmCtrl.HorizontalMargin, scmCtrl.VerticalMargin);
                    break;
            }
        }

        private void AddControlToCell(int rowIndex, Control ctrl)
        {
            ctrl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            IScmContainee scmCtrl = ctrl as IScmContainee;
            Panel containerPanel = new Panel();
            containerPanel.Margin = new Padding(0);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.BackColor = Color.Aquamarine;
            Size size = ctrl.Size;
            containerPanel.Controls.Add(ctrl);
            ctrl.Size = size;
            tableLayoutPanel1.Controls.Add(containerPanel, 1, rowIndex);
        }

        private void MoveControls(int startIndex)
        {
            for (int i = tableLayoutPanel1.RowCount - 3; i >= startIndex; i--)
            {
                Control cellControl = tableLayoutPanel1.GetControlFromPosition(1, i);
                tableLayoutPanel1.SetRow(cellControl, i + 1);
            }
        }

        private void ResetAlignment()
        {
            ResetHorizontalAlignment(_alignment.HorizontalAlignment);
            ResetVerticalAlignment(_alignment.VerticalAlignment);
        }

        private void ResetVerticalAlignment(VerticalAlign align)
        {
            if (_strechRowCount > 0)
                return;

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
            AlignAllControls();
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

        private void RaiseHeightChenged()
        {
            if (MinHeightChanged != null)
                MinHeightChanged(this, new DataEventArgs<int>(_minHeight));
        }

        private void RaiseWidthChanged()
        {
            if (MinWidthChanged != null)
                MinWidthChanged(this, new DataEventArgs<int>(_minWidth));
        }

        #endregion

        #region EventHandlers
        void _alignment_AlignmentChanged(object sender, DataEventArgs<AlignmentType> e)
        {
            if (e.Data == AlignmentType.Vertical)
                ResetVerticalAlignment(_alignment.VerticalAlignment);
            else
                ResetHorizontalAlignment(_alignment.HorizontalAlignment);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        #endregion
    }
}

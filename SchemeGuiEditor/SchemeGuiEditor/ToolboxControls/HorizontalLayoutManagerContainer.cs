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
    public partial class HorizontalLayoutManagerContainer : UserControl, ILayoutManager
    {
        public event EventHandler<DataEventArgs<int>> MinWidthChanged;
        public event EventHandler<DataEventArgs<int>> MinHeightChanged;

        #region Private Members
        private ContainerAlignment _alignment;
        private int _spacing;
        private int _border;
        private List<int> _strechColumns;
        private int _minHeight;
        private int _minWidth;
        #endregion

        #region Constructor
        public HorizontalLayoutManagerContainer()
        {
            InitializeComponent();
            _strechColumns = new List<int>();
            _alignment = new ContainerAlignment(HorizontalAlign.Left, VerticalAlign.Center);
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
                    //RecomputeHorizontalSizes();
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
            Point location = ctrl.Location;
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
                int colIndex;
                IScmContainee scmCtrl = (ctrl as IScmContainee);
                Control nearestContainer = FindNearestContainer(clientPosition);
                if (nearestContainer != null)
                {
                    colIndex = tableLayoutPanel1.GetColumn(nearestContainer);
                    if (nearestContainer.Location.X < clientPosition.X)
                        colIndex += 1;
                }
                else
                    colIndex = 1;

                tableLayoutPanel1.ColumnCount += 1;
                tableLayoutPanel1.ColumnStyles.Insert(colIndex, new ColumnStyle(SizeType.Absolute, ctrl.Width + 2*scmCtrl.HorizontalMargin));
                MoveControls(colIndex);
                AddControlToCell(colIndex, ctrl);
                RecomputeHorizontalSizes();
                SetVerticalPozition(ctrl);
                if (scmCtrl.StretchableHeight)
                    StrechHeight(ctrl);
                if (scmCtrl.StretchableWidth)
                    StrechWidth(ctrl);
                scmCtrl.ScmContainer = this.Parent as IScmContainer;
                sameParent = false;   
            }
        }

        public void SetVerticalPozition(Control ctrl)
        {
            IScmContainee scmCtrl = ctrl as IScmContainee;
            int height = scmCtrl.MinHeight + 2* scmCtrl.VerticalMargin;
            
            if (tableLayoutPanel1.RowStyles[1].Height < height)
            {
                tableLayoutPanel1.RowStyles[1].Height = height;
                AlignAllControls();
                _minHeight = height;
                RaiseHeightChenged();
            }
            else
            {
                int minheight = RecomputeMinHeight();
                if (minheight != _minHeight)
                {
                    _minHeight = minheight;
                    tableLayoutPanel1.RowStyles[1].Height = minheight;
                    AlignAllControls();
                    RaiseHeightChenged();
                }
                else
                    AlignControl(ctrl.Parent as Panel, ctrl);
            }
        }

        public void SetHorizontalPosition(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            RecomputeHorizontalSizes();
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
                int colIndex = tableLayoutPanel1.GetColumn(ctrl);

                tableLayoutPanel1.Controls.Remove(ctrl);

                if (tableLayoutPanel1.ColumnStyles[colIndex].SizeType == SizeType.Percent)
                {
                    _strechColumns.Remove(colIndex);
                    if (_strechColumns.Count == 0)
                        ResetHorizontalAlignment(_alignment.HorizontalAlignment);
                    else
                        RecomputeStrechedColumns();
                }
                
                for (int i = colIndex + 1; i < tableLayoutPanel1.ColumnCount - 1; i++)
                {
                    if (_strechColumns.Contains(i))
                    {
                        _strechColumns.Remove(i);
                        _strechColumns.Add(i - 1);
                    }
                    Control cellControl = tableLayoutPanel1.GetControlFromPosition(i, 1);
                    tableLayoutPanel1.SetColumn(cellControl, i - 1);
                }

                tableLayoutPanel1.ColumnStyles.RemoveAt(colIndex);

                tableLayoutPanel1.ColumnCount -= 1;
                RecomputeHorizontalSizes();
                RecomputeVerticalSizes();
            }
        }

        public void StrechHeight(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            IScmContainee scmCtrl = ctrl as IScmContainee;
            if (scmCtrl.StretchableHeight)
            {
                ctrl.Height = pnl.Height - 2 * scmCtrl.VerticalMargin;
                ctrl.Anchor = ctrl.Anchor | AnchorStyles.Bottom;
                tableLayoutPanel1.SetRow(pnl, 0);
                tableLayoutPanel1.SetRowSpan(pnl, 3);
            }
            else
            {
                ctrl.Anchor = ctrl.Anchor & ~AnchorStyles.Bottom;
                tableLayoutPanel1.SetRowSpan(pnl, 1);
                tableLayoutPanel1.SetRow(pnl, 1);
            }
            SetVerticalPozition(ctrl);
        }

        public void StrechWidth(Control ctrl)
        {
            Panel pnl = ctrl.Parent as Panel;
            IScmContainee scmCtrl = ctrl as IScmContainee;
            int col = tableLayoutPanel1.GetColumn(pnl);
            ColumnStyle colStyle = tableLayoutPanel1.ColumnStyles[col];
            if (scmCtrl.StretchableWidth)
            {
                ctrl.Anchor = ctrl.Anchor | AnchorStyles.Right;
                colStyle.SizeType = SizeType.Percent;
                colStyle.Width = 100;
                if (_strechColumns.Count == 0)
                {
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;
                    tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount - 1].Width = 0;
                }
                _strechColumns.Add(col);
            }
            else
            {
                ctrl.Anchor = ctrl.Anchor & ~AnchorStyles.Right;
                colStyle.SizeType = SizeType.Absolute;
                _strechColumns.Remove(col);
                if (_strechColumns.Count == 0)
                {
                    ResetHorizontalAlignment(_alignment.HorizontalAlignment);
                }
                RecomputeHorizontalSizes();
            }
            RecomputeStrechedColumns();
        }

        public List<IScmControl> GetChildControls()
        {
            List<IScmControl> ctrls = new List<IScmControl>();

            for (int i = 1; i < tableLayoutPanel1.ColumnCount - 1; i++)
            {
                Control pnl = tableLayoutPanel1.GetControlFromPosition(i, 1);
                if (pnl.Controls.Count > 0)
                    ctrls.Add(pnl.Controls[0] as IScmControl);
            }
            return ctrls;
        }
        #endregion

        #region Private Methods

        private void RecomputeStrechedColumns()
        {
            int totalWidth = 0;

            if (_strechColumns.Count == 0)
                return;
            foreach (int col in _strechColumns)
            {
                Control pnl = tableLayoutPanel1.GetControlFromPosition(col, 1);
                if (pnl.Controls.Count > 0)
                {
                    IScmContainee scmCtrl = pnl.Controls[0] as IScmContainee;
                    totalWidth += scmCtrl.MinWidth;
                }
            }

            float ho = (float)(this.Width - totalWidth) / _strechColumns.Count;

            foreach (int col in _strechColumns)
            {
                Control pnl = tableLayoutPanel1.GetControlFromPosition(col, 1);
                if (pnl.Controls.Count > 0)
                {
                    IScmContainee scmCtrl = pnl.Controls[0] as IScmContainee;
                    tableLayoutPanel1.ColumnStyles[col].Width = (float) (scmCtrl.MinWidth + ho) * 100 / this.Width;
                }
            }
        }

        private void RecomputeHorizontalSizes()
        {
            int totalWidth = 0;
            foreach (Control pnl in tableLayoutPanel1.Controls)
            {
                if (pnl.Controls.Count == 0)
                    continue;

                IScmContainee scmControl = pnl.Controls[0] as IScmContainee;
                int colIndex = tableLayoutPanel1.GetColumn(pnl);
                int width = scmControl.HorizontalMargin * 2 + scmControl.MinWidth;
                if (colIndex < tableLayoutPanel1.ColumnCount - 2)
                    width += _spacing;
                if (!scmControl.StretchableWidth)
                    tableLayoutPanel1.ColumnStyles[colIndex].Width = width;
                totalWidth += width;
            }
            _minWidth = totalWidth;
            RaiseWidthChanged();
        }

        private void RecomputeVerticalSizes()
        {
            int minheight = RecomputeMinHeight();
            if (minheight != _minHeight)
            {
                _minHeight = minheight;
                tableLayoutPanel1.RowStyles[1].Height = minheight;
                AlignAllControls();
                RaiseHeightChenged();
            }
        }

        private int RecomputeMinHeight()
        {
            int maxHeight = 0;
            foreach (Control pnl in tableLayoutPanel1.Controls)
            {
                if (pnl.Controls.Count == 0)
                    continue;

                IScmContainee scmCtrl = pnl.Controls[0] as IScmContainee;
                int height = 2 * scmCtrl.VerticalMargin + scmCtrl.MinHeight;
                if (height > maxHeight)
                    maxHeight = height;
            }
            return maxHeight;
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
            if (scmCtrl.StretchableHeight)
            {
                ctrl.Location = new Point(scmCtrl.HorizontalMargin, scmCtrl.VerticalMargin);
                return;
            }
            switch (_alignment.VerticalAlignment)
            {
                case VerticalAlign.Center:
                    ctrl.Location = new Point(scmCtrl.HorizontalMargin, parent.Height / 2 - scmCtrl.MinHeight / 2);
                    break;
                case VerticalAlign.Top:
                    ctrl.Location = new Point(scmCtrl.HorizontalMargin, scmCtrl.VerticalMargin);
                    break;
                case VerticalAlign.Bottom:
                    ctrl.Location = new Point(scmCtrl.HorizontalMargin, parent.Height - scmCtrl.MinHeight - scmCtrl.VerticalMargin);
                    break;
            }
        }

        private void AddControlToCell(int colIndex, Control ctrl)
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
            tableLayoutPanel1.Controls.Add(containerPanel, colIndex, 1);
        }

        private void MoveControls(int startIndex)
        {
            for (int i = tableLayoutPanel1.ColumnCount - 3; i >= startIndex; i--)
            {
                if (_strechColumns.Contains(i))
                {
                    _strechColumns.Remove(i);
                    _strechColumns.Add(i + 1);
                }
                Control cellControl = tableLayoutPanel1.GetControlFromPosition(i, 1);
                tableLayoutPanel1.SetColumn(cellControl, i + 1);
            }
        }

        private void ResetAlignment()
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
                    tableLayoutPanel1.RowStyles[2].Height = 100;
                    break;
                case VerticalAlign.Center:
                    tableLayoutPanel1.RowStyles[0].Height = 50;
                    tableLayoutPanel1.RowStyles[2].Height = 50;
                    break;
                case VerticalAlign.Bottom:
                    tableLayoutPanel1.RowStyles[0].Height = 100;
                    tableLayoutPanel1.RowStyles[2].Height = 0;
                    break;
            }
            AlignAllControls();
        }

        private void ResetHorizontalAlignment(HorizontalAlign align)
        {
            if (_strechColumns.Count > 0)
                return;

            switch (align)
            {
                case HorizontalAlign.Left:
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;
                    tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount-1].Width = 100;
                    break;
                case HorizontalAlign.Center:
                    tableLayoutPanel1.ColumnStyles[0].Width = 50;
                    tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount - 1].Width = 50;
                    break;
                case HorizontalAlign.Right:
                    tableLayoutPanel1.ColumnStyles[0].Width = 100;
                    tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount - 1].Width = 0;
                    break;
            }
        }

        private Control FindNearestContainer(Point clientPosition)
        {
            Control nearestContainer = null;
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl.Location.X > clientPosition.X)
                {
                    if (nearestContainer == null || nearestContainer.Location.X > ctrl.Location.X)
                        nearestContainer = ctrl;
                }
                else
                {
                    if (nearestContainer == null || nearestContainer.Location.X < ctrl.Location.X)
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

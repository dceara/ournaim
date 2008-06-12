using System;
using System.Windows.Forms;
using System.Drawing;
using SchemeGuiEditor.ToolboxControls;
using System.Collections.Generic;

namespace SchemeGuiEditor.Utils
{
    public enum ControlPoint
    {
        TopLeft,
        Top,
        TopRight,
        Right,
        BottomRight,
        Bottom,
        BottomLeft,
        Left
    }
    /// <summary>
    /// This class implements sizing and moving functions for runtime editing of graphic controls
    /// </summary>
    public class PickBox
    {
        #region Constants
        private const int BoxSize = 8;
        private const int MinSize = 20;
        #endregion

        #region Members
        private Color BoxColor = Color.White;
        private Control _control;
        private Control _parentContainer;
        private Control _parent;
        private List<Label> _lbls = new List<Label>();
        private int _startl;
        private int _startt;
        private int _startw;
        private int _starth;
        private int _startx;
        private int _starty;
        private bool _dragging;
        private Cursor[] arrArrow = new Cursor[] {Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE, Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE};
        private Cursor oldCursor;
        #endregion

        #region Constructor
        // Constructor creates 8 sizing handles & wires mouse events to each that implement sizing functions
        public PickBox(Control parentContainer)
        {
            _parentContainer = parentContainer;
            for (int i = 0; i < 8; i++)
            {
                Label lbl = new Label();
                lbl.Tag = i;
                lbl.FlatStyle = 0;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.BackColor = BoxColor;
                lbl.Cursor = arrArrow[i];
                lbl.Text = "";
                lbl.Visible = false;
                _parentContainer.Controls.Add(lbl);
                lbl.MouseDown += new MouseEventHandler(this.lbl_MouseDown);
                lbl.MouseMove += new MouseEventHandler(this.lbl_MouseMove);
                lbl.MouseUp += new MouseEventHandler(this.lbl_MouseUp);
                _lbls.Add(lbl);
            }
        }
        #endregion

        #region Public methods
        public void SelectControl(Control newControl)
        {
            if (newControl == null)
            {
                if (_control != null)
                {
                    _control.SizeChanged -= new EventHandler(_control_SizeChanged);
                    _control.MarginChanged -= new EventHandler(_control_MarginChanged);
                    _control.ParentChanged -= new EventHandler(_control_ParentChanged);
                }
                _control = newControl;
                HideHandles();
                return;
            }
            if (_control != newControl)
            {
                if (_control != null)
                {
                    _control.SizeChanged -= new EventHandler(_control_SizeChanged);
                    _control.MarginChanged -= new EventHandler(_control_MarginChanged);
                    _control.ParentChanged -= new EventHandler(_control_ParentChanged);
                }
                _control = newControl;
                _control.SizeChanged += new EventHandler(_control_SizeChanged);
                _control.ParentChanged += new EventHandler(_control_ParentChanged);
                _control.MarginChanged += new EventHandler(_control_MarginChanged);
                SetParent();
            }
            HideHandles();
            //Position sizing handles around Control
            MoveHandles();
            //Display sizing handles
            ShowHandles();

            oldCursor = _control.Cursor;
            _control.Cursor = Cursors.SizeAll;
        }

        private void SetParent()
        {
            if (_parent != null)
                _parent.LocationChanged -= new EventHandler(_parent_LocationChanged);
            _parent = _control.Parent;
            if (_parent != null)
                _parent.LocationChanged += new EventHandler(_parent_LocationChanged);
        }

        // Get mouse pointer starting position on mouse down and hide sizing handles
        public void StartMove(MouseEventArgs e)
        {
            _startx = e.X;
            _starty = e.Y;
            HideHandles();
        }

        // Reposition the dragged control
        public void MoveControl(MouseEventArgs e)
        {
            int l = _control.Left + e.X - _startx;
            int t = _control.Top + e.Y - _starty;
            int w = _control.Width;
            int h = _control.Height;
            l = (l < 0) ? 0 : ((l + w > _control.Parent.ClientRectangle.Width) ?
              _control.Parent.ClientRectangle.Width - w : l);
            t = (t < 0) ? 0 : ((t + h > _control.Parent.ClientRectangle.Height) ?
            _control.Parent.ClientRectangle.Height - h : t);
            _control.Left = l;
            _control.Top = t;
        }
        #endregion

        #region Private Methods
        private void ShowHandles()
        {
            if (_control != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    _lbls[i].Visible = true;
                    _lbls[i].BringToFront();
                }
            }
        }

        private void HideHandles()
        {
            for (int i = 0; i < 8; i++)
            {
                _lbls[i].Visible = false;
            }
        }

        private void MoveHandles()
        {
            Point location = _parentContainer.PointToClient(_control.Parent.PointToScreen(_control.Location));
            int sX = location.X - BoxSize;
            int sY = location.Y - BoxSize;
            int sW = _control.Width + BoxSize;
            int sH = _control.Height + BoxSize;
            int hB = BoxSize / 2;
            int[] arrPosX = new int[] {sX+hB, sX + sW / 2, sX + sW-hB, sX + sW-hB,
			sX + sW-hB, sX + sW / 2, sX+hB, sX+hB};
            int[] arrPosY = new int[] {sY+hB, sY+hB, sY+hB, sY + sH / 2, sY + sH-hB,
			sY + sH-hB, sY + sH-hB, sY + sH / 2};
            for (int i = 0; i < 8; i++)
                _lbls[i].SetBounds(arrPosX[i], arrPosY[i], BoxSize, BoxSize);
        }
        #endregion

        #region Event Handlers

        void _control_MarginChanged(object sender, EventArgs e)
        {
            if (!_dragging)
                MoveHandles();
        }

        void _control_ParentChanged(object sender, EventArgs e)
        {
            SetParent();
        }

        void _parent_LocationChanged(object sender, EventArgs e)
        {
            if (!_dragging)
                MoveHandles();
        }

        void _control_SizeChanged(object sender, EventArgs e)
        {
            if (!_dragging)
                MoveHandles();
        }

        // Store control position and size when mouse button pushed over any sizing handle
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (ResizeAllowed(sender as Label))
            {
                _dragging = true;
                _startl = _control.Left;
                _startt = _control.Top;
                _startw = _control.Width;
                _starth = _control.Height;
                HideHandles();
            }
        }

        private bool ResizeAllowed(Label label)
        {
            IScmControlProperties ctrlProp = (_control as IScmControl).ScmPropertyObject;
            if (ctrlProp.AutosizeHeight)
            {
                switch ((ControlPoint)label.Tag)
                {
                    case ControlPoint.Bottom:
                    case ControlPoint.BottomLeft:
                    case ControlPoint.BottomRight:
                    case ControlPoint.Top:
                    case ControlPoint.TopLeft:
                    case ControlPoint.TopRight:
                        return false;
                }
            }

            if (!(_control is ScmFrame) && ctrlProp.StretchableHeight)
            {
                switch ((ControlPoint)label.Tag)
                {
                    case ControlPoint.Bottom:
                    case ControlPoint.BottomLeft:
                    case ControlPoint.BottomRight:
                    case ControlPoint.Top:
                    case ControlPoint.TopLeft:
                    case ControlPoint.TopRight:
                        return false;
                }
            }

            if (ctrlProp.AutosizeWidth)
            {
                switch ((ControlPoint)label.Tag)
                {
                    case ControlPoint.BottomLeft:
                    case ControlPoint.BottomRight:
                    case ControlPoint.Left:
                    case ControlPoint.Right:
                    case ControlPoint.TopLeft:
                    case ControlPoint.TopRight:
                        return false;
                }
            }

            if (!(_control is ScmFrame) && ctrlProp.StretchableWidth)
            {
                switch ((ControlPoint)label.Tag)
                {
                    case ControlPoint.BottomLeft:
                    case ControlPoint.BottomRight:
                    case ControlPoint.Left:
                    case ControlPoint.Right:
                    case ControlPoint.TopLeft:
                    case ControlPoint.TopRight:
                        return false;
                }
            }
            return true;
        }

        // Size the picked control in accordance with sizing handle being dragged
        //	0   1   2
        //  7       3
        //  6   5   4
        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (ResizeAllowed(sender as Label))
            {
                int l = _control.Left;
                int w = _control.Width;
                int t = _control.Top;
                int h = _control.Height;
                if (_dragging)
                {
                    switch ((ControlPoint)((Label)sender).Tag)
                    {
                        case ControlPoint.TopLeft:
                            l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                            t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                            w = _startl + _startw - _control.Left;
                            h = _startt + _starth - _control.Top;
                            break;
                        case ControlPoint.Top: 
                            t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                            h = _startt + _starth - _control.Top;
                            break;
                        case ControlPoint.TopRight:
                            w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                            t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                            h = _startt + _starth - _control.Top;
                            break;
                        case ControlPoint.Right:
                            w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                            break;
                        case ControlPoint.BottomRight:
                            w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                            h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                            break;
                        case ControlPoint.Bottom: 
                            h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                            break;
                        case ControlPoint.BottomLeft:
                            l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                            w = _startl + _startw - _control.Left;
                            h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                            break;
                        case ControlPoint.Left:
                            l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                            w = _startl + _startw - _control.Left;
                            break;
                    }
                    l = (l < 0) ? 0 : l;
                    t = (t < 0) ? 0 : t;
                    _control.SetBounds(l, t, w, h, BoundsSpecified.All);
                }
            }
        }

        // Display sizing handles around picked control once sizing has completed
        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
            MoveHandles();
            ShowHandles();
        }
        #endregion
    }
}


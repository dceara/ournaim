using System;
using System.Windows.Forms;
using System.Drawing;
using SchemeGuiEditor.ToolboxControls;

namespace SchemeGuiEditor.Utils
{
    /// <summary>
    /// This class implements sizing and moving functions for runtime editing of graphic controls
    /// </summary>
    public class PickBox
    {
        #region constants
        private const int BoxSize = 8;
        private const int MinSize = 20;
        #endregion

        #region Members
        private Color BoxColor = Color.White;
        private Control _control;
        private Label[] _lbl = new Label[8];
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
        public PickBox()
        {
            for (int i = 0; i < 8; i++)
            {
                _lbl[i] = new Label();
                _lbl[i].TabIndex = i;
                _lbl[i].FlatStyle = 0;
                _lbl[i].BorderStyle = BorderStyle.FixedSingle;
                _lbl[i].BackColor = BoxColor;
                _lbl[i].Cursor = arrArrow[i];
                _lbl[i].Text = "";
                _lbl[i].BringToFront();
                _lbl[i].MouseDown += new MouseEventHandler(this.lbl_MouseDown);
                _lbl[i].MouseMove += new MouseEventHandler(this.lbl_MouseMove);
                _lbl[i].MouseUp += new MouseEventHandler(this.lbl_MouseUp);
            }
        }
        #endregion

        #region Public methods
        public void SelectControl(Control newControl)
        {
            _control = newControl;
            
            //Add sizing handles to Control's container (Form or PictureBox)
            for (int i = 0; i < 8; i++)
            {
                _control.Parent.Controls.Add(_lbl[i]);
                _lbl[i].BringToFront();
            }

            //Position sizing handles around Control
            MoveHandles();

            //Display sizing handles
            ShowHandles();

            oldCursor = _control.Cursor;
            _control.Cursor = Cursors.SizeAll;
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
                    _lbl[i].Visible = true;
                }
            }
        }

        private void HideHandles()
        {
            for (int i = 0; i < 8; i++)
            {
                _lbl[i].Visible = false;
            }
        }

        private void MoveHandles()
        {
            int sX = _control.Left - BoxSize;
            int sY = _control.Top - BoxSize;
            int sW = _control.Width + BoxSize;
            int sH = _control.Height + BoxSize;
            int hB = BoxSize / 2;
            int[] arrPosX = new int[] {sX+hB, sX + sW / 2, sX + sW-hB, sX + sW-hB,
			sX + sW-hB, sX + sW / 2, sX+hB, sX+hB};
            int[] arrPosY = new int[] {sY+hB, sY+hB, sY+hB, sY + sH / 2, sY + sH-hB,
			sY + sH-hB, sY + sH-hB, sY + sH / 2};
            for (int i = 0; i < 8; i++)
                _lbl[i].SetBounds(arrPosX[i], arrPosY[i], BoxSize, BoxSize);
        }
        #endregion

        #region Event Handlers
        // Store control position and size when mouse button pushed over any sizing handle
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startl = _control.Left;
            _startt = _control.Top;
            _startw = _control.Width;
            _starth = _control.Height;
            HideHandles();
        }

        // Size the picked control in accordance with sizing handle being dragged
        //	0   1   2
        //  7       3
        //  6   5   4
        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            int l = _control.Left;
            int w = _control.Width;
            int t = _control.Top;
            int h = _control.Height;
            if (_dragging)
            {
                switch (((Label)sender).TabIndex)
                {
                    case 0: // Dragging top-left sizing box
                        l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                        t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                        w = _startl + _startw - _control.Left;
                        h = _startt + _starth - _control.Top;
                        break;
                    case 1: // Dragging top-center sizing box
                        t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                        h = _startt + _starth - _control.Top;
                        break;
                    case 2: // Dragging top-right sizing box
                        w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                        t = _startt + e.Y < _startt + _starth - MinSize ? _startt + e.Y : _startt + _starth - MinSize;
                        h = _startt + _starth - _control.Top;
                        break;
                    case 3: // Dragging right-middle sizing box
                        w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                        break;
                    case 4: // Dragging right-bottom sizing box
                        w = _startw + e.X > MinSize ? _startw + e.X : MinSize;
                        h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                        break;
                    case 5: // Dragging center-bottom sizing box
                        h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                        break;
                    case 6: // Dragging left-bottom sizing box
                        l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                        w = _startl + _startw - _control.Left;
                        h = _starth + e.Y > MinSize ? _starth + e.Y : MinSize;
                        break;
                    case 7: // Dragging left-middle sizing box
                        l = _startl + e.X < _startl + _startw - MinSize ? _startl + e.X : _startl + _startw - MinSize;
                        w = _startl + _startw - _control.Left;
                        break;
                }
                l = (l < 0) ? 0 : l;
                t = (t < 0) ? 0 : t;
                _control.SetBounds(l, t, w, h);
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


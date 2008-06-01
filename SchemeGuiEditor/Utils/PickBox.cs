using System;
using System.Windows.Forms;
using System.Drawing;
using SchemeGuiEditor.ToolboxControls;

namespace SchemeGuiEditor.Utils
{
    /// <summary>
    /// This class implements sizing and moving functions for
    ///	runtime editing of graphic controls
    /// </summary>
    public class PickBox
    {

        private const int BoxSize = 8;
        private Color BoxColor = Color.White;
        private Control _control;
        private Label[] lbl = new Label[8];
        private int startl;
        private int startt;
        private int startw;
        private int starth;
        private int startx;
        private int starty;
        private bool dragging;
        private Cursor[] arrArrow = new Cursor[] {Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE, Cursors.SizeNWSE, Cursors.SizeNS,
			Cursors.SizeNESW, Cursors.SizeWE};
        private Cursor oldCursor;

        private const int MIN_SIZE = 20;

        // Constructor creates 8 sizing handles & wires mouse events
        // to each that implement sizing functions
        public PickBox()
        {
            for (int i = 0; i < 8; i++)
            {
                lbl[i] = new Label();
                lbl[i].TabIndex = i;
                lbl[i].FlatStyle = 0;
                lbl[i].BorderStyle = BorderStyle.FixedSingle;
                lbl[i].BackColor = BoxColor;
                lbl[i].Cursor = arrArrow[i];
                lbl[i].Text = "";
                lbl[i].BringToFront();
                lbl[i].MouseDown += new MouseEventHandler(this.lbl_MouseDown);
                lbl[i].MouseMove += new MouseEventHandler(this.lbl_MouseMove);
                lbl[i].MouseUp += new MouseEventHandler(this.lbl_MouseUp);
            }
        }

        public void SelectControl(Control newControl)
        {
            _control = newControl;
            
            //Add sizing handles to Control's container (Form or PictureBox)
            for (int i = 0; i < 8; i++)
            {
                _control.Parent.Controls.Add(lbl[i]);
                lbl[i].BringToFront();
            }

            //Position sizing handles around Control
            MoveHandles();

            //Display sizing handles
            ShowHandles();

            oldCursor = _control.Cursor;
            _control.Cursor = Cursors.SizeAll;

        }

        public void Remove()
        {
            HideHandles();
            _control.Cursor = oldCursor;
        }

        private void ShowHandles()
        {
            if (_control != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    lbl[i].Visible = true;
                }
            }
        }

        private void HideHandles()
        {
            for (int i = 0; i < 8; i++)
            {
                lbl[i].Visible = false;
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
                lbl[i].SetBounds(arrPosX[i], arrPosY[i], BoxSize, BoxSize);
        }

        // Store control position and size when mouse button pushed over
        // any sizing handle
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startl = _control.Left;
            startt = _control.Top;
            startw = _control.Width;
            starth = _control.Height;
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
            if (dragging)
            {
                switch (((Label)sender).TabIndex)
                {
                    case 0: // Dragging top-left sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        w = startl + startw - _control.Left;
                        h = startt + starth - _control.Top;
                        break;
                    case 1: // Dragging top-center sizing box
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        h = startt + starth - _control.Top;
                        break;
                    case 2: // Dragging top-right sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        t = startt + e.Y < startt + starth - MIN_SIZE ? startt + e.Y : startt + starth - MIN_SIZE;
                        h = startt + starth - _control.Top;
                        break;
                    case 3: // Dragging right-middle sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        break;
                    case 4: // Dragging right-bottom sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 5: // Dragging center-bottom sizing box
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 6: // Dragging left-bottom sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        w = startl + startw - _control.Left;
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                    case 7: // Dragging left-middle sizing box
                        l = startl + e.X < startl + startw - MIN_SIZE ? startl + e.X : startl + startw - MIN_SIZE;
                        w = startl + startw - _control.Left;
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
            dragging = false;
            MoveHandles();
            ShowHandles();
        }

        // Get mouse pointer starting position on mouse down and hide sizing handles
        public void StartMove(MouseEventArgs e)
        {
            startx = e.X;
            starty = e.Y;
            HideHandles();
        }

        // Reposition the dragged control
        public void MoveControl(MouseEventArgs e)
        {
            int l = _control.Left + e.X - startx;
            int t = _control.Top + e.Y - starty;
            int w = _control.Width;
            int h = _control.Height;
            l = (l < 0) ? 0 : ((l + w > _control.Parent.ClientRectangle.Width) ?
              _control.Parent.ClientRectangle.Width - w : l);
            t = (t < 0) ? 0 : ((t + h > _control.Parent.ClientRectangle.Height) ?
            _control.Parent.ClientRectangle.Height - h : t);
            _control.Left = l;
            _control.Top = t;
        }
        // Display sizing handles around picked control once dragging has completed
        private void ctl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            MoveHandles();
            ShowHandles();
        }

    }
}


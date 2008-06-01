using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SchemeGuiEditor.Gui
{
    public partial class ToolWindow : DockContent
    {
        public ToolWindow()
        {
            InitializeComponent();
            InitMenuItems();
            this.TabPageContextMenuStrip = contextMenuStripFloatingOptions;
        }

        protected override void OnDockStateChanged(EventArgs e)
        {
            SetContextMenuState();
            base.OnDockStateChanged(e);
        }

        public virtual List<object> GetPropertiesObjects()
        {
            return new List<Object>();
        }

        #region Private Methods
        private void SetContextMenuState()
        {
            ResetMenuItems();
            switch (this.DockState)
            {
                case DockState.Float:
                    floatingToolStripMenuItem.Checked = true;
                    autoHideToolStripMenuItem.Enabled = false;
                    break;
                case DockState.DockTopAutoHide:
                case DockState.DockLeftAutoHide:
                case DockState.DockBottomAutoHide:
                case DockState.DockRightAutoHide:
                    autoHideToolStripMenuItem.Checked = true;
                    floatingToolStripMenuItem.Enabled = false;
                    dockableToolStripMenuItem.Enabled = false;
                    tabbedDocumentToolStripMenuItem.Enabled = false;
                    ShowHint = DockState;
                    break;
                case DockState.Document:
                    tabbedDocumentToolStripMenuItem.Checked = true;
                    autoHideToolStripMenuItem.Enabled = false;
                    break;
                case DockState.DockTop:
                case DockState.DockLeft:
                case DockState.DockBottom:
                case DockState.DockRight:
                    dockableToolStripMenuItem.Checked = true;
                    ShowHint = DockState;
                    break;
            }
        }

        private void ResetMenuItems()
        {
            floatingToolStripMenuItem.Enabled = true;
            dockableToolStripMenuItem.Enabled = true;
            tabbedDocumentToolStripMenuItem.Enabled = true;
            autoHideToolStripMenuItem.Enabled = true;
            hideToolStripMenuItem.Enabled = true;

            floatingToolStripMenuItem.Checked = false;
            dockableToolStripMenuItem.Checked = false;
            tabbedDocumentToolStripMenuItem.Checked = false;
            autoHideToolStripMenuItem.Checked = false;
            hideToolStripMenuItem.Checked = false;
        }

        private void InitMenuItems()
        {
            floatingToolStripMenuItem.Click += new EventHandler(floatingToolStripMenuItem_Click);
            dockableToolStripMenuItem.Click += new EventHandler(dockableToolStripMenuItem_Click);
            tabbedDocumentToolStripMenuItem.Click += new EventHandler(tabbedDocumentToolStripMenuItem_Click);
            autoHideToolStripMenuItem.Click += new EventHandler(autoHideToolStripMenuItem_Click);
            hideToolStripMenuItem.Click += new EventHandler(hideToolStripMenuItem_Click);
        }

        private void AutoHide()
        {
            switch (DockState)
            {
                case DockState.DockLeft:
                    DockState = DockState.DockLeftAutoHide;
                    break;
                case DockState.DockRight:
                    DockState = DockState.DockRightAutoHide;
                    break;
                case DockState.DockTop:
                    DockState = DockState.DockTopAutoHide;
                    break;
                case DockState.DockBottom:
                    DockState = DockState.DockBottomAutoHide;
                    break;
                case DockState.DockLeftAutoHide:
                    DockState = DockState.DockLeft;
                    break;
                case DockState.DockRightAutoHide:
                    DockState = DockState.DockRight;
                    break;
                case DockState.DockTopAutoHide:
                    DockState = DockState.DockTop;
                    break;
                case DockState.DockBottomAutoHide:
                    DockState = DockState.DockBottom;
                    break;
            }
        }
        #endregion

        #region EventHandlers
        void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        void autoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoHide();
        }

        void tabbedDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DockState = DockState.Document;
        }

        void dockableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DockState = this.ShowHint;
        }

        void floatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DockState = DockState.Float;
        }
        #endregion
    }
}
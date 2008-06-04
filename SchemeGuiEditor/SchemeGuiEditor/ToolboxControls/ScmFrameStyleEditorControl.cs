using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmFrameStyleEditorControl : UserControl
    {
        private ScmFrameStyle _style;

        public ScmFrameStyleEditorControl(ScmFrameStyle style)
        {
            InitializeComponent();
            _style = style;
            InitCheckBoxes();
        }

        private void InitCheckBoxes()
        {
            checkBoxNoCaption.Checked = _style.NoCaption;
            checkBoxFloating.Checked = _style.Floating;
            checkBoxMdiChild.Checked = _style.MdiChild;
            checkBoxMdiParent.Checked = _style.MdiParent;
            checkBoxNoResizeBorder.Checked = _style.NoResizeBorder;
            checkBoxNoSystemMenu.Checked = _style.NoSystemMenu;
        }

        public ScmFrameStyle Style
        {
            get { return _style; }
        }

        private void checkBoxNoResizeBorder_CheckedChanged(object sender, EventArgs e)
        {
            _style.NoResizeBorder = checkBoxNoResizeBorder.Checked;
        }

        private void checkBoxNoCaption_CheckedChanged(object sender, EventArgs e)
        {
            _style.NoCaption = checkBoxNoCaption.Checked;
        }

        private void checkBoxNoSystemMenu_CheckedChanged(object sender, EventArgs e)
        {
            _style.NoSystemMenu = checkBoxNoSystemMenu.Checked;
        }

        private void checkBoxFloating_CheckedChanged(object sender, EventArgs e)
        {
            _style.Floating = checkBoxFloating.Checked;
        }

        private void checkBoxMdiParent_CheckedChanged(object sender, EventArgs e)
        {
            _style.MdiParent = checkBoxMdiParent.Checked;
        }

        private void checkBoxMdiChild_CheckedChanged(object sender, EventArgs e)
        {
            _style.MdiChild = checkBoxMdiChild.Checked;
        }

    }
}

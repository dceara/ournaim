using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmButtonStyleEditorControl : UserControl
    {
        private ScmButtonStyle _style;

        public ScmButtonStyleEditorControl(ScmButtonStyle style)
        {
            InitializeComponent();
            _style = style;
            InitCheckBoxes();
        }

        private void InitCheckBoxes()
        {
            checkBoxBorder.Checked = _style.Border;
            checkBoxDeleted.Checked = _style.Deleted;
        }

        public ScmButtonStyle Style
        {
            get { return _style; }
        }

        private void checkBoxBorder_CheckedChanged(object sender, EventArgs e)
        {
            _style.Border = checkBoxBorder.Checked;
        }

        private void checkBoxDeleted_CheckedChanged(object sender, EventArgs e)
        {
            _style.Deleted = checkBoxDeleted.Checked;
        }
    }
}

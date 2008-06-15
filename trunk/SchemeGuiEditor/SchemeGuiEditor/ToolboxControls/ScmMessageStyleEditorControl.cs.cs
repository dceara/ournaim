using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmMessageStyleEditorControl : UserControl
    {
        private ScmMessageStyle _style;

        public ScmMessageStyleEditorControl(ScmMessageStyle style)
        {
            InitializeComponent();
            _style = style;
            InitCheckBoxes();
        }

        private void InitCheckBoxes()
        {
            checkBoxDeleted.Checked = _style.Deleted;
        }

        public ScmMessageStyle Style
        {
            get { return _style; }
        }

        private void checkBoxDeleted_CheckedChanged(object sender, EventArgs e)
        {
            _style.Deleted = checkBoxDeleted.Checked;
        }
    }
}

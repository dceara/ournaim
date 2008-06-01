using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmButton : Button, IScmControl
    {
        private ScmButtonProperties _scmProperties;

        public ScmButton()
        {
            _scmProperties = new ScmButtonProperties(this);
        }

        #region IScmControl Members

        public object ScmPropertyObject
        {
            get { return _scmProperties; }
        }

        #endregion
    }

    public class ScmButtonProperties
    {
        private ScmButton _button;

        public ScmButtonProperties(ScmButton button)
        {
            _button = button;
        }
    }

}

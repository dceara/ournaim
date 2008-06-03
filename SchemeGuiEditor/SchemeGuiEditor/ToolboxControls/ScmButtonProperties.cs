using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmButtonProperties :IScmControlProperties
    {
        private ScmButton _button;

        public ScmButtonProperties(ScmButton button)
        {
            _button = button;
        }

        #region IScmControlProperties Members

        public IScmControl Control
        {
            get { return _button; }
        }

        #endregion
    }
}

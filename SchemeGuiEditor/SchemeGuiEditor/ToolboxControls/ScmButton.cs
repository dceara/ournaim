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

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }

        public void SetInitialProperties()
        {
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmControl
    {
        IScmControlProperties ScmPropertyObject { get;}
        void SetInitialProperties();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public enum StrechDirection
    {
        Horizontal,
        Vertical
    }
    public interface IScmControl
    {
        event EventHandler ControlChanged;
        IScmControlProperties ScmPropertyObject { get;}
        void SetInitialProperties(string name);
        void ControlResized();
    }
}

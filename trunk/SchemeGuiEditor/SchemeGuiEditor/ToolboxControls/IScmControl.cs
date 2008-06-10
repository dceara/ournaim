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
        event EventHandler<DataEventArgs<StrechDirection>> StrechChanged;
        IScmControlProperties ScmPropertyObject { get;}
        void SetInitialProperties();
    }
}

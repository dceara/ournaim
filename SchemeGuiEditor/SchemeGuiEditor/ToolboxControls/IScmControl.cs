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
        event EventHandler ContentSizeChanged;
        IScmControlProperties ScmPropertyObject { get;}
        void SetInitialProperties();
    }
}

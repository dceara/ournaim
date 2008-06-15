using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmContainer : IScmControl
    {
        event EventHandler NameChanged;
        LayoutManagerContainer LayoutManager { get;}
    }
}

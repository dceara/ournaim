using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmContainer : IScmControl
    {
        LayoutManagerContainer LayoutManager { get;}
    }
}

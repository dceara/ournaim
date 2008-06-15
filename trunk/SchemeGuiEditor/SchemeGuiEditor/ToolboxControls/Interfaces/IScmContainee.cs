using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmContainee :IScmControl
    {
        IScmContainer ScmContainer { get; set;}
        int HorizontalMargin { get; set; }
        int VerticalMargin { get; set;}
        int MinWidth {get; set;}
        int MinHeight { get; set;}
        bool StretchableWidth { get; set;}
        bool StretchableHeight { get;set;}

    }
}

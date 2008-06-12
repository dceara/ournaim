using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmControlProperties : INotifyPropertyChanged
    {
        string DefaultControlName { get;}
        IScmControl Control { get;}
        string ToScmCode();
        string Name { get; set;}
        string Label { get; set;}
        string Parent { get; set;}
        bool StretchableWidth { get;}
        bool StretchableHeight { get;}
        bool AutosizeHeight { get; }
        bool AutosizeWidth { get;}
    }
}

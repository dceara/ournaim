using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface IScmControlProperties
    {
        event EventHandler PropertyChanged;
        string DefaultControlName { get;}
        IScmControl Control { get;}
        string ToScmCode();
        string Name { get; }
        //string Label { get; set;}
        string Parent { get; }
        bool StretchableWidth { get;}
        bool StretchableHeight { get;}
        bool AutosizeHeight { get; }
        bool AutosizeWidth { get;}
        void NotifyPropertyChanged();
    }
}

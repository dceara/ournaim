using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SchemeGuiEditor.ToolboxControls
{
    public interface ILayoutManager
    {
        ContainerAlignment Alignment { get; set;}
        int Border { get; set;}
        int Spacing { get; set; }
        void SetHorizontalPosition(Control ctrl);
        void SetVerticalPozition(Control ctrl);
        void StrechWidth(Control ctrl);
        void StrechHeight(Control ctrl);
        List<IScmControl> GetChildControls();
        void AddControl(Control ctrl);
        void AddControl(Control ctrl, Point screenPosition);
        void AddControl(Control ctrl, Point screenPosition,out bool sameParent);
        void RemoveControl(Control ctrl);
        void RemoveContainer(Control ctrl);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Silver.UI;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmContainer : UserControl
    {
        private PickBox _pickBox;

        public PickBox PickBox
        {
            get { return _pickBox; }
        }
        
        public ScmContainer()
        {
            InitializeComponent();
            _pickBox = new PickBox();
        }

        public virtual int Priority
        {
            get { return 0; }
        }

        public virtual void AddControl(Control ctrl, Point location)
        {
            Controls.Add(ctrl);
            ctrl.Location = PointToClient(location);
        }
    }
}

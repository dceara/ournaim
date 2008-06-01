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

        public virtual void AddControl(Control ctrl)
        {
            if (ctrl != null)
                Controls.Add(ctrl);
        }

        protected Control CreateControl(Type controlType)
        {
            Control ctrl = Activator.CreateInstance(controlType) as Control;
            if (ctrl is ScmContainer)
            {
                ScmContainer container = ctrl as ScmContainer;
                if (container.Priority <= this.Priority && container.Priority < 2)
                    return null;
            }
            ctrl.SizeChanged += new EventHandler(ctrl_SizeChanged);
            ctrl.LocationChanged += new EventHandler(ctrl_LocationChanged);
            return ctrl;
        }

        private void ctrl_LocationChanged(object sender, EventArgs e)
        {

        }

        private void ctrl_SizeChanged(object sender, EventArgs e)
        {
        }

        public virtual int Priority
        {
            get { return 0; }
        }

        public virtual void AddControl(Control ctrl, Point location)
        {
            Controls.Add(ctrl);
            ctrl.Location = new Point(location.X - Location.X, location.Y - Location.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Services;
using SchemeGuiEditor.Constants;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmFrame : ScmContainer
    {
        private int _priority = 1;
        
        public ScmFrame()
        {
            InitializeComponent();
        }

        public string Label
        {
            get{return labelTitle.Text;}
            set{labelTitle.Text = value;}
        }

        public override void AddControl(Control ctrl, Point location)
        {
            ctrl.Location = panelContainer.PointToClient(location);
            panelContainer.Controls.Add(ctrl);
        }

        public override int Priority
        {
            get { return 1; }
        }

        private void panelContainer_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine(e.Data.ToString());
        }
    }

    public class ScmFrameProperties
    {
        private ScmFrame _frame;

        public string Label
        {
            get
            {
                return _frame.Label; }
            set 
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.FrameLabelToLong);
                    return;
                }
                _frame.Label = value;
            }
        }
    }
}

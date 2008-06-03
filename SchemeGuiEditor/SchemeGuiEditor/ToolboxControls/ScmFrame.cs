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
    public partial class ScmFrame : ScmContainer,IScmControl
    {
        private ScmFrameProperties _scmProperties;
        public ScmFrame()
        {
            InitializeComponent();
            _scmProperties = new ScmFrameProperties(this);
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

        private void panelContainer_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine(e.Data.ToString());
        }

        #region IScmControl Members

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }

        #endregion
    }

    public class ScmFrameProperties : IScmControlProperties
    {
        private ScmFrame _frame;

        public ScmFrameProperties(ScmFrame frame)
        {
            _frame = frame;
        }

        public string Name
        {
            get
            {
                return _frame.Name;
            }
            set
            {
                _frame.Name = value;
            }
        }

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

        #region IScmControlProperties Members

        public IScmControl Control
        {
            get { return _frame; }
        }

        #endregion
    }
}

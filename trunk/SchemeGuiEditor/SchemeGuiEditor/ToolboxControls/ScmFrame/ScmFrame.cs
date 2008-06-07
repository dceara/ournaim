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
    public partial class ScmFrame : UserControl ,IScmContainer
    {
        private ScmFrameProperties _scmProperties;
        public ScmFrame()
        {
            InitializeComponent();
            Size s = layoutManagerContainer1.ComputeMinSize();
            this.Size = s;
            this.MinimumSize = s;
            layoutManagerContainer1.BringToFront();
            _scmProperties = new ScmFrameProperties(this);
        }

        public string Label
        {
            get{return labelTitle.Text;}
            set{labelTitle.Text = value;}
        }

        public void RecomputeFrameSizes()
        {
            Size s = layoutManagerContainer1.ComputeMinSize();
            if (!_scmProperties.UseHeight)
                this.Height = s.Height;
            if (!_scmProperties.UseWidth)
                this.Width = s.Width;

            if (_scmProperties.MinWidth > s.Width)
                s.Width = _scmProperties.MinWidth;
            if (_scmProperties.MinHeight > s.Height)
                s.Height = _scmProperties.MinHeight;

            this.MinimumSize = s;
        }

        #region IScmControl Members

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }
        
        public void SetInitialProperties()
        {
            _scmProperties.UseWidth = true;
            _scmProperties.UseHeight = true;
            _scmProperties.Width = "300";
            _scmProperties.Height = "300";
        }

        #endregion

        #region IScmContainer Members

        public LayoutManagerContainer LayoutManager
        {
            get { return layoutManagerContainer1; }
        }

        #endregion
    }
}

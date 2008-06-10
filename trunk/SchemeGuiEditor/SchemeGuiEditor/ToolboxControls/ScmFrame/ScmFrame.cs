using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Services;
using SchemeGuiEditor.Constants;
using SchemeGuiEditor.Utils;

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
            layoutManagerContainer1.ContentSizeChanged += new EventHandler(layoutManagerContainer1_ContentSizeChanged);
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
            if (_scmProperties.AutosizeHeight)
                this.Height = s.Height;
            if (_scmProperties.AutosizeWidth)
                this.Width = s.Width;

            if (_scmProperties.MinWidth > s.Width)
                s.Width = _scmProperties.MinWidth;
            if (_scmProperties.MinHeight > s.Height)
                s.Height = _scmProperties.MinHeight;

            this.MinimumSize = s;
        }

        #region IScmControl Members
        public event EventHandler<DataEventArgs<StrechDirection>> StrechChanged;
        public event EventHandler ContentSizeChanged;

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }
        
        public void SetInitialProperties()
        {
            _scmProperties.AutosizeWidth = false;
            _scmProperties.AutosizeHeight = false;
            _scmProperties.Width = "300";
            _scmProperties.Height = "300";
            _scmProperties.UseX = true;
            _scmProperties.UseY = true;
            _scmProperties.X = "0";
            _scmProperties.Y = "0";
        }
        #endregion

        #region IScmContainer Members

        public LayoutManagerContainer LayoutManager
        {
            get { return layoutManagerContainer1; }
        }

        #endregion


        void layoutManagerContainer1_ContentSizeChanged(object sender, EventArgs e)
        {
            RecomputeFrameSizes();
        }
    }
}

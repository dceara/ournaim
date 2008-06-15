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
        #region Private Members
        private ScmFrameProperties _scmProperties;
        private const int _minHeight = 30;
        private const int _minWidth = 128;
        private int _contentWidth;
        private int _contentHeight;
        #endregion

        #region Constructor
        public ScmFrame()
        {
            InitializeComponent();
            this.MinimumSize = new Size(_minWidth, _minHeight);
            layoutManagerContainer1.BringToFront();
            layoutManagerContainer1.MinHeightChanged += new EventHandler<DataEventArgs<int>>(layoutManagerContainer1_MinHeightChanged);
            layoutManagerContainer1.MinWidthChanged += new EventHandler<DataEventArgs<int>>(layoutManagerContainer1_MinWidthChanged);
            _scmProperties = new ScmFrameProperties(this);
        }
        #endregion

        #region Properties
        public string Label
        {
            get{return labelTitle.Text;}
            set{labelTitle.Text = value;}
        }
        #endregion

        #region IScmControl Members
        public event EventHandler ControlChanged;

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }
        
        public void SetInitialProperties(string name)
        {
            _scmProperties.Name = name;
            _scmProperties.Label = name;
            _scmProperties.AutosizeWidth = false;
            _scmProperties.AutosizeHeight = false;
            _scmProperties.Width = "300";
            _scmProperties.Height = "300";
            _scmProperties.UseX = true;
            _scmProperties.UseY = true;
            _scmProperties.X = "0";
            _scmProperties.Y = "0";
        }

        public void ControlResized()
        {
        }
        #endregion

        #region IScmContainer Members
        public event EventHandler NameChanged;

        public LayoutManagerContainer LayoutManager
        {
            get { return layoutManagerContainer1; }
        }

        #endregion

        #region Public Methods
        public void ResetMinHeight()
        {
            this.MinimumSize = new Size(this.MinimumSize.Width, Math.Max(_contentHeight, _scmProperties.MinHeight));
            if (_scmProperties.AutosizeHeight)
                this.Height = this.MinimumSize.Height;
        }

        public void ResetMinWidth()
        {
            this.MinimumSize = new Size(Math.Max(_minWidth,
                Math.Max(_contentWidth, _scmProperties.MinWidth)),this.MinimumSize.Height);
        }
        public void ResetWidth()
        {
            this.Width = this.MinimumSize.Width;
        }

        public void ResetHeight()
        {
            this.Height = this.MinimumSize.Height;
        }

        public void RaiseNameChanged()
        {
            if (NameChanged != null)
                NameChanged(this, EventArgs.Empty);
        }
        #endregion

        #region Event Handlers
        void layoutManagerContainer1_MinWidthChanged(object sender, DataEventArgs<int> e)
        {
            _contentWidth = e.Data;
            ResetMinWidth();
            if (e.Data > this.Width || _scmProperties.AutosizeWidth)
                this.Width = e.Data;
        }

        void layoutManagerContainer1_MinHeightChanged(object sender, DataEventArgs<int> e)
        {
            _contentHeight = _minHeight + e.Data;
            ResetMinHeight();

            if (_contentHeight > this.Height || _scmProperties.AutosizeHeight)
                this.Height = _contentHeight;
        }
        #endregion

    }
}

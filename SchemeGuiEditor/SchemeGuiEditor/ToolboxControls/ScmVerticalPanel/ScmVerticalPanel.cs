using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public partial class ScmVerticalPanel : UserControl, IScmContainer , IScmContainee
    {
        #region Private Members
        private ScmVerticalPanelProperties _scmProperties;
        private IScmContainer _scmContainer;
        private int _verticalMargin;
        private int _horizontalMargin;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        #endregion

        public ScmVerticalPanel()
        {
            InitializeComponent();
            this.Size = new Size(0, 0);
            _stretchableHeight = true;
            _stretchableWidth = true;
            layoutManagerContainer1.MinHeightChanged += new EventHandler<DataEventArgs<int>>(layoutManagerContainer1_MinHeightChanged);
            layoutManagerContainer1.MinWidthChanged += new EventHandler<DataEventArgs<int>>(layoutManagerContainer1_MinWidthChanged);
            _scmProperties = new ScmVerticalPanelProperties(this);
        }

        #region IScmContainer Members

        public event EventHandler NameChanged;

        public ILayoutManager LayoutManager
        {
            get { return layoutManagerContainer1; }
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
            this.Name = name;
            this.StretchableHeight = true;
            this.StretchableWidth = true;
            _scmProperties.AutosizeHeight = false;
            _scmProperties.AutosizeWidth = false;
        }

        public void ControlResized()
        {
            if (!StretchableHeight && this.Height != _scmProperties.MinHeight)
            {
                _scmProperties.MinHeight = this.Height;
            }
            if (!this.StretchableWidth && this.Width != _scmProperties.MinWidth)
            {
                _scmProperties.MinWidth = this.Width;
            }
            _scmProperties.NotifyPropertyChanged();
        }

        #endregion

        #region IScmContainee Members

        public IScmContainer ScmContainer
        {
            get { return _scmContainer; }
            set
            {
                if (_scmContainer != null)
                    _scmContainer.NameChanged -= new EventHandler(_scmContainer_NameChanged);

                _scmContainer = value;
                _scmProperties.Parent = _scmContainer.ScmPropertyObject.Name;
                _scmContainer.NameChanged += new EventHandler(_scmContainer_NameChanged);
            }
        }

        public int HorizontalMargin
        {
            get { return _horizontalMargin; }
            set
            {
                _horizontalMargin = value;
                if (this.StretchableWidth)
                {
                    this.StretchableWidth = false;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetHorizontalPosition(this);
                    this.StretchableWidth = true;
                }
                else
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetHorizontalPosition(this);

                RaiseControlChanged();
            }
        }

        public int VerticalMargin
        {
            get { return _verticalMargin; }
            set
            {
                _verticalMargin = value;
                if (this.StretchableHeight)
                {
                    this.StretchableHeight = false;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetVerticalPozition(this);
                    this.StretchableHeight = true;
                }
                else
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetVerticalPozition(this);

                RaiseControlChanged();
            }
        }

        public int MinWidth
        {
            get { return Math.Max(_scmProperties.MinWidth, this.MinimumSize.Width); }
            set
            {
                if (!StretchableWidth)
                {
                    this.Width = value;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetHorizontalPosition(this);
                }
                RaiseControlChanged();
            }
        }

        public int MinHeight
        {
            get { return Math.Max(_scmProperties.MinHeight, this.MinimumSize.Height); }
            set
            {
                if (!StretchableHeight)
                {
                    this.Height = value;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.SetVerticalPozition(this);
                }
                RaiseControlChanged();
            }
        }

        public bool StretchableWidth
        {
            get
            {
                return _stretchableWidth;
            }
            set
            {
                if (value != _stretchableWidth)
                {
                    _stretchableWidth = value;
                    if (!_stretchableWidth)
                        this.Width = this.MinWidth;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.StrechWidth(this);
                }
                RaiseControlChanged();
            }
        }

        public bool StretchableHeight
        {
            get
            {
                return _stretchableHeight;
            }
            set
            {
                if (value != _stretchableHeight)
                {
                    _stretchableHeight = value;
                    if (!_stretchableHeight)
                        this.Height = this.MinHeight;
                    if (_scmContainer != null)
                        _scmContainer.LayoutManager.StrechHeight(this);
                }
                RaiseControlChanged();
            }
        }

        #endregion
        
        private void RaiseControlChanged()
        {
            if (ControlChanged != null)
                ControlChanged(this, EventArgs.Empty);
        }

        public void ResetWidth()
        {
            if (!this.StretchableWidth)
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

        void _scmContainer_NameChanged(object sender, EventArgs e)
        {
            _scmProperties.Parent = _scmContainer.ScmPropertyObject.Name;
            _scmProperties.NotifyPropertyChanged();
        }

        #region Event Handlers
        void layoutManagerContainer1_MinWidthChanged(object sender, DataEventArgs<int> e)
        {
            if (this.StretchableWidth)
            {
                this.StretchableWidth = false;
                this.MinimumSize = new Size(Math.Max(e.Data, _scmProperties.MinWidth), this.MinimumSize.Height);
                ScmContainer.LayoutManager.SetHorizontalPosition(this);
                this.StretchableWidth = true;
            }
            else
            {
                this.MinimumSize = new Size(Math.Max(e.Data, _scmProperties.MinWidth), this.MinimumSize.Height);
                ScmContainer.LayoutManager.SetHorizontalPosition(this);
            }

        }

        void layoutManagerContainer1_MinHeightChanged(object sender, DataEventArgs<int> e)
        {
            if (this.StretchableHeight)
            {
                this.StretchableHeight = false;
                this.MinimumSize = new Size(this.MinimumSize.Width, Math.Max(e.Data, _scmProperties.MinHeight));
                ScmContainer.LayoutManager.SetVerticalPozition(this);
                this.StretchableHeight = true;
            }
            else
            {
                this.MinimumSize = new Size(this.MinimumSize.Width, Math.Max(e.Data, _scmProperties.MinHeight));
                ScmContainer.LayoutManager.SetVerticalPozition(this);
            }
        }

        private void layoutManagerContainer1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }
        #endregion
    }
}


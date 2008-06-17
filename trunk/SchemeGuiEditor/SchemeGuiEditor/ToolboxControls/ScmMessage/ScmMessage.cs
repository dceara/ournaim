using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmMessage : Label, IScmContainee
    {
        #region Private Members
        private ScmMessageProperties _scmProperties;
        private IScmContainer _scmContainer;
        private int _verticalMargin;
        private int _horizontalMargin;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        #endregion

        public ScmMessage()
        {
            _verticalMargin = 2;
            _horizontalMargin = 2;
            _scmProperties = new ScmMessageProperties(this);
            this.Text = " ";
        }

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

        protected override void OnTextChanged(EventArgs e)
        {
            RecomputeSizes();
        }

        public void RecomputeSizes()
        {
            SizeF textSize = this.CreateGraphics().MeasureString(this.Text, this.Font);
            Size s = new Size(Convert.ToInt32(textSize.Width) + 10, 20);
            this.MinimumSize = s;

            if (_scmProperties.AutosizeWidth)
                this.Width = s.Width;
            else
                if (s.Width > _scmProperties.MinWidth)
                {
                    _scmProperties.MinWidth = s.Width;
                    this.Width = s.Width;
                    _scmProperties.NotifyPropertyChanged();
                }

            if (_scmProperties.AutosizeHeight)
                this.Height = s.Height;
            else
                if (s.Height > _scmProperties.MinHeight)
                {
                    _scmProperties.MinHeight = s.Height;
                    this.Height = Height;
                    _scmProperties.NotifyPropertyChanged();
                }
        }

        void _scmContainer_NameChanged(object sender, EventArgs e)
        {
            _scmProperties.Parent = _scmContainer.ScmPropertyObject.Name;
            _scmProperties.NotifyPropertyChanged();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }
    }

}

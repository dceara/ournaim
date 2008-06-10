using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Constants;
using System.ComponentModel;
using System.Drawing;
using SchemeGuiEditor.Services;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public enum ButtonPropNames
    {
        None,
        Parent,
        Label,
        Enabled,
        MinWidth,
        MinHeight,
        StrechWidth,
        StrechHeight,
        VerticalMargin,
        HorizontalMargin
    }
    public class ScmButtonProperties :IScmControlProperties
    {
        private ScmButton _button;
        private bool _enabled;
        private string _parent;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        private int _minWidth;
        private int _minHeight;
        private int _verticalMargin;
        private int _horizontalMargin;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private ButtonPropNames _lastSetProperty;
        private Dictionary<ButtonPropNames, List<string>> _externalObjects;

        public ScmButtonProperties(ScmButton button)
        {
            _button = button;
            _enabled = true;
            _button.SizeChanged += new EventHandler(_button_SizeChanged);
            _button.MarginChanged += new EventHandler(_button_MarginChanged);
            _externalObjects = new Dictionary<ButtonPropNames, List<string>>();
        }
                
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region IScmControlProperties Members

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _button; }
        }

        #endregion

        [Browsable(false)]
        public ButtonPropNames LastSetProperty
        {
            get { return _lastSetProperty; }
            set { _lastSetProperty = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name of the parent container")]
        [ReadOnly(true)]
        public string Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name used in code to identify the object")]
        public string Name
        {
            get { return _button.Name; }
            set { _button.Name = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The string displayed on the button")]
        public string Label
        {
            get { return _button.Text; }
            set
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.LabelToLong);
                    return;
                }
                _button.Text = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Enables or disables the button")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting minimum width for the button")]
        [DefaultValue(true)]
        public bool AutosizeWidth
        {
            get { return _autosizeWidth; }
            set
            {
                _autosizeWidth = value;
                if (_autosizeWidth)
                {
                    _minWidth = 0;
                    _button.RecomputeSizes();
                }
                else
                    _minWidth = _button.Width;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow setting an minimum Height for the button")]
        [DefaultValue(true)]
        public bool AutosizeHeight
        {
            get { return _autosizeHeight; }
            set
            {
                _autosizeHeight = value;
                if (_autosizeHeight)
                {
                    _minHeight = 0;
                    _button.RecomputeSizes();
                }
                else
                    _minHeight = _button.Height;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum width for the button in pixels")]
        [DefaultValue(0)]
        public int MinWidth
        {
            get { return _minWidth; }
            set
            {
                if (!_autosizeWidth)
                {
                    if (value < 0 || value > 10000)
                    {
                        MessageService.ShowError(ControlValidation.SizeValueInvalid);
                        return;
                    }
                    _minWidth = value;
                    _button.Width = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum height for the button in pixels")]
        [DefaultValue(0)]
        public int MinHeight
        {
            get { return _minHeight; }
            set
            {
                if (!_autosizeHeight)
                {
                    if (value < 0 || value > 10000)
                    {
                        MessageService.ShowError(ControlValidation.SizeValueInvalid);
                        return;
                    }
                    _minHeight = value;
                    _button.Height = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Button's horizontal stretchability")]
        [DefaultValue(false)]
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
                    _button.RaiseStrechChanged(StrechDirection.Horizontal);
                    if (!_stretchableWidth)
                        _button.Width = _minWidth;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Button's vertical stretchability")]
        [DefaultValue(false)]
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
                    _button.Height = _minHeight;
                    _button.RaiseStrechChanged(StrechDirection.Vertical);
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the button in pixels")]
        [DefaultValue(0)]
        public int VerticalMargin
        {
            get { return _verticalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _verticalMargin = value;
                _button.Top = value;
                _button.Margin = new Padding(0, 0, _button.Margin.Right, value);
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the button in pixels")]
        [DefaultValue(0)]
        public int HorizontalMargin
        {
            get { return _horizontalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _horizontalMargin = value;
                _button.Left = value;
                _button.Margin = new Padding(0, 0, value, _button.Margin.Bottom);
            }
        }

        void _button_MarginChanged(object sender, EventArgs e)
        {
            _verticalMargin = _button.Margin.Bottom;
            _horizontalMargin = _button.Margin.Right;
            NotifyPropertyChanged();
        }

        void _button_SizeChanged(object sender, EventArgs e)
        {
            if (!_stretchableWidth && !_autosizeWidth)
            {
                _minWidth = _button.Width;
                NotifyPropertyChanged();
            }
            if (!_stretchableHeight && !_autosizeHeight)
            {
                _minHeight = _button.Height;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return Name + " " + _button.GetType().FullName;
        }

        public void SetExternalObject(string comm)
        {
            List<string> extObj;
            if (!_externalObjects.ContainsKey(_lastSetProperty))
            {
                extObj = new List<string>();
                _externalObjects.Add(_lastSetProperty, extObj);
            }
            else
            {
                extObj = _externalObjects[_lastSetProperty];
            }
            extObj.Add(comm);
        }

        private void NotifyPropertyChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(""));
            }
        }

    }
}

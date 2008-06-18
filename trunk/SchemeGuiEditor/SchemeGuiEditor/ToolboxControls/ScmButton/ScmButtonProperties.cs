using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Constants;
using System.ComponentModel;
using System.Drawing;
using SchemeGuiEditor.Services;
using System.Windows.Forms;
using SchemeGuiEditor.Utils;
using System.Drawing.Design;

namespace SchemeGuiEditor.ToolboxControls
{
    #region Properties enum
    public enum ButtonPropNames
    {
        Parent,
        Label,
        Enabled,
        MinWidth,
        MinHeight,
        StrechWidth,
        StrechHeight,
        VerticalMargin,
        HorizontalMargin,
        Style,
        ScmBlock,
        ScmComment
    }
    #endregion

    public class ScmButtonProperties :IScmControlProperties
    {
        #region Private Members
        private ScmButton _button;
        private bool _enabled;
        private string _parent;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private bool _forceDisplay;
        private int _minWidth;
        private int _minHeight;
        private ScmButtonStyle _style;
        private List<ButtonPropNames> _parsedProperties;
        private Dictionary<int, ScmComment> _parsedComments;
        private Dictionary<int, ScmBlock> _parsedScmBlocks;
        #endregion

        public ScmButtonProperties(ScmButton button)
        {
            _button = button;
            _enabled = true;
            _autosizeHeight = true;
            _autosizeWidth = true;
            _style = new ScmButtonStyle();
            _parsedProperties = new List<ButtonPropNames>();
            _parsedComments = new Dictionary<int, ScmComment>();
            _parsedScmBlocks = new Dictionary<int, ScmBlock>();
        }

        #region IScmControlProperties Members

        public event EventHandler PropertyChanged;

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _button; }
        }

        public string ToScmCode()
        {
            string code = string.Format("(define {0}\n\t(new button%\n {1}))\n\n", this.Name, GetScmPropertiesCode());
            return code;
        }

        [Browsable(false)]
        public string DefaultControlName
        {
            get { return "Button"; }
        }

        public void NotifyPropertyChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Properties
        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name of the parent container")]
        [ReadOnly(true)]
        public string Parent
        {
            get { return _parent; }
            set 
            {
                _parent = value;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name used in code to identify the object")]
        public string Name
        {
            get { return _button.Name; }
            set 
            {
                if (value == string.Empty)
                {
                    MessageService.ShowError(ControlValidation.InvalidValue);
                    return;
                }
                _button.Name = value; }
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
                _button.Refresh();
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
                    _button.MinWidth = _button.Width;
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
                    _button.MinHeight = 0;
                    _button.RecomputeSizes();
                }
                else
                    _button.MinHeight = _button.Height;
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
                    _button.MinWidth = value;
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
                    _button.MinHeight = value;
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
                return _button.StretchableWidth;
            }
            set
            {
                _button.StretchableWidth = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Button's vertical stretchability")]
        [DefaultValue(false)]
        public bool StretchableHeight
        {
            get
            {
                return _button.StretchableHeight;
            }
            set
            {
                _button.StretchableHeight = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the button in pixels")]
        [DefaultValue(2)]
        public int VerticalMargin
        {
            get { return _button.VerticalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _button.VerticalMargin = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Horizontal margins for the button in pixels")]
        [DefaultValue(2)]
        public int HorizontalMargin
        {
            get { return _button.HorizontalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _button.HorizontalMargin = value;
            }
        }

        [Editor(typeof(ScmStyleUiEditor), typeof(UITypeEditor))]
        public ScmButtonStyle Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }
        #endregion

        #region Override Mothods
        public override string ToString()
        {
            return Name + " " + _button.GetType().FullName;
        }
        #endregion

        #region Public Methods
        public void SetScmComment(ScmComment comment)
        {
            _parsedProperties.Add(ButtonPropNames.ScmComment);
            _parsedComments.Add(_parsedProperties.Count - 1, comment);
        }

        public void SetScmBlock(ScmBlock scmBlock)
        {
            _parsedProperties.Add(ButtonPropNames.ScmBlock);
            _parsedScmBlocks.Add(_parsedProperties.Count - 1, scmBlock);
        }

        public void AddParesedProperty(ButtonPropNames propertyName)
        {
            _parsedProperties.Add(propertyName);
        }

        #endregion

        #region Private methods
        private string GetScmPropertiesCode()
        {
            string propertiesCode = "";
            AddMissingProperties();
            for (int i = 0; i < _parsedProperties.Count; i++)
                propertiesCode += GetProppertyCode(_parsedProperties[i], i);
            return propertiesCode;
        }

        private string GetProppertyCode(ButtonPropNames propName, int index)
        {
            string code = "";
            switch (propName)
            {
                case ButtonPropNames.Label:
                    code = CodeGenerationUtils.Indent(string.Format("(label \"{0}\")", this.Label),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.Parent:
                    code = CodeGenerationUtils.Indent(string.Format("(parent {0})", this.Parent),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.Enabled:
                    if (_forceDisplay || this.Enabled != true)
                        code = CodeGenerationUtils.Indent(string.Format("(enabled {0})", CodeGenerationUtils.ToScmBoolValue(this.Enabled)),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.MinWidth:
                    if (_forceDisplay || this.MinWidth != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-width {0})", this.MinWidth),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.MinHeight:
                    if (_forceDisplay || this.MinHeight != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-height {0})", this.MinHeight),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.StrechWidth:
                    if (_forceDisplay || this.StretchableWidth != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-width {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableWidth)),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.StrechHeight:
                    if (_forceDisplay || this.StretchableHeight != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-height {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableHeight)),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.VerticalMargin:
                    if (_forceDisplay || this.VerticalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(vert-margin {0})", this.VerticalMargin),2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.HorizontalMargin:
                    if (_forceDisplay || this.HorizontalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(horiz-margin {0})", this.HorizontalMargin), 2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.Style:
                    if (_forceDisplay || !this.Style.HasDefaultValues())
                        code = CodeGenerationUtils.Indent(string.Format("(style \'{0})", this.Style.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case ButtonPropNames.ScmComment:
                    code = _parsedComments[index].ToScmCode(2);
                    _forceDisplay = true;
                    break;
                case ButtonPropNames.ScmBlock:
                    code = _parsedScmBlocks[index].ToScmCode(2);
                    _forceDisplay = false;
                    break;

            }
            return code;
        }

        private void AddMissingProperties()
        {
            for (int i = 0; i < 10; i++)    //iterate trough all posible properties
                if (!_parsedProperties.Contains((ButtonPropNames)i))
                    _parsedProperties.Add((ButtonPropNames)i);
        }
        #endregion
    }
}

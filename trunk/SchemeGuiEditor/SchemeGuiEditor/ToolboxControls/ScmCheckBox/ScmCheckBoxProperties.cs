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
    public enum CheckBoxPropNames
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

    public class ScmCheckBoxProperties :IScmControlProperties
    {
        #region Private Members
        private ScmCheckBox _checkBox;
        private bool _enabled;
        private string _parent;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private bool _forceDisplay;
        private int _minWidth;
        private int _minHeight;
        private ScmStyle _style;
        private List<CheckBoxPropNames> _parsedProperties;
        private Dictionary<int, ScmComment> _parsedComments;
        private Dictionary<int, ScmBlock> _parsedScmBlocks;
        #endregion

        public ScmCheckBoxProperties(ScmCheckBox checkBox)
        {
            _checkBox = checkBox;
            _enabled = true;
            _style = new ScmStyle();
            _autosizeHeight = true;
            _autosizeWidth = true;
            _parsedProperties = new List<CheckBoxPropNames>();
            _parsedComments = new Dictionary<int, ScmComment>();
            _parsedScmBlocks = new Dictionary<int, ScmBlock>();
        }

        #region IScmControlProperties Members

        public event EventHandler PropertyChanged;

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _checkBox; }
        }

        public string ToScmCode()
        {
            string code = string.Format("(define {0}\n\t(new check-box%\n {1}))\n\n", this.Name, GetScmPropertiesCode());
            return code;
        }

        [Browsable(false)]
        public string DefaultControlName
        {
            get { return "CheckBox"; }
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
            get { return _checkBox.Name; }
            set 
            {
                if (value == string.Empty)
                {
                    MessageService.ShowError(ControlValidation.InvalidValue);
                    return;
                }
                _checkBox.Name = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The string displayed next to the checkbox")]
        public string Label
        {
            get { return _checkBox.Text; }
            set
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.LabelToLong);
                    return;
                }
                _checkBox.Text = value;
                _checkBox.Refresh();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Enables or disables the checkbox")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting minimum width for the checkbox")]
        [DefaultValue(true)]
        public bool AutosizeWidth
        {
            get { return _autosizeWidth; }
            set
            {
                _autosizeWidth = value;
                if (_autosizeWidth)
                {
                    _checkBox.MinWidth = 0;
                    _checkBox.RecomputeSizes();
                }
                else
                    _checkBox.MinWidth = _checkBox.Width;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow setting an minimum Height for the checkbox")]
        [DefaultValue(true)]
        public bool AutosizeHeight
        {
            get { return _autosizeHeight; }
            set
            {
                _autosizeHeight = value;
                if (_autosizeHeight)
                {
                    _checkBox.MinHeight = 0;
                    _checkBox.RecomputeSizes();
                }
                else
                    _checkBox.MinHeight = _checkBox.Height;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum width for the checkbox in pixels")]
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
                    _checkBox.MinWidth = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum height for the checkbox in pixels")]
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
                    _checkBox.MinHeight = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Checkbox's horizontal stretchability")]
        [DefaultValue(false)]
        public bool StretchableWidth
        {
            get
            {
                return _checkBox.StretchableWidth;
            }
            set
            {
                _checkBox.StretchableWidth = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Checkbox's vertical stretchability")]
        [DefaultValue(false)]
        public bool StretchableHeight
        {
            get
            {
                return _checkBox.StretchableHeight;
            }
            set
            {
                _checkBox.StretchableHeight = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the checkbox in pixels")]
        [DefaultValue(2)]
        public int VerticalMargin
        {
            get { return _checkBox.VerticalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _checkBox.VerticalMargin = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Horizontal margins for the checkbox in pixels")]
        [DefaultValue(2)]
        public int HorizontalMargin
        {
            get { return _checkBox.HorizontalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _checkBox.HorizontalMargin = value;
            }
        }

        [Editor(typeof(ScmStyleUiEditor), typeof(UITypeEditor))]
        public ScmStyle Style
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
            return Name + " " + _checkBox.GetType().FullName;
        }
        #endregion

        #region Public Methods
        public void SetScmComment(ScmComment comment)
        {
            _parsedProperties.Add(CheckBoxPropNames.ScmComment);
            _parsedComments.Add(_parsedProperties.Count - 1, comment);
        }

        public void SetScmBlock(ScmBlock scmBlock)
        {
            _parsedProperties.Add(CheckBoxPropNames.ScmBlock);
            _parsedScmBlocks.Add(_parsedProperties.Count - 1, scmBlock);
        }

        public void AddParesedProperty(CheckBoxPropNames propertyName)
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

        private string GetProppertyCode(CheckBoxPropNames propName, int index)
        {
            string code = "";
            switch (propName)
            {
                case CheckBoxPropNames.Label:
                    code = CodeGenerationUtils.Indent(string.Format("(label \"{0}\")", this.Label),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.Parent:
                    code = CodeGenerationUtils.Indent(string.Format("(parent {0})", this.Parent),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.Enabled:
                    if (_forceDisplay || this.Enabled != true)
                        code = CodeGenerationUtils.Indent(string.Format("(enabled {0})", CodeGenerationUtils.ToScmBoolValue(this.Enabled)),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.MinWidth:
                    if (_forceDisplay || this.MinWidth != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-width {0})", this.MinWidth),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.MinHeight:
                    if (_forceDisplay || this.MinHeight != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-height {0})", this.MinHeight),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.StrechWidth:
                    if (_forceDisplay || this.StretchableWidth != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-width {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableWidth)),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.StrechHeight:
                    if (_forceDisplay || this.StretchableHeight != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-height {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableHeight)),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.VerticalMargin:
                    if (_forceDisplay || this.VerticalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(vert-margin {0})", this.VerticalMargin),2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.HorizontalMargin:
                    if (_forceDisplay || this.HorizontalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(horiz-margin {0})", this.HorizontalMargin), 2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.Style:
                    if (_forceDisplay || !this.Style.HasDefaultValues())
                        code = CodeGenerationUtils.Indent(string.Format("(style \'{0})", this.Style.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case CheckBoxPropNames.ScmComment:
                    code = _parsedComments[index].ToScmCode(2);
                    _forceDisplay = true;
                    break;
                case CheckBoxPropNames.ScmBlock:
                    code = _parsedScmBlocks[index].ToScmCode(2);
                    _forceDisplay = false;
                    break;

            }
            return code;
        }

        private void AddMissingProperties()
        {
            for (int i = 0; i < 10; i++)    //iterate trough all posible properties
                if (!_parsedProperties.Contains((CheckBoxPropNames)i))
                    _parsedProperties.Add((CheckBoxPropNames)i);
        }
        #endregion
    }
}

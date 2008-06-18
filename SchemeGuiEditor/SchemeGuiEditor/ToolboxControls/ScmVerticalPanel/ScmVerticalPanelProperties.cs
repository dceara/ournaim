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
    public enum VerticalPanelPropNames
    {
        Parent,
        Enabled,
        Border,
        Spacing,
        Alignment,
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

    public class ScmVerticalPanelProperties :IScmControlProperties
    {
        #region Private Members
        private ScmVerticalPanel _panel;
        private bool _enabled;
        private string _parent;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private bool _forceDisplay;
        private int _minWidth;
        private int _minHeight;
        private ScmButtonStyle _style;
        private List<VerticalPanelPropNames> _parsedProperties;
        private Dictionary<int, ScmComment> _parsedComments;
        private Dictionary<int, ScmBlock> _parsedScmBlocks;
        #endregion

        public ScmVerticalPanelProperties(ScmVerticalPanel panel)
        {
            _panel = panel;
            _enabled = true;
            _style = new ScmButtonStyle();
            _autosizeHeight = true;
            _autosizeWidth = true;
            _parsedProperties = new List<VerticalPanelPropNames>();
            _parsedComments = new Dictionary<int, ScmComment>();
            _parsedScmBlocks = new Dictionary<int, ScmBlock>();
        }

        #region IScmControlProperties Members

        public event EventHandler PropertyChanged;

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _panel; }
        }

        public string ToScmCode()
        {
            string code = string.Format("(define {0}\n\t(new vertical-panel%\n {1}))\n\n", this.Name, GetScmPropertiesCode());
            return code;
        }

        [Browsable(false)]
        public string DefaultControlName
        {
            get { return "HorizontalPanel"; }
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
            get { return _panel.Name; }
            set 
            {
                if (value == string.Empty)
                {
                    MessageService.ShowError(ControlValidation.InvalidValue);
                    return;
                }
                _panel.Name = value;
                _panel.RaiseNameChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Enables or disables the panel")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Alignment specification for a container")]
        public ContainerAlignment Alignment
        {
            get
            {
                return _panel.LayoutManager.Alignment;
            }
            set
            {
                _panel.LayoutManager.Alignment = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Border margin for the container in pixels")]
        [DefaultValue(0)]
        public int Border
        {
            get
            {
                return _panel.LayoutManager.Border;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }

                _panel.LayoutManager.Border = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Border spacing for the container in pixels")]
        [DefaultValue(0)]
        public int Spacing
        {
            get
            {
                return _panel.LayoutManager.Spacing;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }

                _panel.LayoutManager.Spacing = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting minimum width for the panel")]
        [DefaultValue(true)]
        public bool AutosizeWidth
        {
            get { return _autosizeWidth; }
            set
            {
                _autosizeWidth = value;
                if (_autosizeWidth)
                {
                    _panel.MinWidth = 0;
                    _panel.ResetWidth();
                }
                else
                    _panel.MinWidth = _panel.Width;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow setting an minimum Height for the panel")]
        [DefaultValue(true)]
        public bool AutosizeHeight
        {
            get { return _autosizeHeight; }
            set
            {
                _autosizeHeight = value;
                if (_autosizeHeight)
                {
                    _panel.MinHeight = 0;
                    _panel.ResetHeight();
                }
                else
                    _panel.MinHeight = _panel.Height;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum width for the panel in pixels")]
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
                    _panel.MinWidth = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum height for the panel in pixels")]
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
                    _panel.MinHeight = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Panel's horizontal stretchability")]
        [DefaultValue(true)]
        public bool StretchableWidth
        {
            get
            {
                return _panel.StretchableWidth;
            }
            set
            {
                _panel.StretchableWidth = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Panel's vertical stretchability")]
        [DefaultValue(true)]
        public bool StretchableHeight
        {
            get
            {
                return _panel.StretchableHeight;
            }
            set
            {
                _panel.StretchableHeight = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the panel in pixels")]
        [DefaultValue(0)]
        public int VerticalMargin
        {
            get { return _panel.VerticalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _panel.VerticalMargin = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Horizontal margins for the panel in pixels")]
        [DefaultValue(0)]
        public int HorizontalMargin
        {
            get { return _panel.HorizontalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _panel.HorizontalMargin = value;
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
            return Name + " " + _panel.GetType().FullName;
        }
        #endregion

        #region Public Methods
        public void SetScmComment(ScmComment comment)
        {
            _parsedProperties.Add(VerticalPanelPropNames.ScmComment);
            _parsedComments.Add(_parsedProperties.Count - 1, comment);
        }

        public void SetScmBlock(ScmBlock scmBlock)
        {
            _parsedProperties.Add(VerticalPanelPropNames.ScmBlock);
            _parsedScmBlocks.Add(_parsedProperties.Count - 1, scmBlock);
        }

        public void AddParesedProperty(VerticalPanelPropNames propertyName)
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

        private string GetProppertyCode(VerticalPanelPropNames propName, int index)
        {
            string code = "";
            switch (propName)
            {
                case VerticalPanelPropNames.Parent:
                    code = CodeGenerationUtils.Indent(string.Format("(parent {0})", this.Parent),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.Border:
                    if (_forceDisplay || this.Border != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(border {0})", this.Border), 2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.Spacing:
                    if (_forceDisplay || this.Spacing != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(spacing {0})", this.Spacing), 2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.Alignment:
                    if (_forceDisplay ||
                        this.Alignment.HorizontalAlignment != HorizontalAlign.Center ||
                        this.Alignment.VerticalAlignment != VerticalAlign.Top)
                        code = CodeGenerationUtils.Indent(string.Format("(alignment \'{0})", this.Alignment.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.Enabled:
                    if (_forceDisplay || this.Enabled != true)
                        code = CodeGenerationUtils.Indent(string.Format("(enabled {0})", CodeGenerationUtils.ToScmBoolValue(this.Enabled)),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.MinWidth:
                    if (_forceDisplay || this.MinWidth != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-width {0})", this.MinWidth),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.MinHeight:
                    if (_forceDisplay || this.MinHeight != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-height {0})", this.MinHeight),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.StrechWidth:
                    if (_forceDisplay || this.StretchableWidth != true)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-width {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableWidth)),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.StrechHeight:
                    if (_forceDisplay || this.StretchableHeight != true)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-height {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableHeight)),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.VerticalMargin:
                    if (_forceDisplay || this.VerticalMargin != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(vert-margin {0})", this.VerticalMargin),2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.HorizontalMargin:
                    if (_forceDisplay || this.HorizontalMargin != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(horiz-margin {0})", this.HorizontalMargin), 2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.Style:
                    if (_forceDisplay || !this.Style.HasDefaultValues())
                        code = CodeGenerationUtils.Indent(string.Format("(style \'{0})", this.Style.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case VerticalPanelPropNames.ScmComment:
                    code = _parsedComments[index].ToScmCode(2);
                    _forceDisplay = true;
                    break;
                case VerticalPanelPropNames.ScmBlock:
                    code = _parsedScmBlocks[index].ToScmCode(2);
                    _forceDisplay = false;
                    break;

            }
            return code;
        }

        private void AddMissingProperties()
        {
            for (int i = 0; i < 12; i++)    //iterate trough all posible properties
                if (!_parsedProperties.Contains((VerticalPanelPropNames)i))
                    _parsedProperties.Add((VerticalPanelPropNames)i);
        }
        #endregion
    }
}



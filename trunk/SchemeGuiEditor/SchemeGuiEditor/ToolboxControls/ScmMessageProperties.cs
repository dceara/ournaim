using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Constants;
using System.ComponentModel;
using System.Drawing;
using SchemeGuiEditor.Services;
using System.Windows.Forms;
using SchemeGuiEditor.Utils;
using System;
using System.Drawing.Design;

namespace SchemeGuiEditor.ToolboxControls
{
    #region Properties enum
    public enum MessagePropNames
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

    public class ScmMessageProperties : IScmControlProperties
    {
        #region Private Members
        private ScmMessage _message;
        private bool _enabled;
        private string _parent;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private bool _forceDisplay;
        private int _minWidth;
        private int _minHeight;
        private ScmMessageStyle _style;
        private List<MessagePropNames> _parsedProperties;
        private Dictionary<int, ScmComment> _parsedComments;
        private Dictionary<int, ScmBlock> _parsedScmBlocks;
        #endregion

        public ScmMessageProperties(ScmMessage message)
        {
            _message = message;
            _enabled = true;
            _style = new ScmMessageStyle();
            _parsedProperties = new List<MessagePropNames>();
            _parsedComments = new Dictionary<int, ScmComment>();
            _parsedScmBlocks = new Dictionary<int, ScmBlock>();
        }

        #region IScmControlProperties Members

        public event EventHandler PropertyChanged;

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _message; }
        }

        public string ToScmCode()
        {
            string code = string.Format("(define {0}\n\t(new message%\n {1}))\n\n", this.Name, GetScmPropertiesCode());
            return code;
        }

        [Browsable(false)]
        public string DefaultControlName
        {
            get { return "Message"; }
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
            get { return _message.Name; }
            set
            {
                if (value == string.Empty)
                {
                    MessageService.ShowError(ControlValidation.InvalidValue);
                    return;
                }
                _message.Name = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The displayed text")]
        public string Label
        {
            get { return _message.Text; }
            set
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.LabelToLong);
                    return;
                }
                _message.Text = value;
                _message.Refresh();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Enables or disables the message")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting minimum width for the message")]
        [DefaultValue(true)]
        public bool AutosizeWidth
        {
            get { return _autosizeWidth; }
            set
            {
                _autosizeWidth = value;
                if (_autosizeWidth)
                {
                    _message.MinWidth = 0;
                    _message.RecomputeSizes();
                }
                else
                    _message.MinWidth = _message.Width;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow setting an minimum Height for the message")]
        [DefaultValue(true)]
        public bool AutosizeHeight
        {
            get { return _autosizeHeight; }
            set
            {
                _autosizeHeight = value;
                if (_autosizeHeight)
                {
                    _message.MinHeight = 0;
                    _message.RecomputeSizes();
                }
                else
                    _message.MinHeight = _message.Height;
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum width for the message in pixels")]
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
                    _message.MinWidth = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum height for the message in pixels")]
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
                    _message.MinHeight = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Message's horizontal stretchability")]
        [DefaultValue(false)]
        public bool StretchableWidth
        {
            get
            {
                return _message.StretchableWidth;
            }
            set
            {
                _message.StretchableWidth = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Message's vertical stretchability")]
        [DefaultValue(false)]
        public bool StretchableHeight
        {
            get
            {
                return _message.StretchableHeight;
            }
            set
            {
                _message.StretchableHeight = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Vertical margins for the message in pixels")]
        [DefaultValue(2)]
        public int VerticalMargin
        {
            get { return _message.VerticalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _message.VerticalMargin = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Horizontal margins for the message in pixels")]
        [DefaultValue(2)]
        public int HorizontalMargin
        {
            get { return _message.HorizontalMargin; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }
                _message.HorizontalMargin = value;
            }
        }

        [Editor(typeof(ScmStyleUiEditor), typeof(UITypeEditor))]
        public ScmMessageStyle Style
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
            return Name + " " + _message.GetType().FullName;
        }
        #endregion

        #region Public Methods
        public void SetScmComment(ScmComment comment)
        {
            _parsedProperties.Add(MessagePropNames.ScmComment);
            _parsedComments.Add(_parsedProperties.Count - 1, comment);
        }

        public void SetScmBlock(ScmBlock scmBlock)
        {
            _parsedProperties.Add(MessagePropNames.ScmBlock);
            _parsedScmBlocks.Add(_parsedProperties.Count - 1, scmBlock);
        }

        public void AddParesedProperty(MessagePropNames propertyName)
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

        private string GetProppertyCode(MessagePropNames propName, int index)
        {
            string code = "";
            switch (propName)
            {
                case MessagePropNames.Label:
                    code = CodeGenerationUtils.Indent(string.Format("(label \"{0}\")", this.Label), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.Parent:
                    code = CodeGenerationUtils.Indent(string.Format("(parent {0})", this.Parent), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.Enabled:
                    if (_forceDisplay || this.Enabled != true)
                        code = CodeGenerationUtils.Indent(string.Format("(enabled {0})", CodeGenerationUtils.ToScmBoolValue(this.Enabled)), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.MinWidth:
                    if (_forceDisplay || this.MinWidth != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-width {0})", this.MinWidth), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.MinHeight:
                    if (_forceDisplay || this.MinHeight != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-height {0})", this.MinHeight), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.StrechWidth:
                    if (_forceDisplay || this.StretchableWidth != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-width {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableWidth)), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.StrechHeight:
                    if (_forceDisplay || this.StretchableHeight != false)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-height {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableHeight)), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.VerticalMargin:
                    if (_forceDisplay || this.VerticalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(vert-margin {0})", this.VerticalMargin), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.HorizontalMargin:
                    if (_forceDisplay || this.HorizontalMargin != 2)
                        code = CodeGenerationUtils.Indent(string.Format("(horiz-margin {0})", this.HorizontalMargin), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.Style:
                    if (_forceDisplay || !this.Style.HasDefaultValues())
                        code = CodeGenerationUtils.Indent(string.Format("(style \'{0})", this.Style.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case MessagePropNames.ScmComment:
                    code = _parsedComments[index].ToScmCode(2);
                    _forceDisplay = true;
                    break;
                case MessagePropNames.ScmBlock:
                    code = _parsedScmBlocks[index].ToScmCode(2);
                    _forceDisplay = false;
                    break;

            }
            return code;
        }

        private void AddMissingProperties()
        {
            for (int i = 0; i < 10; i++)    //iterate trough all posible properties
                if (!_parsedProperties.Contains((MessagePropNames)i))
                    _parsedProperties.Add((MessagePropNames)i);
        }
        #endregion
    }
}



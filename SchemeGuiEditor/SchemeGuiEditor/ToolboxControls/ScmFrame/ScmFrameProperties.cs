using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SchemeGuiEditor.Constants;
using SchemeGuiEditor.Services;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    #region Properties enum
    public enum FramePropNames
    {
        Label,
        Parent,
        Width,
        Height,
        X,
        Y,
        Style,
        Enabled,
        Border,
        Spacing,
        Alignment,
        MinWidth,
        MinHeight,
        StrechWidth,
        StrechHeight,
        ScmComment,
        ScmBlock
    }
    #endregion

    [DefaultPropertyAttribute("Name")]
    public class ScmFrameProperties : IScmControlProperties
    {
        #region Private Members
        private ScmFrame _frame;
        private bool _enabled;
        private string _parent;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        private bool _autosizeWidth;
        private bool _autosizeHeight;
        private string _width;
        private string _height;
        private int _minWidth;
        private int _minHeight;
        private bool _useX;
        private bool _useY;
        private string _x;
        private string _y;
        private bool _forceDisplay;
        private ScmFrameStyle _style;
        private List<FramePropNames> _parsedProperties;
        private Dictionary<int,ScmComment> _parsedComments;
        private Dictionary<int,ScmBlock> _parsedScmBlocks;
        #endregion

        public ScmFrameProperties(ScmFrame frame)
        {
            _frame = frame;
            _parent = "";
            _enabled = true;
            _stretchableHeight = true;
            _stretchableWidth = true;
            _autosizeHeight = true;
            _autosizeWidth = true;
            _style = new ScmFrameStyle();
            _frame.SizeChanged += new EventHandler(_frame_SizeChanged);
            _frame.LocationChanged += new EventHandler(_frame_LocationChanged);
            _parsedProperties = new List<FramePropNames>();
            _parsedComments = new Dictionary<int, ScmComment>();
            _parsedScmBlocks = new Dictionary<int, ScmBlock>();
        }

        #region IScmControlProperties Members
        public event EventHandler PropertyChanged;

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _frame; }
        }

        public string ToScmCode()
        {
            string code = string.Format("(define {0}\n\t(new frame%\n {1}))\n\n", this.Name, GetScmPropertiesCode());
            return code;
        }
        [Browsable(false)]
        public string DefaultControlName
        {
            get { return "Frame"; }
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
        [DescriptionAttribute("Indicates the name of the parent frame")]
        public string Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name used in code to identify the object")]
        public string Name
        {
            get { return _frame.Name; }
            set 
            { 
                _frame.Name = value;
                _frame.RaiseNameChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The string displayed in the frame's title bar")]
        public string Label
        {
            get { return _frame.Label; }
            set
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.LabelToLong);
                    return;
                }
                _frame.Label = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting an initial width for the frame, else MinWidth is used")]
        [DefaultValue(false)]
        public bool AutosizeWidth
        {
            get { return _autosizeWidth; }
            set
            {
                _autosizeWidth = value;
                if (_autosizeWidth)
                {
                    _width = "";
                    _frame.ResetWidth();
                }
                else
                    _width = _frame.Width.ToString();
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow setting an initial Height for the frame, else MinHeight is used")]
        [DefaultValue(false)]
        public bool AutosizeHeight
        {
            get { return _autosizeHeight; }
            set 
            {
                _autosizeHeight = value;
                if (_autosizeHeight)
                {
                    _height = "";
                    _frame.ResetHeight();
                }
                else
                    _height = _frame.Height.ToString();
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial width for the frame in pixels")]
        [DefaultValue("")]
        public string Width
        {
            get { return _width; }
            set
            {
                if (!_autosizeWidth)
                {
                    int width;
                    if (!int.TryParse(value, out width))
                    {
                        MessageService.ShowError(ControlValidation.InvalidFormat);
                        return;
                    }

                    if (width < 0 || width > 10000)
                    {
                        MessageService.ShowError(ControlValidation.SizeValueInvalid);
                        return;
                    }

                    _frame.Size = new Size(width, _frame.Size.Height);
                    _width = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial height for the frame in pixels")]
        [DefaultValue("")]
        public string Height
        {
            get { return _height; }
            set
            {
                if (!_autosizeWidth)
                {
                    int height;
                    if (!int.TryParse(value, out height))
                    {
                        MessageService.ShowError(ControlValidation.InvalidFormat);
                        return;
                    }

                    if (height < 0 || height > 10000)
                    {
                        MessageService.ShowError(ControlValidation.SizeValueInvalid);
                        return;
                    }

                    _frame.Size = new Size(_frame.Size.Width,height);
                    _height = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum width for the frame in pixels")]
        [DefaultValue(0)]
        public int MinWidth
        {
            get { return _minWidth; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    MessageService.ShowError(ControlValidation.SizeValueInvalid);
                    return;
                }

                _minWidth = value;
                _frame.ResetMinWidth();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum height for the frame in pixels")]
        [DefaultValue(0)]
        public int MinHeight
        {
            get { return _minHeight; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    MessageService.ShowError(ControlValidation.SizeValueInvalid);
                    return;
                }

                _minHeight = value;
                _frame.ResetMinHeight();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting an initial location for the frame Otherwise, a location is selected automatically")]
        [DefaultValue(false)]
        public bool UseX
        {
            get { return _useX; }
            set 
            {
                _useX = value;
                if (!_useX)
                    _x = "";
                else
                    _x = _frame.Location.X.ToString();
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Allow seting an initial location for the frame Otherwise, a location is selected automatically")]
        [DefaultValue(false)]
        public bool UseY
        {
            get { return _useY; }
            set 
            {
                _useY = value;
                if (!_useY)
                    _y = "";
                else
                    _y = _frame.Location.Y.ToString();
                NotifyPropertyChanged();
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial location for the frame")]
        public string X
        {
            get { return _x; }
            set 
            {
                if (_useX)
                {
                    int x;
                    if (!int.TryParse(value, out x))
                    {
                        MessageService.ShowError(ControlValidation.InvalidFormat);
                        return;
                    }

                    if (x < -10000 || x > 10000)
                    {
                        MessageService.ShowError(ControlValidation.LocationValueInvalid);
                        return;
                    }

                    _frame.Location = new Point(x, _frame.Location.Y);
                    _x = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial location for the frame")]
        public string Y
        {
            get { return _y; }
            set 
            {
                if (_useY)
                {
                    int y;
                    if (!int.TryParse(value, out y))
                    {
                        MessageService.ShowError(ControlValidation.InvalidFormat);
                        return;
                    }

                    if (y < -10000 || y > 10000)
                    {
                        MessageService.ShowError(ControlValidation.LocationValueInvalid);
                        return;
                    }

                    _frame.Location = new Point(_frame.Location.X,y);
                    _y = value;
                }
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryBehavior)]
        [DescriptionAttribute("Enables or disables a window so that input events are ignored")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Border margin for the container in pixels")]
        [DefaultValue(0)]
        public int Border
        {
            get
            {
                return _frame.LayoutManager.Padding.All;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }

                _frame.LayoutManager.Padding = new Padding(value);
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Border spacing for the container in pixels")]
        [DefaultValue(0)]
        public int Spacing
        {
            get
            {
                return _frame.LayoutManager.Spacing;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.ValueInvalid);
                    return;
                }

                _frame.LayoutManager.Spacing = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Alignment specification for a container")]
        public ContainerAlignment Alignment
        {
            get
            {
                return _frame.LayoutManager.Alignment;
            }
            set
            {
                _frame.LayoutManager.Alignment = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Area's horizontal stretchability")]
        [DefaultValue(true)]
        public bool StretchableWidth
        {
            get
            {
                return _stretchableWidth;
            }
            set
            {
                _stretchableWidth = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Area's vertical stretchability")]
        [DefaultValue(true)]
        public bool StretchableHeight
        {
            get
            {
                return _stretchableHeight;
            }
            set
            {
                _stretchableHeight = value;
            }
        }

        [Editor(typeof(ScmStyleUiEditor), typeof(UITypeEditor))]
        public ScmFrameStyle Style
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

        #region EventHandlers
        void _frame_SizeChanged(object sender, EventArgs e)
        {
            if (!_autosizeHeight)
            {
                _height = _frame.Height.ToString();
                NotifyPropertyChanged();
            }
            if (!_autosizeWidth)
            {
                _width = _frame.Width.ToString();
                NotifyPropertyChanged();
            }
        }
        void _frame_LocationChanged(object sender, EventArgs e)
        {
            if (_useX)
            {
                _x = _frame.Location.X.ToString();
                NotifyPropertyChanged();
            }
            if (_useY)
            {
                _y = _frame.Location.Y.ToString();
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Override Methods
        public override string ToString()
        {
            return Name + " " + _frame.GetType().FullName;
        }
        #endregion

        #region Public Methods
        public void SetScmComment(ScmComment comment)
        {
            _parsedProperties.Add(FramePropNames.ScmComment);
            _parsedComments.Add(_parsedProperties.Count - 1, comment);
        }

        public void SetScmBlock(ScmBlock scmBlock)
        {
            _parsedProperties.Add(FramePropNames.ScmBlock);
            _parsedScmBlocks.Add(_parsedProperties.Count - 1, scmBlock);
        }

        public void SetXYProp(string name, string value)
        {
            if (name == "x")
            {
                this.UseX = true;
                this.X = value;
                AddParesedProperty(FramePropNames.X);
                return;
            }
            if (name == "y")
            {
                this.UseY = true;
                this.Y = value;
                AddParesedProperty(FramePropNames.Y);
                return;
            }
            string str = "(" + name + " " + value + ")";
            SetScmBlock(new ScmBlock(str));
        }

        public void AddParesedProperty(FramePropNames propertyName)
        {
            _parsedProperties.Add(propertyName);
        }
        #endregion

        #region Private Methods
        private string GetScmPropertiesCode()
        {
            string propertiesCode = "";
            AddMissingProperties();
            for (int i = 0;i< _parsedProperties.Count;i++)
                propertiesCode += GetProppertyCode(_parsedProperties[i],i);
            return propertiesCode;
        }

        private string GetProppertyCode(FramePropNames propName, int index)
        {
            string code = "";
            switch (propName)
            {
                case FramePropNames.Label:
                    code = CodeGenerationUtils.Indent(string.Format("(label \"{0}\")", this.Label),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Parent:
                    if (_forceDisplay || this.Parent != "")
                        code = CodeGenerationUtils.Indent(string.Format("(parent {0})", this.Parent),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Width:
                    if (_forceDisplay || this.AutosizeWidth != true)
                        if (this.AutosizeHeight == true)
                            code = CodeGenerationUtils.Indent(string.Format("(width {0})", CodeGenerationUtils.ToScmBoolValue(false)),2);
                        else
                            code = CodeGenerationUtils.Indent(string.Format("(width {0})", this.Width),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Height:
                    if (_forceDisplay || this.AutosizeHeight != true)
                        if (this.AutosizeHeight == true)
                            code = CodeGenerationUtils.Indent(string.Format("(height {0})", CodeGenerationUtils.ToScmBoolValue(false)),2);
                        else
                            code = CodeGenerationUtils.Indent(string.Format("(height {0})", this.Height), 2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.X:
                    if (_forceDisplay || this.UseX != false)
                        if (this.UseX == false)
                            code = CodeGenerationUtils.Indent(string.Format("(x {0})", CodeGenerationUtils.ToScmBoolValue(false)),2);
                        else
                            code = CodeGenerationUtils.Indent(string.Format("(x {0})", this.X),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Y:
                    if (_forceDisplay || this.UseY != false)
                        if (this.UseY == false)
                            code = CodeGenerationUtils.Indent(string.Format("(y {0})", CodeGenerationUtils.ToScmBoolValue(false)),2);
                        else
                            code = CodeGenerationUtils.Indent(string.Format("(y {0})", this.Y),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Style:
                    if (_forceDisplay || !this.Style.HasDefaultValues())
                        code = CodeGenerationUtils.Indent(string.Format("(style \'{0})", this.Style.ToScmCode()), 2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Enabled:
                    if (_forceDisplay || this.Enabled != true)
                        code = CodeGenerationUtils.Indent(string.Format("(enabled {0})", CodeGenerationUtils.ToScmBoolValue(this.Enabled)),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Border:
                    if (_forceDisplay || this.Border != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(border {0})", this.Border),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Spacing:
                    if (_forceDisplay || this.Spacing != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(spacing {0})", this.Spacing),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.Alignment:
                    if (_forceDisplay ||
                        this.Alignment.HorizontalAlignment != HorizontalAlign.Center ||
                        this.Alignment.VerticalAlignment != VerticalAlign.Top)
                        code = CodeGenerationUtils.Indent(string.Format("(alignment \'{0})", this.Alignment.ToScmCode()),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.MinWidth:
                    if (_forceDisplay || this.MinWidth != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-width {0})", this.MinWidth),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.MinHeight:
                    if (_forceDisplay || this.MinHeight != 0)
                        code = CodeGenerationUtils.Indent(string.Format("(min-height {0})", this.MinHeight),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.StrechWidth:
                    if (_forceDisplay || this.StretchableWidth != true)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-width {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableWidth)),2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.StrechHeight:
                    if (_forceDisplay || this.StretchableHeight != true)
                        code = CodeGenerationUtils.Indent(string.Format("(stretchable-height {0})",
                            CodeGenerationUtils.ToScmBoolValue(this.StretchableHeight)), 2);
                    _forceDisplay = false;
                    break;
                case FramePropNames.ScmComment:
                    code = _parsedComments[index].ToScmCode(2);
                    _forceDisplay = true;
                    break;
                case FramePropNames.ScmBlock:
                    code = _parsedScmBlocks[index].ToScmCode(2);
                    _forceDisplay = false;
                    break;
            }
            return code;
        }

        private void AddMissingProperties()
        {
            for (int i = 0; i < 15; i++)    //iterate trough all posible properties
                if (!_parsedProperties.Contains((FramePropNames)i))
                    _parsedProperties.Add((FramePropNames)i);
        }
        #endregion

    }
}

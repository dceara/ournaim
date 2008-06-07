using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SchemeGuiEditor.Constants;
using SchemeGuiEditor.Services;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace SchemeGuiEditor.ToolboxControls
{
    public enum FramePropNames
    {
        None,
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
        StrechHeight
    }

    [DefaultPropertyAttribute("Name")]
    public class ScmFrameProperties : IScmControlProperties
    {
        private ScmFrame _frame;
        private bool _enabled;
        private string _parent;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        private bool _useWidth;
        private bool _useHeight;
        private string _width;
        private string _height;
        private int _minWidth;
        private int _minHeight;
        private ContainerAlignment _alignment;
        private ScmFrameStyle _style;
        private FramePropNames _lastSetProperty;

        private Dictionary<FramePropNames, List<object>> _externalObjects;

        public ScmFrameProperties(ScmFrame frame)
        {
            _frame = frame;
            _alignment = new ContainerAlignment(HorizontalAlign.Center,VerticalAlign.Top);
            _enabled = true;
            _stretchableHeight = true;
            _stretchableWidth = true;
            _style = new ScmFrameStyle();
            _externalObjects = new Dictionary<FramePropNames, List<object>>();
            _frame.SizeChanged += new EventHandler(_frame_SizeChanged);
        }

        public void AddExternalObject(object obj)
        {
        }

        [Browsable(false)]
        public FramePropNames LastSetProperty
        {
            get { return _lastSetProperty; }
            set { _lastSetProperty = value; }
        }

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
            set { _frame.Name = value; }
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

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Allow seting an initial width for the frame, else MinWidth is used")]
        [DefaultValue(false)]
        public bool UseWidth
        {
            get { return _useWidth; }
            set { _useWidth = value;}
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Allow setting an initial Height for the frame, else MinHeight is used")]
        [DefaultValue(false)]
        public bool UseHeight
        {
            get { return _useHeight; }
            set { _useHeight = value; }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial width for the frame in pixels")]
        [DefaultValue("")]
        public string Width
        {
            get { return _width; }
            set
            {
                if (_useWidth)
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
        [DescriptionAttribute("Initial width for the frame in pixels")]
        [DefaultValue("")]
        public string Height
        {
            get { return _height; }
            set
            {
                if (_useWidth)
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
        [DescriptionAttribute("Initial width for the frame in pixels")]
        [DefaultValue(0)]
        public int MinWidth
        {
            get { return _minWidth; }
            set
            {
                _minWidth = value;
                if (value > _frame.MinimumSize.Width)
                    _frame.MinimumSize = new Size(value, _frame.MinimumSize.Height);
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial width for the frame in pixels")]
        [DefaultValue(0)]
        public int MinHeight
        {
            get { return _minHeight; }
            set
            {
                _minHeight = value;
                if (value > _frame.MinimumSize.Height)
                    _frame.MinimumSize = new Size(_frame.MinimumSize.Width, value);
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial location for the frame")]
        public Point Location
        {
            get
            {
                return _frame.Location;
            }
            set
            {
                _frame.Location = value;
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
                    MessageService.ShowError(ControlValidation.FrameValueInvalid);
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
                    MessageService.ShowError(ControlValidation.FrameValueInvalid);
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

        [Editor(typeof(ScmFrameStyleUiEditor), typeof(UITypeEditor))]
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
        #region EventHandlers
        void _frame_SizeChanged(object sender, EventArgs e)
        {
            if (_useHeight)
                _height = _frame.Height.ToString();
            if (_useWidth)
                _width = _frame.Width.ToString();
        }
        #endregion

        #region IScmControlProperties Members

        [Browsable(false)]
        public IScmControl Control
        {
            get { return _frame; }
        }

        #endregion

        public override string ToString()
        {
            return Name + " " + _frame.GetType().FullName;
        }
    }
}

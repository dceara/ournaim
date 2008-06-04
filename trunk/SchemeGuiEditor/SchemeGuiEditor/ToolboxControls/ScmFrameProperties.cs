using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SchemeGuiEditor.Constants;
using SchemeGuiEditor.Services;
using System.Drawing;
using System.Drawing.Design;

namespace SchemeGuiEditor.ToolboxControls
{
    [DefaultPropertyAttribute("Name")]
    public class ScmFrameProperties : IScmControlProperties
    {
        private ScmFrame _frame;
        private bool _enabled;
        private int _border;
        private int _spacing;
        private bool _stretchableWidth;
        private bool _stretchableHeight;
        private ContainerAlignment _alignment;
        private ScmFrameStyle _style;

        public ScmFrameProperties(ScmFrame frame)
        {
            _frame = frame;
            _alignment = new ContainerAlignment(HorizontalAlign.Center,VerticalAlign.Top);
            _enabled = true;
            _stretchableHeight = true;
            _stretchableWidth = true;
            _style = new ScmFrameStyle();
        }

        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name used in code to identify the object")]
        public string Name
        {
            get
            {
                return _frame.Name;
            }
            set
            {
                _frame.Name = value;
            }
        }
        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The string displayed in the frame's title bar")]
        public string Label
        {
            get
            {
                return _frame.Label;
            }
            set
            {
                if (value.Length > 200)
                {
                    MessageService.ShowError(ControlValidation.FrameLabelToLong);
                    return;
                }
                _frame.Label = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Initial size for the frame in pixels")]
        public Size Size
        {
            get
            {
                return _frame.Size;
            }
            set
            {
                _frame.Size = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Minimum size for the frame in pixels")]
        public Size MinSize
        {
            get
            {
                return _frame.MinimumSize;
            }
            set
            {
                _frame.MinimumSize = value;
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
                return _border;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.FrameValueInvalid);
                    return;
                }

                _border = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("Border spacing for the container in pixels")]
        [DefaultValue(0)]
        public int Spacing
        {
            get
            {
                return _spacing;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    MessageService.ShowError(ControlValidation.FrameValueInvalid);
                    return;
                }

                _spacing = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Alignment specification for a container")]
        public ContainerAlignment Alignment
        {
            get
            {
                return _alignment;
            }
            set
            {
                _alignment = value;
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

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SchemeGuiEditor.ToolboxControls
{
    #region Alignment Enums
    public enum HorizontalAlign
    {
        Left,
        Center,
        Right
    }

    public enum VerticalAlign
    {
        Top,
        Center,
        Bottom
    }
    #endregion

    [TypeConverter(typeof(AlignmentTypeConverter))]
    public class ContainerAlignment
    {
        #region Members
        private HorizontalAlign _horizontalAlignment;
        private VerticalAlign _verticalAlignment;
        public event EventHandler AlignmentChanged;
        #endregion

        #region Constructors
        public ContainerAlignment()
        {
        }

        public ContainerAlignment(HorizontalAlign horizontalAlign, VerticalAlign verticalAlign)
        {
            _horizontalAlignment = horizontalAlign;
            _verticalAlignment = verticalAlign;
        }
        #endregion

        #region Properties
        [DefaultValue(HorizontalAlign.Center)]       
        public HorizontalAlign HorizontalAlignment
        {
            get { return _horizontalAlignment; }
            set 
            {
                if (_horizontalAlignment != value)
                {
                    _horizontalAlignment = value;
                    if (AlignmentChanged != null)
                        AlignmentChanged(this, EventArgs.Empty);
                }
            }
        }

        [DefaultValue(VerticalAlign.Top)]
        public VerticalAlign VerticalAlignment
        {
            get { return _verticalAlignment; }
            set
            {
                if (_verticalAlignment != value)
                {
                    _verticalAlignment = value;
                    if (AlignmentChanged != null)
                        AlignmentChanged(this, EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Override methods
        public override string ToString()
        {
            return _horizontalAlignment.ToString() +", "+ _verticalAlignment.ToString();
        }
        
        public override bool Equals(object obj)
        {
            ContainerAlignment ca = obj as ContainerAlignment;
            return (this.VerticalAlignment == ca.VerticalAlignment && this.VerticalAlignment == ca.VerticalAlignment);
        }
        #endregion

        #region Public Methods
        public string ToScmCode()
        {
            string code = string.Format("({0} {1})",HorizontalAlignString(),VerticalAlignString());
            return code;
        }
        #endregion

        #region Private Methods
        private string VerticalAlignString()
        {
            switch (_verticalAlignment)
            {
                case VerticalAlign.Top:
                    return "top";
                case VerticalAlign.Center:
                    return "center";
                case VerticalAlign.Bottom:
                    return "bottom";
            }
            return "";
        }

        private string HorizontalAlignString()
        {
            switch (_horizontalAlignment)
            {
                case HorizontalAlign.Center:
                    return "center";
                case HorizontalAlign.Left:
                    return "left";
                case HorizontalAlign.Right:
                    return "right";
            }
            return "";
        }
        #endregion

    }

    public class AlignmentTypeConverter : TypeConverter
    {
        public AlignmentTypeConverter()
        {
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(ContainerAlignment));
        }
    }
}

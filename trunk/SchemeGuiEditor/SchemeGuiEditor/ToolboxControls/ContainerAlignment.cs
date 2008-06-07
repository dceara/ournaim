using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SchemeGuiEditor.ToolboxControls
{
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

    [TypeConverter(typeof(AlignmentTypeConverter))]
    public class ContainerAlignment
    {
        public event EventHandler AlignmentChanged;

        private HorizontalAlign _horizontalAlignment;
        private VerticalAlign _verticalAlignment;

        public ContainerAlignment()
        {
        }

        public ContainerAlignment(HorizontalAlign horizontalAlign, VerticalAlign verticalAlign)
        {
            _horizontalAlignment = horizontalAlign;
            _verticalAlignment = verticalAlign;
        }

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

        public override string ToString()
        {
            return _horizontalAlignment.ToString() +", "+ _verticalAlignment.ToString();
        }

        public override bool Equals(object obj)
        {
            ContainerAlignment ca = obj as ContainerAlignment;
            return (this.VerticalAlignment == ca.VerticalAlignment && this.VerticalAlignment == ca.VerticalAlignment);
        }
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

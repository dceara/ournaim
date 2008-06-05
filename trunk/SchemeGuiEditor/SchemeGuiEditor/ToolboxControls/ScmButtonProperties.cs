using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Constants;
using System.ComponentModel;
using System.Drawing;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmButtonProperties :IScmControlProperties
    {
        private ScmButton _button;
        private bool _enabled;

        public ScmButtonProperties(ScmButton button)
        {
            _button = button;
        }
   //vert-margin = 2 : exact integer in [0, 1000]
   //horiz-margin = 2 : exact integer in [0, 1000]
   //min-width = graphical minimum width : exact integer in [0, 10000]
   //min-height = graphical minimum height : exact integer in [0, 10000]
   //stretchable-width = #f : boolean
   //stretchable-height = #f : boolean
        [CategoryAttribute(AttributesCategories.CategoryDesign)]
        [DescriptionAttribute("Indicates the name used in code to identify the object")]
        public string Name
        {
            get
            {
                return _button.Name;
            }
            set
            {
                _button.Name = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryAppearance)]
        [DescriptionAttribute("The string displayed on the button")]
        public string Label
        {
            get
            {
                return _button.Text;
            }
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
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
            }
        }

        [CategoryAttribute(AttributesCategories.CategoryLayout)]
        [DescriptionAttribute("Location for the button relative to it's parent")]
        public Point Location
        {
            get
            {
                return _button.Location;
            }
            set
            {
                _button.Location = value;
            }
        }



        #region IScmControlProperties Members

        public IScmControl Control
        {
            get { return _button; }
        }

        #endregion
    }
}

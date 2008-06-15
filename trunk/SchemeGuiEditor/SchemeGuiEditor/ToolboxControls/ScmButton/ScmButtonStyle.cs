using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmButtonStyle
    {
        private bool _border;
        private bool _deleted;

        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public bool Border
        {
            get { return _border; }
            set { _border = value; }
        }
        
        public override string ToString()
        {
            string description = string.Empty;
            if (_border)
                description += "Border, ";
            if (_deleted)
                description += "Deleted, ";

            if (description != string.Empty)
                description = description.Remove(description.Length - 2);

            return description;
        }

        public bool HasDefaultValues()
        {
            if (_border)
                return false;
            if (_deleted)
                return false;
            return true;
        }

        public string ToScmCode()
        {
            string code = "(";
            if (_border)
                code += "border ";
            if (_deleted)
                code += "deleted ";
            code = code.TrimEnd(' ') + ")";
            return code;
        }
    }

}

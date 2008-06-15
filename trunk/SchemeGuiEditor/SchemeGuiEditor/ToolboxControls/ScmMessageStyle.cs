using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmMessageStyle
    {
        private bool _deleted;

        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public override string ToString()
        {
            string description = string.Empty;
            if (_deleted)
                description += "Deleted";

            return description;
        }

        public bool HasDefaultValues()
        {
            if (_deleted)
                return false;
            return true;
        }

        public string ToScmCode()
        {
            string code = "(";
            if (_deleted)
                code += "deleted";
            code += ")";
            return code;
        }
    }
}

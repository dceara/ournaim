using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmComment
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public ScmComment(string text)
        {
            _text = text;
        }

        public string ToScmCode(int indent)
        {
            string code = "";
            for (int i = 0; i < indent; i++)
                code += "\t";
            code += _text + "\n";
            return code;
        }
    }
}

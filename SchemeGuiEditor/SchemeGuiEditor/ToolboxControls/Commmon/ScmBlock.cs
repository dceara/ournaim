using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmBlock
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public ScmBlock(string text)
        {
            _text = text;
        }

        public string ToScmCode(int indent)
        {
            string code = "";
            int ind = indent-1;
            foreach (char c in _text)
            {
                if (c == '(')
                {
                    ind++;
                    code += "\n";
                    for (int i = 0; i < ind; i++)
                        code += "\t";
                }
                if (c == ')')
                    ind--;

                code += c;
            }
            code += "\n\n";
            return code;
        }
    }
}

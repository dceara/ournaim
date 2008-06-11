using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.Utils
{
    public class CodeGenerationUtils
    {
        public static string ToScmBoolValue(bool value)
        {
            if (value == true)
                return "#t";
            else return "#f";
        }

        public static string Indent(string str, int indent)
        {
            string code = "";
            for (int i = 0; i < indent; i++)
                code += "\t";
            code += str + "\n";
            return code;
        }
    }
}

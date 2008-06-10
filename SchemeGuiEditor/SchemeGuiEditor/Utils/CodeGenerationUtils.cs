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
    }
}

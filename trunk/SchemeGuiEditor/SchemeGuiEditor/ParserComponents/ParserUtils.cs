using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ParserComponents
{
    public class ParserUtils
    {
        public static int GetIntValue(string value)
        {
            int nr = 0;
            int.TryParse(value, out nr);
            return nr;
        }
    }
}

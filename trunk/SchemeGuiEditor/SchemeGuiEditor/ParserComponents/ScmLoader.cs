using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace SchemeGuiEditor.ParserComponents
{
    public class ScmLoader
    {
        public static List<object> LoadScmData(string fileName)
        {
            try
            {
                ANTLRFileStream antlrFileStream = new ANTLRFileStream(fileName);
                ScmGrammarLexer lexer = new ScmGrammarLexer(antlrFileStream);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                ScmGrammarParser parser = new ScmGrammarParser(tokens);
                parser.main();

                return parser.ParsedData;
            }
            catch (Exception)
            {
                return new List<object>();
            }
        }
    }
}

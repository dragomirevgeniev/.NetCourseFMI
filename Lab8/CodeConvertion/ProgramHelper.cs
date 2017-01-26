using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeConvertion
{
    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public ProgramHelper()
        {

        }

        bool ICodeChecker.CodeCheckSyntax(string code, string language)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ConvertToCSharp(string code)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ConvertToVB2015(string code)
        {
            throw new NotImplementedException();
        }
    }
}
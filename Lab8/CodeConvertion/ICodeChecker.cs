using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeConvertion
{
    public interface ICodeChecker : IConvertible
    {
        bool CodeCheckSyntax(string code, string language);
    }
}
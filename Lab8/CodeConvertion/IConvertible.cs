using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeConvertion
{
    public interface IConvertible
    {
        string ConvertToCSharp(string code);
        string ConvertToVB2015(string code);
    }
}
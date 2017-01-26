using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeConvertion
{
    public class ProgramConverter : IConvertible
    {
        public ProgramConverter()
        {

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramHelper ph = new ProgramHelper();
            ProgramConverter pc = new ProgramConverter();

            bool ic = ((ICodeChecker)pc).CodeCheckSyntax("code", "language");
            string csharpCode = ((ICodeChecker)pc).ConvertToCSharp("code VB2015");
            Console.WriteLine(ic + csharpCode);

            bool ics = ((ICodeChecker)ph).CodeCheckSyntax("code", "language");
            string vb2015Code = ((ICodeChecker)ph).ConvertToCSharp("code VB2015");
            Console.WriteLine(ics + vb2015Code);
        }
    }
}

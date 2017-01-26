using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public interface Comparable
    {
        double SizeOf();

        double this[string index] { get; set; }
    }
}

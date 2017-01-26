using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseApp
{
    public class IntBits
    {
        public int IntVal { get; set; }

        public IntBits(int v)
        {
            IntVal = v;
        }

        public bool this[int index]
        {
            get
            {
                if (index >= 0 && index < 32)
                {
                    return (IntVal & (1 << index)) == 0? false : true;
                }
                return false;
            }
            set
            {
                if (index >= 0 && index < 32)
                {
                    if (value)
                    {
                        IntVal |= (1 << index);
                    }
                    else
                    {
                        IntVal &= ~(1 << index);
                    }
                }
            }
        }

        public override string ToString()
        {
            return "Integer value: " + IntVal;
        }
    }
}

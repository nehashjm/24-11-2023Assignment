using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class Factorial
    {
        public int fact(int num)
        {
            
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * fact(num-1);
            }
        }
    }
}

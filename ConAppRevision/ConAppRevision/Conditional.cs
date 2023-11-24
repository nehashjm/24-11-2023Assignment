using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class Conditional
    {
        public void Display()
        {
            Console.WriteLine("enter number");
            int i = int.Parse(Console.ReadLine());
            if(i%2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}

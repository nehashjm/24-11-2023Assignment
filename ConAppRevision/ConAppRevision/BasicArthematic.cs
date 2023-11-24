using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class BasicArthematic
    {
        public void Display()
        {
            int a;
            int b;
            Console.WriteLine("enter number 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("choose one\t 1add \t2sub\t 3mul\t 4div\t 5mod\t ");
            int ch = int.Parse(Console.ReadLine());
            if(ch == 1)
            {
                int result = a + b;
                Console.WriteLine("addition" + result);
            }
            else if (ch == 2)
            {
                int result = a - b;
                Console.WriteLine("substraction" + result);
            }
            else if (ch == 3)
            {
                int result = a * b;
                Console.WriteLine("multiplication" + result);
            }
            else if (ch == 4)
            {
                try
                {
                    int result = a / b;
                    Console.WriteLine("Division" + result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else 
            {
                int result = a % b;
                Console.WriteLine("modulus"+result);
            }
        }
    }
}

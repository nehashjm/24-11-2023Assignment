using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class UserInput
    {
        public void Display()
        {
            string name;
            Console.WriteLine("enter user input");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}

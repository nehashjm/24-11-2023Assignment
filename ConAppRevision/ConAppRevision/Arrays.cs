using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class Arrays
    {
        public void Display()
        {
            int[] arr = {10,20,30,40,50};
            int sum = arr.Sum();
            int avg = arr.Sum()/arr.Length;
            Console.WriteLine(sum+"\t"+avg);
        }
    }
}

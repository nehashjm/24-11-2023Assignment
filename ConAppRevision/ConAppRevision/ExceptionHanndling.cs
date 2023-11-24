using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRevision
{
    public class ExceptionHanndling
    {
        public void display()
        {
            try
            {
                int age;

                while (true)
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out age))
                    {
                        // Valid integer input
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }

                if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age <= 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex);
            }
           
        }
    
    
    }
}

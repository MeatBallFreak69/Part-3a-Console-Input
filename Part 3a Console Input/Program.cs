using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year = DateTime.Now.Year;

            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            
            int age = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"The year is {year}");






        }
    }
}

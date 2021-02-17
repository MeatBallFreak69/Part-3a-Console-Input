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

            Console.WriteLine("Program 1");

            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            
            int age = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"The year is {year}");
            Console.WriteLine("");


            Console.WriteLine("Program 2");

            Console.WriteLine("Please input 3 numbers");
            Console.WriteLine("Number 1");
            int NumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2");
            int NumTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 3");
            int NumThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your total is {NumOne + NumTwo + NumThree}");
            Console.WriteLine("");


            Console.WriteLine("Program 3");

            Console.WriteLine("Please input three distances (km)");
            Console.WriteLine("Distance 1");
            double DisOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance 2");
            double DisTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance 3");
            double DisThree = Convert.ToDouble(Console.ReadLine());
            double totalDistance = (DisOne + DisTwo + DisThree) / 3;
            totalDistance = Math.Round(totalDistance, 2); 
            Console.WriteLine($"Your average distance is {totalDistance}");
            Console.WriteLine("");

            Console.WriteLine("Program 3");

            Console.WriteLine("Please input the length of two sides of a triangle to find hypotenuse");

            Console.WriteLine("Length One");
            double lengthOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length Two");
            double lengthTwo = Convert.ToDouble(Console.ReadLine());
            double thirdLength = Math.Sqrt((lengthOne * lengthOne) + (lengthTwo * lengthTwo));
            Console.WriteLine($"Your hypotenuse is {thirdLength}");

        }
    }
}

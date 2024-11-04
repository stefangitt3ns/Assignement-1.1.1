using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a console app that asks for your name, age, and height 
            // Then print out each one.

            Console.WriteLine("Please enter your name, age and height in this order.");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How tall are you? Use a decimale to seperate the feet from the inches. Ex. 5.8 = 5 feet 8 inches. ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Welcome {name}, you are age {age} years old, and you are {height} tall");
            Console.Read();
        }
    }
}

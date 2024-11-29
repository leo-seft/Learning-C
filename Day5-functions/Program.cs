using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Hello(name);
            Console.WriteLine("Please give me a number");
            double num1 = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Please give me another number");
            double num2 = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("They sum up to " + add(num1,num2));
        }

        public static void Hello(string name){
            Console.WriteLine($"Hello {name}");
        }
        public static double add (double num1, double num2){
            return num1 + num2;
        }
    }
}
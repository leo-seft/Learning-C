using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday, 
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            string firstString = "hello";

            double myDouble = 4.5;

            int num = (int)myDouble;

            Console.WriteLine(firstString);

            Console.WriteLine("{0} my number is " + num,firstString);

            DayOfWeek today = DayOfWeek.Tuesday;
            int todayNumer = (int)today;

            Console.WriteLine(today);
            Console.WriteLine(todayNumer);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);
        }
    }
}
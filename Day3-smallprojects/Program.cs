using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameTag
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, I am your name badge generator");
           Console.WriteLine("Please give me your first name");
           string firstName = Console.ReadLine() ?? "N/A"; 
           Console.WriteLine("Please give me your last name");
           string lastName = Console.ReadLine() ?? "N/A";
           Console.WriteLine("What is your job?");
           string job = Console.ReadLine() ?? "N/A";
           Console.WriteLine("What is your email?");
           string email = Console.ReadLine() ?? "N/A";

           Console.WriteLine($"Name: {firstName} {lastName}" );
           Console.WriteLine($"Job:   {job,-20}" );
           Console.WriteLine($"Contact Email:  {email,-20}" );

        }
    }
}
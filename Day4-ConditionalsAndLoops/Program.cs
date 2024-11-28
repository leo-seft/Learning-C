using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            bool correct = false;

            Console.WriteLine("I am a number guessing game");
            Console.WriteLine("Please guess the number");

            while (!correct)
            {
                // Provide a fallback for null input
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int guess)){
                    if (guess == number){
                        Console.WriteLine("Correct guess");
                        correct = true;
                    }
                    else if (guess > number){
                        Console.WriteLine("Too high");
                        Console.WriteLine("Guess again");
                    }
                    else{
                        Console.WriteLine("Too low");
                        Console.WriteLine("Guess again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("What was your test score out of 100?");
            string scoreInput = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(scoreInput, out int score))
            {
                Console.WriteLine((score >= 60) ? "Pass" : "Fail");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            for (int j = 0; j < 5 ; j++){
                for (int i = 0; i < 10; i++){
                    Console.Write("{0,3}", "+");
                }
                Console.WriteLine();
            }
        }
    }
}
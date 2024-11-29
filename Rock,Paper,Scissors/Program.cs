using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            bool handSelected = false;

            while (!handSelected)
            {
                Console.WriteLine("Please enter the number corresponding to the hand: Rock(0), Paper(1), Scissors(2)");
                int playerNum;

                //checks if user input is valid
                if (!int.TryParse(Console.ReadLine(), out playerNum))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                string playerHand = "";

                // Determine player's hand
                switch (playerNum)
                {
                    case 0:
                        playerHand = "Rock";
                        Console.WriteLine("You selected Rock");
                        handSelected = true;
                        break;
                    case 1:
                        playerHand = "Paper";
                        Console.WriteLine("You selected Paper");
                        handSelected = true;
                        break;
                    case 2:
                        playerHand = "Scissors";
                        Console.WriteLine("You selected Scissors");
                        handSelected = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input, try again");
                        break;
                }

                if (!handSelected)
                    continue;

                // Generate computer's hand
                Random random = new Random();
                int computerNum = random.Next(0, 3);
                string computerHand = "";

                switch (computerNum)
                {
                    case 0:
                        computerHand = "Rock";
                        break;
                    case 1:
                        computerHand = "Paper";
                        break;
                    case 2:
                        computerHand = "Scissors";
                        break;
                }

                Console.WriteLine($"The computer selected {computerHand}");

                // Determine the winner
                if (playerHand == computerHand)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if ((playerHand == "Rock" && computerHand == "Scissors") ||
                         (playerHand == "Paper" && computerHand == "Rock") ||
                         (playerHand == "Scissors" && computerHand == "Paper"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
            }
        }
    }
}

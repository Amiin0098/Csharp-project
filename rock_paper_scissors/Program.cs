using System;

namespace console_app
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            PlayGame();

            Console.WriteLine("Thank you for playing!");
        }

        static void PlayGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Enter ROCK, PAPER, or SCISSORS:");
                string userChoice = Console.ReadLine();

                if (!IsValidChoice(userChoice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                string computerChoice = GetComputerChoice();

                Console.WriteLine($"Player: {userChoice}");
                Console.WriteLine($"Computer: {computerChoice}");

                string result = DetermineWinner(userChoice, computerChoice);
                Console.WriteLine(result);

                playAgain = AskToPlayAgain();
            }
        }

        static bool IsValidChoice(string choice)
        {
            string lowercaseChoice = choice.ToLower();
            return lowercaseChoice == "rock" || lowercaseChoice == "paper" || lowercaseChoice == "scissors";
        }


        static string GetComputerChoice()
        {
            Random random = new Random();
            int choice = random.Next(0, 3);

            switch (choice)
            {
                case 0:
                    return "rock";
                case 1:
                    return "paper";
                case 2:
                    return "scissors";
                default:
                    return "";
            }
        }

        static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It's a draw!";
            }
            else if (
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper")
            )
            {
                return "You win!";
            }
            else
            {
                return "You lose!";
            }
        }

        static bool AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string playAgainInput = Console.ReadLine();

            return (playAgainInput.ToLower() == "y");
        }
    }
}
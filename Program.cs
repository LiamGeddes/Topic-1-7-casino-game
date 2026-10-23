namespace Topic_1_7_casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            int ties = 0;
            string choice = "";

            Console.Title = ("Rock Paper Scissors");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("===========================================");
            Console.WriteLine("        ROCK PAPER SCISSORS ");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine(" Rock Beats Scissors");
            Console.WriteLine("Scissors Beats Paper");
            Console.WriteLine("Paper Beats Rock");
            Console.WriteLine();
            Console.WriteLine("You Earn 1 Point For Every Win");
            Console.WriteLine();

            while (choice != "quit")
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("Your Score: " + playerScore);
                Console.WriteLine("Computer Score: " + computerScore);
                Console.WriteLine("Ties: " + ties);
                Console.WriteLine("________________________________");
                Console.WriteLine();

                Console.Write("Choose Rock, Paper, Scissors Or Quit: ");
                choice = Console.ReadLine().ToLower();

                if (choice == "quit")
                {
                    break;
                }

                if (choice != "rock" && choice != "paper" && choice != "scissors")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice.Try again.");
                    Console.WriteLine();
                    continue;
                }

                Random random = new Random();
                int computerNumber = random.Next(1, 4);

                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "rock";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "paper";
                }
                else
                {
                    computerChoice = "scissors";
                }

                Console.WriteLine();
                Console.WriteLine("You chose: " + choice);
                Console.WriteLine("Computer chose: " + computerChoice);
                Console.WriteLine();

                if (choice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                    ties++;
                }
                else if (choice == "rock" && computerChoice == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win!");
                    playerScore++;
                }
                else if (choice =="paper" && computerChoice == "rock")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win!");
                    playerScore++;
                }
                else if (choice == "scissors" && computerChoice == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win!");
                    playerScore++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer Wins!");
                    computerScore++;
                }

                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("         GAME OVER");
            Console.WriteLine("=============================");
            Console.WriteLine("Your wins: " + playerScore);
            Console.WriteLine("Computer wins: " + computerScore);
            Console.WriteLine("Ties: " + ties);
            Console.WriteLine();

            if (playerScore > computerScore)
            {
                Console.WriteLine("You are the overall winner!");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("The computer is the overall winner!");
            }
            else
            {
                Console.WriteLine("The game ended in a tie");
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}

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
            }



        }
    }
}

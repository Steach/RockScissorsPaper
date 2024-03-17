using System.ComponentModel.Design.Serialization;

namespace RockScissorsPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endGame = false;
            string userName;
            int userAge = 0;
            int playedRounds = 0;
            int winGames = 0;

            Console.WriteLine("Hello, this is Rock, Scissors, Paper game!\n");

            Console.WriteLine("Enter your name: ");
            while (true)
            {
                userName = Console.ReadLine();
                if (userName != "")
                    break;
                else 
                {
                    Console.WriteLine($"You name can`t was empty. Please enter your name: ");
                }
            }

            while (userAge < 12)
            {
                Console.WriteLine($"Enter your age: ");
                while (!int.TryParse(Console.ReadLine(), out userAge))
                {
                    Console.WriteLine("Enter your age: ");
                }

                if (userAge <= 12)
                {
                    Console.WriteLine($"Sorry this game for person older than 12.\n");
                    break;
                }
                    
            }

            Console.WriteLine($"User Name: {userName};");
            Console.WriteLine($"User Age: {userAge};");
            Console.WriteLine($"Played game rounds: {playedRounds};");
            Console.WriteLine($"Win Game: {winGames}.\n");

            while (true)
            {
                Console.WriteLine($"Do you want play? (yes/no)\n");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                    break;
                else if (answer == "no")
                {
                    endGame = true;
                    Console.WriteLine($"Game over.\nGood bye!\n");
                    break;
                }
                    
                else
                    Console.WriteLine("Answer must be yes or no.\n");
            }

            while (!endGame)
            {
                Console.WriteLine($"Choose your weapon: ");
                Console.WriteLine($"{(TypeOfWaepon)1} - 1, \n{(TypeOfWaepon)2} - 2, \n{(TypeOfWaepon)3} - 3, \n");
                int userWeapon = int.Parse(Console.ReadLine());
                Console.WriteLine($"GAME!");
            }
            
        }
    }
}

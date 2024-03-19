using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace RockScissorsPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endGame = false;
            string userName = "";
            int userAge = 0;
            int playedRounds = 0;
            int winGames = 0;

            //Console.SetWindowSize(80, 50);
            Console.WindowHeight = 50;

            WelcomeText();
            userName = EnterPlayerName();
            userAge = EnterPlayerAge();
            DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
            ReadyToGame(ref endGame, userName, winGames);
            Game(ref endGame, userName, winGames, ref playedRounds, userAge);
        }

        static void WelcomeText()
        {
            Console.WriteLine("Hello, this is Rock, Scissors, Paper game!\n");
        }

        static string EnterPlayerName()
        {
            string userName;
            Console.Write("Enter your name: ");
            while (true)
            {
                userName = Console.ReadLine();
                if (userName != "")
                    return userName;
                else
                    Console.WriteLine($"You name can`t be empty. Please enter your name: ");
            }
        }

        static int EnterPlayerAge()
        {
            int userAge = 0;
            while (userAge < 12)
            {
                Console.Write($"Enter your age (12+): ");
                while (!int.TryParse(Console.ReadLine(), out userAge))
                    Console.WriteLine("Enter your age (12+): ");
                if (userAge < 12)
                {
                    Console.WriteLine($"Sorry this game for person older than 12.\n");
                    Environment.Exit(0);
                }
            }
            return userAge;
        }

        static void ReadyToGame(ref bool endGame, string userName, int winGames)
        {
            while (true)
            {
                Console.WriteLine($"\n============================Are you ready?====================================");
                Console.Write($"Do you want play (yes/no) ? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                    break;
                else if (answer == "no")
                {
                    endGame = true;

                    Console.WriteLine("==============================================================================");
                    Console.WriteLine($"{userName} Win games: {winGames}");
                    Console.WriteLine($"Game over.\n{userName} Good bye!\n");
                    break;
                }

                else
                    Console.WriteLine("Answer must be yes or no.\n");
                Console.WriteLine("==============================================================================\n");
            }
        }

        static void DisplayPlayerInformation(string userName, int userAge, int playedRounds, int winGames)
        {
            Console.WriteLine($"\n==========================Player Information==================================");
            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"User Age: {userAge}");
            Console.WriteLine($"Played game rounds: {playedRounds}");
            Console.WriteLine($"Win Game: {winGames}");
            Console.WriteLine("==============================================================================\n");
        }

        static void DisplayWeapon(int weaponID)
        {
            switch (weaponID)
            {
                case 1:
                    DisplayRock();
                    break;
                case 2:
                    DisplayScissors();
                    break;
                case 3:
                    DisplayPaper();
                    break;
            }
        }

        static void DisplayPaper()
        {
            Console.WriteLine("\n");
            Console.WriteLine("           ███");
            Console.WriteLine("       ████░░░███");
            Console.WriteLine("      █░░░█░░░█░░█");
            Console.WriteLine("      █░░░█░░░█░░█");
            Console.WriteLine("      █░░░█░░░█░░█ ██");
            Console.WriteLine("      █░░░█░░░█░░░█░░█");
            Console.WriteLine("      █░░░█░░░█░░░█░░█");
            Console.WriteLine("      █░░░█░░░█░░░█░░█");
            Console.WriteLine(" ███  █░░░█░░░█░░░█░░░█");
            Console.WriteLine("█░░░█ █░░░█░░░█░░░█░░░█");
            Console.WriteLine("█░░░░██░░░█░░░█░░░█░░░█");
            Console.WriteLine(" █░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine(" █░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("  █░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("  █░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("   █░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("    █░░░░░░░░░░░░░░░█");
            Console.WriteLine("     ███████████████");
            Console.WriteLine("\n");
        }

        static void DisplayRock()
        {
            Console.WriteLine("\n");
            Console.WriteLine("           ███ ███");
            Console.WriteLine("       ███ █░█ █░█ ███");
            Console.WriteLine("      ██░██░░░█░░░██░██");
            Console.WriteLine("      █░░░█░░░█░░░█░░░█");
            Console.WriteLine("  ███████░█░░░█░░░█░░██");
            Console.WriteLine(" █░░░░░███░███░███░██░█");
            Console.WriteLine(" █░░░████░░░░░░░░░░░░░█");
            Console.WriteLine("  █░░█░░░░░░░░░░░░░░░░█");
            Console.WriteLine("  █░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("   █░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("    █░░░░░░░░░░░░░░░█");
            Console.WriteLine("     ███████████████");
            Console.WriteLine("\n");
        }

        static void DisplayScissors()
        {
            Console.WriteLine("\n");
            Console.WriteLine("            ███");
            Console.WriteLine("    ███    █░░░█");
            Console.WriteLine("   █░░░█   █░░░█");
            Console.WriteLine("   █░░░█   █░░░█");
            Console.WriteLine("    █░░░█  █░░░█");
            Console.WriteLine("    █░░░█  █░░░█");
            Console.WriteLine("    █░░░█  █░░░█");
            Console.WriteLine("     █░░░█ █░░░█");
            Console.WriteLine("     █░░░█ █░░░█");
            Console.WriteLine("     █░░░█ █░░░███ ███");
            Console.WriteLine("    ██░░░█ █░░█░░░█░░░█");
            Console.WriteLine("   █░░░░░░░█████░░█░░██");
            Console.WriteLine("   █░░░░░░██░░░░██░██░█");
            Console.WriteLine("  █░░░░░██░░░░░░█░░░░░█");
            Console.WriteLine("  █░░░███░░░░███░░░░░░█");
            Console.WriteLine("   ███░░░░░███░░░░░░░█");
            Console.WriteLine("    █░░░████░░░░░░░░█");
            Console.WriteLine("     ███████████████");
            Console.WriteLine("\n");
        }

        static int ChooseWaepon()
        {
            int userWaepon = 0;
            
            Console.WriteLine($"Choose your weapon (enter a number of weapon): ");
            Console.WriteLine($"1. {(TypeOfWaepon)1} \n2. {(TypeOfWaepon)2} \n3. {(TypeOfWaepon)3} \n");
            
            while (!int.TryParse(Console.ReadLine(), out userWaepon) || (userWaepon != 1 && userWaepon != 2 && userWaepon != 3))
            {
                Console.WriteLine("You must choose 1, 2 or 3:");
            }
            return userWaepon;
        }

        static void Game(ref bool endGame, string userName, int winGames, ref int playedRounds, int userAge)
        {
            while (!endGame)
            {
                int playerRoundScore = 0;
                int aiRoundScore = 0;
                int rounds = 0;
                int userWeapon = 0;
                int aiWeapon = 0;
                Random randomize = new Random();

                Console.Clear();

                while (playerRoundScore < 2 && aiRoundScore < 2)
                {
                    Console.Clear();
                    
                    DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
                    
                    Console.WriteLine($"Round {rounds+1}: \nScore: {userName} {playerRoundScore} = {aiRoundScore} AI");
                    
                    rounds++;
                    
                    Console.WriteLine($"=================================Round {rounds}======================================");

                    userWeapon = ChooseWaepon();
                    aiWeapon = randomize.Next(1, 4);

                    Console.WriteLine("\n==============================================================================\n");
                    Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI\n");
                    DisplayWeapon(userWeapon);
                    DisplayWeapon(aiWeapon);

                    switch (userWeapon)
                    {
                        case 1:
                            if (aiWeapon == 1)
                                Console.WriteLine("Weapons is equal");
                            if (aiWeapon == 2)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round!");
                            }
                            if (aiWeapon == 3)
                            {
                                aiRoundScore++;
                                Console.WriteLine($"AI win this round!");
                            }
                            break;

                        case 2:
                            if (aiWeapon == 1)
                            {
                                aiRoundScore++;
                                Console.WriteLine("AI win this round!");
                            }
                            if (aiWeapon == 2)
                                Console.WriteLine($"Weapons is equal");
                            if (aiWeapon == 3)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round!");
                            }
                            break;

                        case 3:
                            if (aiWeapon == 1)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round!");
                            }
                            if (aiWeapon == 2)
                            {
                                aiRoundScore++;
                                Console.WriteLine($"AI win this round!");
                            }
                            if (aiWeapon == 3)
                                Console.WriteLine($"Weapons is equal");
                            break;
                    }

                    Console.WriteLine("\n==============================================================================\n");
                    Console.WriteLine($"Press Enter to continue...");
                    Console.ReadLine();
                }

                playedRounds++;

                Console.Clear();

                DisplayPlayerInformation(userName, userAge, playedRounds, winGames);

                Console.WriteLine("\n==============================================================================\n");
                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI\n");

                Console.WriteLine("==============================================================================");
                Console.WriteLine($"{userName} {playerRoundScore} = {aiRoundScore} AI");

                if (playerRoundScore > aiRoundScore)
                {
                    winGames++;
                    Console.WriteLine($"{userName} win this game!\nWin game: {winGames}");
                }
                else if (playerRoundScore < aiRoundScore)
                {
                    Console.WriteLine($"You loose. Be luck in next time!\nWin game: {winGames}");
                }
                else
                {
                    Console.WriteLine($"Win anyone.\nWin game: {winGames}");
                }

                ReadyToGame(ref endGame, userName, winGames);
            }
        }
    }
}

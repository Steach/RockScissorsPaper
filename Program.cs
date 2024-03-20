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

            Console.WindowHeight = 50;


            WelcomeText();
            DisplayRules();
            userName = EnterPlayerName();
            userAge = EnterPlayerAge();
            DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
            ReadyToGame(ref endGame, userName, winGames);
            Game(ref endGame, userName, winGames, ref playedRounds, userAge);
        }

        static void WelcomeText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"_|_|_| ");
            Console.WriteLine($"_|    _|    _|_|      _|_|_|  _|  _|");
            Console.WriteLine($"_|_|_|    _|    _|  _|        _|_|");
            Console.WriteLine($"_|    _|  _|    _|  _|        _|  _|");
            Console.WriteLine($"_|    _|    _|_|      _|_|_|  _|    _|");
            Console.WriteLine($"");
            Console.WriteLine($"  _|_|_|            _|");
            Console.WriteLine($"_|          _|_|_|        _|_|_|    _|_|_|    _|_|    _|  _|_|    _|_|_|");
            Console.WriteLine($"  _|_|    _|        _|  _|_|      _|_|      _|    _|  _|_|      _|_|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"      _|  _|        _|      _|_|      _|_|  _|    _|  _|            _|_|");
            Console.WriteLine($"_|_|_|      _|_|_|  _|  _|_|_|    _|_|_|      _|_|    _|        _|_|_|");
            Console.WriteLine($"");
            Console.WriteLine($"_|_|_|");
            Console.WriteLine($"_|    _|    _|_|_|  _|_|_|      _|_|    _|  _|_|");
            Console.WriteLine($"_|_|_|    _|    _|  _|    _|  _|_|_|_|  _|_|");
            Console.WriteLine($"_|        _|    _|  _|    _|  _|        _|");
            Console.WriteLine($"_|          _|_|_|  _|_|_|      _|_|_|  _|");
            Console.WriteLine($"                    _|");
            Console.WriteLine($"                    _|");
            Console.WriteLine($"");
            Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Do you want play (yes/no) ? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                    break;
                else if (answer == "no")
                {
                    endGame = true;

                    Console.ResetColor();
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine($"Good bey {userName}, come again.\nWin games: {winGames}");
                    DisplayGameOver();
                    break;
                }
                else
                    Console.WriteLine("Answer must be yes or no.\n");
                Console.ResetColor();
                Console.WriteLine("==============================================================================\n");
            }
        }

        static void DisplayPlayerInformation(string userName, int userAge, int playedRounds, int winGames)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n==========================Player Information==================================");
            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"User Age: {userAge}");
            Console.WriteLine($"Played game rounds: {playedRounds}");
            Console.WriteLine($"Win Game: {winGames}");
            Console.WriteLine("==============================================================================\n");
            Console.ResetColor();
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

        static void DisplayRules()
        {
            Console.WriteLine("==============================================================================\n");
            Console.WriteLine("Game Rules:");
            Console.WriteLine("\n1. The game has 3 types of weapons:" +
                " Rock, Scissors, Paper\r\n" +
                "2. Paper beats rock, but loses to scissors\r\n" +
                "3. Scissors beat paper, but lose to rock\r\n" +
                "4. Rock beats scissors, but loses to paper");
            Console.WriteLine("5. The user or AI awarded a point for winning \n   only in case of two wins and one loss, \n   or three wins and zero losses in the battle.");
            Console.WriteLine("\n==============================================================================\n");
        }

        static int ChooseWaepon()
        {
            int userWaepon = 0;
            
            Console.WriteLine($"1. {(TypeOfWaepon)1} \n2. {(TypeOfWaepon)2} \n3. {(TypeOfWaepon)3} \n");
            Console.Write($"Choose your weapon (enter a number of weapon): ");

            while (!int.TryParse(Console.ReadLine(), out userWaepon) || (userWaepon != 1 && userWaepon != 2 && userWaepon != 3))
            {
                Console.WriteLine("You must choose 1, 2 or 3:");
            }
            Console.Clear();
            return userWaepon;
        }

        static void DisplayedTextEqual()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Weapons is equal");
            Console.ResetColor();

        }

        static void DisplayedTextPlayerWin(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userName}. {WinText()}");
            Console.ResetColor();
        }

        static string WinText()
        {
            Random randomize = new Random();
            int randomText = randomize.Next(1, 4);
            string text = "";
            switch (randomText)
            {
                case 1:
                    {
                        text = "Congratulations on your win! You played incredibly well.";
                        break;
                    }
                case 2:
                    {
                        text = "So proud of you! You worked hard and it paid off.";
                        break;
                    }
                case 3:
                    {
                        text = "You deserve this win! You're a true champion.";
                        break;
                    }
            }
            return text;
        }

        static string LooseText()
        {
            Random randomize = new Random();
            int randomText = randomize.Next(1, 4);
            string text = "";
            switch (randomText)
            {
                case 1:
                    {
                        text = "Tough loss, but you played your heart out. There's always next time.";
                        break;
                    }
                case 2:
                    {
                        text = "Don't be too hard on yourself. You gave it your all and that's what matters.";
                        break;
                    }
                case 3:
                    {
                        text = "We're all proud of you. You showed great sportsmanship and that's more important than winning.";
                        break;
                    }
            }
            return text;
        }

        static void DisplayedTextAIWin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{LooseText()}");
            Console.ResetColor();
        }

        static void DisplayRoundInfoText(int rounds, string userName, int playerRoundScore, int aiRoundScore)
        {
            Console.WriteLine($"Round {rounds + 1}: \nScore: {userName} {playerRoundScore} - {aiRoundScore} AI");
        }

        static void DisplayGameOver()
        {
            Console.WriteLine($"\n");
            Console.WriteLine($" _|_|_|");
            Console.WriteLine($"_|       _|_|_| _|_|_| _|_|    _|_|");
            Console.WriteLine($"_| _|_| _|   _| _|   _|   _| _|_|_|_|");
            Console.WriteLine($"_|   _| _|   _| _|   _|   _| _|");
            Console.WriteLine($" _|_|_|  _|_|_| _|   _|   _|   _|_|_|");

            Console.WriteLine($" _|_|");
            Console.WriteLine($"_|   _| _|   _|   _|_|   _|  _|_|");
            Console.WriteLine($"_|   _| _|   _| _|_|_|_| _|_|");
            Console.WriteLine($"_|   _|  _| _|  _|       _|");
            Console.WriteLine($" _|_|     _|     _|_|_|  _|");
            Console.WriteLine($"\n");
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

                while (rounds < 3 & playerRoundScore <= 2 && aiRoundScore <= 2)
                {
                    Console.Clear();
                    
                    DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
                    DisplayRoundInfoText(rounds, userName, playerRoundScore, aiRoundScore);
                    
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
                                DisplayedTextEqual();
                            if (aiWeapon == 2)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round.");
                            }
                            if (aiWeapon == 3)
                            {
                                aiRoundScore++;
                                Console.WriteLine($"AI win this round.");
                            }
                            break;

                        case 2:
                            if (aiWeapon == 1)
                            {
                                aiRoundScore++;
                                Console.WriteLine($"AI win this round.");
                            }
                            if (aiWeapon == 2)
                                DisplayedTextEqual();
                            if (aiWeapon == 3)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round.");
                            }
                            break;

                        case 3:
                            if (aiWeapon == 1)
                            {
                                playerRoundScore++;
                                Console.WriteLine($"{userName} win this round.");
                            }
                            if (aiWeapon == 2)
                            {
                                aiRoundScore++;
                                Console.WriteLine($"AI win this round.");
                            }
                            if (aiWeapon == 3)
                                DisplayedTextEqual();
                            break;
                    }

                    Console.WriteLine("\n==============================================================================\n");
                    Console.WriteLine($"Press Enter to continue...");
                    Console.ReadLine();
                }

                playedRounds++;

                Console.Clear();

                if (playerRoundScore > aiRoundScore && playerRoundScore >= 2)
                {
                    winGames++;
                    DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
                    DisplayRoundInfoText(rounds, userName, playerRoundScore, aiRoundScore);
                    DisplayedTextPlayerWin(userName);
                }
                else if (playerRoundScore < aiRoundScore && aiRoundScore >= 2)
                {
                    DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
                    DisplayRoundInfoText(rounds, userName, playerRoundScore, aiRoundScore);
                    DisplayedTextAIWin();
                }
                else
                {
                    DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
                    DisplayRoundInfoText(rounds-1, userName, playerRoundScore, aiRoundScore);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The match ended in a draw.");
                    Console.ResetColor();
                }

                ReadyToGame(ref endGame, userName, winGames);
            }
        }
    }
}
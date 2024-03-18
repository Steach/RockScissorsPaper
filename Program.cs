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

            Console.WriteLine("Hello, this is Rock, Scissors, Paper game!\n");

            userName = EnterPlayerName();
            userAge = EnterPlayerAge();
            DisplayPlayerInformation(userName, userAge, playedRounds, winGames);
            ReadyToGame(ref endGame, userName, winGames);
            Game(ref endGame, userName, winGames, ref playedRounds);
        }

        static string EnterPlayerName()
        {
            string userName;
            Console.Write("Enter your name: ");
            while (true)
            {
                userName = Console.ReadLine();
                if (userName != "")
                {
                    return userName;
                } 
                else
                {
                    Console.WriteLine($"You name can`t be empty. Please enter your name: ");
                }
            }
        }

        static int EnterPlayerAge()
        {
            int userAge = 0;
            while (userAge < 12)
            {
                Console.Write($"Enter your age: ");
                while (!int.TryParse(Console.ReadLine(), out userAge))
                {
                    Console.WriteLine("Enter your age: ");
                }
                if (userAge <= 12)
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
                Console.WriteLine($"\n--------------------------Are you ready?------------------------------------");
                Console.Write($"Do you want play (yes/no) ? - ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                    break;
                else if (answer == "no")
                {
                    endGame = true;

                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"{userName} Win games: {winGames}");
                    Console.WriteLine($"Game over.\n{userName} Good bye!\n");
                    break;
                }

                else
                    Console.WriteLine("Answer must be yes or no.\n");
                Console.WriteLine("------------------------------------------------------------------------------\n");
            }
        }

        static void DisplayPlayerInformation(string userName, int userAge, int playedRounds, int winGames)
        {
            Console.WriteLine($"\n--------------------------Player Information---------------------------------");
            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"User Age: {userAge}");
            Console.WriteLine($"Played game rounds: {playedRounds}");
            Console.WriteLine($"Win Game: {winGames}");
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }

        static void Game(ref bool endGame, string userName, int winGames, ref int playedRounds)
        {
            while (!endGame)
            {
                Console.Clear();
                int playerRoundScore = 0;
                int aiRoundScore = 0;
                int rounds = 0;
                Random randomize = new Random();

                while (playerRoundScore < 2 && aiRoundScore < 2)
                {
                    rounds++;
                    Console.WriteLine($"---------------------------------Round {rounds}--------------------------------------");
                    Console.WriteLine($"Choose your weapon: ");
                    Console.WriteLine($"1. {(TypeOfWaepon)1} \n2. {(TypeOfWaepon)2} \n3. {(TypeOfWaepon)3} \n");
                    int userWeapon = int.Parse(Console.ReadLine());
                    if (userWeapon != 1 && userWeapon != 2 && userWeapon != 3)
                    {
                        Console.WriteLine("You must choose 1, 2 or 3:");
                        continue;
                    }

                    int aiWeapon = randomize.Next(1, 4);

                    switch (userWeapon)
                    {
                        case 1:
                            if (aiWeapon == 1)
                            {
                                Console.WriteLine("Weapons is equal");
                            }
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
                            {
                                Console.WriteLine($"Weapons is equal");
                            }
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
                            {
                                Console.WriteLine($"Weapons is equal");
                            }
                            break;
                    }
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"Round {rounds}: \nScore: {userName} {playerRoundScore} - {aiRoundScore} AI");

                }
                playedRounds++;
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine($"{userName} {playerRoundScore} - {aiRoundScore} AI");
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

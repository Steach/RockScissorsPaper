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

            Console.Write("Enter your name: ");
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
                Console.Write($"Enter your age: ");
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

            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"User Age: {userAge}");
            Console.WriteLine($"Played game rounds: {playedRounds}");
            Console.WriteLine($"Win Game: {winGames}\n");

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
                int playerRoundScore = 0;
                int aiRoundScore = 0;
                int rounds = 0;
                Random randomize = new Random();

                while (rounds < 3)
                {
                    Console.WriteLine("------------------------------------------------------------------------------");
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
                                playerRoundScore++;
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine("Weapons is equal");
                            }
                            if (aiWeapon == 2)
                            {
                                playerRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"{userName} win this round!");
                            }
                            if(aiWeapon == 3)
                            {
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"AI win this round!");
                            }
                            rounds += 1;
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.WriteLine($"Round {rounds}: \nScore: {userName} {playerRoundScore} - {aiRoundScore} AI");
                            break;
                        case 2:
                            if (aiWeapon == 1)
                            {
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine("AI win this round!");
                            }
                            if (aiWeapon == 2)
                            {
                                playerRoundScore++;
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"Weapons is equal");
                            }
                            if (aiWeapon == 3)
                            {
                                playerRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"{userName} win this round!");
                            }
                            rounds += 1;
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.WriteLine($"Round {rounds}: \nScore: {userName} {playerRoundScore} - {aiRoundScore} AI");
                            break;
                        case 3:
                            if (aiWeapon == 1)
                            {
                                playerRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"{userName} win this round!");
                            }
                            if (aiWeapon == 2)
                            {
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"AI win this round!");
                            }
                            if (aiWeapon == 3)
                            {
                                playerRoundScore++;
                                aiRoundScore++;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"{userName} | {(TypeOfWaepon)userWeapon} VS {(TypeOfWaepon)aiWeapon} | AI");
                                Console.WriteLine($"Weapons is equal");
                            }
                            rounds += 1;
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.WriteLine($"Round {rounds}: \nScore: {userName} {playerRoundScore} - {aiRoundScore} AI");
                            break;
                    }
     
                }
                playedRounds++;
                if (playerRoundScore > aiRoundScore)
                {
                    winGames++;
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"{userName} {playerRoundScore} - {aiRoundScore} AI");
                    Console.WriteLine($"{userName} win this game!\nWin game: {winGames}");
                }
                else if (playerRoundScore < aiRoundScore)
                {
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"{userName} {playerRoundScore} - {aiRoundScore} AI");
                    Console.WriteLine($"You loose. Be luck in next time!\nWin game: {winGames}");
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"{userName} {playerRoundScore} - {aiRoundScore} AI");
                    Console.WriteLine($"Win anyone.\nWin game: {winGames}");
                }

                while (true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"Do you want play again? (yes/no)\n");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                        break;
                    else if (answer == "no")
                    {
                        endGame = true;

                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine($"{userName} Win games: {winGames}");
                        Console.WriteLine($"Game over.\nGood bye!\n");
                        break;
                    }

                    else
                        Console.WriteLine("Answer must be yes or no.\n");
                }
            }
            
        }
    }
}

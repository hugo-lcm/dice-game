using System;
using System.Net.WebSockets;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber;
            int enemyRandomNumber;
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine($"you rolled a {playerRandomNumber}");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine($"enemy AI roleed a {enemyRandomNumber}");

                if (playerRandomNumber > enemyRandomNumber)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round!");
                }
                else if (playerRandomNumber < enemyRandomNumber)
                {
                    enemyPoints++;
                    Console.WriteLine("AI wins this round");
                }
                else
                {
                    Console.WriteLine("draw, no one scores!");
                }

                Console.WriteLine($"scoreboard: player: {playerPoints} || AI: {enemyPoints}");
                Console.WriteLine();

            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("you win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("it's a draw!");
            }

            Console.ReadKey();
        }
    }
}
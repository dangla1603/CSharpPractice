using System;

namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a mini game Rock-Paper-Scissors that run on console
            // User will enter the input and compare the result with the system

            Random random = new Random();
            string player;
            string computer;
            bool playGame = true;
            string response;
            while (playGame)
            {
                player = "";
                computer = "";
                response = "";
                

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Please enter ROCK , PAPER , SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                  
                }
                int thisRandom = random.Next(1, 4);
                switch (thisRandom)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                if(player == "ROCK" && computer == "SCISSORS")
                {
                    Console.WriteLine("You Win");
                }
                else if(player == "PAPER" && computer == "ROCK")
                {
                    Console.WriteLine("You Win");
                }
                else if (player == "SCISSORS" && computer == "PAPER")
                {
                    Console.WriteLine("You Win");
                }
                else if (player == computer)
                {
                    Console.WriteLine("You Draw");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }              
            }

        

        }
    }
}

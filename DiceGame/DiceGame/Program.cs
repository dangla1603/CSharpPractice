using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare player & enemy
            int playerRandomNum;
            int enemyRandomNum;


            int playerScore = 0;
            int enemyScore = 0;
            //initialize random to generate random number
            Random random = new Random();
            
            //Using for loop to play the game 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                //wait for any key press
                Console.ReadKey();

                //player will generate random number range between 1 and 7.
                playerRandomNum = random.Next(1, 7);

                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                //creating timeout in 1000ms
                System.Threading.Thread.Sleep(1000);

                //enemy will generate random number range between 1 and 7.
                enemyRandomNum = random.Next(1, 7);

                Console.WriteLine("Enemy rolled a " + enemyRandomNum);


                //check if player win the game or not
                if(playerRandomNum > enemyRandomNum)
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                }
                else if ( playerRandomNum < enemyRandomNum)
                {
                    Console.WriteLine("You lose!");
                    enemyScore++;
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Final Score:");
            Console.WriteLine("You: "+ playerScore + " Enemy: " + enemyScore);
            Console.ReadKey();

        }
    }
}

using System;

namespace PredictNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program to create a mini game that can predict a number from generating random number from the system
            // it will count how many time until you can guess the correct number
            // everytime you guess wrong, the system will give you the hint(greater/smaller) from the correct number
            // Goal : practicing using while loop and understand variables in different scope 


            // Instantitate some variables that are needed to generate the game
            Random randomNumber = new Random();
            int count;
            int guess;
            int correctNumber;
            string response;

            bool playGame = true;

            // Using while loop to make sure player can play the game until they guess the correct number
            while(playGame){

                count = 0;
                guess = 0;
                response = "";
                //generating random number from 1 to 100
                correctNumber = randomNumber.Next(1, 100);


                // while loop to guess the correct number
                while(guess != correctNumber) {

                    Console.Write("enter number (1 - 100): ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if ( guess > correctNumber)
                    {
                        Console.WriteLine("It's too large!");
                    }else if(guess < correctNumber)
                    {
                        Console.WriteLine("It's too small!");
                    }
                    else
                    {
                        Console.WriteLine("It's correct !!");
                    }
                    count++;                 
                }
                Console.WriteLine("You are Winner !!!!!");
                Console.WriteLine($"Total: {count} times");

                Console.WriteLine("Do you want to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    playGame = true;
                }
                else
                {
                    playGame = false;
                }
                Console.WriteLine("See you next time!");

                Console.ReadKey();

            }

        }
    }
}

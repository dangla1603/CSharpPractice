using System;
using System.IO;
using System.Collections.Generic;
namespace RestaurantOwner
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            MainMenu();
            
        }

        //Method to register new account
        public static void RegisterAccount() 
        {
            StreamWriter writer = new StreamWriter("Accounts.txt",true);

            //collect data from user
            Console.WriteLine("Enter username: ");
            string newUserName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string newPassword = Console.ReadLine();
           
            writer.WriteLine("\n"+newUserName+ ","+ newPassword);
            Console.WriteLine("New account has been registered !");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            writer.Close();
        }

        //Method to log in with existing account 
        public static void LogIn(string userName, string password)            
        {
            // initialize reader obj from StreamReader
            StreamReader reader = new StreamReader("Accounts.txt");
            RestaurantAccount newAccount = new RestaurantAccount();
            string[] lines = File.ReadAllLines("Accounts.txt");

            while(lines != null)
            {
                foreach ( var a in lines)
                {
                    if (a.Contains(userName) && a.Contains(password))
                    {
                        Account account = new Account(userName, password);
                        newAccount.addAccount(account);
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Hi {0} !!!!", newAccount.GetUserName(account.UserName).ToUpper());
                        Console.WriteLine("Log in your account");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        RestaurantMenu();
                    }if (a.Contains(userName) && !a.Contains(password))
                    {
                        
                        Console.WriteLine("Wrong username/password");
                        MainMenu();
                    }
                }
            }
            reader.Close();
        }

        //Method to display Restaurant Menu when log in with existing account
        public static void RestaurantMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Welcome to Restaurant Owner App");
                Console.WriteLine("Please choose your option: ");
                Console.WriteLine("1. View Your Fridge");
                Console.WriteLine("2. Add new Fridge");
                Console.WriteLine("3. Add Food Item");
                Console.WriteLine("4. remove Food Item");
                Console.WriteLine("5. remove Fridge");
                Console.WriteLine("6. Log out");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. View Your Fridge");
                        break;
                    case 2:
                        Console.WriteLine("2. Add new Fridge");
                        break;
                    case 3:
                        Console.WriteLine("3. Add Food Item");
                        break;
                    case 4:
                        Console.WriteLine("4. remove Food Item");
                        break;
                    case 5:
                        Console.WriteLine("5. remove Fridge");
                        break;
                    case 6:
                        Console.WriteLine("Account logged out");
                        Console.WriteLine("Returning to Main Menu");
                        Console.WriteLine("Press any key to continue....");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    default:
                        break;
                }
            } while (choice != 7);
        }

        //Method to display main menu from the application
        public static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Welcome to Restaurant Owner App");
                Console.WriteLine("Please choose your option: ");
                Console.WriteLine("1. Register Account");
                Console.WriteLine("2. Log in");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        RegisterAccount();
                        break;
                    case 2:
                        Console.WriteLine("Enter username: ");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string password = Console.ReadLine();
                        LogIn(userName, password);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (choice != 3);
        }
    }
}

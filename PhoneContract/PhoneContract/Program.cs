using System;

namespace PhoneContact
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var phoneBook = new PhoneBook();

            int option;
           
            while(true)
            {
                Console.WriteLine("Please choose your options:");
                Console.WriteLine("1.View your contact");
                Console.WriteLine("2.Adding");
                Console.WriteLine("3.Display contact by given number");
                Console.WriteLine("4.search contact by given name");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice [1-5]: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("------------------------");
                        phoneBook.DisplayAllContact();
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.addContact(newContact);
                        Console.WriteLine("------------------------");
                        break;
                    case 3:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Enter number:");
                        var searchNumber = Console.ReadLine();
                        Console.WriteLine("------------------------");
                        phoneBook.DisplayContact(searchNumber);
                        Console.WriteLine("------------------------");
                        break;
                    case 4:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Enter name:");
                        var searchName = Console.ReadLine();
                        Console.WriteLine("------------------------");
                        phoneBook.DisplayMatchingContacts(searchName);
                        Console.WriteLine("------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Existing the application");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            
        }
    }
}

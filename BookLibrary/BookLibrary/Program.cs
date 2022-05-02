using System;
using System.IO;

namespace BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library[] books = new Library[0];

            int choice;
            // menu

            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Welcome to Dang's Library");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Load data");
                Console.WriteLine("2. View Library");
                Console.WriteLine("3. Add books");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please choose your option: ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        LoadData(ref books);
                        break;
                    case 2:
                        DisplayAllBooks(books);
                        break;
                    case 3:
                        addBook(ref books);
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

                //clear everything after user make their choice
                Console.Clear();

            } while (choice != 4);

            

        }



        public static void LoadData(ref Library[] books) {
            
            // creater object reader to call the class StreamReader to read
            // the txt file "Library"
            StreamReader reader = new StreamReader("Library.txt");

            // reading the first line of the size of the array
            int size = Convert.ToInt32(reader.ReadLine());
            books = new Library[size];

            // using for loop to load the list of books from the array
            for (int index = 0; index < books.Length; index++)
            {
                //putting the object in the array
                books[index] = new Library();
                books[index].Title = reader.ReadLine();
                books[index].Author = reader.ReadLine();
                books[index].Year = Convert.ToInt32(reader.ReadLine());
            }

            reader.Close();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void DisplayAllBooks(Library[] books) {

            
            // load the data from the text file
            

            // using the for loop to print out the list of books from the array
            for (int index = 0; index < books.Length; index++)
            {
                books[index].displayInformation();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void addBook(ref Library[] books)
        {
            Console.Clear();
            
            // creating object to write in the text file from calling from StreamWrite class
            StreamWriter write = new StreamWriter("Library.txt");
            write.WriteLine(books.Length + 1);

            //create new object 
            Library temp = new Library();


            //collect data from user
            Console.Write("Enter Title: ");
            temp.Title = Console.ReadLine();

            Console.Write("Enter Author: ");
            temp.Author = Console.ReadLine();

            Console.Write("Enter Year: ");
            temp.Year = Convert.ToInt32(Console.ReadLine());


            //write new data to text file
            write.WriteLine(temp.Title);
            write.WriteLine(temp.Author);
            write.WriteLine(temp.Year);

            //put back the old books back to file
            for (int index = 0; index < books.Length; index++)
            {;
                write.WriteLine(books[index].Title);
                write.WriteLine(books[index].Author);
                write.WriteLine(books[index].Year);

            }

            //close the file
            write.Close();

            //update our array
            LoadData(ref books);
        }
    }
}

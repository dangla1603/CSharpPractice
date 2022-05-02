using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Library
    {
        // Variables
        private string title;
        private string author;
        private int year;

        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        // Contructors
        public Library()
        {

        }

        public Library(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        // toString
        public void displayInformation()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("-----------------------");
        }
    }
}

using System;
using System.Collections.Generic;

namespace LibraryCardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.WriteLine("1) List all books.");
            Console.WriteLine("2) Add a book.");
            Console.WriteLine("3) Save and Exit.");
            string result = Console.ReadLine();

            if (result == "1")
            {
                CardCatalog.ListAllBooks();
                return true;
            }
            else if (result == "2")
            {
                CardCatalog.AddABook();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

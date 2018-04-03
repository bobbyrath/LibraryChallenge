using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryCardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a file: ");
            string filename = Console.ReadLine();
            CardCatalog cc = new CardCatalog(filename);
            DisplayMenu(cc);
        }



        public static void DisplayMenu(CardCatalog cc)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu(cc);
                Console.WriteLine();
            }
        }

        public static bool MainMenu(CardCatalog cc)
        {

            Console.WriteLine("1) List all books.");
            Console.WriteLine("2) Add a book.");
            Console.WriteLine("3) Save and Exit.");
            string result = Console.ReadLine();

            if (result == "1")
            {
                cc.ListAllBooks();
                return true;
            }
            else if (result == "2")
            {
                cc.AddABook();
                return true;
            }
            else if (result == "3")
            {
                cc.Save();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

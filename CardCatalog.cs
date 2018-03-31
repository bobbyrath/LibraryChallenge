using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace LibraryCardCatalog
{
    class CardCatalog
    {
        private static string FileName { get; set; }
        private static List<Book> bookList { get; set; }

        public static void GetFile()
        {
            Console.WriteLine("Enter a file: ");
            FileName = Console.ReadLine();
            bookList = new List<Book>();
        }

        public static void DisplayMenu()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
                Console.WriteLine();
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
                ListAllBooks();
                return true;
            }
            else if (result == "2")
            {
                AddABook();
                return true;
            }
            else if (result == "3")
            {
                Save();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AddABook()
        {
            Console.WriteLine("Add a book");

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            
            Console.Write("Enter author's name: ");
            string author = Console.ReadLine();

            Console.Write("Enter the genre: ");
            string genre = Console.ReadLine();

            long isbn;
            string isbnInput;
            //testing below if the ISBN is actually input as a number, and also if it is 13 digits long
            do
            {
                do
                {
                    Console.Write("Enter the 13 digit ISBN: ");
                    isbnInput = Console.ReadLine();
                } while (isbnInput.Length!= 13);
            } while (!long.TryParse(isbnInput, out isbn));

            bookList.Add(new Book(title, author, genre, isbn));
            Console.WriteLine("Make sure to save or this book won't be added!");
        }

        public static void ListAllBooks()
        {
            try
            {
                using (Stream stream = File.Open(FileName, FileMode.Open))
                {
                    Console.WriteLine("Your current books are...");
                    Console.WriteLine();
                    BinaryFormatter bf = new BinaryFormatter();
                    bookList = (List<Book>)bf.Deserialize(stream);
                    stream.Close();
                }
            }
            //Catch exception when list is attempted to be pulled with nothing in the list
            catch (IOException)
            {
                Console.WriteLine("You have no books, go add some!");
                Console.WriteLine();
            }
           
            foreach (Book book in bookList)
            {
                Console.WriteLine("Title: {0}, Author: {1}, Genre: {2}, ISBN: {3}",
                    book.Title, book.Author, book.Genre, book.ISBN);
            }
        }
        public static void Save()
        {
            Stream stream = File.Open(FileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, bookList);
            stream.Close();
        }
    }
}
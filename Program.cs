using System;
using System.Collections.Generic;

namespace LibraryCardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is from Neil.
            //ok!
            //test
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }

        public static List<Book> bookList = new List<Book>();

        
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
                return false;
            }
            else
            {
                return true;
            }

        }


        public static void ListAllBooks()
        {
            foreach (Book b in bookList)
            {
                Console.WriteLine("{0} {1}", b.Title, b.AuthorLast);
            }
            Console.ReadLine();
        }

        public static void AddABook()
        {

            Console.WriteLine("Add a book");

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author's first name: ");
            string fn = Console.ReadLine();
            Console.Write("Enter author's last name: ");
            string ln = Console.ReadLine();
            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();
            Console.Write("Enter ISBN#: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Fiction or Non-Fiction: ");
            string ficnon = Console.ReadLine();


            bookList.Add(new Book
            {
                Title = title,
                AuthorFirst = fn,
                AuthorLast = ln,
                Genre = genre,
                ISBN = isbn,
                Fiction = ficnon
            });





            //string book1 = title + "    " + fn + " " + ln + "   " + genre + "   " + isbn + "    " + ficnon;
            //Console.WriteLine(book1);            
            //Console.WriteLine("Name: {0}     Author: {1} {2}     Genre: {3}     ISBN#: {4}     F or NF: {5}", title, fn, ln, genre, isbn, ficnon);


            Console.ReadLine();
        }
    }
}

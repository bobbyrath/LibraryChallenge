using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCardCatalog
{
    class CardCatalog
    {
        public static void ListAllBooks()
        {
            Console.WriteLine("Your current books are...");
            foreach (Book b in bookList)
            {
                //Console.WriteLine("{0} {1}", b.Title, b.AuthorLast);
            }
           
        }
        public static List<Book> bookList = new List<Book>();


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
            //string book1 = title + "    " + fn + " " + ln + "   " + genre 
            //+ "   " + isbn + "    " + ficnon;
            //Console.WriteLine(book1);            
            //Console.WriteLine("Name: {0}     Author: {1} {2}     Genre: {3}     ISBN#: {4}     F or NF: {5}", title, fn, ln, genre, isbn, ficnon);
        }
    }
}
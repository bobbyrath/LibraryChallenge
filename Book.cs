using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryCardCatalog
{   
    [Serializable]
    public class Book 
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public long ISBN { get; set; }

        public Book(string title, string author, string genre, long isbn)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
        }
    }
}


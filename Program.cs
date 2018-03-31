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
            CardCatalog.GetFile();
            CardCatalog.DisplayMenu();
        }
    }
}

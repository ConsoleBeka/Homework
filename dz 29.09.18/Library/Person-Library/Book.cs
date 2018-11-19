 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Person_Library
{
    class Book
    {
        public const string name = "1";
        public const int countOfPages = 4;
        public const string authorName = "2";


        public string GetName
        {
            get { return name; }
        }

        public int GetcountOfPages
        {
            get { return countOfPages; }
        }

        public string GetauthorName
        {
            get { return authorName; }
        }
    }
}
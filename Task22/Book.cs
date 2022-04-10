using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    public class Book
    {
        public Book()
        {
            _totalCount++;
            No = _totalCount;
        }
        static int _totalCount;
        public int No { get; }
        public string Name { get; set;}
        public string AuthorName { get; set;}
        public int Price { get; set;}
        public Genre Genre { get; set;}

    }
}

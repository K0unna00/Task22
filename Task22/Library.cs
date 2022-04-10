using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
        public class Library
        {
        public List<Book> Books = new List<Book>();
        public List<Book> FilterByPrice(int numMin, int numMax)
        {
            List<Book> NewBooks = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Price > numMin && item.Price < numMax) NewBooks.Add(item);
            }
            return NewBooks;
        }
        public List<Book> FIlterByGenre(Genre genre)
        {
            List<Book> NewBooks = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Genre == genre) NewBooks.Add(item);
            }
            return NewBooks;
        }
        public Book FindBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if (item.No==no)
                {
                    return item;
                }
            }
            return null;
        }
        public bool IsExistBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if(item.No==no) return true;
            }
            return false;
        }
        public void RemoveAll(Predicate<Book> pred)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (!pred(item))
                {
                    newBooks.Add(item);
                }
            }
            Books = newBooks;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Task22
{
    internal class Program
    {
        static void Main(string[] BexininDunyasi)
        {
            //Predicate<Book> predicate = (x => x.No > 1);
            Predicate<Book> predicate = x => x.Genre==Genre.Dedective;
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            book1.Genre = (Genre)1;
            book2.Genre = (Genre)2;
            book3.Genre = (Genre)2;
            book4.Genre = (Genre)1;
            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            library.Books.Add(book4);
            //List<Book> list = library.FIlterByGenre(Genre.Dedective);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.No);
            //}
            library.RemoveAll(predicate);
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.No);
            }
        }
    }
}

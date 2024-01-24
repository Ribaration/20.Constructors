using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Console.WriteLine(book1.title);
            Console.ReadLine();

        }
        class Book
        {
            public string title;
            public int pages;
            public string author;

            //this method below is called a constructor
            public Book(string aTitle, string aAuthor, int aPages) 
            {
                 title = aTitle;
                author = aAuthor;
                pages = aPages;
            }

        }
    }
}

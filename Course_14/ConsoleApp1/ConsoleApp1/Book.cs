using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Book
    {
        
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle = "Unknown", string aAuthor = "Unknown", int aPages = 0) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }


        public Book()
        {
            Console.WriteLine("Defualt Const.");
        }
    }
}

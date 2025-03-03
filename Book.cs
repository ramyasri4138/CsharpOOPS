using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            ISBN = "000-0000000000";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "000-0000000000"; // Default ISBN
        }

        // Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

}

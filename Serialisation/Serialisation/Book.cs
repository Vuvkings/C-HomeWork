using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }

        public Book(string title, string author, DateTime publishedDate)
        {
            Title = title;
            Author = author;
            PublishedDate = publishedDate;
        }
        
    }
}

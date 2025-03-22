using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Book : Media
    {
        public int PageCount { get; set; }
        public string Genre { get; set; }



        public Book(int pageCount, string genre, string title, string author, int yearPublished, bool isAvailable)
            : base(title, author, yearPublished, isAvailable)
        {
            PageCount = pageCount;
            Genre = genre;
        }
    }
}

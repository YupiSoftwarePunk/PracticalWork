using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Movie : Media
    {
        public int Duration { get; set; }
        public string Producer { get; set; }



        public Movie(int duration, string producer, string title, string author, int yearPublished, bool isAvailable)
            : base(title, author, yearPublished, isAvailable)
        {
            Duration = duration;
            Producer = producer;
        }
    }
}

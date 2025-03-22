using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MusicAlbum : Media
    {
        public string Performer {  get; set; }
        public int TracksCount { get; set; }



        public MusicAlbum(string performer, int tracksCount, string title, string author, int yearPublished, bool isAvailable)
            : base(title, author, yearPublished, isAvailable)
        {
            Performer = performer;
            TracksCount = tracksCount;
        }
    }
}

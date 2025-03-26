using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class FilterClass
    {
        public static Library<Book> FilterByYear(ref Library<Book> newList, int year)
        {
            try
            {
                var query = from i in newList.media where i.YearPublished > year select i;
                return (Library<Book>)query;
            }
            catch
            {
                throw new Exception("Таких элементов не существует!!");
            }

        }

        public static List<Movie> SortByDuration(ref Library<Movie> newList)
        {
            try
            {
                var query = from i in newList.media orderby i.Duration select i;
                return query.ToList();
            }
            catch
            {
                throw new Exception("Таких элементов не существует!!");
            }
        }
    }
}

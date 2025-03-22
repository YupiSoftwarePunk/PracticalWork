using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface IMediaManager<T> where T : Media
    {
        List<Media> media {  get; }

        void Add(T item)
        {
            media.Add(item);
        }

        bool Remove(string title)
        {
            if (title != null)
            {
                media.Remove(title);
                return true;
            }
            else
            {
                return false;
            }
        }

        T FindByTitle(string title)
        {
            Dictionary<string, T> titleFinder = new Dictionary<string, T>();
            return titleFinder[title];
        }

        IEnumerable<T> FilterByYear(int year)
        {
            return (IEnumerable<T>)media.Where(i => i.YearPublished > year).
                OrderByDescending(i => i.YearPublished);
            /*var query =*/
            //foreach (var i in query)
            //{
            //    Console.WriteLine(i.YearPublished);
            //    yield return (T)i;
            //}
        }

        IEnumerable<T> GetAllAvailable()
        {
            return (IEnumerable<T>)media.GroupBy(i => i.IsAvailable);
            //foreach (var i in query)
            //{
            //    yield return (T)i;
            //}
        }
    }
}

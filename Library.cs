using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        List<T> media = new List<T>();
        Dictionary<string, T> titleFinder = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (!titleFinder.ContainsKey(item.Title))
            {
                media.Add(item);
                titleFinder.Add(item.Title, (T)item.Title);
            }
            else
            {
                throw new Exception("Элемент с таким именем уже существует");
            }

        }

        public bool Remove(string title)
        {
            if (titleFinder.ContainsKey(title))
            {
                if (title != null)
                {
                    media.Remove((T)title);
                    titleFinder.Remove(title);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Элемента с таким именем не существует");
            }
        }

        public T FindByTitle(string title)
        {
            if (titleFinder.ContainsKey(title))
            {
                return titleFinder[title];
            }
            else
            {
                throw new Exception("Элемента с таким именем не существует");
            }
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return media.Where(i => i.YearPublished == year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return media.Where(i => i.IsAvailable);
        }
    }
}

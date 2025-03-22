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
                throw new Exception("Элемент с таким именем уже существует!!");
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
                throw new Exception("Элемента с таким именем не существует!!");
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
                throw new Exception("Элемента с таким именем не существует!!");
            }
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            try
            {
                return media.Where(i => i.YearPublished == year);
            }
            catch
            {
                throw new Exception("Элемента с таким годом выпуска не существует!!");
            }

            
        }

        public IEnumerable<T> GetAllAvailable()
        {
            try
            {
                return media.Where(i => i.IsAvailable);
            }
            catch
            {
                throw new Exception("Нет доступных элементов!!");
            }
            
        }

        public IEnumerable<T> ShowBooks(int year)
        {
            try
            {
                return media.Where(i => i.YearPublished > year);
            }
            catch
            {
                throw new Exception("Элементов с таким годом издания не существует!!");
            }
        }

        public List<Movie> ShowMovies()
        {
            try
            {
                return media.OrderBy(i => i.Duration).ToList();
            }
            catch
            {
                throw new Exception("Таких элементов не существует!!");
            }
        }

        public IEnumerable<T> GetAllUnAvailable()
        {
            try
            {
                bool IsUnAvailable = !media.Any(i => i.IsAvailable);
                return media.Where(i => i.IsAvailable == IsUnAvailable);
            }
            catch
            {
                throw new Exception("Нет недоступных элементов!!");
            }

        }

        public IEnumerable<T> ChangeAvailability()
        {
            try
            {
                bool IsUnAvailable = !media.Any(i => i.IsAvailable);
                return media.Where(i => i.IsAvailable = IsUnAvailable);
            }
            catch
            {
                throw new Exception("Нет доступных элементов для изменения статуса!!");
            }
        }


        public void PrintAll()
        {
            foreach (var i in media)
            {
                Console.WriteLine($"Название: {i.Title},\nАвтор: {i.Author}\nГод публикации: {i.YearPublished}\nДоступно: {i.IsAvailable}\n");
            }
        }
    }
}

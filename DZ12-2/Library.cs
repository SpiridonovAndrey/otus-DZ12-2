using System.Collections.Concurrent;
using System.Collections.ObjectModel;

namespace DZ12_2
{
    internal class Library
    {
        public ConcurrentDictionary<string, int> Books = new ConcurrentDictionary<string, int>();
        public void Add(string name)
        {
            Books.TryAdd(name, 0);
        }
        public void Update(string name)
        {
            Books.TryUpdate(name, Books.GetValueOrDefault(name) +1, Books.GetValueOrDefault(name));
        }
        public void Delete(string name)
        {
            int a;
            Books.TryRemove(name, out a);
        }
    }
}

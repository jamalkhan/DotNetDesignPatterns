using System.Collections;

namespace DotNetDesignPatterns.IteratorPattern
{

    public class Aggregate<T>
    {
        private ArrayList _items = new ArrayList();

        public Iterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
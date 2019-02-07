namespace DotNetDesignPatterns.IteratorPattern
{

    public class Iterator<T>
    {
        private Aggregate<T> _aggregate;
        private int _current = 0;

        public Iterator(Aggregate<T> aggregate)
        {
            this._aggregate = aggregate;
        }

        public T First()
        {
            return (T)_aggregate[0];
        }

        public T Next()
        {
            T ret = default(T);
            if (_current < _aggregate.Count - 1)
            {
                ret = (T)_aggregate[++_current];
            }
            return ret;
        }
    }
}
namespace SL
{
    public class RandomList<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
    {
        private global::System.Collections.Generic.List<T> list;
        private int currentIndex;
        // C# has no syntax for parameterized property 'Item'.
        public T this[int index]
        {
            get
            {
                return default;
            }
        }

        public void Add(T item)
        {
        }

        private void Shuffle()
        {
        }

        public T RandomGet()
        {
            return default;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return null;
        }
    }
}
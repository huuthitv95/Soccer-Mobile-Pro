namespace Common
{
    public class ObjectPool<T>
        where T : global::Common.IRecycleable, new()
    {
        private global::System.Collections.Generic.Queue<T> pool;
        private static global::Common.ObjectPool<T> instance;
        public static global::Common.ObjectPool<T> Instance => null;

        public int Capacity
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public T GetFromPool()
        {
            return default;
        }

        private T InternalCreate()
        {
            return default;
        }

        public void Release(T releasedObj)
        {
        }
    }
}
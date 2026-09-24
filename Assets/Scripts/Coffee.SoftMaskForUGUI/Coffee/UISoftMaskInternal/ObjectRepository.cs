namespace Coffee.UISoftMaskInternal
{
    internal class ObjectRepository<T>
        where T : global::UnityEngine.Object
    {
        private class Entry
        {
            public global::UnityEngine.Hash128 hash;
            public int reference;
            public T storedObject;
            public void Release(global::System.Action<T> onRelease)
            {
            }

            public override string ToString()
            {
                return null;
            }
        }

        private readonly global::System.Collections.Generic.Dictionary<global::UnityEngine.Hash128, global::Coffee.UISoftMaskInternal.ObjectRepository<T>.Entry> _cache;
        private readonly global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Hash128> _objectKey;
        private readonly string _name;
        private readonly global::System.Action<T> _onRelease;
        private readonly global::System.Collections.Generic.Stack<global::Coffee.UISoftMaskInternal.ObjectRepository<T>.Entry> _pool;
        public int count => 0;

        public ObjectRepository(global::System.Action<T> onRelease = null)
        {
        }

        public void Clear()
        {
        }

        public bool Valid(global::UnityEngine.Hash128 hash, T obj)
        {
            return false;
        }

        public void Get(global::UnityEngine.Hash128 hash, ref T obj, global::System.Func<T> onCreate)
        {
        }

        public void Get<TS>(global::UnityEngine.Hash128 hash, ref T obj, global::System.Func<TS, T> onCreate, TS source)
        {
        }

        private bool GetFromCache(global::UnityEngine.Hash128 hash, ref T obj)
        {
            return false;
        }

        private void Add(global::UnityEngine.Hash128 hash, ref T obj, T newObject)
        {
        }

        public void Release(ref T obj)
        {
        }

        private void Remove(global::Coffee.UISoftMaskInternal.ObjectRepository<T>.Entry entry)
        {
        }
    }
}
public class ShortLivedObjectCache<K, V>
    where V : class
{
    private struct CacheItem
    {
        public V obj;
        public float expireTime;
    }

    private global::System.Collections.Generic.Dictionary<K, ShortLivedObjectCache<K, V>.CacheItem> cache;
    private global::System.Func<K, V> createFunc;
    private global::System.Func<float> getTimeFunc;
    private global::System.Collections.Generic.List<K> keysToRemove;
    public ShortLivedObjectCache(global::System.Func<K, V> createFunc, global::System.Func<float> getTimeFunc)
    {
    }

    public V Get(K key, float lifeTime)
    {
        return null;
    }

    public void Clear()
    {
    }

    public void Updater(float currentTime)
    {
    }
}
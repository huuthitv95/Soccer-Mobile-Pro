public class AssetLifetimeBinderPool
{
    private global::System.Collections.Generic.Dictionary<object, AssetLifetimeBinder> binders;
    private bool autoCleanup;
    private float cleanupInterval;
    private float lastCleanupTime;
    public int Count => 0;

    public AssetLifetimeBinderPool(bool autoCleanup = true, float cleanupInterval = 5f)
    {
    }

    public void AddBinder(object managedObject, object assetObject, global::System.Action<object> releaseAction)
    {
    }

    public bool RemoveBinder(object assetObject)
    {
        return false;
    }

    public void CleanupDeadBinders()
    {
    }

    public void ReleaseAll()
    {
    }

    public bool HasBinder(object assetObject)
    {
        return false;
    }

    public void Update()
    {
    }
}
public class AssetLifetimeBinder
{
    private global::System.WeakReference<object> managedObject;
    private global::System.WeakReference<object> assetObject;
    private global::System.Action<object> ReleaseAction;
    public AssetLifetimeBinder(object managedObject, object assetObject, global::System.Action<object> releaseAction)
    {
    }

    public void Release()
    {
    }

    public bool IsManagedAlive()
    {
        return false;
    }

    public bool IsAssetAlive(object managed)
    {
        return false;
    }

    public static bool CheckAssetAlive(object assetObject)
    {
        return false;
    }

    public void ChangeManagedObject(object newManagedObject)
    {
    }

    public object GetManagedObject()
    {
        return null;
    }

    public object GetAssetObject()
    {
        return null;
    }
}
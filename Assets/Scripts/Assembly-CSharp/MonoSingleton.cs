public abstract class MonoSingleton<T> : global::UnityEngine.MonoBehaviour where T : MonoSingleton<T>
{
    private static T ms_instance;
    public static T Instance => null;

    protected static T Instantiate()
    {
        return null;
    }

    protected virtual void Initial()
    {
    }

    private void Awake()
    {
    }

    public void OnApplicationQuit()
    {
    }
}
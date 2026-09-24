public abstract class PicGenerater<T> : MonoSingleton<T> where T : PicGenerater<T>
{
    protected global::UnityEngine.Camera camera;
    protected bool loading;
    protected abstract string ScenePath { get; }

    protected virtual void Awake()
    {
    }

    protected abstract void OnInit(global::UnityEngine.GameObject root);
    public virtual void LoadScene()
    {
    }

    public virtual void Init()
    {
    }

    protected abstract bool CheckEnableUpdate();
    protected abstract void ConsumeTask();
    protected virtual void Update()
    {
    }
}
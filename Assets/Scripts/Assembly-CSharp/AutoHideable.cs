[global::System.Serializable]
public struct AutoHideable<T>
    where T : global::FLInterface.IShowHideable
{
    [global::UnityEngine.SerializeField]
    private T target;
    [global::UnityEngine.SerializeField]
    private float hideTime;
    private float currentTime;
    private bool isShow;
    public bool enabled => false;

    public void Hide()
    {
    }

    public void Show()
    {
    }

    public void Update(float deltaTime)
    {
    }

    public AutoHideable(T target, float hideTime = 1.5f)
    {
        this.target = default;
        this.hideTime = 0f;
        currentTime = 0f;
        isShow = false;
    }
}

public class AutoHideable : global::UnityEngine.MonoBehaviour, global::FLInterface.IShowHideable
{
    [global::UnityEngine.SerializeField]
    private AutoHideable<global::FLInterface.GameObjectShowHideable> core;
    bool global::FLInterface.IShowHideable.enabled => false;

    public void Hide()
    {
    }

    public void Show()
    {
    }

    private void Update()
    {
    }
}
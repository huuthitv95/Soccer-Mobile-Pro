public abstract class WindowTweenBase : global::UnityEngine.MonoBehaviour, IWindowTween
{
    [global::System.Serializable]
    private struct ExtenTweenInfo
    {
        [global::UnityEngine.SerializeField]
        public WindowTweenBase tween;
        [global::UnityEngine.SerializeField]
        public float offset;
    }

    protected global::UnityEngine.Events.UnityAction OnComplete;
    public global::UnityEngine.Events.UnityAction OnTweenStart;
    protected global::DG.Tweening.Sequence seq;
    [global::UnityEngine.SerializeField]
    private WindowTweenBase.ExtenTweenInfo[] Collaborative;
    private global::System.Collections.Generic.List<WindowTweenBase.ExtenTweenInfo> dynamicCollaborative;
    [global::UnityEngine.SerializeField]
    protected virtual bool IsCloseTween { get; private set; }

    [global::UnityEngine.SerializeField]
    protected virtual bool IsOpenTween { get; private set; }

    public void AddOnTweenComplete(global::UnityEngine.Events.UnityAction action)
    {
    }

    private void Awake()
    {
    }

    public virtual void Close()
    {
    }

    public virtual void Open(global::UnityEngine.Events.UnityAction OnComplete)
    {
    }

    public abstract global::DG.Tweening.Sequence CreateSequence();
    public void RegistCollaborative(WindowTweenBase target, float offset)
    {
    }
}
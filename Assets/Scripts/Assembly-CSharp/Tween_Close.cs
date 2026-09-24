public class Tween_Close : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.HideInInspector]
    public float DT;
    protected global::UnityEngine.GameObject closeMask;
    protected global::UnityEngine.UI.Image parentBg;
    public static int ActiveRef { get; private set; }

    public virtual void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDestroy()
    {
    }

    protected virtual global::System.Collections.IEnumerator DelayClose()
    {
        return null;
    }
}
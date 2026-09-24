public class ScrollListPlaceholder2 : global::UnityEngine.MonoBehaviour
{
    private enum Direction
    {
        Horizontal = 0,
        Vertical = 1
    }

    [global::UnityEngine.SerializeField]
    private ScrollListPlaceholder2.Direction scrollDirection;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform fullScreenRect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform alignRect;
    [global::UnityEngine.SerializeField]
    private float offset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<float> OnSizeDeterminedEvent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<float> OnSizeDeterminedEvent_IgnoreOffset;
    private bool uninitialize;
    [global::UnityEngine.SerializeField]
    private bool initializeOnEnable;
    private void Start()
    {
    }

    public void Init()
    {
    }

    private void Initialize()
    {
    }
}
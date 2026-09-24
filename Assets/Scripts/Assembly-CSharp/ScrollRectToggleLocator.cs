public class ScrollRectToggleLocator : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    public class ToggleBinding
    {
        public global::UnityEngine.UI.Toggle Toggle;
        public global::UnityEngine.RectTransform Target;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect scrollRect;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<ScrollRectToggleLocator.ToggleBinding> bindings;
    [global::UnityEngine.SerializeField]
    private float pixelOffset;
    [global::UnityEngine.SerializeField]
    private float duration;
    private global::UnityEngine.RectTransform viewport;
    private global::UnityEngine.RectTransform content;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Toggle> registeredToggles;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Events.UnityAction<bool>> toggleHandlers;
    private bool suppressToggle;
    private bool suppressScroll;
    private global::UnityEngine.Coroutine scrollRoutine;
    private static readonly global::UnityEngine.Vector3[] corners;
    public void ChangeOffset(float newOffset)
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void SetBindings(global::System.Collections.Generic.List<ScrollRectToggleLocator.ToggleBinding> newBindings)
    {
    }

    public void SetBindings(global::UnityEngine.UI.Toggle[] toggles, global::UnityEngine.RectTransform[] targets)
    {
    }

    public void RefreshBindings()
    {
    }

    public void StopScroll()
    {
    }

    public void ScrollToIndex(int index)
    {
    }

    private void EnsureReferences()
    {
    }

    private void RegisterScroll()
    {
    }

    private void UnregisterScroll()
    {
    }

    private void RegisterBindings()
    {
    }

    private void UnregisterBindings()
    {
    }

    private void OnToggleValueChanged(int index, bool isOn)
    {
    }

    private void OnScrollValueChanged(global::UnityEngine.Vector2 pos)
    {
    }

    private void SyncToggleFromScroll()
    {
    }

    private int FindClosestBindingIndex()
    {
        return 0;
    }

    private int ResolvePrimaryAxis(global::UnityEngine.Bounds viewBounds, global::UnityEngine.Bounds contentBounds)
    {
        return 0;
    }

    private float CalculateNormalizedForAxis(global::UnityEngine.RectTransform target, int axis)
    {
        return 0f;
    }

    private static global::UnityEngine.Bounds GetBoundsInView(global::UnityEngine.RectTransform rect, ref global::UnityEngine.Matrix4x4 viewWorldToLocal)
    {
        return default;
    }

    private void StartOrSetNormalized(global::UnityEngine.Vector2 target)
    {
    }

    private global::System.Collections.IEnumerator AnimateTo(global::UnityEngine.Vector2 target, float seconds)
    {
        return null;
    }

    private void StopActiveRoutine()
    {
    }
}
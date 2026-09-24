public class UIRaycastPassThrough : global::UnityEngine.MonoBehaviour, global::UnityEngine.ICanvasRaycastFilter
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform passThroughArea;
    public void Initialize(global::UnityEngine.RectTransform area)
    {
    }

    public bool IsRaycastLocationValid(global::UnityEngine.Vector2 screenPoint, global::UnityEngine.Camera eventCamera)
    {
        return false;
    }
}
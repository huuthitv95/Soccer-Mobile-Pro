[global::System.Serializable]
public class RectTransformEntry
{
    public global::UnityEngine.RectTransform target;
    public global::UnityEngine.Vector2 anchoredPosition;
    public global::UnityEngine.Vector2 sizeDelta;
    public global::UnityEngine.Vector2 anchorMin;
    public global::UnityEngine.Vector2 anchorMax;
    public global::UnityEngine.Vector2 pivot;
    public global::UnityEngine.Vector3 localScale;
    public global::UnityEngine.Vector3 localEulerAngles;
    public void Capture()
    {
    }

    public void Apply(bool pos = true, bool size = true, bool anchors = true, bool piv = true, bool scale = false, bool rot = false)
    {
    }
}
public class GUITourEventMapLine : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private int fromId;
    [global::UnityEngine.SerializeField]
    private int toId;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.RectTransform> segments;
    public int FromId => 0;
    public int ToId => 0;
    public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> Segments => null;

    public void Initialize(int fromId, int toId)
    {
    }

    public void AddSegment(global::UnityEngine.RectTransform segment)
    {
    }

    public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> GetImages()
    {
        return null;
    }

    public void GetImages(global::System.Collections.Generic.List<global::UnityEngine.UI.Image> images)
    {
    }
}
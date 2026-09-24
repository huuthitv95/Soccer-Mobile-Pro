[global::System.Serializable]
public class RectTransformSnapshot
{
    public string name;
    public global::System.Collections.Generic.List<RectTransformEntry> entries;
    public void CaptureAll()
    {
    }

    public void ApplyAll(bool pos = true, bool size = true, bool anchors = true, bool piv = true, bool scale = false, bool rot = false)
    {
    }
}
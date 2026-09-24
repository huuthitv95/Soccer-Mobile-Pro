public class UIPositionPresets : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct PositionPreset
    {
        public global::UnityEngine.RectTransform target;
        public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> options;
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<UIPositionPresets.PositionPreset> presets;
    public void Apply(int presetIndex)
    {
    }
}
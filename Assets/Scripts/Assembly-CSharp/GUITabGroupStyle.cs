public class GUITabGroupStyle : global::UnityEngine.MonoBehaviour
{
    private global::System.Collections.Generic.List<GUITabStyle> gUITabStyles;
    private void Awake()
    {
    }

    public void UpdateStyle(bool checkTgState = false)
    {
    }

    public void Initialize(global::UnityEngine.Transform group, int count, global::System.Action<int, bool> OnToggleChanged, global::System.Action<int, global::UnityEngine.Transform> updater, int defaultIdx = 0, bool invokeDefaultAction = true)
    {
    }

    public static void InitToggleGroup(global::UnityEngine.Transform group, int count, global::System.Action<int, bool> OnToggleChanged, global::System.Action<int, global::UnityEngine.Transform> updater, int defaultIdx = 0, bool invokeDefaultAction = true)
    {
    }

    public static void InitToggleGroup(global::System.Func<int, global::UnityEngine.Transform> getItem, int count, global::System.Action<int, bool> OnToggleChanged, global::System.Action<int, global::UnityEngine.Transform> updater, int defaultIdx = 0, bool invokeDefaultAction = true)
    {
    }

    public static void InitToggleGroup(global::System.Collections.Generic.IList<global::UnityEngine.Transform> toggles, int count, global::System.Action<int, bool> OnToggleChanged, global::System.Action<int, global::UnityEngine.Transform> updater, int defaultIdx = 0, bool invokeDefaultAction = true)
    {
    }
}
public class PlayerLODTimeline : global::UnityEngine.MonoBehaviour
{
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject>[] _lodGameObjects;
    private global::UnityEngine.GameObject Lod0HeadNode;
    private global::System.Collections.Generic.List<DetectEnableEvent> DetactEnableEvents;
    private const int DefaultLevel = 0;
    private static global::System.Collections.Generic.List<PlayerLODTimeline> allLods;
    [global::UnityEngine.SerializeField]
    private bool ManualLod;
    [global::UnityEngine.SerializeField]
    private int ManualLodLevel;
    private int currentLevel;
    private void Start()
    {
    }

    private void Detacted_EnableChanged(bool obj)
    {
    }

    private global::System.Collections.IEnumerator Refresh()
    {
        return null;
    }

    public void setCurrentLevel(int level)
    {
    }
}
public class RuntimeStaticBatching : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    public class StaticBatchingData
    {
        public global::UnityEngine.GameObject staticBatchRoot;
        public global::UnityEngine.GameObject[] gos;
    }

    [global::UnityEngine.SerializeField]
    public RuntimeStaticBatching.StaticBatchingData[] staticBatchingDatas;
    private void Start()
    {
    }

    public void GroupChildren()
    {
    }
}
public class Gradient2ParamsHolder : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct Params
    {
        public global::UnityEngine.GameObject go;
        public global::UIThemes.Gradient2Theme.Gradient2Params p;
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<Gradient2ParamsHolder.Params> paramsList;
    private global::System.Collections.Generic.Dictionary<global::UnityEngine.GameObject, global::UIThemes.Gradient2Theme.Gradient2Params> backUpDict;
    public void Apply()
    {
    }

    public void Restore()
    {
    }
}
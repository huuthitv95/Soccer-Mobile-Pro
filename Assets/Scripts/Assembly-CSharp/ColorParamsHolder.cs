public class ColorParamsHolder : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private class Params
    {
        public global::UnityEngine.UI.Graphic go;
        public global::UnityEngine.Color color;
        public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Color> colorEvent;
        [global::UnityEngine.HideInInspector]
        public global::UnityEngine.Color backUpColor;
        [global::UnityEngine.HideInInspector]
        public bool hasBackUp;
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<ColorParamsHolder.Params> paramsList;
    public void Apply()
    {
    }

    public void Restore()
    {
    }
}
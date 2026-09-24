public class ColorParamsHolder2 : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private class Params
    {
        public global::UnityEngine.UI.Graphic go;
        public global::UnityEngine.Color[] color;
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<ColorParamsHolder2.Params> paramsList;
    public void Apply(int idx)
    {
    }

    public void Apply(bool isOn)
    {
    }
}
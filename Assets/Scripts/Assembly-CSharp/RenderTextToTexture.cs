public class RenderTextToTexture : global::UnityEngine.MonoBehaviour
{
    public class Parameter
    {
        public bool sloganFont;
        public global::UnityEngine.Color BgColor;
        public global::UnityEngine.Color TextColor;
        public global::UnityEngine.FontStyle FontStyle;
        public int fontSize;
        public bool EnableOutLine;
        public global::UnityEngine.Color OutlineColor;
        public global::UnityEngine.Vector2 OutlineDistance;
        private static RenderTextToTexture.Parameter defaultParameter;
        public static RenderTextToTexture.Parameter Default => null;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera camera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image bg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform[] textRectTransform;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Outline[] outline;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ContentSizeFitter[] contentSizeFitter;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Canvas canvas;
    private static RenderTextToTexture inst;
    private global::UnityEngine.RenderTexture renderTexture;
    private void Awake()
    {
    }

    public global::UnityEngine.RenderTexture GetATexture(string str, RenderTextToTexture.Parameter p = null)
    {
        return null;
    }

    public static global::UnityEngine.RenderTexture GetTexture(string str, RenderTextToTexture.Parameter p = null)
    {
        return null;
    }
}
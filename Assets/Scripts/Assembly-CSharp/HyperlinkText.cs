public class HyperlinkText : global::UnityEngine.UI.Text, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler
{
    public class HyperlinkInfo
    {
        public int startIndex;
        public int endIndex;
        public string linkUrl;
        public global::System.Collections.Generic.List<HyperlinkText.ClickAreas> clickAreas;
    }

    public class ClickAreas
    {
        public float xMin;
        public float xMax;
        public float yMin;
        public float yMax;
        public ClickAreas(float xMin, float xMax, float yMin, float yMax)
        {
        }
    }

    [global::System.Serializable]
    public class HrefClickEvent : global::UnityEngine.Events.UnityEvent<string>
    {
    }

    private string colorAddedStr;
    public readonly global::System.Collections.Generic.List<HyperlinkText.HyperlinkInfo> hrefInfos;
    protected static readonly global::System.Text.StringBuilder textRebuild;
    [global::UnityEngine.SerializeField]
    private HyperlinkText.HrefClickEvent onHrefClickCB;
    private const int perCharVerCount = 4;
    private const string pattern = "<a href=([^>\\n\\s]+)>(.*?)(</a>)";
    private const string colorStartStr = "<color=#A8FF6E>";
    private const string colorEndStr = "</color>";
    private const string otherPattern = "<.+?>";
    private static readonly global::System.Text.RegularExpressions.Regex s_HrefRegex;
    private HyperlinkText mHyperlinkText;
    private static readonly global::System.Text.RegularExpressions.Regex otherRegex;
    public HyperlinkText.HrefClickEvent onHrefClick
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    protected override void Awake()
    {
    }

    protected override void OnEnable()
    {
    }

    protected override void OnDisable()
    {
    }

    public override void SetVerticesDirty()
    {
    }

    protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
    {
    }

    protected virtual string GetDealedText(string originText)
    {
        return null;
    }

    public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void OnHyperlinkTextInfo(string url)
    {
    }
}
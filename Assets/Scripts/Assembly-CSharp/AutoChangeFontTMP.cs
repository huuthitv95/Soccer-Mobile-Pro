public class AutoChangeFontTMP : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private string needMaterial;
    private global::TMPro.TextMeshProUGUI text;
    private bool Listen;
    public global::TMPro.TMP_FontAsset CurrentFont => null;

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void InitFont()
    {
    }

    public void SetFontByLanguage(LanguageSetting.eLanguage language)
    {
    }

    private void OnDestroy()
    {
    }
}
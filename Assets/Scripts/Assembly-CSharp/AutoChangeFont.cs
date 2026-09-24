public class AutoChangeFont : global::UnityEngine.MonoBehaviour
{
    private enum FLFontStyle
    {
        standard = 0,
        Medium = 1,
        Bold = 2,
        black = 3
    }

    [global::UnityEngine.SerializeField]
    private AutoChangeFont.FLFontStyle fontStyle;
    private global::UnityEngine.UI.Text text;
    private bool Listen;
    private static global::System.Collections.Generic.List<AutoChangeFont> nowActivedChangedFonts;
    public global::UnityEngine.Font CurrentFont => null;

    public void ChangeColor(global::UnityEngine.Color color)
    {
    }

    private void Awake()
    {
    }

    private void InitFont()
    {
    }

    private void OnSetLanguage(LanguageSetting.eLanguage languageType)
    {
    }

    public void SetFont(global::UnityEngine.Font f)
    {
    }

    public void SetFontByLanguage(LanguageSetting.eLanguage language)
    {
    }

    private void OnDestroy()
    {
    }
}
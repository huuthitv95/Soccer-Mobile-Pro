public static class LanguageSetting
{
    public enum eLanguage
    {
        EN = 0,
        FR = 1,
        IT = 2,
        DE = 3,
        ES = 4,
        JA = 5,
        PT = 6,
        RU = 7,
        ZH_CN = 8,
        ZH_TW = 9,
        ZH_HK = 10,
        KO = 11,
        AR = 12,
        NL = 13,
        TR = 14,
        ID = 15,
        TH = 16,
        VI = 17,
        EN_GB = 18,
        FA = 19,
        PL = 20,
        SV = 21,
        HI = 22,
        TOTAL_COUNT = 23,
        ES_ES = 24,
        EN_US = 25
    }

    public static string[] FontType;
    public static string[] ItalicFontType;
    private static FontContainer container;
    private static global::System.Collections.Generic.Dictionary<LanguageSetting.eLanguage, global::UnityEngine.Font> languageToFont;
    private static global::System.Collections.Generic.Dictionary<LanguageSetting.eLanguage, global::UnityEngine.Font> languageToItalicFont;
    public static string[] FontTMPType;
    public static float[] FontTMPCharSpace;
    public static float[] FontTMPStyle;
    private static FontTMPContainer TMPContainer;
    private static global::System.Collections.Generic.Dictionary<LanguageSetting.eLanguage, FontTMPContainer.FontTMPEntry> languageToFontTMP;
    public static LanguageEvent OnSetLanguage;
    private static LanguageSetting.eLanguage language;
    public static LanguageSetting.eLanguage Language => LanguageSetting.eLanguage.EN;

    public static global::UnityEngine.Font GetFontByLanguage(LanguageSetting.eLanguage languageType)
    {
        return null;
    }

    public static global::UnityEngine.Font GetItalicFont(LanguageSetting.eLanguage languageType)
    {
        return null;
    }

    public static FontTMPContainer.FontTMPEntry GetFontTMPByLanguage(LanguageSetting.eLanguage languageType)
    {
        return default;
    }

    public static void SetLanguage(LanguageSetting.eLanguage type)
    {
    }
}
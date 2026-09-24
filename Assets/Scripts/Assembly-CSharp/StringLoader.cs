public class StringLoader : global::Common.Singleton<StringLoader>
{
    private static bool _dataInitialed;
    private static global::UnityEngine.AndroidJavaObject _unityContext;
    private static bool isEnUs;
    private global::System.Collections.Generic.Dictionary<LanguageSetting.eLanguage, global::UnityEngine.Font> LanguageToFont;
    private global::System.Collections.Generic.Dictionary<LanguageSetting.eLanguage, global::System.Collections.Generic.Dictionary<string, string>> stringsdata;
    private global::System.Collections.Generic.HashSet<StringID> StringList;
    private global::System.Collections.Generic.HashSet<StringIDTMP> StringTMPList;
    public static bool IsInitialed => false;
    public static global::UnityEngine.AndroidJavaObject UnityContext => null;

    public static bool IsEnUS
    {
        get
        {
            return false;
        }

        private set
        {
        }
    }

    public static string LanguageCountryTag { get; private set; }

    // C# has no syntax for parameterized property 'Item'.
    public string this[string id]
    {
        get
        {
            return null;
        }
    }

    public void Init()
    {
    }

    public void LoadString()
    {
    }

    private static int getSDKInt()
    {
        return 0;
    }

    public static LanguageSetting.eLanguage GetLocalizedLanguage()
    {
        return LanguageSetting.eLanguage.EN;
    }

    public static string GetDeviceCountry()
    {
        return null;
    }

    public string GetString(string id, bool fixArabic = true)
    {
        return null;
    }

    public string GetStringWithReplacement(string id, string[] replaceKeys, string[] replaceValues)
    {
        return null;
    }

    public string GetStringWithReplacement(string id, string replaceKeys, string replaceValues)
    {
        return null;
    }

    public string GetString(string id, LanguageSetting.eLanguage eLanguage, bool fixArabic = true)
    {
        return null;
    }

    public string GetStringWithReplacedKeywords(string id, string keyword, string replace)
    {
        return null;
    }

    public static string FixArabic(string str)
    {
        return null;
    }

    public string GetString(string id, params object[] args)
    {
        return null;
    }

    public void RegisterString(StringID str)
    {
    }

    public void RegisterStringTMP(StringIDTMP str)
    {
    }

    public void UnregisterString(StringID str)
    {
    }

    public void UnregisterStringTMP(StringIDTMP str)
    {
    }

    public void RefreshAllString()
    {
    }

    public void CheckLocalLanguage()
    {
    }
}
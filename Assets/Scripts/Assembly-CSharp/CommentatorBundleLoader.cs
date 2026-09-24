public class CommentatorBundleLoader : global::Common.Singleton<CommentatorBundleLoader>, global::Common.ExternalAssetBundleLoader
{
    private global::System.Collections.Generic.List<LanguageSetting.eLanguage> supportedLanguages;
    private global::System.Collections.Generic.List<string> bundles;
    public void Load()
    {
    }

    private void Load(LanguageSetting.eLanguage lan, global::UnityEngine.AndroidJavaObject context = null)
    {
    }

    private string GetLanguageStr(LanguageSetting.eLanguage lan)
    {
        return null;
    }

    public string GetAndroidLanguageStr(LanguageSetting.eLanguage lan)
    {
        return null;
    }

    public void Reload(LanguageSetting.eLanguage lan, global::UnityEngine.AndroidJavaObject context)
    {
    }

    public string GetTempBundlePath(LanguageSetting.eLanguage lan)
    {
        return null;
    }

    public string GetBundleName(LanguageSetting.eLanguage lan)
    {
        return null;
    }

    private LanguageSetting.eLanguage GetLanguageByStr(string str)
    {
        return LanguageSetting.eLanguage.EN;
    }

    private void CheckDeleteObsoleteFile()
    {
    }

    private void CheckNeedCopyBundle(string language, global::UnityEngine.AndroidJavaObject context = null)
    {
    }

    private void CheckSupported()
    {
    }

    public bool IsSupported(LanguageSetting.eLanguage language)
    {
        return false;
    }

    public global::System.Collections.Generic.List<LanguageSetting.eLanguage> GetSupported()
    {
        return null;
    }

    public bool isExist(string name)
    {
        return false;
    }

    public global::UnityEngine.AssetBundle Load(string name)
    {
        return null;
    }
}
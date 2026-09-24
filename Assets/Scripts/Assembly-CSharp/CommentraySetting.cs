public class CommentraySetting : SettingPageBase
{
    private class Item
    {
        private global::UnityEngine.UI.Button downlaod;
        private global::UnityEngine.UI.Toggle toggle;
        private global::UnityEngine.UI.Toggle toggleOff;
        private global::UnityEngine.UI.Text text;
        private global::UnityEngine.Transform node;
        private LanguageSetting.eLanguage lan;
        private bool isDownloaded;
        private CommentraySetting setting;
        public void Init(global::UnityEngine.Transform root, LanguageSetting.eLanguage eLanguage, ref string name, CommentraySetting setting)
        {
        }

        public void EnableToggle()
        {
        }

        private void OnToggleValueChange(bool isOn)
        {
        }

        private void Downlaod()
        {
        }

        public void Update(LanguageSetting.eLanguage eLanguage)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform child;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject downloadFlag;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, LanguageSetting.eLanguage>> commentorLan;
    private global::System.Collections.Generic.List<CommentraySetting.Item> items;
    private void Init()
    {
    }

    private void OnChangeOption(CommentraySetting.Item trigger, LanguageSetting.eLanguage target)
    {
    }

    private void OnDownload(LanguageSetting.eLanguage target)
    {
    }

    public override void Init(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    public override void OnClose()
    {
    }
}
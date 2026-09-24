public class Win_Setting : global::Common.WindowBase
{
    [global::System.Serializable]
    private class SettingPageInfo
    {
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.UI.Toggle toggle;
        [global::UnityEngine.SerializeField]
        private SettingPageBase page;
        private bool initFlag;
        public void SetActive(bool active, Win_Setting.GameSettingCategory category, bool inGame)
        {
        }

        public void OnClose()
        {
        }
    }

    public enum GameSettingCategory
    {
        Normal = 0,
        MasterLeague = 1,
        Friendly = 2,
        PlayerCareer = 3
    }

    public enum SupportType
    {
        BUG = 0,
        PAYMENT = 1,
        SUGGESTION = 2,
        OTHER = 3
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReplay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    [global::UnityEngine.SerializeField]
    private Win_Setting.SettingPageInfo[] settingPages;
    private bool inited;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Setting Fill(Win_Setting.GameSettingCategory category, global::UnityEngine.Events.UnityAction action)
    {
        return null;
    }

    public static int GetCommonDifficulty()
    {
        return 0;
    }

    public override void OnClose()
    {
    }

    public void OpenPrivacyPolicy()
    {
    }

    public void OpenAMZ()
    {
    }

    private string EscapeURL(string url)
    {
        return null;
    }

    public void OpenContactSupport()
    {
    }

    private void ContactUs(Win_Setting.SupportType type)
    {
    }

    private long GetUnixTimestamp()
    {
        return 0L;
    }
}
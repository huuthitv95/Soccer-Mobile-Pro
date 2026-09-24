public class Win_CupGroup : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private StringID cupName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRefresh;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRefresh_bottomBanner;
    [global::UnityEngine.SerializeField]
    private EventThemeTitle themeTitle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect scrollViewNevigation;
    public override void OnOpen(object parameter)
    {
    }

    public static bool SupportCupGroup(FACup fACup)
    {
        return false;
    }

    private void Fill(FACup fACup)
    {
    }

    private void scrollToItem(int idx)
    {
    }
}
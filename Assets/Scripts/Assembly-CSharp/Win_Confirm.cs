public class Win_Confirm : global::Common.WindowBase
{
    public enum IconType
    {
        None = 0,
        Warning = 1,
        Leave = 2,
        Transfer = 3,
        Custom = 4
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOk;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text context;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] icons;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnLeftCancel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRightCancel;
    private global::System.Action onWindowClose;
    public override void OnOpen(object paramter)
    {
    }

    public Win_Confirm Fill(string contextId, Win_Confirm.IconType iconType = Win_Confirm.IconType.Warning, string confirmId = "ok", string cancelId = "cancel", string titleId = null)
    {
        return null;
    }

    public void ShowCancelBtn(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void HideBtnClose()
    {
    }

    public void CloseWindow()
    {
    }

    public void SetCustomIcon(global::UnityEngine.Sprite sprite)
    {
    }

    public void ShowCancelBtn(bool left, global::UnityEngine.Events.UnityAction action, string str)
    {
    }

    public static Win_Confirm ShowPCRetirement(string descKey, global::UnityEngine.Events.UnityAction onConfirm, bool showCancel)
    {
        return null;
    }

    public static Win_Confirm ShowPCRetirement(global::FL.PlayerCareer playerCareer)
    {
        return null;
    }
}
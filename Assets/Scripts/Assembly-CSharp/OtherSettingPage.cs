public class OtherSettingPage : SettingPageBase
{
    [global::UnityEngine.SerializeField]
    private GUIWheel targetFPS;
    [global::UnityEngine.SerializeField]
    private GUIWheel screenResolution;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDatabase;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCloudSave;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRestorePurchases;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    public override void Init(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    private void InitTargetFPS()
    {
    }

    private void InitScreenResolution()
    {
    }

    public void ClickSaveData()
    {
    }

    public void InitRestorePurchases()
    {
    }

    private void OnRestorePurchasesClicked()
    {
    }

    private void SetRestorePurchasesLoading(bool isLoading)
    {
    }

    public override void OnClose()
    {
    }
}
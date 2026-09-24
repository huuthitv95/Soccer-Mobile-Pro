public class Win_UserPlayerBaseInfoEditor : global::Common.WindowBase
{
    private const int MinKitNumber = 1;
    private const int MaxKitNumber = 99;
    [global::UnityEngine.SerializeField]
    private ForwardBackwardController forwardBackwardController;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField nameInputField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField kitNameInputField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField kitNumberInputField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSelectRegion;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image regionIcon;
    private SelectRoleSceneManager selectRoleSceneManager;
    private UserPlayerSetupData userPlayerSetupData;
    private bool rebirthMode;
    private global::UnityEngine.Events.UnityAction onRebirthNext;
    private const string FallbackDefaultName = "New Player";
    private const string FallbackDefaultKitName = "New Player";
    private const int FallbackDefaultKitNumber = 99;
    private string defaultName;
    private string defaultKitName;
    private int defaultKitNumber;
    private NationalData.eNation defaultNationality => NationalData.eNation.None;

    public void Fill(UserPlayerSetupData userPlayerSetupData, SelectRoleSceneManager selectRoleSceneManager, global::UnityEngine.GameObject playerGO)
    {
    }

    public void FillRebirth(UserPlayerSetupData userPlayerSetupData, SelectRoleSceneManager selectRoleSceneManager, global::UnityEngine.GameObject playerGO, global::UnityEngine.Events.UnityAction onNext)
    {
    }

    private void Back()
    {
    }

    private void Next()
    {
    }

    private void RegisterUIEvent()
    {
    }

    private void InitDefaultInfo()
    {
    }

    private void InitDefaultInfoConfig()
    {
    }

    private void InitSetupInfo()
    {
    }

    private void OnNameValueChanged(string value)
    {
    }

    private void OnNameEndEdit(string value)
    {
    }

    private void OnKitNameValueChanged(string value)
    {
    }

    private void OnKitNameEndEdit(string value)
    {
    }

    private char ValidateNameInput(string text, int position, char character)
    {
        return '\0';
    }

    private bool IsNextToSpaceOrApostrophe(string text, int position)
    {
        return false;
    }

    private void OnKitNumberValueChanged(string value)
    {
    }

    private void OnKitNumberEndEdit(string value)
    {
    }

    private void OpenSelectRegionWindow()
    {
    }

    private void OnNationSelected(NationalData.eNation nation)
    {
    }

    private string NormalizeInput(string value, string fallback)
    {
        return null;
    }
}
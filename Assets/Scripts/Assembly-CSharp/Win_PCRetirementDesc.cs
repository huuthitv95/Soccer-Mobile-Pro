public class Win_PCRetirementDesc : global::Common.WindowBase
{
    public enum EntryType
    {
        ManualRetirement = 0,
        ForcedRetirementNotice = 1
    }

    private const string RetirementUnavailableTipKey = "pc_retirement_not_available";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    private Win_PCRetirementDesc.EntryType entryType;
    private global::FL.PlayerCareer playerCareer;
    private global::UnityEngine.Events.UnityAction onConfirm;
    public void HideBackButton()
    {
    }

    public void Fill(Win_PCRetirementDesc.EntryType entryType, global::FL.PlayerCareer playerCareer, global::UnityEngine.Events.UnityAction onConfirm = null)
    {
    }

    private void SetupButtons()
    {
    }

    private void OnConfirmClicked()
    {
    }

    private void ConfirmRetirement()
    {
    }

    private void OpenRetirementAchievement(global::FL.PlayerCareer retiredCareer)
    {
    }
}
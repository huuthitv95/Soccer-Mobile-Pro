public class Win_UserPlayerTempBoost : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject switchTab;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private GUIBoostRatingRV boostRatingRV;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerRestoreStaminaRV restoreStaminaRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormation;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerBaseInfo userPlayerBaseInfo;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image coachTrustyIcon;
    public override void OnOpen(object parameter)
    {
    }

    public void InitForOutOfMatch(UserPlayerData player, PlayerTemporaryBoostManager manager, CupMatchBase match)
    {
    }

    public void InitForInMatch(UserPlayerData player, InGamePlayer inGamePlayer, bool boosted, PlayerTemporaryBoostManager manager, CupMatchBase match)
    {
    }

    private void ApplyPlayerModel(ClubPlayer player, CupMatchBase match)
    {
    }

    private void InitCommon()
    {
    }

    public void AddFormationAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void ShowNextBtn(global::UnityEngine.Events.UnityAction onClick)
    {
    }

    public void AddBackAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void HideSwitchTab()
    {
    }

    public void HideNextButton()
    {
    }
}
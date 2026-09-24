public class Win_SeasonMission : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text seasonText;
    [global::UnityEngine.SerializeField]
    private GUISeasonMission[] seasonMissionItems;
    [global::UnityEngine.SerializeField]
    private GUIRenewalMission renewalMissionItem;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCareerTopBar careerTopBar;
    private global::FL.PlayerCareer playerCareer;
    private Win_RewardAnimationEffect rewardClaimEffectWindow;
    private bool openingRewardClaimEffectWindow;
    private bool playingClaimAnimation;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public Win_SeasonMission Fill(global::FL.PlayerCareer playerCareer)
    {
        return null;
    }

    private void Refresh()
    {
    }

    private void UpdateLeagueInfo()
    {
    }

    private void UpdateRenewalMission()
    {
    }

    private void UpdateBonusMissions()
    {
    }

    private void OnClaimMission(global::Srv.SeasonMission mission, GUISeasonMission missionItem)
    {
    }

    private void FinishRewardClaimAnimation(bool playCoinNumberAnimation)
    {
    }

    private void FinishInterruptedRewardClaimAnimation()
    {
    }

    private void PlayRewardClaimAnimation(GUISeasonMission missionItem)
    {
    }

    private void OnRewardClaimEffectWindowClose()
    {
    }

    private void CloseRewardClaimEffectWindow()
    {
    }

    private void ClearRewardClaimEffectWindow()
    {
    }

    private global::UnityEngine.Vector2 GetScreenPoint(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }

    private void SetSeasonMissionClaimButtonsInteractable(bool interactable)
    {
    }

    public static string GetProgressText(global::Srv.SeasonMission mission)
    {
        return null;
    }

    public static void SetProgressFill(global::UnityEngine.UI.Image fill, global::Srv.SeasonMission mission)
    {
    }

    public static float GetProgressRate(global::Srv.SeasonMission mission)
    {
        return 0f;
    }

    public static global::UnityEngine.Color GetLeagueLabelColor(int leagueLevel)
    {
        return default;
    }

    public static global::UnityEngine.Color GetLeagueTextColor(int leagueLevel)
    {
        return default;
    }

    public static global::UnityEngine.Color GetLeagueTextColor(RegionalLeague.LeagueLevel leagueLevel)
    {
        return default;
    }

    public static global::UnityEngine.Color GetLeagueLabelColor(RegionalLeague.LeagueLevel leagueLevel)
    {
        return default;
    }
}
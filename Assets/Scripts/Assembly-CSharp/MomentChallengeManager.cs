public class MomentChallengeManager : IQuitMatchPopupHandler
{
    public enum ChallengeStateType
    {
        NotStarted = 0,
        InProgress = 1,
        Failed = 2,
        Completed = 3,
        OutOfAttempts = 4
    }

    private MomentChallengeConfigManager.ChallengeInfo currentChallenge;
    private global::Srv.MomentChallengeArchive challengeArchive;
    private MomentChallengeConfigManager configManager;
    private (global::FLGameData.RewardType, int)[] SpecialReward;
    private bool needShowFailedTip;
    public static global::FLGameProgressSetting.EasySave.RedPointData RedPoint;
    public MomentChallengeManager.ChallengeStateType ChallengeState => MomentChallengeManager.ChallengeStateType.NotStarted;
    private int MaxRetryTimes => 0;

    public (int, int) GetRetryInfo()
    {
        return default;
    }

    public global::System.DateTime GetNextFreeRefreshTime()
    {
        return default;
    }

    public void CheckLoadCurrentChallenge()
    {
    }

    public MomentChallengeConfigManager.ChallengeInfo GetCurrentChallenge()
    {
        return null;
    }

    public SimulatedPreviousSegmentMatchData GeneratePreviousSegmentData()
    {
        return null;
    }

    public void Retry()
    {
    }

    public void RefreshForRV()
    {
    }

    private void RefreshForNewDay()
    {
    }

    private void CreateNewChallenge()
    {
    }

    public bool RefreshToLevel(int levelId)
    {
        return false;
    }

    private MomentChallengeConfigManager.ChallengeInfo CreateRandomChallengeShell()
    {
        return null;
    }

    private void ApplyChallenge(MomentChallengeConfigManager.ChallengeInfo newChallenge)
    {
    }

    private void ApplyRandomValues()
    {
    }

    private void LoadFromArchive()
    {
    }

    private int CalculatePlayerLevelValue()
    {
        return 0;
    }

    public int GetTodayTotalReward()
    {
        return 0;
    }

    public global::System.Collections.Generic.IEnumerable<(global::FLGameData.RewardType, int)> GetAllSpecialRewards()
    {
        return null;
    }

    public int GetCurrentSpecialRewardIndex()
    {
        return 0;
    }

    public bool TryGetLastSpecialReward(out (global::FLGameData.RewardType, int) reward)
    {
        reward = default;
        return false;
    }

    public bool TryGetSpecificReward(out (global::FLGameData.RewardType, int) reward)
    {
        reward = default;
        return false;
    }

    private void OnChallengePassed()
    {
    }

    public int GetUnclaimedRewards()
    {
        return 0;
    }

    public void ClaimRewards()
    {
    }

    public bool NeedShowFailedTip()
    {
        return false;
    }

    public void MarkNoNeedShowFailedTip()
    {
    }

    private void OnChallengeFinish(bool passed)
    {
    }

    public void OnMatchFinish(in MatchMissionPointChecker checkPoint, bool giveup = false)
    {
    }

    private void AddPlayTimes()
    {
    }

    public static void StartChallenge()
    {
    }

    public void OnQuitMatchPopup(global::UnityEngine.Events.UnityAction onConfirm, global::UnityEngine.Camera camera)
    {
    }

    public void CheckPopup()
    {
    }
}
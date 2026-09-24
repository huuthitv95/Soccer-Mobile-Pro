public class LicensedTeamChallenge : global::Common.Singleton<LicensedTeamChallenge>
{
    public int[] rewards;
    public int[] teamIds;
    private const string LicensedChallengeRewardTipKey = "LicensedChallengeRewardTipKey";
    public bool IsOpen => false;
    public bool IsCompleted => false;
    public bool IsManCityCompleted => false;
    public bool IsMonacoCompleted => false;

    public int GetCurrentChallengeDifficulty()
    {
        return 0;
    }

    public bool HasRewardTip()
    {
        return false;
    }

    public void SetHasRewardTip(bool hasTip)
    {
    }

    public void OnChallengeFinish(CupMatchBase match)
    {
    }

    private void HandleChallengeFinish(bool userWin, int userId)
    {
    }

    public void Start(int userTeamId, int opponentTeamId)
    {
    }
}
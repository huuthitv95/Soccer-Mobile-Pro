public class GUIChallengeRoundRewardItem : global::UnityEngine.MonoBehaviour
{
    private enum RewardType
    {
        BallOrJersey = 0,
        Coins = 1,
        ClissicTeam = 2,
        LegendPlayer = 3,
        LegendPlayerPool = 4,
        Point = 5
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage BallOrJerseyImage;
    [global::UnityEngine.SerializeField]
    private bool isRevealEnabled;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] rewardTypeObjects;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text pointText;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] playerCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerLocked;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo revealPlayerRV;
    [global::UnityEngine.SerializeField]
    public GUITeam uiTeam;
    [global::UnityEngine.SerializeField]
    private bool customJerseyOrBallImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject unlockedPlayerCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerCardCucoloris;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject rewardBg;
    private global::UnityEngine.Transform ShowReward(GUIChallengeRoundRewardItem.RewardType type)
    {
        return null;
    }

    private void ShowRewardBg(bool show)
    {
    }

    public void Updater(in ChampionshipRoadConfig.ChallengeMissionConfig config, global::FL.IRewardRevealSupport rewardRevealSupport)
    {
    }

    public void CoinUpdater(int coins, global::FL.IRewardRevealSupport rewardRevealSupport)
    {
    }

    public void PointUpdater(int points)
    {
    }

    public void Updater(global::FL.TourEvent.TourEventRewardConfig config)
    {
    }

    public void ClissicTeamUpdater(int teamId)
    {
    }

    public void JerseyOrBallUpdater(int id)
    {
    }

    public void SiglePlayerUpdater(int playerId, int mid, global::FL.IRewardRevealSupport rewardRevealSupport)
    {
    }

    public void PoolPlayerUpdater()
    {
    }

    private void FillPlayerCard(int playerId)
    {
    }

    private void UpdatePlayerLockState(bool isRevealed, global::FL.IRewardRevealSupport rewardRevealSupport, int playerId, int missionId)
    {
    }
}
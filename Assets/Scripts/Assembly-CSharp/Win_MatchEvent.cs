public class Win_MatchEvent : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerEvent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform penalty;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Playables.PlayableDirector playableGoal;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Playables.PlayableDirector playableCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image nameBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerGoalStats;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform goalStats;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform appsStats;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void OnEnableAnim()
    {
    }

    private global::DG.Tweening.Tween OnDisableAnim()
    {
        return null;
    }

    private void CloseWindow()
    {
    }

    public Win_MatchEvent ShowPenalty(TeamsData home, TeamsData away, global::System.Collections.Generic.List<int> homeScores, global::System.Collections.Generic.List<int> awayScores, int[] score)
    {
        return null;
    }

    private void FillPenalty(global::UnityEngine.Transform root, TeamsData team, global::System.Collections.Generic.List<int> scores, bool ishome)
    {
    }

    public Win_MatchEvent ShowPlayerEvent(TeamsData team, int opp, ClubPlayer player, bool isMyTeam, InGamePlayer ingamePlayer, global::EngineMessages.FoulType foulType = global::EngineMessages.FoulType.None)
    {
        return null;
    }

    private void UpdatePlayerGoalStats(ClubPlayer player, InGamePlayer ingamePlayer, global::EngineMessages.FoulType foulType)
    {
    }

    private Win_MatchEvent ShowPlayerEvent(TeamsData team, int opp, ClubPlayer player, bool isMyTeam, InGamePlayer ingamePlayer)
    {
        return null;
    }

    public Win_MatchEvent ShowInjuredEvent(TeamsData team, int opp, ClubPlayer player, bool isMyTeam, InGamePlayer ingamePlayer)
    {
        return null;
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }
}
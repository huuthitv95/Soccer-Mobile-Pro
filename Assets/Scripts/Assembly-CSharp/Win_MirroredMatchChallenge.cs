public class Win_MirroredMatchChallenge : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text pointNumText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform finalMatch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] matchGroups;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform progressBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShop;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject mask;
    private global::FL.MirroredMatchChallengeManager manager;
    private MirroredMatchChallengeConfig.ChallengeEventConfig currentChallenge;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void OpenShop()
    {
    }

    private void UpdatePointText(int count)
    {
    }

    private void UpdateTexts()
    {
    }

    private void OnTipClick()
    {
    }

    private void UpdateItems()
    {
    }

    private void UpdateProgressUI(int cur, int target, bool needAnim)
    {
    }

    private void UpdateMatchInfo(global::UnityEngine.Transform root, in ChampionshipRoadConfig.ClassicMatchConfig cfg)
    {
    }

    private void StartChallenge(ChampionshipRoadConfig.ClassicTeamMatchChallenge cfg, bool isFinalMatch, bool isLocked)
    {
    }

    private void UpdateMatchState(global::UnityEngine.Transform root, int id, ref int progress)
    {
    }
}
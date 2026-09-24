public class Win_LoaclPVPFormation : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITeam p1Team;
    [global::UnityEngine.SerializeField]
    private GUITeam p2Team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormationP1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormationP2;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formationThumbP1;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formationThumbP2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    private CupMatchBase match;
    private global::System.Action<CupMatchBase> startMatch;
    public void Initialize(CupMatchBase localBattleMatch, global::System.Action<CupMatchBase> startMatchAction)
    {
    }

    private void Refresh()
    {
    }

    private void RefreshFormation(GUIFormationThumb formationThumb, TeamsData team)
    {
    }

    private void OpenPlayerOneFormation()
    {
    }

    private void OpenPlayerTwoFormation()
    {
    }

    private void OpenFormation(TeamsData team)
    {
    }

    private void Play()
    {
    }

    private bool ValidateTeam(TeamsData team)
    {
        return false;
    }
}
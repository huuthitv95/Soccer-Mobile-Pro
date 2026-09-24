public class Win_PlayerDevelopment : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerList;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PAC;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PAS;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform SHO;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform DRI;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform DEF;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PHY;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    private global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> tempPlayerExp;
    private global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> tempPlayerProperty;
    public global::System.Collections.Generic.Dictionary<int, global::System.Tuple<int, int, float, float>> tempPlayerDebugInfo;
    private float animationTime;
    private global::System.Collections.Generic.Queue<global::DG.Tweening.Tweener> inProcessAnim;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(RegionalLeague regionalLeague, TeamsData team, global::System.Action nextAction)
    {
    }

    public void FillTraining(RegionalLeague regionalLeague, TeamsData team, global::System.Collections.Generic.List<ClubPlayer> players, global::System.Action nextAction)
    {
    }

    private void CommonFill(RegionalLeague regionalLeague, TeamsData team, global::System.Collections.Generic.List<ClubPlayer> players, global::System.Action nextAction)
    {
    }

    private global::FL.PlayerExpStruct GetDeltaExp(int id)
    {
        return default;
    }

    private global::SL.Player.Hexagram GetOldProperty(int id)
    {
        return default;
    }

    private void killAnimation()
    {
    }

    private global::DG.Tweening.Tweener DONumberText(global::UnityEngine.UI.Text target, float endValue, float startValue, float duration, string format = "0%")
    {
        return null;
    }

    private void UpdatePlayerInfo(ClubPlayer player, float DeltaExp, float newExp, int property, global::UnityEngine.Transform item, string PropertyName, int oldProperty)
    {
    }

    private void SetAbilityColor(global::UnityEngine.UI.Text text, float value)
    {
    }

    public override void OnClose()
    {
    }
}
public class Win_ChampionsLeagueRuleSelector : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button groupMode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button leagueMode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::UnityEngine.Events.UnityAction<int> OnSelect)
    {
    }

    public static string GetWindowStyle(global::SL.CupRules rules)
    {
        return null;
    }
}
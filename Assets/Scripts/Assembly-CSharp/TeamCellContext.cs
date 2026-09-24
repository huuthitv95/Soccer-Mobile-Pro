public class TeamCellContext : global::FancyScrollView.FancyGridViewContext
{
    public TeamsData Selected;
    public int fixedRating;
    public global::UnityEngine.Rect rect;
    public global::System.Collections.Generic.List<TeamsData> teams;
    public global::System.Collections.Generic.HashSet<int> chooseableMark;
    public global::System.Action<TeamsData> OnSelect;
    public global::System.Action<global::UnityEngine.Transform, TeamsData, global::System.Action> UnlockTeamAction;
    public global::System.Action<TeamCell, TeamsData> OnInit;
    public void Select(TeamsData itemData)
    {
    }
}
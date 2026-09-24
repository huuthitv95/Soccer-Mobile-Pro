public class TeamCell : global::FancyScrollView.FancyGridViewCell<TeamsData, TeamCellContext>
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle tg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image icon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image lockIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<TeamsData, global::UnityEngine.Transform> UpdateContextEvent;
    [global::UnityEngine.SerializeField]
    private GUIClassicTeam classicTeam;
    public GUIClassicTeam ClassicTeamComponent => null;

    public override void SetContext(TeamCellContext context)
    {
    }

    public override void UpdateContent(TeamsData itemData)
    {
    }
}
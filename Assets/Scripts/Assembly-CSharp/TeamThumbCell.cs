public class TeamThumbCell : global::FancyScrollView.FancyGridViewCell<TeamsData, TeamCellContext>
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image icon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject userFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text TeamName;
    public override void UpdateContent(TeamsData itemData)
    {
    }
}
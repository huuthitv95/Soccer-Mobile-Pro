public class TeamGridView : global::FancyScrollView.FancyGridView<TeamsData, TeamCellContext>
{
    private class CellGroup : global::FancyScrollView.FancyCellGroup<TeamsData, TeamCellContext>
    {
    }

    [global::UnityEngine.SerializeField]
    private global::FancyScrollView.FancyGridViewCell<TeamsData, TeamCellContext> cellPrefab;
    private int jumpIdx;
    public TeamCellContext context => null;

    protected override void SetupCellTemplate()
    {
    }

    public void UpdateSelection(int index)
    {
    }

    public void JumpTo(int index)
    {
    }

    private void LateUpdate()
    {
    }
}
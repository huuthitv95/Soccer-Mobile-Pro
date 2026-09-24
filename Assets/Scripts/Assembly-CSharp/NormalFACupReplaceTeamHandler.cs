public class NormalFACupReplaceTeamHandler : IFACupReplaceTeamHandler
{
    public void ReplaceTeam(global::SL.FACupGroupsData CupProto, global::Srv.WorldCupData archive, in FACup.FACupSharedData sharedData)
    {
    }

    public void ReplaceAll(global::System.Collections.Generic.List<int> teams, int[][] groups, global::System.Action<global::System.Collections.Generic.KeyValuePair<int, int>> cb)
    {
    }

    public global::System.Collections.Generic.List<int> Group2List(int[][] groups)
    {
        return null;
    }

    public void SaveGroup(int[][] groups, global::Srv.WorldCupData archive)
    {
    }

    void IFACupReplaceTeamHandler.ReplaceTeam(global::SL.FACupGroupsData cupProto, global::Srv.WorldCupData archive, in FACup.FACupSharedData sharedData)
    {
    }
}
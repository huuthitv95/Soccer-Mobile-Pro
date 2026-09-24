public class IAPPlayerRule
{
    public struct IAPPlayerTeamMapping
    {
        private global::System.Collections.Generic.Dictionary<int, int> mapping;
        public IAPPlayerTeamMapping(global::System.Collections.Generic.Dictionary<int, int> mapping)
        {
            this.mapping = null;
        }

        public int GetTeamId(int playerId)
        {
            return 0;
        }

        public void RecordMapping(int playerId, int teamId)
        {
        }
    }

    private IAPPlayerRule.IAPPlayerTeamMapping _FriendlyIAPPlayerTeamMapping;
    private global::System.Collections.Generic.List<int> _iapPlayerIds;
    private global::System.Collections.Generic.HashSet<int> _updatedIAPPlayerMatchManagers;
    public IAPPlayerRule.IAPPlayerTeamMapping FriendlyIAPPlayerTeamMapping => default;

    public static bool IsIAPPlayer(int playerId)
    {
        return false;
    }

    public void AddIAPPlayerId(int playerId)
    {
    }

    public global::System.Collections.Generic.IEnumerable<int> GetAllIAPPlayerIds()
    {
        return null;
    }

    public (int, int) GetIAPPlayerPurchaseStatus()
    {
        return default;
    }

    public ClubPlayer GetTempDisplayPlayer(int playerId)
    {
        return null;
    }

    public bool CheckPurchased(int playerId)
    {
        return false;
    }

    public void MarkAsPurchased(int playerId)
    {
    }

    public void CheckUpdateIAPPlayersFromContinueArchive(IMatchManager matchManager)
    {
    }

    public global::System.Collections.Generic.IEnumerable<int> GetAllPurchasedIAPPlayerIds()
    {
        return null;
    }

    public void AddIAPPlayerToUserTeam(TeamsData lastTeam, TeamsData userTeam, ClubPlayer player, IMatchManager matchManager)
    {
    }

    public void HandleIAPPlayerInit(IMatchManager matchManager, TeamsData userTeam)
    {
    }

    private void HandleIAPPlayerInit(IMatchManager matchManager, TeamsData userTeam, bool skipRegionalLeague)
    {
    }

    public void HandleIAPPlayerInit(RegionalLeague matchManager, TeamsData userTeam)
    {
    }
}
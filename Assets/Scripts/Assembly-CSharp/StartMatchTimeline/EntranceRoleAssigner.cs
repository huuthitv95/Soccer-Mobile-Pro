namespace StartMatchTimeline
{
    public static class EntranceRoleAssigner
    {
        public struct RoleInfo
        {
            public global::StartMatchTimeline.EntranceRole role;
            public int indexInGroup;
            public int groupSize;
        }

        private static global::System.Collections.Generic.Dictionary<int, global::StartMatchTimeline.EntranceRoleAssigner.RoleInfo> map;
        public static bool ShouldUseEntrance()
        {
            return false;
        }

        public static void Reset()
        {
        }

        public static bool TryGetRole(InGamePlayer p, out global::StartMatchTimeline.EntranceRoleAssigner.RoleInfo info)
        {
            info = default;
            return false;
        }

        public static void AssignFromSample(int userTeamId, int opponentTeamId, InGamePlayer[] userTeam, InGamePlayer[] opponentTeam, int userDatabaseId)
        {
        }

        private static void Shuffle<T>(global::System.Collections.Generic.List<T> list)
        {
        }
    }
}
public class Win_PlayerRank : global::Common.WindowBase
{
    private struct UserRankData
    {
        public int Rank;
        public int Value;
        public UserRankData(int rank, int value)
        {
            Rank = 0;
            Value = 0;
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topScorers;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topAssists;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform toggles;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topScorers_user;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topAssists_user;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topScorersContainer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform topAssistsContainer;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>>> goalDatas;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>>> assistDatas;
    private global::System.Collections.Generic.List<Win_PlayerRank.UserRankData> userGoalDatas;
    private global::System.Collections.Generic.List<Win_PlayerRank.UserRankData> userAssistDatas;
    private int currentIdx;
    private int userTeamId;
    private bool isPlayerCareer;
    private ClubPlayer userCareerPlayer;
    private global::UnityEngine.Vector2 topScorersContainerOffsetMin;
    private global::UnityEngine.Vector2 topAssistsContainerOffsetMin;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.HashSet<ClubPlayer>> leavePlayers;
    private global::System.Collections.Generic.List<IMatchManager> managers;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateList(int offset)
    {
    }

    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> GetDisplayRankData(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> rankData)
    {
        return null;
    }

    private void UpdateRankContainerLayout()
    {
    }

    private void UpdateRankContainerLayout(global::UnityEngine.RectTransform container, global::UnityEngine.Vector2 originOffsetMin, global::UnityEngine.RectTransform userRank)
    {
    }

    private void UpdateList(global::UnityEngine.Transform list, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>>> datas)
    {
    }

    private void UpdateUserRank(global::UnityEngine.Transform userLabel, global::System.Collections.Generic.List<Win_PlayerRank.UserRankData> datas)
    {
    }

    private Win_PlayerRank.UserRankData GetUserRankData(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> rankData)
    {
        return default;
    }

    private void FillRankItem(global::UnityEngine.Transform item, ClubPlayer player, string rankText, int value, bool hideTeam)
    {
    }

    private void UpdatePlayerIcon(global::UnityEngine.UI.RawImage playerIcon, ClubPlayer player)
    {
    }

    public override void OnClose()
    {
    }
}
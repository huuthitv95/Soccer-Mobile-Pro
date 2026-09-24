public class Win_TrophyInfo : global::Common.WindowBase
{
    public struct PlayerHornerData
    {
        public int id;
        public ClubPlayer player;
        public TeamsData team;
        public string name;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform yearsList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform detailList;
    public void Fill(global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Srv.CompetitionsHonorData>> detailData, string name, global::SL.GameData.CompetitionType type)
    {
    }

    public void FillPlayer(global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Srv.CompetitionsHonorData>> detailData, global::System.Collections.Generic.List<Win_TrophyInfo.PlayerHornerData> clubplayers, string name)
    {
    }

    public override void OnOpen(object parameter)
    {
    }
}
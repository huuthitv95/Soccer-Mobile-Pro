public class Win_CommonChooseTeam : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform proto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform TeamList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform TeamProto;
    private global::System.Action<TeamsData> onSelect;
    public override void OnOpen(object parameter)
    {
    }

    public Win_CommonChooseTeam Fill(global::System.Action<TeamsData> onSelect, global::System.Collections.ArrayList datas)
    {
        return null;
    }

    private void updateTeamsList(object matchManager)
    {
    }
}
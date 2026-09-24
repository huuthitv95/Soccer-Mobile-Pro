public class Win_Tactics : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform formationList;
    private TeamsData team;
    private global::System.Action OnFormationChanged;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Tactics Fill(TeamsData team, global::System.Action OnFormationChanged)
    {
        return null;
    }

    private void UpdateFormation()
    {
    }

    private void ChangeFormation(global::SL.FormationTemplate formation)
    {
    }

    private ClubPlayer FiltBestFit(global::System.Collections.Generic.List<ClubPlayer> list, FormationTool.UIRole role, global::System.Func<ClubPlayer, bool> condition = null)
    {
        return null;
    }

    private void RemoveFromCollections<Key, Value>(global::System.Collections.Generic.Dictionary<Key, global::System.Collections.Generic.List<Value>> map, Key key, Value value)
    {
    }

    public override void OnClose()
    {
    }
}
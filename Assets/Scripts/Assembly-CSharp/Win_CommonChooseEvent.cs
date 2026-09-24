public class Win_CommonChooseEvent : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform proto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text eventName;
    private global::System.Action<object> onSelect;
    public override void OnOpen(object parameter)
    {
    }

    public Win_CommonChooseEvent Fill(global::System.Action<object> onSelect, global::System.Collections.ArrayList datas, string eventName)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<global::SL.LeagueProto> GetLeagueEvents()
    {
        return null;
    }

    public static global::System.Collections.Generic.List<global::SL.CupRules> GetWorldCup()
    {
        return null;
    }

    public static global::System.Collections.Generic.List<global::SL.CupRules> GetCupEvents()
    {
        return null;
    }
}
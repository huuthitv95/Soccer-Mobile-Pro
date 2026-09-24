public class Win_PlayerContractRenewalPopup : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text tip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAll1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAll30;
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    private bool first;
    public override void OnOpen(object parameter)
    {
    }

    public Win_PlayerContractRenewalPopup Fill(RegionalLeague regionalLeague, global::System.Collections.Generic.List<ClubPlayer> players, string tipStr)
    {
        return null;
    }

    private void Renewal(ClubPlayer player, RegionalLeague regionalLeague, int count, int fee)
    {
    }
}
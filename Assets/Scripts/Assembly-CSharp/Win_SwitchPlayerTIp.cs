public class Win_SwitchPlayerTIp : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITeam team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage inIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage outIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text inName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text outName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image bar;
    private global::UnityEngine.Coroutine m_Coroutine;
    private global::System.Collections.Generic.Queue<(ClubPlayer, ClubPlayer, TeamsData)> queue;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void OnEnableAnim()
    {
    }

    private global::DG.Tweening.Tween OnDisableAnim()
    {
        return null;
    }

    private void CloseWindow()
    {
    }

    public Win_SwitchPlayerTIp ShowSwitchEvent(TeamsData homeTeam, TeamsData awayTeam, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer>> switchQueue, bool positionOffset)
    {
        return null;
    }

    private global::System.Collections.IEnumerator StartAnimation()
    {
        return null;
    }

    private void FillSwitchUI((ClubPlayer, ClubPlayer, TeamsData) data)
    {
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }
}
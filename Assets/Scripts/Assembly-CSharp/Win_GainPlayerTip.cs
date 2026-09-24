public class Win_GainPlayerTip : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIPlayer GUIPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Playables.PlayableDirector director;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image from;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image to;
    public override void OnOpen(object parameter)
    {
    }

    public void ShowTransferInfo(ClubPlayer clubPlayer, TeamsData user, TeamsData previous)
    {
    }
}
public class Win_PackOpeningView : global::Common.WindowBase
{
    public class OpenParameter
    {
        public ClubPlayer Player;
        public global::System.Action<ClubPlayer> OnComplete;
    }

    private const string RedrawRewardTunnel = "tour_event_redraw_replacement";
    [global::UnityEngine.SerializeField]
    private GUIPlayer playerCard;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo redrawReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animator animator;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCardBg[] playerCardBgs;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCardBg targetPlayerCardBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    private ClubPlayer currentPlayer;
    private global::System.Action<ClubPlayer> onComplete;
    private bool animationOver;
    public override void OnOpen(object parameter)
    {
    }

    private void OnConfirmBtnClicked()
    {
    }

    public override void OnClose()
    {
    }

    public void Fill(ClubPlayer player)
    {
    }

    private void ResetAnimation()
    {
    }

    private void Update()
    {
    }

    private void BindRedrawReward()
    {
    }

    private void OnRedrawVideoSucceed()
    {
    }

    private void RefreshRedrawRewardState()
    {
    }
}
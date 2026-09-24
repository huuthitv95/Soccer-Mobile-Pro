public class Win_NegotiationAnimation : global::Common.WindowBase
{
    public class Parameter
    {
        public global::FL.PlayerCareer PlayerCareer;
        public global::FL.PlayerCareerTransferNegotiationResult Result;
        public global::UnityEngine.GameObject PlayerModel;
        public global::System.Action<global::UnityEngine.GameObject> OnPlayerModelReleased;
    }

    private const string ContentsOpenState = "contents_open";
    private const string ContentsSuccessTextState = "contents_success_text";
    private const string ContentsSuccessState = "contents_success";
    private const string ContentsFailTextState = "contents_fail_text";
    private const string ContentsFailState = "contents_fail";
    private const float OpenDuration = 1f;
    private const float ResultTextDuration = 1f;
    private const float ResultDuration = 1.5f;
    private const float ResultEffectDurationScale = 0.55f;
    [global::UnityEngine.SerializeField]
    private GUITeam team;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animator contentsAnimator;
    private global::FL.PlayerCareer playerCareer;
    private global::FL.PlayerCareerTransferNegotiationResult result;
    private global::System.Action<global::UnityEngine.GameObject> onPlayerModelReleased;
    private global::DG.Tweening.Sequence animationSequence;
    private bool playerModelReleased;
    public const float ShortResultEffectDurationScale = 0.55f;
    public override void OnOpen(object parameter)
    {
    }

    public Win_NegotiationAnimation Fill(global::FL.PlayerCareer playerCareer, global::FL.PlayerCareerTransferNegotiationResult result, global::UnityEngine.GameObject playerModel, global::System.Action<global::UnityEngine.GameObject> onPlayerModelReleased)
    {
        return null;
    }

    private void FillTeam()
    {
    }

    private void ApplyPlayerModel(global::UnityEngine.GameObject playerModel)
    {
    }

    private void PlayNegotiationAnimation()
    {
    }

    private void PlayState(string stateName)
    {
    }

    private void ResetAnimator()
    {
    }

    private bool IsSucceeded()
    {
        return false;
    }

    private void StopAnimation(bool resetAnimator)
    {
    }

    public override void OnClose()
    {
    }

    private void ReleasePlayerModel()
    {
    }
}
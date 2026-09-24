public class Win_Tips : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private StringID text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject blueBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image defaultBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject blackBG;
    private const float DefaultFadeOutDelay = 2f;
    private const float FadeOutDuration = 0.5f;
    private global::DG.Tweening.Sequence fadeOutSequence;
    public override void OnOpen(object parameter)
    {
    }

    public void ShowBlueBG()
    {
    }

    public void ShowBlackBG()
    {
    }

    public void ResetFadeOutTime(float time)
    {
    }

    public override void OnClose()
    {
    }

    private void PlayFadeOut(float delay)
    {
    }

    private void StopFadeOut()
    {
    }
}
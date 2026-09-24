public class Win_Fade : global::Common.WindowBase
{
    private enum FadeType
    {
        FadeIn = 0,
        FadeOut = 1,
        FadeOutIn = 2
    }

    private global::UnityEngine.UI.Image image;
    private float duration;
    private float nowTime;
    private Win_Fade.FadeType fadeType;
    private bool pause;
    private global::System.Action OnStepChange;
    public override void OnOpen(object paramter)
    {
    }

    public Win_Fade Pause()
    {
        return null;
    }

    public Win_Fade Resume()
    {
        return null;
    }

    public void Update()
    {
    }

    private void FadeInUpdater(float normalizeTime)
    {
    }

    private void FadeOutUpdater(float normalizeTime)
    {
    }

    private void FadeOutInUpdater(float normalizeTime)
    {
    }

    public void FadeFadeOutIn(float duration, global::System.Action OnStepChange)
    {
    }

    public void FadeOut(float duration)
    {
    }

    public void FadeIn(float duration)
    {
    }
}
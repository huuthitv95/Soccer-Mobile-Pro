public class GUIPlayerCareerCoinNumber : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text Text;
    [global::UnityEngine.SerializeField]
    private EffectID effectID;
    private global::FL.PlayerCareer playerCareer;
    private global::UnityEngine.Coroutine coinAnimationCoroutine;
    private bool enableAnimation;
    private bool delayNextCurrencyChangeAnimation;
    private bool hasDelayedCurrencyChange;
    private int delayedCurrencyValue;
    private global::System.Action onAnimationFinish;
    private void Awake()
    {
    }

    private void Reset()
    {
    }

    public void Fill(global::FL.PlayerCareer playerCareer)
    {
    }

    public void Fill(RegionalLeague regionalLeague)
    {
    }

    private void UpdateTextAndDoAnimation(int previous, int current)
    {
    }

    private void UpdateText(int count)
    {
    }

    public void DelayNextCurrencyChangeAnimation()
    {
    }

    public void FinishDelayedCurrencyChangeAnimation(bool playAnimation)
    {
    }

    public void DisableAnimaiton()
    {
    }

    public void EnableAnimation()
    {
    }

    public void SetOnAnimationFinish(global::System.Action onAnimationFinish)
    {
    }

    public void SetCoinNumber(int count, bool useAnim = false, global::System.Action onAnimationFinish = null)
    {
    }

    private void OnDestroy()
    {
    }

    private void StopCoinAnimation()
    {
    }

    private void UnbindCurrencyEvent()
    {
    }
}
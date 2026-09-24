public class GUICoinNumber : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text Text;
    [global::UnityEngine.SerializeField]
    private EffectID coinEffectId;
    private OnCoinChangeEvent onCoinChange;
    private global::UnityEngine.Coroutine coinAnimationCoroutine;
    private bool enableAnimation;
    private global::System.Action OnAnimationFinish;
    public void Fill(FinancialManager financialManager)
    {
    }

    public void Fill(OnCoinChangeEvent onCoinChangeEvent, int coinNum)
    {
    }

    private void UpdateText(int count, int increment, int reason)
    {
    }

    private void UpdateTextAndDoAnimation(int count, int increment, int reason)
    {
    }

    public void DisableAnimaiton()
    {
    }

    public void EnableAnimation()
    {
    }

    public void SetOnAnimationFinish(global::System.Action OnAnimationFinish)
    {
    }

    public void SetCoinNumber(int count, bool useAnim = false, global::System.Action OnAnimationFinish = null)
    {
    }

    private void OnDestroy()
    {
    }
}
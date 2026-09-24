public class Win_NativeAD : global::UnityEngine.MonoBehaviour
{
    private static Win_NativeAD instance;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform adContainer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text countdownText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Canvas canvas;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image prograssBarFill;
    private void Awake()
    {
    }

    public void CloseAd()
    {
    }

    public static (global::UnityEngine.RectTransform, global::UnityEngine.Canvas) Show()
    {
        return default;
    }

    private void SetupCloseButton()
    {
    }

    private global::System.Collections.IEnumerator StartCountdown(int seconds)
    {
        return null;
    }
}
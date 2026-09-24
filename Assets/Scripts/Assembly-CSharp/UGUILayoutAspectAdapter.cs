[global::UnityEngine.DisallowMultipleComponent]
public class UGUILayoutAspectAdapter : global::UnityEngine.MonoBehaviour
{
    public enum AdaptMode
    {
        FitHeightByWidth = 0,
        FitWidthByHeight = 1,
        FitByMinScale = 2
    }

    [global::UnityEngine.SerializeField]
    private float initialWidth;
    [global::UnityEngine.SerializeField]
    private float initialHeight;
    [global::UnityEngine.SerializeField]
    private UGUILayoutAspectAdapter.AdaptMode adaptMode;
    private void Start()
    {
    }
}
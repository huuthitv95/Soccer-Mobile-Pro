public class MainViewPage : global::UnityEngine.MonoBehaviour
{
    internal static bool isInit;
    internal static bool backFromMatch;
    [global::UnityEngine.SerializeField]
    public UIAlphaFadeInTween bg;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Color bgMainColor;
    public virtual void Initialize()
    {
    }

    public virtual bool Show(MainView mainView)
    {
        return false;
    }
}
public class MainView26WorldCupBg : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct PageInfo
    {
        public MainView.MainViewPageType page;
        public int bgIdx;
    }

    [global::UnityEngine.SerializeField]
    private ColorPaletteImage bg;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<MainView26WorldCupBg.PageInfo> pages;
    private void Start()
    {
    }

    public void OnPageChange(MainView.MainViewPageType targetPage)
    {
    }
}
public class Win_TacticsStyle : global::Common.WindowBase
{
    [global::System.Serializable]
    private struct Items
    {
        public global::UnityEngine.UI.Button btn;
        public global::UnityEngine.GameObject mark;
        public int id;
        public global::UnityEngine.UI.Text text;
        public global::UnityEngine.UI.Image icon;
        public void MarkHighlight(int current, global::UnityEngine.Color[] iconColor, global::UnityEngine.Color[] textColor)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private Win_TacticsStyle.Items balance;
    [global::UnityEngine.SerializeField]
    private Win_TacticsStyle.Items counter;
    [global::UnityEngine.SerializeField]
    private Win_TacticsStyle.Items control;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color[] textColors;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color[] imageColors;
    private IMatchManager MatchManager;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(IMatchManager matchManager)
    {
    }

    private void OnClick(ref Win_TacticsStyle.Items item)
    {
    }

    private void UpdateMark(int current)
    {
    }

    public static global::EngineMessages.ControlStyle GetControlStyle(IMatchManager matchManager)
    {
        return global::EngineMessages.ControlStyle.Balance;
    }

    public static void CheckMask(global::UnityEngine.RectTransform btn, IMatchManager matchManager)
    {
    }

    public override void OnClose()
    {
    }
}
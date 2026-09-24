public class UIPlayingStyle : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> styleDotsLeftAttack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject selectedDotLeftAttack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject styleRecLeftAttack;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> styleDotsRightAttack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject selectedDotRightAttack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject styleRecRightAttack;
    private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> styleDots;
    private global::UnityEngine.GameObject styleRec;
    private global::UnityEngine.GameObject selectedDot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button styleButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSetting;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform popUp;
    public global::System.Action OnTipShown;
    public global::System.Action OnTipClosed;
    public bool openTipOnlyOnce;
    private int style;
    public global::System.Action<int> OnStyleChange;
    public global::System.Collections.Generic.List<string> playingStyleList;
    private global::System.Collections.Generic.Dictionary<int, int> UserStylePreferenceRecord;
    private bool leftAttack;
    private bool poped;
    private global::UnityEngine.Coroutine waitCloseCoroutine;
    private int clickStyleButtonCount;
    private global::System.DateTime lastOpenTime;
    private bool openTip;
    public bool openStyle { get; private set; }
    public int playingStyle => 0;

    public void SwitchAttack(bool left)
    {
    }

    private void Start()
    {
    }

    private void InitDots()
    {
    }

    public void showPopUpWithTextID(string stringID)
    {
    }

    public void OnStyleButtonClicked()
    {
    }

    public void OnStyleDotClick(int k)
    {
    }

    private void Update()
    {
    }

    private void UpdateStyleBlueRed()
    {
    }

    public void closeStyleAnim()
    {
    }

    private void RecordStyleChange(int style)
    {
    }

    public void OnMatchFinished()
    {
    }

    private void EventLogPlayingStyle()
    {
    }

    private void OpenWithoutAnim()
    {
    }

    private void CloseWithoutAnim()
    {
    }

    public void OpenTip()
    {
    }

    private void CloseTip()
    {
    }
}
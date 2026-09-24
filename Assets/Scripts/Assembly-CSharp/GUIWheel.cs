public class GUIWheel : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPrev;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<bool> nextEnabledEvent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<bool> prevEnabledEvent;
    [global::UnityEngine.SerializeField]
    private bool hideButtonsWhenDisabled;
    [global::UnityEngine.SerializeField]
    private GUIPageIndicator pageIndicator;
    [global::UnityEngine.SerializeField]
    private bool notifyWhenInit;
    private int count;
    private int current;
    private global::UnityEngine.Events.UnityAction<int> onSelect;
    private global::System.Func<int, string> getString;
    private bool loop;
    private bool enableWheel;
    public int CurrentIdx => 0;

    public void Init(int count, int current, global::UnityEngine.Events.UnityAction<int> onSelect, global::System.Func<int, string> getString, bool loop = true)
    {
    }

    private void OnInit()
    {
    }

    public void Init<T>(GameSettingManager.SimpleSettingOption<T> settingOption, bool loop)
    {
    }

    private void Start()
    {
    }

    private void Onupdate(int offset, bool notify = true)
    {
    }

    public void SetCurrent(int idx)
    {
    }

    private void SetCurrent(int idx, bool notify)
    {
    }

    private void CheckBtnState()
    {
    }

    public void EnableWheel(bool enable)
    {
    }

    public void SetPageIndicatorActive(bool active)
    {
    }
}
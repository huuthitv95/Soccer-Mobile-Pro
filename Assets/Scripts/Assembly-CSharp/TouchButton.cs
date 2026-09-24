public class TouchButton : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerExitHandler
{
    public enum ExitDirection
    {
        None = -1,
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }

    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject upArrow;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject downArrow;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject leftArrow;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject rightArrow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text displayText;
    public string text;
    public global::EngineMessages.InputFunction[] funcs;
    [global::System.NonSerialized]
    public global::EngineMessages.InputFunction keyDown;
    [global::System.NonSerialized]
    public global::EngineMessages.InputFunction keyExit;
    private bool _pressed;
    private bool enableExitKey;
    public global::System.Collections.Generic.Queue<global::EngineMessages.InputEvent> pendingEvents { get; set; }

    public bool EnableExitKey
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public void ResetDisplay()
    {
    }

    public static void ChangePressDefInputPlan(TouchButton btn)
    {
    }

    public static void ChangePressDefInputPlanTo2(TouchButton btn)
    {
    }

    public static void ChangeSprintDefInputPlan(TouchButton btn)
    {
    }

    private global::EngineMessages.InputFunction ExitKey(TouchButton.ExitDirection dir)
    {
        return global::EngineMessages.InputFunction.Up;
    }

    private void Start()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Update()
    {
    }

    public void InitButtonTexts(global::System.Func<string, string> stringLoader)
    {
    }

    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerPress()
    {
    }

    private void OnApplicationFocus(bool focus)
    {
    }
}
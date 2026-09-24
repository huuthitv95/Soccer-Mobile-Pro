public class VariableJoystick : Joystick
{
    [global::UnityEngine.SerializeField]
    private float moveThreshold;
    [global::UnityEngine.SerializeField]
    private JoystickType joystickType;
    private global::UnityEngine.Vector2 fixedPosition;
    public float MoveThreshold
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public void SetMode(JoystickType joystickType)
    {
    }

    protected override void Start()
    {
    }

    public override void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public override void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    protected override void HandleInput(float magnitude, global::UnityEngine.Vector2 normalised, global::UnityEngine.Vector2 radius, global::UnityEngine.Camera cam)
    {
    }
}
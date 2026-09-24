public class Joystick : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
    [global::UnityEngine.SerializeField]
    private float handleRange;
    [global::UnityEngine.SerializeField]
    private float deadZone;
    [global::UnityEngine.SerializeField]
    private AxisOptions axisOptions;
    [global::UnityEngine.SerializeField]
    private bool snapX;
    [global::UnityEngine.SerializeField]
    private bool snapY;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.RectTransform background;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform handle;
    private global::UnityEngine.RectTransform baseRect;
    protected global::UnityEngine.Canvas canvas;
    protected global::UnityEngine.Camera cam;
    private global::UnityEngine.Vector2 input;
    public float Horizontal => 0f;
    public float Vertical => 0f;
    public global::UnityEngine.Vector2 Direction => default;

    public float HandleRange
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public float DeadZone
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public AxisOptions AxisOptions
    {
        get
        {
            return AxisOptions.Both;
        }

        set
        {
        }
    }

    public bool SnapX
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool SnapY
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public global::UnityEngine.RectTransform Background => null;
    public global::UnityEngine.RectTransform Handle => null;

    protected virtual void Start()
    {
    }

    public virtual void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    protected virtual void HandleInput(float magnitude, global::UnityEngine.Vector2 normalised, global::UnityEngine.Vector2 radius, global::UnityEngine.Camera cam)
    {
    }

    private void FormatInput()
    {
    }

    private float SnapFloat(float value, AxisOptions snapAxis)
    {
        return 0f;
    }

    public virtual void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void OnDisable()
    {
    }

    protected virtual global::UnityEngine.Vector2 ScreenPointToAnchoredPosition(global::UnityEngine.Vector2 screenPosition)
    {
        return default;
    }

    protected global::UnityEngine.Vector2 ScreenPointToAnchoredPosition(global::UnityEngine.Vector2 screenPosition, global::UnityEngine.Camera camera)
    {
        return default;
    }
}
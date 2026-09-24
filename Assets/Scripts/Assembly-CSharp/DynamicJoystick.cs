public class DynamicJoystick : Joystick
{
    [global::UnityEngine.SerializeField]
    private float moveThreshold;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform MovableRect;
    private float MovableRadius;
    private bool HiddenByDefault;
    private global::UnityEngine.Vector2 StartPos;
    private global::UnityEngine.Vector2 origin;
    private global::UnityEngine.Vector3[] boundsCorners;
    private global::UnityEngine.Vector3[] BgCorners;
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

    protected override void Start()
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
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
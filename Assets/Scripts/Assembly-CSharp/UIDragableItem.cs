public class UIDragableItem : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
    [global::System.Serializable]
    public class InitDragProtoEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.Transform, UIDragableItem>
    {
    }

    [global::System.Serializable]
    public class UIDragableItemEvent : global::UnityEngine.Events.UnityEvent<UIDragableItem>
    {
    }

    [global::System.Serializable]
    public class OnCoveredEvent : global::UnityEngine.Events.UnityEvent<UIDragableItem, bool>
    {
    }

    [global::System.Serializable]
    public class OnChangePosEvent : global::UnityEngine.Events.UnityEvent<UIDragableItem, UIDragableItem>
    {
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect scrollRect;
    [global::UnityEngine.SerializeField]
    private UIDragableItemGroup group;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform dragProto;
    public UIDragableItem.InitDragProtoEvent OnDragProtoInit;
    public UIDragableItem.OnCoveredEvent OnCovered;
    public UIDragableItem.UIDragableItemEvent OnStartDragEvent;
    public UIDragableItem.UIDragableItemEvent OnEndDragEvent;
    public UIDragableItem.UIDragableItemEvent OnClick;
    private bool beginDrag;
    private bool beginScroll;
    private global::UnityEngine.Vector2 touchPos;
    private int LowSpeedFrameCounter;
    protected global::UnityEngine.Vector3 offset;
    private int pointerDownFrame;
    private global::UnityEngine.Vector3 tempScale;
    private bool pointerDown;
    public int DataFlag { get; set; }
    public bool CanDrag { get; set; }
    private bool Scorllable => false;

    void global::UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void OnBeginDragAction(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void DragUpdater(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    void global::UnityEngine.EventSystems.IDragHandler.OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void EndDragAction(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    void global::UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    void global::UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void Start()
    {
    }

    private void OnDestroy()
    {
    }

    private void Update()
    {
    }
}
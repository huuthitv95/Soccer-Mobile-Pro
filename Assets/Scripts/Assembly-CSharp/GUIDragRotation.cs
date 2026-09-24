public class GUIDragRotation : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject target;
    [global::UnityEngine.SerializeField]
    private bool xDrag;
    [global::UnityEngine.SerializeField]
    private bool yDrag;
    private global::UnityEngine.Vector2 lastPos;
    public void SetTarget(global::UnityEngine.GameObject target)
    {
    }

    public void SetAxis(bool xDrag, bool yDrag)
    {
    }

    public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    void global::UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }
}
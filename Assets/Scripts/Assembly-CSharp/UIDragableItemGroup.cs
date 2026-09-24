public class UIDragableItemGroup : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    public UIDragableItem.OnChangePosEvent OnChangePos;
    private global::System.Collections.Generic.List<UIDragableItem> group;
    private UIDragableItem covered;
    private UIDragableItem currentDrag;
    public void AddItem(UIDragableItem item)
    {
    }

    public void RemoveItem(UIDragableItem item)
    {
    }

    public void CheckCover(UIDragableItem src, global::UnityEngine.EventSystems.PointerEventData eventData, global::UnityEngine.Vector2 screenPos)
    {
    }

    public void OnStartDrag(UIDragableItem item)
    {
    }

    public void OnEndDrag(UIDragableItem src)
    {
    }
}
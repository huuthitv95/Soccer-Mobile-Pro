public class ScrollRectNested : global::UnityEngine.UI.ScrollRect
{
    private enum EScrollDir
    {
        Horizontal = 0,
        Vertical = 1
    }

    private ScrollRectNested m_SRNested;
    private ScrollRectNested.EScrollDir m_ScrollDir;
    private ScrollRectNested.EScrollDir m_CurScrollDir;
    protected override void Awake()
    {
    }

    public override void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public override void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public override void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public override void OnScroll(global::UnityEngine.EventSystems.PointerEventData data)
    {
    }
}
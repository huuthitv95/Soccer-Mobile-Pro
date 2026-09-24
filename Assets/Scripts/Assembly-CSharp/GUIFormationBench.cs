public class GUIFormationBench : GUIFormationItem, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect ScrollRect;
    public bool IsLeft;
    private bool beginDrag;
    private bool beginScroll;
    private global::UnityEngine.Vector2 touchPos;
    private int LowSpeedFrameCounter;
    private bool pointerDown;
    private int pointerDownFrame;
    private global::UnityEngine.Vector3 tempScale;
    public override void OnSelect(bool select)
    {
    }

    public override void UpdateOriginalFormationUI()
    {
    }

    public override void OnCovered(bool covered, FormationTool.UIPosition position)
    {
    }

    public override void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public override void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void Update()
    {
    }

    public override void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    protected override bool CheckSwitchable()
    {
        return false;
    }
}
public class UIEventPassThrough : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
    [global::UnityEngine.SerializeField]
    private bool passThrough;
    [global::UnityEngine.SerializeField]
    private bool passOnlyFirst;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent onPointerDown;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent onPointerUp;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent onPointerClick;
    private static global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> results;
    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void PassEvent<T>(global::UnityEngine.EventSystems.PointerEventData data, global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> function)
        where T : global::UnityEngine.EventSystems.IEventSystemHandler
    {
    }
}
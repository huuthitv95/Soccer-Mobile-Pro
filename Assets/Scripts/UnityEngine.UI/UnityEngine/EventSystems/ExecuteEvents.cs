namespace UnityEngine.EventSystems
{
    public static class ExecuteEvents
    {
        public delegate void EventFunction<T1>(T1 handler, global::UnityEngine.EventSystems.BaseEventData eventData);
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDragHandler> s_DragHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDropHandler> s_DropHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;
        private static readonly global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;
        private static readonly global::UnityEngine.UI.ObjectPool<global::System.Collections.Generic.List<global::UnityEngine.EventSystems.IEventSystemHandler>> s_HandlerListPool;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.Transform> s_InternalTransformList;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerEnterHandler> pointerEnterHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerExitHandler> pointerExitHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerDownHandler> pointerDownHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerUpHandler> pointerUpHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IPointerClickHandler> pointerClickHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IInitializePotentialDragHandler> initializePotentialDrag => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IBeginDragHandler> beginDragHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDragHandler> dragHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IEndDragHandler> endDragHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDropHandler> dropHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IScrollHandler> scrollHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IUpdateSelectedHandler> updateSelectedHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ISelectHandler> selectHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IDeselectHandler> deselectHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.IMoveHandler> moveHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ISubmitHandler> submitHandler => null;
        public static global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<global::UnityEngine.EventSystems.ICancelHandler> cancelHandler => null;

        public static T ValidateEventData<T>(global::UnityEngine.EventSystems.BaseEventData data)
            where T : class
        {
            return null;
        }

        private static void Execute(global::UnityEngine.EventSystems.IPointerEnterHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IPointerExitHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IPointerDownHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IPointerUpHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IPointerClickHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IInitializePotentialDragHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IBeginDragHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IDragHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IEndDragHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IDropHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IScrollHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IUpdateSelectedHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.ISelectHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IDeselectHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.IMoveHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.ISubmitHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void Execute(global::UnityEngine.EventSystems.ICancelHandler handler, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private static void GetEventChain(global::UnityEngine.GameObject root, global::System.Collections.Generic.IList<global::UnityEngine.Transform> eventChain)
        {
        }

        public static bool Execute<T>(global::UnityEngine.GameObject target, global::UnityEngine.EventSystems.BaseEventData eventData, global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
            return false;
        }

        public static global::UnityEngine.GameObject ExecuteHierarchy<T>(global::UnityEngine.GameObject root, global::UnityEngine.EventSystems.BaseEventData eventData, global::UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
            return null;
        }

        private static bool ShouldSendToComponent<T>(global::UnityEngine.Component component)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
            return false;
        }

        private static void GetEventList<T>(global::UnityEngine.GameObject go, global::System.Collections.Generic.IList<global::UnityEngine.EventSystems.IEventSystemHandler> results)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
        }

        public static bool CanHandleEvent<T>(global::UnityEngine.GameObject go)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
            return false;
        }

        public static global::UnityEngine.GameObject GetEventHandler<T>(global::UnityEngine.GameObject root)
            where T : global::UnityEngine.EventSystems.IEventSystemHandler
        {
            return null;
        }
    }
}
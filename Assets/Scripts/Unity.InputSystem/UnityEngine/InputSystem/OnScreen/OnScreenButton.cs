namespace UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : global::UnityEngine.InputSystem.OnScreen.OnScreenControl, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.SerializeField]
        private string m_ControlPath;
        protected override string controlPathInternal
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}
namespace UnityEngine.UI.Extensions
{
    public class UISelectableExtension : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        [global::System.Serializable]
        public class UIButtonEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.EventSystems.PointerEventData.InputButton>
        {
        }

        public global::UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonPress;
        public global::UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonRelease;
        public global::UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonHeld;
        private bool _pressed;
        private global::UnityEngine.EventSystems.PointerEventData _heldEventData;
        void global::UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void Update()
        {
        }

        public void TestClicked()
        {
        }

        public void TestPressed()
        {
        }

        public void TestReleased()
        {
        }

        public void TestHold()
        {
        }

        private void OnDisable()
        {
        }
    }
}
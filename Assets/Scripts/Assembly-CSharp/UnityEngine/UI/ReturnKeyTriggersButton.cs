namespace UnityEngine.UI
{
    public class ReturnKeyTriggersButton : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.EventSystems.IEventSystemHandler
    {
        private global::UnityEngine.EventSystems.EventSystem _system;
        public global::UnityEngine.UI.Button button;
        private bool highlight;
        public float highlightDuration;
        private void Start()
        {
        }

        private void RemoveHighlight()
        {
        }

        public void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }
    }
}
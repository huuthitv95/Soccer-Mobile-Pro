namespace UnityEngine.UI.Extensions
{
    public class SelectableScaler : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        public global::UnityEngine.AnimationCurve animCurve;
        public float speed;
        private global::UnityEngine.Vector3 initScale;
        public global::UnityEngine.Transform target;
        private global::UnityEngine.UI.Selectable selectable;
        public global::UnityEngine.UI.Selectable Target => null;

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private global::System.Collections.IEnumerator ScaleIN()
        {
            return null;
        }

        private global::System.Collections.IEnumerator ScaleOUT()
        {
            return null;
        }
    }
}
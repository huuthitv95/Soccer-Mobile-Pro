namespace UnityEngine.UI.Extensions
{
    public class UI_Knob : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        public enum Direction
        {
            CW = 0,
            CCW = 1
        }

        public global::UnityEngine.UI.Extensions.UI_Knob.Direction direction;
        [global::UnityEngine.HideInInspector]
        public float knobValue;
        public float maxValue;
        public int loops;
        public bool clampOutput01;
        public bool snapToPosition;
        public int snapStepsPerLoop;
        [global::UnityEngine.Space]
        public global::UnityEngine.UI.Extensions.KnobFloatValueEvent OnValueChanged;
        private float _currentLoops;
        private float _previousValue;
        private float _initAngle;
        private float _currentAngle;
        private global::UnityEngine.Vector2 _currentVector;
        private global::UnityEngine.Quaternion _initRotation;
        private bool _canDrag;
        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void SetInitPointerData(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void SnapToPosition(ref float knobValue)
        {
        }

        private void InvokeEvents(float value)
        {
        }
    }
}
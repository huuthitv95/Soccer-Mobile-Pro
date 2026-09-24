namespace LeTai.TrueShadow.Demo
{
    public class DirectionalKnob : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler
    {
        public global::UnityEngine.Transform knobGraphic;
        public float min;
        public float max;
        public float value;
        public global::LeTai.TrueShadow.Demo.KnobValueChangedEvent knobValueChanged;
        private global::UnityEngine.RectTransform rectTransform;
        private global::UnityEngine.Vector2 zeroVector;
        protected override void Start()
        {
        }

        public void SetValue(float newValue)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}
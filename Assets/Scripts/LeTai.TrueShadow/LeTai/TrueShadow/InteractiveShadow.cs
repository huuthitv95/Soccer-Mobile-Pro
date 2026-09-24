namespace LeTai.TrueShadow
{
    public class InteractiveShadow : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        public float smoothTime;
        public bool autoDeselect;
        public float selectedSize;
        public float hoverSize;
        public float clickedSize;
        public float selectedDistance;
        public float hoverDistance;
        public float clickedDistance;
        public global::UnityEngine.Color selectedColor;
        public global::UnityEngine.Color hoverColor;
        public global::UnityEngine.Color clickedColor;
        private float normalSize;
        private float normalDistance;
        private global::UnityEngine.Color normalColor;
        private bool normalStateAcquired;
        private bool isSelected;
        private bool isHovered;
        private bool isClicked;
        private global::LeTai.TrueShadow.TrueShadow shadow;
        private global::UnityEngine.UI.Selectable selectable;
        private float targetSize;
        private float targetDistance;
        private global::UnityEngine.Color targetColor;
        private static readonly global::UnityEngine.Color FADED_COLOR;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> raycastResults;
        private float currentSizeVelocity;
        private float currentDistanceVelocity;
        private float currentColorRVelocity;
        private float currentColorGVelocity;
        private float currentColorBVelocity;
        private float currentColorAVelocity;
        private void OnEnable()
        {
        }

        private global::LeTai.TrueShadow.TrueShadow FindTrueShadow()
        {
            return null;
        }

        private void OnStateChange()
        {
        }

        private void Update()
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private bool IsOverGameObject(global::UnityEngine.Vector2 position)
        {
            return false;
        }
    }
}
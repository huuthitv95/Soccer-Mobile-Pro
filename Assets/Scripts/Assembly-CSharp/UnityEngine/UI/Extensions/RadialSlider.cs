namespace UnityEngine.UI.Extensions
{
    public class RadialSlider : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        [global::System.Serializable]
        public class RadialSliderValueChangedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        [global::System.Serializable]
        public class RadialSliderTextValueChangedEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        private bool isPointerDown;
        private bool isPointerReleased;
        private bool lerpInProgress;
        private global::UnityEngine.Vector2 m_localPos;
        private float m_targetAngle;
        private float m_lerpTargetAngle;
        private float m_startAngle;
        private float m_currentLerpTime;
        private float m_lerpTime;
        private global::UnityEngine.Camera m_eventCamera;
        private global::UnityEngine.UI.Image m_image;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_startColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_endColor;
        [global::UnityEngine.SerializeField]
        private bool m_lerpToTarget;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationCurve m_lerpCurve;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.RadialSlider.RadialSliderValueChangedEvent _onValueChanged;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.RadialSlider.RadialSliderTextValueChangedEvent _onTextValueChanged;
        public float Angle
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float Value
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color EndColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color StartColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool LerpToTarget
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.AnimationCurve LerpCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool LerpInProgress => false;
        public global::UnityEngine.UI.Image RadialImage => null;

        public global::UnityEngine.UI.Extensions.RadialSlider.RadialSliderValueChangedEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.RadialSlider.RadialSliderTextValueChangedEvent onTextValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private void Awake()
        {
        }

        private void Update()
        {
        }

        private void StartLerp(float targetAngle)
        {
        }

        private float GetAngleFromMousePoint()
        {
            return 0f;
        }

        private void UpdateRadialImage(float targetAngle)
        {
        }

        private void NotifyValueChanged()
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}
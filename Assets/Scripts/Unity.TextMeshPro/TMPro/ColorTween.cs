namespace TMPro
{
    internal struct ColorTween : global::TMPro.ITweenValue
    {
        public enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2
        }

        public class ColorTweenCallback : global::UnityEngine.Events.UnityEvent<global::UnityEngine.Color>
        {
        }

        private global::TMPro.ColorTween.ColorTweenCallback m_Target;
        private global::UnityEngine.Color m_StartColor;
        private global::UnityEngine.Color m_TargetColor;
        private global::TMPro.ColorTween.ColorTweenMode m_TweenMode;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        public global::UnityEngine.Color startColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color targetColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::TMPro.ColorTween.ColorTweenMode tweenMode
        {
            get
            {
                return global::TMPro.ColorTween.ColorTweenMode.All;
            }

            set
            {
            }
        }

        public float duration
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool ignoreTimeScale
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public void TweenValue(float floatPercentage)
        {
        }

        public void AddOnChangedCallback(global::UnityEngine.Events.UnityAction<global::UnityEngine.Color> callback)
        {
        }

        public bool GetIgnoreTimescale()
        {
            return false;
        }

        public float GetDuration()
        {
            return 0f;
        }

        public bool ValidTarget()
        {
            return false;
        }
    }
}
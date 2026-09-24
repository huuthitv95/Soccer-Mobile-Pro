namespace UnityEngine.UI.CoroutineTween
{
    internal struct FloatTween : global::UnityEngine.UI.CoroutineTween.ITweenValue
    {
        public class FloatTweenCallback : global::UnityEngine.Events.UnityEvent<float>
        {
        }

        private global::UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
        private float m_StartValue;
        private float m_TargetValue;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        public float startValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float targetValue
        {
            get
            {
                return 0f;
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

        public void AddOnChangedCallback(global::UnityEngine.Events.UnityAction<float> callback)
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
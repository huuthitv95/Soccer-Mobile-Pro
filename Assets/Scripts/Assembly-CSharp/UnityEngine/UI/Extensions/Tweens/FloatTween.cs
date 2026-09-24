namespace UnityEngine.UI.Extensions.Tweens
{
    public struct FloatTween : global::UnityEngine.UI.Extensions.Tweens.ITweenValue
    {
        public class FloatTweenCallback : global::UnityEngine.Events.UnityEvent<float>
        {
        }

        public class FloatFinishCallback : global::UnityEngine.Events.UnityEvent
        {
        }

        private float m_StartFloat;
        private float m_TargetFloat;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        private global::UnityEngine.UI.Extensions.Tweens.FloatTween.FloatTweenCallback m_Target;
        private global::UnityEngine.UI.Extensions.Tweens.FloatTween.FloatFinishCallback m_Finish;
        public float startFloat
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float targetFloat
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

        public void AddOnFinishCallback(global::UnityEngine.Events.UnityAction callback)
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

        public void Finished()
        {
        }
    }
}
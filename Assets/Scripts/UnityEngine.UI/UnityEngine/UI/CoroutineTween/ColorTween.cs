// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using System.Collections;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{

    // Color tween class, receives the
    // TweenValue callback and then sets
    // the value on the target.
    internal struct ColorTween : ITweenValue
    {
        public enum ColorTweenMode
        {
            All,
            RGB,
            Alpha
        }

        public class ColorTweenCallback : UnityEvent<Color> {}

        private ColorTweenCallback m_Target;
        private Color m_StartColor;
        private Color m_TargetColor;
        private ColorTweenMode m_TweenMode;

        private float m_Duration;
        private bool m_IgnoreTimeScale;

        public Color startColor
        {
            get { return m_StartColor; }
            set { m_StartColor = value; }
        }

        public Color targetColor
        {
            get { return m_TargetColor; }
            set { m_TargetColor = value; }
        }

        public ColorTweenMode tweenMode
        {
            get { return m_TweenMode; }
            set { m_TweenMode = value; }
        }

        public float duration
        {
            get { return m_Duration; }
            set { m_Duration = value; }
        }

        public bool ignoreTimeScale
        {
            get { return m_IgnoreTimeScale; }
            set { m_IgnoreTimeScale = value; }
        }

        public void TweenValue(float floatPercentage)
        {
            if (!ValidTarget())
                return;

            var newColor = Color.Lerp(m_StartColor, m_TargetColor, floatPercentage);

            if (m_TweenMode == ColorTweenMode.Alpha)
            {
                newColor.r = m_StartColor.r;
                newColor.g = m_StartColor.g;
                newColor.b = m_StartColor.b;
            }
            else if (m_TweenMode == ColorTweenMode.RGB)
            {
                newColor.a = m_StartColor.a;
            }
            m_Target.Invoke(newColor);
        }

        public void AddOnChangedCallback(UnityAction<Color> callback)
        {
            if (m_Target == null)
                m_Target = new ColorTweenCallback();

            m_Target.AddListener(callback);
        }

        public bool GetIgnoreTimescale()
        {
            return m_IgnoreTimeScale;
        }

        public float GetDuration()
        {
            return m_Duration;
        }

        public bool ValidTarget()
        {
            return m_Target != null;
        }
    }
}

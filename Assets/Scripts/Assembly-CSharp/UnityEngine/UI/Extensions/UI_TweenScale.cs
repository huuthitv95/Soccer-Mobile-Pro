namespace UnityEngine.UI.Extensions
{
    public class UI_TweenScale : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.AnimationCurve animCurve;
        public float speed;
        public bool isLoop;
        public bool playAtAwake;
        [global::UnityEngine.Space]
        public bool isUniform;
        public global::UnityEngine.AnimationCurve animCurveY;
        private global::UnityEngine.Vector3 initScale;
        private global::UnityEngine.Transform myTransform;
        private global::UnityEngine.Vector3 newScale;
        private void Awake()
        {
        }

        public void Play()
        {
        }

        private global::System.Collections.IEnumerator Tween()
        {
            return null;
        }

        public void ResetTween()
        {
        }
    }
}
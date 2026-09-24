namespace Game.UI.Tween
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UISlideFadeInTween : global::UnityEngine.MonoBehaviour
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform targetRect;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.CanvasGroup targetCanvasGroup;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 startPosition;
        [global::UnityEngine.SerializeField]
        private float startAlpha;
        [global::UnityEngine.SerializeField]
        private float endAlpha;
        [global::UnityEngine.SerializeField]
        private float startDelay;
        [global::UnityEngine.SerializeField]
        private float duration;
        [global::UnityEngine.SerializeField]
        private global::DG.Tweening.Ease ease;
        [global::UnityEngine.SerializeField]
        private bool useUnscaledTime;
        [global::UnityEngine.SerializeField]
        private bool playOnEnable;
        [global::UnityEngine.SerializeField]
        private bool restoreEndStateOnDisable;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Events.UnityEvent onComplete;
        private global::DG.Tweening.Sequence sequence;
        private global::UnityEngine.Vector2 endPosition;
        private bool hasEndPosition;
        private void Reset()
        {
        }

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }

        public void CaptureCurrentAsEndPosition()
        {
        }

        public void ApplyEndState()
        {
        }

        private void Replay()
        {
        }

        private void CacheTargets()
        {
        }

        private void OnValidate()
        {
        }
    }
}
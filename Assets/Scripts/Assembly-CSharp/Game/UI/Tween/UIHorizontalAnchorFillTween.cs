namespace Game.UI.Tween
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIHorizontalAnchorFillTween : global::UnityEngine.MonoBehaviour, global::Game.UI.Tween.ISequentialTweenItem
    {
        public global::UnityEngine.RectTransform target;
        public float fromX;
        public float midX;
        public float toX;
        public float midTime;
        public float endTime;
        public float timeScale;
        public global::DG.Tweening.Ease firstEase;
        public global::DG.Tweening.Ease secondEase;
        public bool playOnEnable;
        public bool loop;
        public global::DG.Tweening.LoopType loopType;
        public bool useCurrentAsFrom;
        public float startDelay;
        public global::Game.UI.Tween.UISequentialTweenController controller;
        private global::DG.Tweening.Sequence _seq;
        private float _originalAnchorX;
        public global::UnityEngine.RectTransform RootRect => null;

        public float StartDelay
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::Game.UI.Tween.SequentialTweenItemType ItemType => global::Game.UI.Tween.SequentialTweenItemType.Unknown;
        public bool IsActiveAndEnabled => false;

        private void Reset()
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
    }
}
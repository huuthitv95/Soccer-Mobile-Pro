namespace Game.UI.Tween
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIPopGlowTween : global::UnityEngine.MonoBehaviour, global::Game.UI.Tween.ISequentialTweenItem
    {
        public global::UnityEngine.RectTransform root;
        public global::UnityEngine.CanvasGroup itemCanvasGroup;
        public global::UnityEngine.UI.Graphic glowGraphic;
        public bool playOnEnable;
        public bool loop;
        public global::DG.Tweening.LoopType loopType;
        public float startDelay;
        public float timeScale;
        public bool enableScale;
        public bool useCurrentScaleAsStart;
        public global::UnityEngine.Vector3 scaleStart;
        public float scaleDipValue;
        public float scaleHoldTime;
        public float scaleDipTime;
        public float scaleEndTime;
        public global::DG.Tweening.Ease scaleDipEase;
        public global::DG.Tweening.Ease scaleRecoverEase;
        public global::DG.Tweening.Ease itemFadeEase;
        public global::UnityEngine.AnimationCurve glowCustomCurve;
        public global::UnityEngine.Events.UnityEvent onComplete;
        public global::Game.UI.Tween.UISequentialTweenController controller;
        public bool useGlowPool;
        public int prewarmGlowCount;
        public string glowName;
        public bool followRotation;
        public bool followScale;
        public global::UnityEngine.Vector2 extraPadding;
        public bool useBoundingBoxWhenRotated;
        public bool syncGlowAfterLayout;
        public int maxLayoutSyncFrames;
        private int _pendingLayoutFrames;
        private bool _requestLateRealignOnce;
        private global::DG.Tweening.Sequence _seq;
        private global::DG.Tweening.Tween _itemFadeTween;
        private global::DG.Tweening.Tween _glowTween;
        private bool _autoGlowCreated;
        private bool _usingPooledGlow;
        private global::UnityEngine.GameObject _glowGO;
        private const float RawTotalTime = 0.3166667f;
        private static readonly global::System.Collections.Generic.Stack<global::UnityEngine.GameObject> s_GlowPool;
        private bool isBreakingSequence;
        private static readonly global::UnityEngine.Vector3[] s_WorldCorners;
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

        bool global::Game.UI.Tween.ISequentialTweenItem.IsActiveAndEnabled => false;

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

        private void KillSequence()
        {
        }

        private void PrepareGlow()
        {
        }

        private void AcquireGlow(global::UnityEngine.Transform parent)
        {
        }

        private void EnsurePrewarm()
        {
        }

        private void AlignGlow()
        {
        }

        private void SetGlowAlpha(float a)
        {
        }

        private void HideAutoGlow()
        {
        }

        private void ScheduleLayoutSync()
        {
        }

        private void LateUpdate()
        {
        }

        private void Update()
        {
        }
    }
}
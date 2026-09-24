namespace Game.UI.Tween
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIAnimatorSequentialTween : global::UnityEngine.MonoBehaviour, global::Game.UI.Tween.ISequentialTweenItem
    {
        public global::UnityEngine.RectTransform root;
        public global::UnityEngine.Animator animator;
        public bool playOnEnable;
        [global::UnityEngine.SerializeField]
        private float startDelay;
        public bool loop;
        public global::DG.Tweening.LoopType loopType;
        public float timeScale;
        public string triggerName;
        public string stateName;
        public float crossFadeDuration;
        public int layer;
        public bool rewindOnPlay;
        public bool resetTriggerOnStop;
        public bool goIdleOnStop;
        public string idleStateName;
        public global::Game.UI.Tween.UISequentialTweenController controller;
        private global::DG.Tweening.Sequence _delaySeq;
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

        public bool IsActiveAndEnabled => false;
        public global::Game.UI.Tween.SequentialTweenItemType ItemType => global::Game.UI.Tween.SequentialTweenItemType.Unknown;

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

        private void KillDelay()
        {
        }
    }
}
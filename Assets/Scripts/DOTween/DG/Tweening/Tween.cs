namespace DG.Tweening
{
    public abstract class Tween : global::DG.Tweening.Core.ABSSequentiable
    {
        public float timeScale;
        public bool isBackwards;
        public object id;
        public string stringId;
        public int intId;
        public object target;
        internal global::DG.Tweening.UpdateType updateType;
        internal bool isIndependentUpdate;
        public global::DG.Tweening.TweenCallback onPlay;
        public global::DG.Tweening.TweenCallback onPause;
        public global::DG.Tweening.TweenCallback onRewind;
        public global::DG.Tweening.TweenCallback onUpdate;
        public global::DG.Tweening.TweenCallback onStepComplete;
        public global::DG.Tweening.TweenCallback onComplete;
        public global::DG.Tweening.TweenCallback onKill;
        public global::DG.Tweening.TweenCallback<int> onWaypointChange;
        internal bool isFrom;
        internal bool isBlendable;
        internal bool isRecyclable;
        internal bool isSpeedBased;
        internal bool autoKill;
        internal float duration;
        internal int loops;
        internal global::DG.Tweening.LoopType loopType;
        internal float delay;
        internal global::DG.Tweening.Ease easeType;
        internal global::DG.Tweening.EaseFunction customEase;
        public float easeOvershootOrAmplitude;
        public float easePeriod;
        public string debugTargetId;
        internal global::System.Type typeofT1;
        internal global::System.Type typeofT2;
        internal global::System.Type typeofTPlugOptions;
        internal bool isSequenced;
        internal global::DG.Tweening.Sequence sequenceParent;
        internal int activeId;
        internal global::DG.Tweening.Core.Enums.SpecialStartupMode specialStartupMode;
        internal bool creationLocked;
        internal bool startupDone;
        internal float fullDuration;
        internal int completedLoops;
        internal bool isPlaying;
        internal bool isComplete;
        internal float elapsedDelay;
        internal bool delayComplete;
        internal int miscInt;
        public bool isRelative { get; internal set; }
        public bool active { get; internal set; }
        public bool playedOnce { get; private set; }
        public float position { get; internal set; }

        internal virtual void Reset()
        {
        }

        internal virtual float UpdateDelay(float elapsed)
        {
            return 0f;
        }

        internal abstract bool Startup();
        internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, global::DG.Tweening.Core.Enums.UpdateMode updateMode, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        internal static bool DoGoto(global::DG.Tweening.Tween t, float toPosition, int toCompletedLoops, global::DG.Tweening.Core.Enums.UpdateMode updateMode)
        {
            return false;
        }

        internal static bool OnTweenCallback(global::DG.Tweening.TweenCallback callback, global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool OnTweenCallback<T>(global::DG.Tweening.TweenCallback<T> callback, global::DG.Tweening.Tween t, T param)
        {
            return false;
        }
    }
}
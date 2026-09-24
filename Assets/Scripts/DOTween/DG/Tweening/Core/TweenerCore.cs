namespace DG.Tweening.Core
{
    public class TweenerCore<T1, T2, TPlugOptions> : global::DG.Tweening.Tweener where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
    {
        public T2 startValue;
        public T2 endValue;
        public T2 changeValue;
        public TPlugOptions plugOptions;
        public global::DG.Tweening.Core.DOGetter<T1> getter;
        public global::DG.Tweening.Core.DOSetter<T1> setter;
        internal global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
        internal TweenerCore()
        {
        }

        internal global::DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately)
        {
            return null;
        }

        internal sealed override void Reset()
        {
        }

        internal override float UpdateDelay(float elapsed)
        {
            return 0f;
        }

        internal override bool Startup()
        {
            return false;
        }

        internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, global::DG.Tweening.Core.Enums.UpdateMode updateMode, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
            return false;
        }
    }
}
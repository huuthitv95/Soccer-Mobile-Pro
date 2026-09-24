namespace DG.Tweening.Plugins
{
    public class LongPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<long, long, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<long, long, global::DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately)
        {
        }

        public override long ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<long, long, global::DG.Tweening.Plugins.Options.NoOptions> t, long value)
        {
            return 0L;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<long, long, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<long, long, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<long> getter, global::DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
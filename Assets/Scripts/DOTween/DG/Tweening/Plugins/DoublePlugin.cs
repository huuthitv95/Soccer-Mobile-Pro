namespace DG.Tweening.Plugins
{
    public class DoublePlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<double, double, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<double, double, global::DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately)
        {
        }

        public override double ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<double, double, global::DG.Tweening.Plugins.Options.NoOptions> t, double value)
        {
            return 0.0;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<double, double, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<double, double, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<double> getter, global::DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
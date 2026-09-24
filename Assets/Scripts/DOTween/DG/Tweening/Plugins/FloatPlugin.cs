namespace DG.Tweening.Plugins
{
    public class FloatPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, global::DG.Tweening.Plugins.Options.FloatOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately)
        {
        }

        public override float ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t, float value)
        {
            return 0f;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.FloatOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<float> getter, global::DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
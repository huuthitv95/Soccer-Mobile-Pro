namespace DG.Tweening.Plugins
{
    public class IntPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<int, int, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<int, int, global::DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately)
        {
        }

        public override int ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<int, int, global::DG.Tweening.Plugins.Options.NoOptions> t, int value)
        {
            return 0;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<int, int, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<int, int, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<int> getter, global::DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
namespace DG.Tweening.Plugins
{
    public class UlongPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately)
        {
        }

        public override ulong ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions> t, ulong value)
        {
            return 0uL;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<ulong, ulong, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<ulong> getter, global::DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
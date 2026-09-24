namespace DG.Tweening.Plugins
{
    public class UintPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately)
        {
        }

        public override uint ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions> t, uint value)
        {
            return 0u;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<uint, uint, global::DG.Tweening.Plugins.Options.UintOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.UintOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<uint> getter, global::DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
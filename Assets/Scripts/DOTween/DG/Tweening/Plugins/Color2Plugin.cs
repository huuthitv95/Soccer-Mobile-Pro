namespace DG.Tweening.Plugins
{
    internal class Color2Plugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions> t, global::DG.Tweening.Color2 fromValue, bool setImmediately)
        {
        }

        public override global::DG.Tweening.Color2 ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions> t, global::DG.Tweening.Color2 value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::DG.Tweening.Color2, global::DG.Tweening.Color2, global::DG.Tweening.Plugins.Options.ColorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, global::DG.Tweening.Color2 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.ColorOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::DG.Tweening.Color2> getter, global::DG.Tweening.Core.DOSetter<global::DG.Tweening.Color2> setter, float elapsed, global::DG.Tweening.Color2 startValue, global::DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
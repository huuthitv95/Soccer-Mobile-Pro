namespace DG.Tweening.Plugins
{
    public class RectOffsetPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        private static global::UnityEngine.RectOffset _r;
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions> t, global::UnityEngine.RectOffset fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.RectOffset ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions> t, global::UnityEngine.RectOffset value)
        {
            return null;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.RectOffset, global::UnityEngine.RectOffset, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, global::UnityEngine.RectOffset changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.RectOffset> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.RectOffset> setter, float elapsed, global::UnityEngine.RectOffset startValue, global::UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
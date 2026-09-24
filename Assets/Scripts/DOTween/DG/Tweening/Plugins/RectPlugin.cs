namespace DG.Tweening.Plugins
{
    public class RectPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions> t, global::UnityEngine.Rect fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Rect ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions> t, global::UnityEngine.Rect value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Rect, global::UnityEngine.Rect, global::DG.Tweening.Plugins.Options.RectOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, global::UnityEngine.Rect changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.RectOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Rect> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Rect> setter, float elapsed, global::UnityEngine.Rect startValue, global::UnityEngine.Rect changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
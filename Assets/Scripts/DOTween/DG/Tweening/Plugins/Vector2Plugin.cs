namespace DG.Tweening.Plugins
{
    public class Vector2Plugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::UnityEngine.Vector2 fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Vector2 ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::UnityEngine.Vector2 value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, global::UnityEngine.Vector2 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.VectorOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector2> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector2> setter, float elapsed, global::UnityEngine.Vector2 startValue, global::UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
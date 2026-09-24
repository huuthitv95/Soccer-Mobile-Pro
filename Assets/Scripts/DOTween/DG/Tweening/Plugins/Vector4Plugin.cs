namespace DG.Tweening.Plugins
{
    public class Vector4Plugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::UnityEngine.Vector4 fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Vector4 ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::UnityEngine.Vector4 value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector4, global::UnityEngine.Vector4, global::DG.Tweening.Plugins.Options.VectorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, global::UnityEngine.Vector4 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.VectorOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector4> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector4> setter, float elapsed, global::UnityEngine.Vector4 startValue, global::UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
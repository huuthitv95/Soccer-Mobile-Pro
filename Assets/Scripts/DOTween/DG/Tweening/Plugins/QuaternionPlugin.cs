namespace DG.Tweening.Plugins
{
    public class QuaternionPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> t, global::UnityEngine.Vector3 fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Vector3 ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> t, global::UnityEngine.Quaternion value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, global::UnityEngine.Vector3 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.QuaternionOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Quaternion> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Quaternion> setter, float elapsed, global::UnityEngine.Vector3 startValue, global::UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
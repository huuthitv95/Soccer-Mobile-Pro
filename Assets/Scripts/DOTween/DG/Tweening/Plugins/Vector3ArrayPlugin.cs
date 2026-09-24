namespace DG.Tweening.Plugins
{
    public class Vector3ArrayPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, global::UnityEngine.Vector3[] fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Vector3[] ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, global::UnityEngine.Vector3 value)
        {
            return null;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, global::UnityEngine.Vector3[] changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.Vector3ArrayOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, float elapsed, global::UnityEngine.Vector3[] startValue, global::UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
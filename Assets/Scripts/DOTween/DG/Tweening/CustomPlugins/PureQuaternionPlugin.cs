namespace DG.Tweening.CustomPlugins
{
    public class PureQuaternionPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions>
    {
        private static global::DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;
        public static global::DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug()
        {
            return null;
        }

        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions> t, global::UnityEngine.Quaternion fromValue, bool setImmediately)
        {
        }

        public override global::UnityEngine.Quaternion ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions> t, global::UnityEngine.Quaternion value)
        {
            return default;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Quaternion, global::DG.Tweening.Plugins.Options.NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, global::UnityEngine.Quaternion changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.NoOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Quaternion> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Quaternion> setter, float elapsed, global::UnityEngine.Quaternion startValue, global::UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
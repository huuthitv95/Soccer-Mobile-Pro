namespace DG.Tweening.Plugins
{
    public class PathPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions>
    {
        public override void Reset(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> t)
        {
        }

        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> t, global::DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately)
        {
        }

        public static global::DG.Tweening.Plugins.Core.ABSTweenPlugin<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> Get()
        {
            return null;
        }

        public override global::DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> t, global::UnityEngine.Vector3 value)
        {
            return null;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, global::DG.Tweening.Plugins.Core.PathCore.Path changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.PathOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, float elapsed, global::DG.Tweening.Plugins.Core.PathCore.Path startValue, global::DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }

        public void SetOrientation(global::DG.Tweening.Plugins.Options.PathOptions options, global::DG.Tweening.Tween t, global::DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, global::UnityEngine.Vector3 tPos, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }
    }
}
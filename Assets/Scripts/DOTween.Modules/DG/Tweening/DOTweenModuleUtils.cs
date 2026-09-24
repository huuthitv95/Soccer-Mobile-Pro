namespace DG.Tweening
{
    public static class DOTweenModuleUtils
    {
        public static class Physics
        {
            public static void SetOrientationOnPath(global::DG.Tweening.Plugins.Options.PathOptions options, global::DG.Tweening.Tween t, global::UnityEngine.Quaternion newRot, global::UnityEngine.Transform trans)
            {
            }

            public static bool HasRigidbody2D(global::UnityEngine.Component target)
            {
                return false;
            }

            [global::UnityEngine.Scripting.Preserve]
            public static bool HasRigidbody(global::UnityEngine.Component target)
            {
                return false;
            }

            [global::UnityEngine.Scripting.Preserve]
            public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Core.PathCore.Path, global::DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(global::UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, global::DG.Tweening.Plugins.Core.PathCore.Path path, float duration, global::DG.Tweening.PathMode pathMode)
            {
                return null;
            }
        }

        private static bool _initialized;
        [global::UnityEngine.Scripting.Preserve]
        public static void Init()
        {
        }

        [global::UnityEngine.Scripting.Preserve]
        private static void Preserver()
        {
        }
    }
}
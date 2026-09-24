namespace DG.Tweening
{
    public class DOTween
    {
        public static readonly string Version;
        public static bool useSafeMode;
        public static global::DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
        public static bool showUnityEditorReport;
        public static float timeScale;
        public static bool useSmoothDeltaTime;
        public static float maxSmoothUnscaledTime;
        internal static global::DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
        private static global::DG.Tweening.LogBehaviour _logBehaviour;
        public static global::System.Func<global::UnityEngine.LogType, object, bool> onWillLog;
        public static bool drawGizmos;
        public static bool debugMode;
        private static bool _fooDebugStoreTargetId;
        public static global::DG.Tweening.UpdateType defaultUpdateType;
        public static bool defaultTimeScaleIndependent;
        public static global::DG.Tweening.AutoPlay defaultAutoPlay;
        public static bool defaultAutoKill;
        public static global::DG.Tweening.LoopType defaultLoopType;
        public static bool defaultRecyclable;
        public static global::DG.Tweening.Ease defaultEaseType;
        public static float defaultEaseOvershootOrAmplitude;
        public static float defaultEasePeriod;
        public static global::DG.Tweening.Core.DOTweenComponent instance;
        internal static int maxActiveTweenersReached;
        internal static int maxActiveSequencesReached;
        internal static global::DG.Tweening.Core.SafeModeReport safeModeReport;
        internal static readonly global::System.Collections.Generic.List<global::DG.Tweening.TweenCallback> GizmosDelegates;
        internal static bool initialized;
        internal static bool isQuitting;
        public static global::DG.Tweening.LogBehaviour logBehaviour
        {
            get
            {
                return global::DG.Tweening.LogBehaviour.Default;
            }

            set
            {
            }
        }

        public static bool debugStoreTargetId
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private static void AutoInit()
        {
        }

        private static global::DG.Tweening.IDOTweenInit Init(global::DG.Tweening.Core.DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, global::DG.Tweening.LogBehaviour? logBehaviour)
        {
            return null;
        }

        public static void Clear(bool destroy = false)
        {
        }

        public static global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> To(global::DG.Tweening.Core.DOGetter<float> getter, global::DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> To(global::DG.Tweening.Core.DOGetter<string> getter, global::DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> To(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector2> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector2> setter, global::UnityEngine.Vector2 endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.VectorOptions> To(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, global::UnityEngine.Vector3 endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Quaternion, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.QuaternionOptions> To(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Quaternion> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Quaternion> setter, global::UnityEngine.Vector3 endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Color, global::UnityEngine.Color, global::DG.Tweening.Plugins.Options.ColorOptions> To(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Color> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Color> setter, global::UnityEngine.Color endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, global::DG.Tweening.Core.DOGetter<T1> getter, global::DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Color, global::UnityEngine.Color, global::DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Color> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Color> setter, float endValue, float duration)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, global::UnityEngine.Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, float duration, global::UnityEngine.Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
        {
            return null;
        }

        private static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, float duration, global::UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut)
        {
            return null;
        }

        public static global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector3> getter, global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector3> setter, global::UnityEngine.Vector3[] endValues, float[] durations)
        {
            return null;
        }

        public static global::DG.Tweening.Sequence Sequence()
        {
            return null;
        }

        internal static int CompleteAndReturnKilledTot(object targetOrId)
        {
            return 0;
        }

        public static int Kill(object targetOrId, bool complete = false)
        {
            return 0;
        }

        public static int Pause(object targetOrId)
        {
            return 0;
        }

        private static void InitCheck()
        {
        }

        private static global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(global::DG.Tweening.Core.DOGetter<T1> getter, global::DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return null;
        }
    }
}
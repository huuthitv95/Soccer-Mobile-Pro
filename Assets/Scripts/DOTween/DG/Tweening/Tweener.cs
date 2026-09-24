namespace DG.Tweening
{
    public abstract class Tweener : global::DG.Tweening.Tween
    {
        internal bool hasManuallySetStartValue;
        internal bool isFromAllowed;
        internal Tweener()
        {
        }

        internal static bool Setup<T1, T2, TPlugOptions>(global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, global::DG.Tweening.Core.DOGetter<T1> getter, global::DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return false;
        }

        internal static float DoUpdateDelay<T1, T2, TPlugOptions>(global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return 0f;
        }

        internal static bool DoStartup<T1, T2, TPlugOptions>(global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return false;
        }

        private static bool DOStartupSpecials<T1, T2, TPlugOptions>(global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return false;
        }

        private static void DOStartupDurationBased<T1, T2, TPlugOptions>(global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
        }
    }
}
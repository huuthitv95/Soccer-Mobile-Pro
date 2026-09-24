namespace DG.Tweening
{
    public static class TweenExtensions
    {
        public static void Complete(this global::DG.Tweening.Tween t)
        {
        }

        public static void Complete(this global::DG.Tweening.Tween t, bool withCallbacks)
        {
        }

        public static void Goto(this global::DG.Tweening.Tween t, float to, bool andPlay = false)
        {
        }

        public static void Kill(this global::DG.Tweening.Tween t, bool complete = false)
        {
        }

        public static T Play<T>(this T t)
            where T : global::DG.Tweening.Tween
        {
            return null;
        }

        public static void PlayBackwards(this global::DG.Tweening.Tween t)
        {
        }

        public static void Rewind(this global::DG.Tweening.Tween t, bool includeDelay = true)
        {
        }

        public static global::UnityEngine.YieldInstruction WaitForCompletion(this global::DG.Tweening.Tween t)
        {
            return null;
        }

        public static int CompletedLoops(this global::DG.Tweening.Tween t)
        {
            return 0;
        }

        public static float Duration(this global::DG.Tweening.Tween t, bool includeLoops = true)
        {
            return 0f;
        }

        public static float ElapsedPercentage(this global::DG.Tweening.Tween t, bool includeLoops = true)
        {
            return 0f;
        }

        public static float ElapsedDirectionalPercentage(this global::DG.Tweening.Tween t)
        {
            return 0f;
        }

        public static bool IsActive(this global::DG.Tweening.Tween t)
        {
            return false;
        }

        public static bool IsComplete(this global::DG.Tweening.Tween t)
        {
            return false;
        }

        public static bool IsPlaying(this global::DG.Tweening.Tween t)
        {
            return false;
        }
    }
}
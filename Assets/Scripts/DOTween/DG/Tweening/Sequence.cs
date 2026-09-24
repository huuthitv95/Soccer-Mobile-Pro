namespace DG.Tweening
{
    public sealed class Sequence : global::DG.Tweening.Tween
    {
        internal readonly global::System.Collections.Generic.List<global::DG.Tweening.Tween> sequencedTweens;
        private readonly global::System.Collections.Generic.List<global::DG.Tweening.Core.ABSSequentiable> _sequencedObjs;
        internal float lastTweenInsertTime;
        internal Sequence()
        {
        }

        internal static global::DG.Tweening.Sequence DoInsert(global::DG.Tweening.Sequence inSequence, global::DG.Tweening.Tween t, float atPosition)
        {
            return null;
        }

        internal static global::DG.Tweening.Sequence DoAppendInterval(global::DG.Tweening.Sequence inSequence, float interval)
        {
            return null;
        }

        internal static global::DG.Tweening.Sequence DoPrependInterval(global::DG.Tweening.Sequence inSequence, float interval)
        {
            return null;
        }

        internal static global::DG.Tweening.Sequence DoInsertCallback(global::DG.Tweening.Sequence inSequence, global::DG.Tweening.TweenCallback callback, float atPosition)
        {
            return null;
        }

        internal override void Reset()
        {
        }

        internal override bool Startup()
        {
            return false;
        }

        internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, global::DG.Tweening.Core.Enums.UpdateMode updateMode, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
            return false;
        }

        internal static void Setup(global::DG.Tweening.Sequence s)
        {
        }

        internal static bool DoStartup(global::DG.Tweening.Sequence s)
        {
            return false;
        }

        internal static bool DoApplyTween(global::DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, global::DG.Tweening.Core.Enums.UpdateMode updateMode)
        {
            return false;
        }

        private static bool ApplyInternalCycle(global::DG.Tweening.Sequence s, float fromPos, float toPos, global::DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
        {
            return false;
        }

        private static void StableSortSequencedObjs(global::System.Collections.Generic.List<global::DG.Tweening.Core.ABSSequentiable> list)
        {
        }

        private static bool IsAnyCallbackSet(global::DG.Tweening.Sequence s)
        {
            return false;
        }
    }
}
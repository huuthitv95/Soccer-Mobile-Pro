namespace DG.Tweening.Core
{
    internal static class TweenManager
    {
        internal enum CapacityIncreaseMode
        {
            TweenersAndSequences = 0,
            TweenersOnly = 1,
            SequencesOnly = 2
        }

        internal static bool isUnityEditor;
        internal static int maxActive;
        internal static int maxTweeners;
        internal static int maxSequences;
        internal static bool hasActiveTweens;
        internal static bool hasActiveDefaultTweens;
        internal static bool hasActiveLateTweens;
        internal static bool hasActiveFixedTweens;
        internal static bool hasActiveManualTweens;
        internal static int totActiveTweens;
        internal static int totActiveDefaultTweens;
        internal static int totActiveLateTweens;
        internal static int totActiveFixedTweens;
        internal static int totActiveManualTweens;
        internal static int totActiveTweeners;
        internal static int totActiveSequences;
        internal static int totPooledTweeners;
        internal static int totPooledSequences;
        internal static int totTweeners;
        internal static int totSequences;
        internal static bool isUpdateLoop;
        internal static global::DG.Tweening.Tween[] _activeTweens;
        private static global::DG.Tweening.Tween[] _pooledTweeners;
        private static readonly global::System.Collections.Generic.Stack<global::DG.Tweening.Tween> _PooledSequences;
        private static readonly global::System.Collections.Generic.List<global::DG.Tweening.Tween> _KillList;
        private static readonly global::System.Collections.Generic.Dictionary<global::DG.Tweening.Tween, global::DG.Tweening.Core.TweenLink> _TweenLinks;
        private static int _totTweenLinks;
        private static int _maxActiveLookupId;
        private static bool _requiresActiveReorganization;
        private static int _reorganizeFromId;
        private static int _minPooledTweenerId;
        private static int _maxPooledTweenerId;
        private static bool _despawnAllCalledFromUpdateLoopCallback;
        static TweenManager()
        {
        }

        internal static global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return null;
        }

        internal static global::DG.Tweening.Sequence GetSequence()
        {
            return null;
        }

        internal static void SetUpdateType(global::DG.Tweening.Tween t, global::DG.Tweening.UpdateType updateType, bool isIndependentUpdate)
        {
        }

        internal static void AddActiveTweenToSequence(global::DG.Tweening.Tween t)
        {
        }

        internal static void Despawn(global::DG.Tweening.Tween t, bool modifyActiveLists = true)
        {
        }

        internal static void PurgeAll()
        {
        }

        internal static void PurgePools()
        {
        }

        internal static void AddTweenLink(global::DG.Tweening.Tween t, global::DG.Tweening.Core.TweenLink tweenLink)
        {
        }

        private static void RemoveTweenLink(global::DG.Tweening.Tween t)
        {
        }

        internal static void ResetCapacities()
        {
        }

        internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
        {
        }

        internal static void Update(global::DG.Tweening.UpdateType updateType, float deltaTime, float independentTime)
        {
        }

        internal static int FilteredOperation(global::DG.Tweening.Core.Enums.OperationType operationType, global::DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null)
        {
            return 0;
        }

        internal static bool Complete(global::DG.Tweening.Tween t, bool modifyActiveLists = true, global::DG.Tweening.Core.Enums.UpdateMode updateMode = global::DG.Tweening.Core.Enums.UpdateMode.Goto)
        {
            return false;
        }

        internal static bool Flip(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static void ForceInit(global::DG.Tweening.Tween t, bool isSequenced = false)
        {
        }

        internal static bool Goto(global::DG.Tweening.Tween t, float to, bool andPlay = false, global::DG.Tweening.Core.Enums.UpdateMode updateMode = global::DG.Tweening.Core.Enums.UpdateMode.Goto)
        {
            return false;
        }

        internal static bool Pause(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool Play(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool PlayBackwards(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool PlayForward(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool Restart(global::DG.Tweening.Tween t, bool includeDelay = true, float changeDelayTo = -1f)
        {
            return false;
        }

        internal static bool Rewind(global::DG.Tweening.Tween t, bool includeDelay = true)
        {
            return false;
        }

        internal static bool SmoothRewind(global::DG.Tweening.Tween t)
        {
            return false;
        }

        internal static bool TogglePause(global::DG.Tweening.Tween t)
        {
            return false;
        }

        private static void MarkForKilling(global::DG.Tweening.Tween t)
        {
        }

        private static void EvaluateTweenLink(global::DG.Tweening.Tween t)
        {
        }

        private static void AddActiveTween(global::DG.Tweening.Tween t)
        {
        }

        private static void ReorganizeActiveTweens()
        {
        }

        private static void DespawnActiveTweens(global::System.Collections.Generic.List<global::DG.Tweening.Tween> tweens)
        {
        }

        private static void RemoveActiveTween(global::DG.Tweening.Tween t)
        {
        }

        private static void ClearTweenArray(global::DG.Tweening.Tween[] tweens)
        {
        }

        private static void IncreaseCapacities(global::DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode)
        {
        }

        private static void ManageOnRewindCallbackWhenAlreadyRewinded(global::DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind)
        {
        }
    }
}
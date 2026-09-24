namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class AnimationTrack : global::UnityEngine.Timeline.TrackAsset, global::UnityEngine.Timeline.ILayerable
    {
        private static class AnimationTrackUpgrade
        {
            public static void ConvertRotationsToEuler(global::UnityEngine.Timeline.AnimationTrack track)
            {
            }

            public static void ConvertRootMotion(global::UnityEngine.Timeline.AnimationTrack track)
            {
            }

            public static void ConvertInfiniteTrack(global::UnityEngine.Timeline.AnimationTrack track)
            {
            }
        }

        private const string k_DefaultInfiniteClipName = "Recorded";
        private const string k_DefaultRecordableClipName = "Recorded";
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_InfiniteClipOffsetPosition;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles;
        [global::UnityEngine.SerializeField]
        private double m_InfiniteClipTimeOffset;
        [global::UnityEngine.SerializeField]
        private bool m_InfiniteClipRemoveOffset;
        [global::UnityEngine.SerializeField]
        private bool m_InfiniteClipApplyFootIK;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode mInfiniteClipLoop;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_Position;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_EulerAngles;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AvatarMask m_AvatarMask;
        [global::UnityEngine.SerializeField]
        private bool m_ApplyAvatarMask;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TrackOffset m_TrackOffset;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.AnimationClip m_InfiniteClip;
        private static readonly global::System.Collections.Generic.Queue<global::UnityEngine.Transform> s_CachedQueue;
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Quaternion m_OpenClipOffsetRotation;
        [global::System.Obsolete]
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Quaternion m_Rotation;
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        [global::UnityEngine.HideInInspector]
        private bool m_ApplyOffsets;
        public global::UnityEngine.Vector3 position
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Quaternion rotation
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector3 eulerAngles
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public bool applyOffsets
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TrackOffset trackOffset
        {
            get
            {
                return global::UnityEngine.Timeline.TrackOffset.ApplyTransformOffsets;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.MatchTargetFields matchTargetFields
        {
            get
            {
                return (global::UnityEngine.Timeline.MatchTargetFields)0;
            }

            set
            {
            }
        }

        public global::UnityEngine.AnimationClip infiniteClip
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        internal bool infiniteClipRemoveOffset
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.AvatarMask avatarMask
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool applyAvatarMask
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;
        public bool inClipMode => false;

        public global::UnityEngine.Vector3 infiniteClipOffsetPosition
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Quaternion infiniteClipOffsetRotation
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector3 infiniteClipOffsetEulerAngles
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        internal bool infiniteClipApplyFootIK
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal double infiniteClipTimeOffset
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            set
            {
            }
        }

        internal global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode infiniteClipLoop
        {
            get
            {
                return global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode.UseSourceAsset;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.Vector3 openClipOffsetPosition
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.Quaternion openClipOffsetRotation
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.Vector3 openClipOffsetEulerAngles
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation openClipPreExtrapolation
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation openClipPostExtrapolation
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            set
            {
            }
        }

        internal override bool CanCompileClips()
        {
            return false;
        }

        private void ResetOffsets()
        {
        }

        public global::UnityEngine.Timeline.TimelineClip CreateClip(global::UnityEngine.AnimationClip clip)
        {
            return null;
        }

        public void CreateInfiniteClip(string infiniteClipName)
        {
        }

        public global::UnityEngine.Timeline.TimelineClip CreateRecordableClip(string animClipName)
        {
            return null;
        }

        protected override void OnCreateClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
        }

        protected internal override int CalculateItemsHash()
        {
            return 0;
        }

        internal void UpdateClipOffsets()
        {
        }

        private global::UnityEngine.Playables.Playable CompileTrackPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Timeline.AnimationTrack track, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree, global::UnityEngine.Timeline.AppliedOffsetMode mode)
        {
            return default;
        }

        global::UnityEngine.Playables.Playable global::UnityEngine.Timeline.ILayerable.CreateLayerMixer(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, int inputCount)
        {
            return default;
        }

        internal override global::UnityEngine.Playables.Playable OnCreateClipPlayableGraph(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree)
        {
            return default;
        }

        private int GetDefaultBlendCount()
        {
            return 0;
        }

        private void AttachDefaultBlend(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Animations.AnimationLayerMixerPlayable mixer, bool requireOffset)
        {
        }

        private global::UnityEngine.Playables.Playable AttachOffsetPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable playable, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
        {
            return default;
        }

        private bool RequiresMotionXPlayable(global::UnityEngine.Timeline.AppliedOffsetMode mode, global::UnityEngine.GameObject gameObject)
        {
            return false;
        }

        private static bool UsesAbsoluteMotion(global::UnityEngine.Timeline.AppliedOffsetMode mode)
        {
            return false;
        }

        private bool HasController(global::UnityEngine.GameObject gameObject)
        {
            return false;
        }

        internal global::UnityEngine.Animator GetBinding(global::UnityEngine.Playables.PlayableDirector director)
        {
            return null;
        }

        private static global::UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, int inputCount)
        {
            return default;
        }

        private global::UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree, global::UnityEngine.Timeline.AppliedOffsetMode mode)
        {
            return default;
        }

        private global::UnityEngine.Playables.Playable ApplyTrackOffset(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable root, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.AppliedOffsetMode mode)
        {
            return default;
        }

        internal override void GetEvaluationTime(out double outStart, out double outDuration)
        {
            outStart = default;
            outDuration = default;
        }

        internal override void GetSequenceTime(out double outStart, out double outDuration)
        {
            outStart = default;
            outDuration = default;
        }

        private void AssignAnimationClip(global::UnityEngine.Timeline.TimelineClip clip, global::UnityEngine.AnimationClip animClip)
        {
        }

        public override void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        private void GetAnimationClips(global::System.Collections.Generic.List<global::UnityEngine.AnimationClip> animClips)
        {
        }

        private global::UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(global::UnityEngine.GameObject go, bool animatesRootTransform)
        {
            return global::UnityEngine.Timeline.AppliedOffsetMode.NoRootTransform;
        }

        private bool IsRootTransformDisabledByMask(global::UnityEngine.GameObject gameObject, global::UnityEngine.Transform genericRootNode)
        {
            return false;
        }

        private global::UnityEngine.Transform GetGenericRootNode(global::UnityEngine.GameObject gameObject)
        {
            return null;
        }

        internal bool AnimatesRootTransform()
        {
            return false;
        }

        private static global::UnityEngine.Transform FindInHierarchyBreadthFirst(global::UnityEngine.Transform t, string name)
        {
            return null;
        }

        internal override void OnUpgradeFromVersion(int oldVersion)
        {
        }
    }
}
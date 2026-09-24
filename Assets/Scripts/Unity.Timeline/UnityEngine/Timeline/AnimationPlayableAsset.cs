namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.Timeline.NotKeyable]
    public class AnimationPlayableAsset : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.Timeline.ITimelineClipAsset, global::UnityEngine.Timeline.IPropertyPreview, global::UnityEngine.ISerializationCallbackReceiver
    {
        public enum LoopMode
        {
            UseSourceAsset = 0,
            On = 1,
            Off = 2
        }

        private enum Versions
        {
            Initial = 0,
            RotationAsEuler = 1
        }

        private static class AnimationPlayableAssetUpgrade
        {
            public static void ConvertRotationToEuler(global::UnityEngine.Timeline.AnimationPlayableAsset asset)
            {
            }
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationClip m_Clip;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_Position;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 m_EulerAngles;
        [global::UnityEngine.SerializeField]
        private bool m_UseTrackMatchFields;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
        [global::UnityEngine.SerializeField]
        private bool m_RemoveStartOffset;
        [global::UnityEngine.SerializeField]
        private bool m_ApplyFootIK;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode m_Loop;
        private static readonly int k_LatestVersion;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private int m_Version;
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Quaternion m_Rotation;
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

        public bool useTrackMatchFields
        {
            get
            {
                return false;
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

        public bool removeStartOffset
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool applyFootIK
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop
        {
            get
            {
                return global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode.UseSourceAsset;
            }

            set
            {
            }
        }

        internal bool hasRootTransforms => false;
        internal global::UnityEngine.Timeline.AppliedOffsetMode appliedOffsetMode { get; set; }

        public global::UnityEngine.AnimationClip clip
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override double duration => 0.0;
        public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;
        public global::UnityEngine.Timeline.ClipCaps clipCaps => global::UnityEngine.Timeline.ClipCaps.None;

        public override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go)
        {
            return default;
        }

        internal static global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.AnimationClip clip, global::UnityEngine.Vector3 positionOffset, global::UnityEngine.Vector3 eulerOffset, bool removeStartOffset, global::UnityEngine.Timeline.AppliedOffsetMode mode, bool applyFootIK, global::UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop)
        {
            return default;
        }

        private static bool ShouldApplyOffset(global::UnityEngine.Timeline.AppliedOffsetMode mode, global::UnityEngine.AnimationClip clip)
        {
            return false;
        }

        private static bool ShouldApplyScaleRemove(global::UnityEngine.Timeline.AppliedOffsetMode mode)
        {
            return false;
        }

        public void ResetOffsets()
        {
        }

        public void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        internal static bool HasRootTransforms(global::UnityEngine.AnimationClip clip)
        {
            return false;
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }

        private void OnUpgradeFromVersion(int oldVersion)
        {
        }
    }
}
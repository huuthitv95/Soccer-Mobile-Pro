namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class TimelineAsset : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.ISerializationCallbackReceiver, global::UnityEngine.Timeline.ITimelineClipAsset, global::UnityEngine.Timeline.IPropertyPreview
    {
        private enum Versions
        {
            Initial = 0
        }

        private static class TimelineAssetUpgrade
        {
        }

        [global::System.Obsolete]
        public enum MediaType
        {
            Animation = 0,
            Audio = 1,
            Texture = 2,
            [global::System.Obsolete]
            Video = Texture,
            Script = 3,
            Hybrid = 4,
            Group = 5
        }

        public enum DurationMode
        {
            BasedOnClips = 0,
            FixedLength = 1
        }

        [global::System.Serializable]
        public class EditorSettings
        {
            internal static readonly float kMinFps;
            internal static readonly float kMaxFps;
            internal static readonly float kDefaultFps;
            [global::UnityEngine.HideInInspector]
            [global::UnityEngine.SerializeField]
            private float m_Framerate;
            [global::UnityEngine.HideInInspector]
            [global::UnityEngine.SerializeField]
            private bool m_ScenePreview;
            public float fps
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public bool scenePreview
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }
        }

        private const int k_LatestVersion = 0;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private int m_Version;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> m_Tracks;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private double m_FixedDuration;
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks;
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.TrackAsset> m_CacheRootTracks;
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.TrackAsset> m_CacheFlattenedTracks;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineAsset.EditorSettings m_EditorSettings;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineAsset.DurationMode m_DurationMode;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.Timeline.MarkerTrack m_MarkerTrack;
        public global::UnityEngine.Timeline.TimelineAsset.EditorSettings editorSettings => null;
        public override double duration => 0.0;

        public double fixedDuration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineAsset.DurationMode durationMode
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineAsset.DurationMode.BasedOnClips;
            }

            set
            {
            }
        }

        public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;
        public global::UnityEngine.Timeline.ClipCaps clipCaps => global::UnityEngine.Timeline.ClipCaps.None;
        public int outputTrackCount => 0;
        public int rootTrackCount => 0;
        internal global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> flattenedTracks => null;
        public global::UnityEngine.Timeline.MarkerTrack markerTrack => null;
        internal global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> trackObjects => null;

        private void UpgradeToLatestVersion()
        {
        }

        private void OnValidate()
        {
        }

        internal static float GetValidFramerate(float framerate)
        {
            return 0f;
        }

        public global::UnityEngine.Timeline.TrackAsset GetRootTrack(int index)
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> GetRootTracks()
        {
            return null;
        }

        public global::UnityEngine.Timeline.TrackAsset GetOutputTrack(int index)
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> GetOutputTracks()
        {
            return null;
        }

        private void UpdateRootTrackCache()
        {
        }

        private void UpdateOutputTrackCache()
        {
        }

        internal void AddTrackInternal(global::UnityEngine.Timeline.TrackAsset track)
        {
        }

        internal void RemoveTrack(global::UnityEngine.Timeline.TrackAsset track)
        {
        }

        public override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go)
        {
            return default;
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }

        private void __internalAwake()
        {
        }

        public void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        public void CreateMarkerTrack()
        {
        }

        internal void Invalidate()
        {
        }

        internal void UpdateFixedDurationWithItemsDuration()
        {
        }

        private global::UnityEngine.Timeline.DiscreteTime CalculateItemsDuration()
        {
            return default;
        }

        private static void AddSubTracksRecursive(global::UnityEngine.Timeline.TrackAsset track, ref global::System.Collections.Generic.List<global::UnityEngine.Timeline.TrackAsset> allTracks)
        {
        }

        public global::UnityEngine.Timeline.TrackAsset CreateTrack(global::System.Type type, global::UnityEngine.Timeline.TrackAsset parent, string name)
        {
            return null;
        }

        public T CreateTrack<T>(global::UnityEngine.Timeline.TrackAsset parent, string trackName)
            where T : global::UnityEngine.Timeline.TrackAsset, new()
        {
            return null;
        }

        public T CreateTrack<T>(string trackName)
            where T : global::UnityEngine.Timeline.TrackAsset, new()
        {
            return null;
        }

        public T CreateTrack<T>()
            where T : global::UnityEngine.Timeline.TrackAsset, new()
        {
            return null;
        }

        public bool DeleteClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
            return false;
        }

        public bool DeleteTrack(global::UnityEngine.Timeline.TrackAsset track)
        {
            return false;
        }

        internal void MoveLastTrackBefore(global::UnityEngine.Timeline.TrackAsset asset)
        {
        }

        internal global::UnityEngine.Timeline.TrackAsset AllocateTrack(global::UnityEngine.Timeline.TrackAsset trackAssetParent, string trackName, global::System.Type trackType)
        {
            return null;
        }

        private void DeleteRecordedAnimation(global::UnityEngine.Timeline.TrackAsset track)
        {
        }

        private void DeleteRecordedAnimation(global::UnityEngine.Timeline.TimelineClip clip)
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.Timeline.IgnoreOnPlayableTrack]
    public abstract class TrackAsset : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.ISerializationCallbackReceiver, global::UnityEngine.Timeline.IPropertyPreview, global::UnityEngine.Timeline.ICurvesOwner
    {
        internal enum Versions
        {
            Initial = 0,
            RotationAsEuler = 1,
            RootMotionUpgrade = 2,
            AnimatedTrackProperties = 3
        }

        private static class TrackAssetUpgrade
        {
        }

        private struct TransientBuildData
        {
            public global::System.Collections.Generic.List<global::UnityEngine.Timeline.TrackAsset> trackList;
            public global::System.Collections.Generic.List<global::UnityEngine.Timeline.TimelineClip> clipList;
            public global::System.Collections.Generic.List<global::UnityEngine.Timeline.IMarker> markerList;
            public static global::UnityEngine.Timeline.TrackAsset.TransientBuildData Create()
            {
                return default;
            }

            public void Clear()
            {
            }
        }

        private const int k_LatestVersion = 3;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private int m_Version;
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        [global::UnityEngine.HideInInspector]
        internal global::UnityEngine.AnimationClip m_AnimClip;
        private static global::UnityEngine.Timeline.TrackAsset.TransientBuildData s_BuildData;
        internal const string kDefaultCurvesName = "Track Parameters";
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action<global::UnityEngine.Timeline.TimelineClip, global::UnityEngine.GameObject, global::UnityEngine.Playables.Playable> m_OnClipPlayableCreate;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action<global::UnityEngine.Timeline.TrackAsset, global::UnityEngine.GameObject, global::UnityEngine.Playables.Playable> m_OnTrackAnimationPlayableCreate;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private bool m_Locked;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private bool m_Muted;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private string m_CustomPlayableFullTypename;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationClip m_Curves;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Playables.PlayableAsset m_Parent;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> m_Children;
        [global::System.NonSerialized]
        private int m_ItemsHash;
        [global::System.NonSerialized]
        private global::UnityEngine.Timeline.TimelineClip[] m_ClipsCache;
        private global::UnityEngine.Timeline.DiscreteTime m_Start;
        private global::UnityEngine.Timeline.DiscreteTime m_End;
        private bool m_CacheSorted;
        private bool? m_SupportsNotifications;
        private static global::UnityEngine.Timeline.TrackAsset[] s_EmptyCache;
        private global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;
        private static global::System.Collections.Generic.Dictionary<global::System.Type, global::UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        protected internal global::System.Collections.Generic.List<global::UnityEngine.Timeline.TimelineClip> m_Clips;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.MarkerList m_Markers;
        public double start => 0.0;
        public double end => 0.0;
        public sealed override double duration => 0.0;

        public bool muted
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool mutedInHierarchy => false;
        public global::UnityEngine.Timeline.TimelineAsset timelineAsset => null;

        public global::UnityEngine.Playables.PlayableAsset parent
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        internal global::UnityEngine.Timeline.TimelineClip[] clips => null;
        public virtual bool isEmpty => false;
        public bool hasClips => false;
        public bool hasCurves => false;
        public bool isSubTrack => false;
        public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;

        internal string customPlayableTypename
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.AnimationClip curves
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        string global::UnityEngine.Timeline.ICurvesOwner.defaultCurvesName => null;

        global::UnityEngine.Object global::UnityEngine.Timeline.ICurvesOwner.asset => null;

        global::UnityEngine.Object global::UnityEngine.Timeline.ICurvesOwner.assetOwner => null;

        global::UnityEngine.Timeline.TrackAsset global::UnityEngine.Timeline.ICurvesOwner.targetTrack => null;
        internal global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> subTracksObjects => null;

        public bool locked
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool lockedInHierarchy => false;
        public bool supportsNotifications => false;

        internal static event global::System.Action<global::UnityEngine.Timeline.TimelineClip, global::UnityEngine.GameObject, global::UnityEngine.Playables.Playable> OnClipPlayableCreate
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        internal static event global::System.Action<global::UnityEngine.Timeline.TrackAsset, global::UnityEngine.GameObject, global::UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        protected virtual void OnBeforeTrackSerialize()
        {
        }

        protected virtual void OnAfterTrackDeserialize()
        {
        }

        internal virtual void OnUpgradeFromVersion(int oldVersion)
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }

        private void UpgradeToLatestVersion()
        {
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TimelineClip> GetClips()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> GetChildTracks()
        {
            return null;
        }

        private void __internalAwake()
        {
        }

        public void CreateCurves(string curvesClipName)
        {
        }

        public virtual global::UnityEngine.Playables.Playable CreateTrackMixer(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, int inputCount)
        {
            return default;
        }

        public sealed override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go)
        {
            return default;
        }

        public global::UnityEngine.Timeline.TimelineClip CreateDefaultClip()
        {
            return null;
        }

        public global::UnityEngine.Timeline.TimelineClip CreateClip<T>()
            where T : global::UnityEngine.ScriptableObject, global::UnityEngine.Playables.IPlayableAsset
        {
            return null;
        }

        public bool DeleteClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
            return false;
        }

        public global::UnityEngine.Timeline.IMarker CreateMarker(global::System.Type type, double time)
        {
            return null;
        }

        public T CreateMarker<T>(double time)
            where T : global::UnityEngine.ScriptableObject, global::UnityEngine.Timeline.IMarker
        {
            return null;
        }

        public bool DeleteMarker(global::UnityEngine.Timeline.IMarker marker)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.IMarker> GetMarkers()
        {
            return null;
        }

        public int GetMarkerCount()
        {
            return 0;
        }

        public global::UnityEngine.Timeline.IMarker GetMarker(int idx)
        {
            return null;
        }

        internal global::UnityEngine.Timeline.TimelineClip CreateClip(global::System.Type requestedType)
        {
            return null;
        }

        internal global::UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(global::System.Type requestedType)
        {
            return null;
        }

        internal global::UnityEngine.Timeline.TimelineClip CreateClipOfType(global::System.Type requestedType)
        {
            return null;
        }

        internal global::UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(global::UnityEngine.Playables.IPlayableAsset asset)
        {
            return null;
        }

        private global::UnityEngine.Timeline.TimelineClip CreateClipFromAsset(global::UnityEngine.ScriptableObject playableAsset)
        {
            return null;
        }

        internal global::System.Collections.Generic.IEnumerable<global::UnityEngine.ScriptableObject> GetMarkersRaw()
        {
            return null;
        }

        internal void ClearMarkers()
        {
        }

        internal void AddMarker(global::UnityEngine.ScriptableObject e)
        {
        }

        internal bool DeleteMarkerRaw(global::UnityEngine.ScriptableObject marker)
        {
            return false;
        }

        private int GetTimeRangeHash()
        {
            return 0;
        }

        internal void AddClip(global::UnityEngine.Timeline.TimelineClip newClip)
        {
        }

        private global::UnityEngine.Playables.Playable CreateNotificationsPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable mixerPlayable, global::UnityEngine.GameObject go, global::UnityEngine.Playables.Playable timelinePlayable)
        {
            return default;
        }

        internal global::UnityEngine.Playables.Playable CreatePlayableGraph(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree, global::UnityEngine.Playables.Playable timelinePlayable)
        {
            return default;
        }

        internal virtual global::UnityEngine.Playables.Playable CompileClips(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::System.Collections.Generic.IList<global::UnityEngine.Timeline.TimelineClip> timelineClips, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree)
        {
            return default;
        }

        private void GatherCompilableTracks(global::System.Collections.Generic.IList<global::UnityEngine.Timeline.TrackAsset> tracks)
        {
        }

        private void GatherNotificiations(global::System.Collections.Generic.List<global::UnityEngine.Timeline.IMarker> markers)
        {
        }

        internal virtual global::UnityEngine.Playables.Playable OnCreateClipPlayableGraph(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree)
        {
            return default;
        }

        internal void ConfigureTrackAnimation(global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree, global::UnityEngine.GameObject go, global::UnityEngine.Playables.Playable blend)
        {
        }

        internal void SortClips()
        {
        }

        internal void ClearClipsInternal()
        {
        }

        internal void ClearSubTracksInternal()
        {
        }

        internal void OnClipMove()
        {
        }

        internal global::UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal()
        {
            return null;
        }

        internal void AddChild(global::UnityEngine.Timeline.TrackAsset child)
        {
        }

        internal void MoveLastTrackBefore(global::UnityEngine.Timeline.TrackAsset asset)
        {
        }

        internal bool RemoveSubTrack(global::UnityEngine.Timeline.TrackAsset child)
        {
            return false;
        }

        internal void RemoveClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
        }

        internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
        {
            outStart = default;
            outDuration = default;
        }

        internal virtual void GetSequenceTime(out double outStart, out double outDuration)
        {
            outStart = default;
            outDuration = default;
        }

        public virtual void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        internal global::UnityEngine.GameObject GetGameObjectBinding(global::UnityEngine.Playables.PlayableDirector director)
        {
            return null;
        }

        internal bool ValidateClipType(global::System.Type clipType)
        {
            return false;
        }

        protected virtual void OnCreateClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
        }

        private void UpdateDuration()
        {
        }

        protected internal virtual int CalculateItemsHash()
        {
            return 0;
        }

        protected virtual global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject gameObject, global::UnityEngine.Timeline.TimelineClip clip)
        {
            return default;
        }

        internal void Invalidate()
        {
        }

        internal double GetNotificationDuration()
        {
            return 0.0;
        }

        internal virtual bool CanCompileClips()
        {
            return false;
        }

        internal bool IsCompilable()
        {
            return false;
        }

        private void UpdateChildTrackCache()
        {
        }

        internal virtual int Hash()
        {
            return 0;
        }

        private int GetClipsHash()
        {
            return 0;
        }

        protected static int GetAnimationClipHash(global::UnityEngine.AnimationClip clip)
        {
            return 0;
        }

        private bool HasNotifications()
        {
            return false;
        }

        private bool CanCompileNotifications()
        {
            return false;
        }

        private bool CanCompileClipsRecursive()
        {
            return false;
        }
    }
}
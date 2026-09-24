namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    internal struct MarkerList : global::UnityEngine.ISerializationCallbackReceiver
    {
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> m_Objects;
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.IMarker> m_Cache;
        private bool m_CacheDirty;
        private bool m_HasNotifications;
        public global::System.Collections.Generic.List<global::UnityEngine.Timeline.IMarker> markers => null;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.Timeline.IMarker this[int idx]
        {
            get
            {
                return null;
            }
        }

        public MarkerList(int capacity)
        {
            m_Objects = null;
            m_Cache = null;
            m_CacheDirty = false;
            m_HasNotifications = false;
        }

        public void Add(global::UnityEngine.ScriptableObject item)
        {
        }

        public bool Remove(global::UnityEngine.Timeline.IMarker item)
        {
            return false;
        }

        public bool Remove(global::UnityEngine.ScriptableObject item, global::UnityEngine.Timeline.TimelineAsset timelineAsset, global::UnityEngine.Playables.PlayableAsset thingToDirty)
        {
            return false;
        }

        public void Clear()
        {
        }

        public bool Contains(global::UnityEngine.ScriptableObject item)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.IMarker> GetMarkers()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::UnityEngine.ScriptableObject> GetRawMarkerList()
        {
            return null;
        }

        public global::UnityEngine.Timeline.IMarker CreateMarker(global::System.Type type, double time, global::UnityEngine.Timeline.TrackAsset owner)
        {
            return null;
        }

        public bool HasNotifications()
        {
            return false;
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }

        private void BuildCache()
        {
        }
    }
}
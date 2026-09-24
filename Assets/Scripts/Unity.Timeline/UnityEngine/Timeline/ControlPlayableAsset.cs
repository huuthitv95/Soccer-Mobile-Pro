namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.Timeline.NotKeyable]
    public class ControlPlayableAsset : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.Timeline.IPropertyPreview, global::UnityEngine.Timeline.ITimelineClipAsset
    {
        private const int k_MaxRandInt = 10000;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.ParticleSystem> k_EmptyParticlesList;
        private static readonly global::System.Collections.Generic.HashSet<global::UnityEngine.ParticleSystem> s_SubEmitterCollector;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.ExposedReference<global::UnityEngine.GameObject> sourceGameObject;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.GameObject prefabGameObject;
        [global::UnityEngine.SerializeField]
        public bool updateParticle;
        [global::UnityEngine.SerializeField]
        public uint particleRandomSeed;
        [global::UnityEngine.SerializeField]
        public bool updateDirector;
        [global::UnityEngine.SerializeField]
        public bool updateITimeControl;
        [global::UnityEngine.SerializeField]
        public bool searchHierarchy;
        [global::UnityEngine.SerializeField]
        public bool active;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;
        private global::UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset;
        private double m_Duration;
        private bool m_SupportLoop;
        private static global::System.Collections.Generic.HashSet<global::UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors;
        private static global::System.Collections.Generic.HashSet<global::UnityEngine.GameObject> s_CreatedPrefabs;
        internal bool controllingDirectors { get; private set; }
        internal bool controllingParticles { get; private set; }
        public override double duration => 0.0;
        public global::UnityEngine.Timeline.ClipCaps clipCaps => global::UnityEngine.Timeline.ClipCaps.None;

        public void OnEnable()
        {
        }

        public override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go)
        {
            return default;
        }

        private static global::UnityEngine.Playables.Playable ConnectPlayablesToMixer(global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.List<global::UnityEngine.Playables.Playable> playables)
        {
            return default;
        }

        private void CreateActivationPlayable(global::UnityEngine.GameObject root, global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.List<global::UnityEngine.Playables.Playable> outplayables)
        {
        }

        private void SearchHierarchyAndConnectParticleSystem(global::System.Collections.Generic.IEnumerable<global::UnityEngine.ParticleSystem> particleSystems, global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.List<global::UnityEngine.Playables.Playable> outplayables)
        {
        }

        private void SearchHierarchyAndConnectDirector(global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableDirector> directors, global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.List<global::UnityEngine.Playables.Playable> outplayables, bool disableSelfReferences)
        {
        }

        private static void SearchHierarchyAndConnectControlableScripts(global::System.Collections.Generic.IEnumerable<global::UnityEngine.MonoBehaviour> controlableScripts, global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.List<global::UnityEngine.Playables.Playable> outplayables)
        {
        }

        private static void ConnectMixerAndPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable mixer, global::UnityEngine.Playables.Playable playable, int portIndex)
        {
        }

        internal global::System.Collections.Generic.IList<T> GetComponent<T>(global::UnityEngine.GameObject gameObject)
        {
            return null;
        }

        internal static global::System.Collections.Generic.IEnumerable<global::UnityEngine.MonoBehaviour> GetControlableScripts(global::UnityEngine.GameObject root)
        {
            return null;
        }

        internal void UpdateDurationAndLoopFlag(global::System.Collections.Generic.IList<global::UnityEngine.Playables.PlayableDirector> directors, global::System.Collections.Generic.IList<global::UnityEngine.ParticleSystem> particleSystems)
        {
        }

        private global::System.Collections.Generic.IList<global::UnityEngine.ParticleSystem> GetControllableParticleSystems(global::UnityEngine.GameObject go)
        {
            return null;
        }

        private static void GetControllableParticleSystems(global::UnityEngine.Transform t, global::System.Collections.Generic.ICollection<global::UnityEngine.ParticleSystem> roots, global::System.Collections.Generic.HashSet<global::UnityEngine.ParticleSystem> subEmitters)
        {
        }

        private static void CacheSubEmitters(global::UnityEngine.ParticleSystem ps, global::System.Collections.Generic.HashSet<global::UnityEngine.ParticleSystem> subEmitters)
        {
        }

        public void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        internal static void PreviewParticles(global::UnityEngine.Timeline.IPropertyCollector driver, global::System.Collections.Generic.IEnumerable<global::UnityEngine.ParticleSystem> particles)
        {
        }

        internal static void PreviewActivation(global::UnityEngine.Timeline.IPropertyCollector driver, global::System.Collections.Generic.IEnumerable<global::UnityEngine.GameObject> objects)
        {
        }

        internal static void PreviewTimeControl(global::UnityEngine.Timeline.IPropertyCollector driver, global::UnityEngine.Playables.PlayableDirector director, global::System.Collections.Generic.IEnumerable<global::UnityEngine.MonoBehaviour> scripts)
        {
        }

        internal static void PreviewDirectors(global::UnityEngine.Timeline.IPropertyCollector driver, global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableDirector> directors)
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class AudioTrack : global::UnityEngine.Timeline.TrackAsset
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.AudioMixerProperties m_TrackProperties;
        public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;

        public global::UnityEngine.Timeline.TimelineClip CreateClip(global::UnityEngine.AudioClip clip)
        {
            return null;
        }

        internal override global::UnityEngine.Playables.Playable CompileClips(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, global::System.Collections.Generic.IList<global::UnityEngine.Timeline.TimelineClip> timelineClips, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree)
        {
            return default;
        }

        private void OnValidate()
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class ActivationTrack : global::UnityEngine.Timeline.TrackAsset
    {
        public enum PostPlaybackState
        {
            Active = 0,
            Inactive = 1,
            Revert = 2,
            LeaveAsIs = 3
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;
        private global::UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer;
        public global::UnityEngine.Timeline.ActivationTrack.PostPlaybackState postPlaybackState
        {
            get
            {
                return global::UnityEngine.Timeline.ActivationTrack.PostPlaybackState.Active;
            }

            set
            {
            }
        }

        internal override bool CanCompileClips()
        {
            return false;
        }

        public override global::UnityEngine.Playables.Playable CreateTrackMixer(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go, int inputCount)
        {
            return default;
        }

        internal void UpdateTrackMode()
        {
        }

        public override void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }

        protected override void OnCreateClip(global::UnityEngine.Timeline.TimelineClip clip)
        {
        }
    }
}
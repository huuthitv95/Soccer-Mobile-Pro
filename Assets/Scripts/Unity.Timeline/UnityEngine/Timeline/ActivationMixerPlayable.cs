namespace UnityEngine.Timeline
{
    internal class ActivationMixerPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        private global::UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;
        private bool m_BoundGameObjectInitialStateIsActive;
        private global::UnityEngine.GameObject m_BoundGameObject;
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

        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.ActivationMixerPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, int inputCount)
        {
            return default;
        }

        public override void OnPlayableDestroy(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void ProcessFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info, object playerData)
        {
        }
    }
}
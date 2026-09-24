namespace UnityEngine.Timeline
{
    public class ActivationControlPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        public enum PostPlaybackState
        {
            Active = 0,
            Inactive = 1,
            Revert = 2
        }

        private enum InitialState
        {
            Unset = 0,
            Active = 1,
            Inactive = 2
        }

        public global::UnityEngine.GameObject gameObject;
        public global::UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;
        private global::UnityEngine.Timeline.ActivationControlPlayable.InitialState m_InitialState;
        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.ActivationControlPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject gameObject, global::UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState)
        {
            return default;
        }

        public override void OnBehaviourPlay(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void OnBehaviourPause(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void ProcessFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info, object userData)
        {
        }

        public override void OnGraphStart(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void OnPlayableDestroy(global::UnityEngine.Playables.Playable playable)
        {
        }
    }
}
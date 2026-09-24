namespace UnityEngine.Timeline
{
    public class DirectorControlPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        public global::UnityEngine.Playables.PlayableDirector director;
        private bool m_SyncTime;
        private double m_AssetDuration;
        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.DirectorControlPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.PlayableDirector director)
        {
            return default;
        }

        public override void OnPlayableDestroy(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void OnBehaviourPlay(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void OnBehaviourPause(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void ProcessFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info, object playerData)
        {
        }

        private void SyncSpeed(double speed)
        {
        }

        private void SyncPlayState(global::UnityEngine.Playables.PlayableGraph graph, double playableTime)
        {
        }

        private bool DetectDiscontinuity(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
            return false;
        }

        private bool DetectOutOfSync(global::UnityEngine.Playables.Playable playable)
        {
            return false;
        }

        private void UpdateTime(global::UnityEngine.Playables.Playable playable)
        {
        }
    }
}
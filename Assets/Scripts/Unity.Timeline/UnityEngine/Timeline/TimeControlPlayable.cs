namespace UnityEngine.Timeline
{
    public class TimeControlPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        private global::UnityEngine.Timeline.ITimeControl m_timeControl;
        private bool m_started;
        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.TimeControlPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Timeline.ITimeControl timeControl)
        {
            return default;
        }

        public void Initialize(global::UnityEngine.Timeline.ITimeControl timeControl)
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
    }
}
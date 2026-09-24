namespace UnityEngine.Timeline
{
    internal class ScheduleRuntimeClip : global::UnityEngine.Timeline.RuntimeClipBase
    {
        private global::UnityEngine.Timeline.TimelineClip m_Clip;
        private global::UnityEngine.Playables.Playable m_Playable;
        private global::UnityEngine.Playables.Playable m_ParentMixer;
        private double m_StartDelay;
        private double m_FinishTail;
        private bool m_Started;
        public override double start => 0.0;
        public override double duration => 0.0;
        public global::UnityEngine.Timeline.TimelineClip clip => null;
        public global::UnityEngine.Playables.Playable mixer => default;
        public global::UnityEngine.Playables.Playable playable => default;

        public override bool enable
        {
            set
            {
            }
        }

        public void SetTime(double time)
        {
        }

        public ScheduleRuntimeClip(global::UnityEngine.Timeline.TimelineClip clip, global::UnityEngine.Playables.Playable clipPlayable, global::UnityEngine.Playables.Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
        {
        }

        private void Create(global::UnityEngine.Timeline.TimelineClip clip, global::UnityEngine.Playables.Playable clipPlayable, global::UnityEngine.Playables.Playable parentMixer, double startDelay, double finishTail)
        {
        }

        public override void EvaluateAt(double localTime, global::UnityEngine.Playables.FrameData frameData)
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    internal class RuntimeClip : global::UnityEngine.Timeline.RuntimeClipBase
    {
        private global::UnityEngine.Timeline.TimelineClip m_Clip;
        private global::UnityEngine.Playables.Playable m_Playable;
        private global::UnityEngine.Playables.Playable m_ParentMixer;
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

        public RuntimeClip(global::UnityEngine.Timeline.TimelineClip clip, global::UnityEngine.Playables.Playable clipPlayable, global::UnityEngine.Playables.Playable parentMixer)
        {
        }

        private void Create(global::UnityEngine.Timeline.TimelineClip clip, global::UnityEngine.Playables.Playable clipPlayable, global::UnityEngine.Playables.Playable parentMixer)
        {
        }

        public void SetTime(double time)
        {
        }

        public void SetDuration(double duration)
        {
        }

        public override void EvaluateAt(double localTime, global::UnityEngine.Playables.FrameData frameData)
        {
        }

        public override void Reset()
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    internal class InfiniteRuntimeClip : global::UnityEngine.Timeline.RuntimeElement
    {
        private global::UnityEngine.Playables.Playable m_Playable;
        private static readonly long kIntervalEnd;
        public override long intervalStart => 0L;
        public override long intervalEnd => 0L;

        public override bool enable
        {
            set
            {
            }
        }

        public InfiniteRuntimeClip(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void EvaluateAt(double localTime, global::UnityEngine.Playables.FrameData frameData)
        {
        }
    }
}
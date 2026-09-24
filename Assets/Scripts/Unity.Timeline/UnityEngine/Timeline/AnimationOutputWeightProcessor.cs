namespace UnityEngine.Timeline
{
    internal class AnimationOutputWeightProcessor : global::UnityEngine.Timeline.ITimelineEvaluateCallback
    {
        private struct WeightInfo
        {
            public global::UnityEngine.Playables.Playable mixer;
            public global::UnityEngine.Playables.Playable parentMixer;
            public int port;
        }

        private global::UnityEngine.Animations.AnimationPlayableOutput m_Output;
        private global::UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_MotionXPlayable;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo> m_Mixers;
        public AnimationOutputWeightProcessor(global::UnityEngine.Animations.AnimationPlayableOutput output)
        {
        }

        private void FindMixers()
        {
        }

        private void FindMixers(global::UnityEngine.Playables.Playable parent, int port, global::UnityEngine.Playables.Playable node)
        {
        }

        public void Evaluate()
        {
        }
    }
}
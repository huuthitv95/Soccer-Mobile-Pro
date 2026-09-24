namespace UnityEngine.Timeline
{
    internal class AnimationPreviewUpdateCallback : global::UnityEngine.Timeline.ITimelineEvaluateCallback
    {
        private global::UnityEngine.Animations.AnimationPlayableOutput m_Output;
        private global::UnityEngine.Playables.PlayableGraph m_Graph;
        private global::System.Collections.Generic.List<global::UnityEngine.Animations.IAnimationWindowPreview> m_PreviewComponents;
        public AnimationPreviewUpdateCallback(global::UnityEngine.Animations.AnimationPlayableOutput output)
        {
        }

        public void Evaluate()
        {
        }

        private void FetchPreviewComponents()
        {
        }
    }
}
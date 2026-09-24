namespace UnityEngine.Timeline
{
    public class TimelinePlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        private global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> m_IntervalTree;
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.RuntimeElement> m_ActiveClips;
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;
        private int m_ActiveBit;
        private global::System.Collections.Generic.List<global::UnityEngine.Timeline.ITimelineEvaluateCallback> m_EvaluateCallbacks;
        private global::System.Collections.Generic.Dictionary<global::UnityEngine.Timeline.TrackAsset, global::UnityEngine.Playables.Playable> m_PlayableCache;
        internal static bool muteAudioScrubbing;
        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.TimelinePlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> tracks, global::UnityEngine.GameObject go, bool autoRebalance, bool createOutputs)
        {
            return default;
        }

        public void Compile(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable timelinePlayable, global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> tracks, global::UnityEngine.GameObject go, bool autoRebalance, bool createOutputs)
        {
        }

        private void CompileTrackList(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable timelinePlayable, global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.TrackAsset> tracks, global::UnityEngine.GameObject go, bool createOutputs)
        {
        }

        private void CreateTrackOutput(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Timeline.TrackAsset track, global::UnityEngine.GameObject go, global::UnityEngine.Playables.Playable playable, int port)
        {
        }

        private void EvaluateWeightsForAnimationPlayableOutput(global::UnityEngine.Timeline.TrackAsset track, global::UnityEngine.Animations.AnimationPlayableOutput animOutput)
        {
        }

        private void EvaluateAnimationPreviewUpdateCallback(global::UnityEngine.Timeline.TrackAsset track, global::UnityEngine.Animations.AnimationPlayableOutput animOutput)
        {
        }

        private static global::UnityEngine.Playables.Playable CreatePlayableGraph(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Timeline.TrackAsset asset, global::UnityEngine.GameObject go, global::UnityEngine.Timeline.IntervalTree<global::UnityEngine.Timeline.RuntimeElement> tree, global::UnityEngine.Playables.Playable timelinePlayable)
        {
            return default;
        }

        private global::UnityEngine.Playables.Playable CreateTrackPlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.Playables.Playable timelinePlayable, global::UnityEngine.Timeline.TrackAsset track, global::UnityEngine.GameObject go, bool createOutputs)
        {
            return default;
        }

        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        private void Evaluate(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData frameData)
        {
        }

        private void CacheTrack(global::UnityEngine.Timeline.TrackAsset track, global::UnityEngine.Playables.Playable playable, int port, global::UnityEngine.Playables.Playable parent)
        {
        }

        private static void ForAOTCompilationOnly()
        {
        }
    }
}
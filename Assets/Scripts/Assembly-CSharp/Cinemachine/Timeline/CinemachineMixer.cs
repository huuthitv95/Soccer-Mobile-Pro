namespace Cinemachine.Timeline
{
    public sealed class CinemachineMixer : global::UnityEngine.Playables.PlayableBehaviour
    {
        private global::Cinemachine.CinemachineBrain mBrain;
        private int mBrainOverrideId;
        private bool mPlaying;
        private float mLastOverrideFrame;
        public override void OnGraphStop(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void ProcessFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info, object playerData)
        {
        }

        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    internal class AudioMixerProperties : global::UnityEngine.Playables.PlayableBehaviour
    {
        public float volume;
        public float stereoPan;
        public float spatialBlend;
        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }
    }
}
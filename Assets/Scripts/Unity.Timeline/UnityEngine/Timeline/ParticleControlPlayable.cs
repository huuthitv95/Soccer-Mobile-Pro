namespace UnityEngine.Timeline
{
    public class ParticleControlPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        private const float kUnsetTime = float.MaxValue;
        private float m_LastPlayableTime;
        private float m_LastParticleTime;
        private uint m_RandomSeed;
        public global::UnityEngine.ParticleSystem particleSystem { get; private set; }

        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.ParticleControlPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.ParticleSystem component, uint randomSeed)
        {
            return default;
        }

        public void Initialize(global::UnityEngine.ParticleSystem ps, uint randomSeed)
        {
        }

        private static void SetRandomSeed(global::UnityEngine.ParticleSystem particleSystem, uint randomSeed)
        {
        }

        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData data)
        {
        }

        public override void OnBehaviourPlay(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void OnBehaviourPause(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        private void Simulate(float time, bool restart)
        {
        }
    }
}
namespace UnityEngine.Timeline
{
    public class PrefabControlPlayable : global::UnityEngine.Playables.PlayableBehaviour
    {
        private global::UnityEngine.GameObject m_Instance;
        public global::UnityEngine.GameObject prefabInstance => null;

        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.PrefabControlPlayable> Create(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject prefabGameObject, global::UnityEngine.Transform parentTransform)
        {
            return default;
        }

        public global::UnityEngine.GameObject Initialize(global::UnityEngine.GameObject prefabGameObject, global::UnityEngine.Transform parentTransform)
        {
            return null;
        }

        public override void OnPlayableDestroy(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void OnBehaviourPlay(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void OnBehaviourPause(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        private static void SetHideFlagsRecursive(global::UnityEngine.GameObject gameObject)
        {
        }
    }
}
namespace Cinemachine.Timeline
{
    public sealed class CinemachineShot : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.Timeline.IPropertyPreview
    {
        public global::UnityEngine.ExposedReference<global::Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;
        public override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject owner)
        {
            return default;
        }

        public void GatherProperties(global::UnityEngine.Playables.PlayableDirector director, global::UnityEngine.Timeline.IPropertyCollector driver)
        {
        }
    }
}
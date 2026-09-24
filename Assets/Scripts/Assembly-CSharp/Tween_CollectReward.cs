public class Tween_CollectReward : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.Transform> rewardTransforms;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform endPosition;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform middleOffsetArea;
    private readonly global::System.Collections.Generic.List<global::DG.Tweening.Sequence> _runningSequences;
    private static global::UnityEngine.AnimationCurve posCurve;
    private static global::UnityEngine.AnimationCurve rotationCurve;
    private global::System.Collections.Generic.List<global::UnityEngine.Transform> callList;
    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    public void SetEndPosition(global::UnityEngine.RectTransform endPos)
    {
    }

    public void Play(int count, global::UnityEngine.RectTransform startPosition, global::System.Action<float> onProgress, float delay = 0.22f, float duration = 1.3f)
    {
    }

    private void PlayCollectAnimation(global::System.Collections.Generic.List<global::UnityEngine.Transform> rewardTransforms, global::UnityEngine.RectTransform startPosition, global::UnityEngine.RectTransform middleOffsetArea, global::UnityEngine.RectTransform endPosition, global::System.Action<float> onProgress, float delay = 0.16f, float duration = 1.3f)
    {
    }

    private void PlayCollectAnimation(global::UnityEngine.Transform item, global::UnityEngine.RectTransform startPosition, global::UnityEngine.RectTransform endPosition, global::UnityEngine.RectTransform middleOffsetArea, global::System.Action<float> onComplete, float progress, float delay, float duration = 1.3f)
    {
    }

    private void StopTweens()
    {
    }
}
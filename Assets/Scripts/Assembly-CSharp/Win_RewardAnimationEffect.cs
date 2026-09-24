public class Win_RewardAnimationEffect : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private Tween_CollectReward collectRewardTween;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.SpriteRenderer rewardIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject coin;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.RectTransform> runtimePositions;
    public void SetRewardIcon(global::UnityEngine.Sprite icon)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public void Play(global::UnityEngine.Vector2 endPos_screen)
    {
    }

    public void Play(global::UnityEngine.RectTransform endPos)
    {
    }

    public void Play(global::UnityEngine.Vector2 startPos_screen, global::UnityEngine.Vector2 endPos_screen, int count, global::System.Action<float> onProgress = null, float delay = 0.22f, float duration = 1.3f)
    {
    }

    public void Play(global::UnityEngine.RectTransform startPos, global::UnityEngine.RectTransform endPos, int count = 5, global::System.Action<float> onProgress = null, float delay = 0.22f, float duration = 1.3f)
    {
    }

    private void CheckProgress(float progress)
    {
    }

    private global::UnityEngine.RectTransform CreateRuntimePosition(string positionName, global::UnityEngine.Vector2 screenPosition)
    {
        return null;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }

    private void ClearRuntimePositions()
    {
    }
}
public class UIRewardIconBurstAnimation : global::UnityEngine.MonoBehaviour
{
    private const int IconCount = 14;
    private const float SpawnInterval = 0.025f;
    private const float BurstDuration = 0.46f;
    private const float FadeDuration = 0.16f;
    private static readonly global::UnityEngine.Vector2 DefaultIconSize;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Image> icons;
    private global::DG.Tweening.Sequence sequence;
    private global::UnityEngine.RectTransform root;
    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    public void Play(global::UnityEngine.UI.Image iconStyle, global::UnityEngine.RectTransform playPosition, global::System.Action onComplete)
    {
    }

    public void Stop()
    {
    }

    private void EnsureRoot()
    {
    }

    private global::UnityEngine.UI.Image GetIcon(int index)
    {
        return null;
    }

    private void CopyIconStyle(global::UnityEngine.UI.Image icon, global::UnityEngine.UI.Image iconStyle)
    {
    }

    private global::UnityEngine.Vector2 GetIconSize(global::UnityEngine.UI.Image iconStyle)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetLocalPosition(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }

    private void HideIcons()
    {
    }
}
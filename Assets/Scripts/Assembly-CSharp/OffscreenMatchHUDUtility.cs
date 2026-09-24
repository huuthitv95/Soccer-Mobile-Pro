public static class OffscreenMatchHUDUtility
{
    public static bool TryGetOffscreenLocalPoint(global::UnityEngine.Camera uiCamera, global::UnityEngine.Transform target, global::UnityEngine.RectTransform hudContainer, global::UnityEngine.RectTransform icon, out global::UnityEngine.Vector2 localPoint, out global::UnityEngine.Vector2 direction)
    {
        localPoint = default;
        direction = default;
        return false;
    }

    public static bool TryGetOffscreenEdgePoint(global::UnityEngine.Vector3 screenPosition, out global::UnityEngine.Vector2 edgePoint, out global::UnityEngine.Vector2 direction)
    {
        edgePoint = default;
        direction = default;
        return false;
    }

    private static global::UnityEngine.Vector2 GetIconEdgeOffset(global::UnityEngine.RectTransform icon, global::UnityEngine.Vector2 edgePoint)
    {
        return default;
    }

    public static void InitUserPossessionPlayerFlag(OffscreenMatchHUD hud, AISampleBase aiSample)
    {
    }
}
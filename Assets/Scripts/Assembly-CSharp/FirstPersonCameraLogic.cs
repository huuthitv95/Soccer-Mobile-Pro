public static class FirstPersonCameraLogic
{
    internal const float OffsetOrientationMaxAngularSpeed = 90f;
    internal const float MaxSidelineDeltaTime = 0.05f;
    private static global::UnityEngine.Vector3 GetSafeFlatDirection(global::UnityEngine.Vector3 direction, global::UnityEngine.Vector3 fallbackDirection)
    {
        return default;
    }

    private static global::UnityEngine.Quaternion SafeLookRotation(global::UnityEngine.Vector3 forward, global::UnityEngine.Quaternion fallback)
    {
        return default;
    }

    internal static global::UnityEngine.Quaternion StabilizeOffsetOrientation(ref FirstPersonCameraState state, global::UnityEngine.Quaternion targetOrientation, float deltaTime)
    {
        return default;
    }

    internal static void UpdateSidelineState(ref FirstPersonCameraState state, global::UnityEngine.Vector3 targetLookAtOffset, float targetOrientationBlend, float enterSmoothSpeed, float exitSmoothSpeed, float deltaTime)
    {
    }

    internal static void UpdateLegacySidelineState(ref FirstPersonCameraState state, global::UnityEngine.Vector3 targetLookAtOffset, float enterSmoothSpeed, float exitSmoothSpeed, float deltaTime)
    {
    }

    private static float GetSidelineStep(float z, float threshold)
    {
        return 0f;
    }

    private static float GetSidelineFarBallInfluence(in FirstPersonCameraSettings settings, global::UnityEngine.Vector3 targetPosition, global::UnityEngine.Vector3 ballPosition)
    {
        return 0f;
    }

    private static float GetViewportCorrection(float minValue, float maxValue, float minBound, float maxBound)
    {
        return 0f;
    }

    public static (global::UnityEngine.Vector3, global::UnityEngine.Quaternion) CalculateCameraTransform(in FirstPersonCameraSettings settings, ref FirstPersonCameraState state, global::UnityEngine.Transform target, global::UnityEngine.Vector3 targetForward, global::UnityEngine.Transform ball, global::UnityEngine.Transform opponentGoal, global::UnityEngine.Camera camera, global::UnityEngine.Transform currentCameraTransform, bool playerHasBall, float deltaTime, bool snapTransform = false)
    {
        return default;
    }

    internal static (global::UnityEngine.Vector3, global::UnityEngine.Quaternion) CalculateLegacyCameraTransform(in FirstPersonCameraSettings settings, ref FirstPersonCameraState state, global::UnityEngine.Transform target, global::UnityEngine.Vector3 targetForward, global::UnityEngine.Transform ball, global::UnityEngine.Transform opponentGoal, global::UnityEngine.Camera camera, global::UnityEngine.Transform currentCameraTransform, bool playerHasBall, float deltaTime)
    {
        return default;
    }

    private static (global::UnityEngine.Vector3, global::UnityEngine.Quaternion) CalculateCameraTransformInternal(in FirstPersonCameraSettings settings, ref FirstPersonCameraState state, global::UnityEngine.Transform target, global::UnityEngine.Vector3 targetForward, global::UnityEngine.Transform ball, global::UnityEngine.Transform opponentGoal, global::UnityEngine.Camera camera, global::UnityEngine.Transform currentCameraTransform, bool playerHasBall, float deltaTime, bool snapTransform, bool useOptimizedBehavior)
    {
        return default;
    }
}
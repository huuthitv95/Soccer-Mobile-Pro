public struct FirstPersonCameraState
{
    public float currentOffsetZ;
    public global::UnityEngine.Vector2 currentOffsetXY;
    public float currentDistanceHeightAdjustment;
    public global::UnityEngine.Vector3 currentSidelineLookAtOffset;
    public global::UnityEngine.Vector3 sidelineLookAtOffsetVelocity;
    public float currentSidelineOrientationBlend;
    public float sidelineOrientationBlendVelocity;
    public global::UnityEngine.Vector3 currentLookDirection;
    public bool hasLookDirection;
    public global::UnityEngine.Quaternion currentOffsetOrientation;
    public bool hasOffsetOrientation;
    public void Initialize(FirstPersonCameraSettings settings)
    {
    }
}
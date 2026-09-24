[global::System.Serializable]
public struct FirstPersonCameraSettings
{
	public global::UnityEngine.Vector2 baseOffsetXY;

	public float minOffsetZ;

	public float maxOffsetZ;

	public float playerBallDistForMinZ;

	public float playerBallDistForMaxZ;

	public float followSpeed;

	public float rotationSpeed;

	public global::UnityEngine.Vector3 lookAtOffset;

	public float goalInfluence;

	public float weightCurvature;

	public float forwardFacingThreshold;

	public float backwardFacingThreshold;

	public float backwardDistanceIncrease;

	public float forwardXOffsetIncrease;

	public float viewportYThreshold;

	public float minViewportX_Upper;

	public float maxViewportX_Upper;

	public float minViewportX_Lower;

	public float maxViewportX_Lower;

	public float minViewportY;

	public float maxViewportY;

	public float zoomAdjustSpeed;

	public float panAdjustSpeed;

	public float panSensitivity;

	public bool enableBoundaries;

	public float minBoundsX;

	public float maxBoundsX;

	public float minBoundsZ;

	public float maxBoundsZ;

	public float maxBoundaryHeightIncrease;

	public float boundaryPushFactor;

	public bool enableLookAtBoundaryCorrection;

	public float lookAtBoundaryCorrectionFactor;

	public bool enableDistanceHeightAdjust;

	public float distanceThresholdForHeightAdjust;

	public float maxDistanceForHeightAdjust;

	public float maxDistanceHeightIncrease;

	public float distanceHeightAdjustSpeed;

	public float fov;

	public float sidelineOffsetThreshold;

	public float sidelineOffsetFactor;

	public float sidelineOffsetEnterSmoothSpeed;

	public float sidelineOffsetSmoothSpeed;

	public float sidelineFarBallZDistanceStart;

	public float sidelineFarBallZDistanceEnd;

	public float sidelineFarBallInfluence;

	public static FirstPersonCameraSettings Default => default;

	public static FirstPersonCameraSettings LegacyDefault => default;
}

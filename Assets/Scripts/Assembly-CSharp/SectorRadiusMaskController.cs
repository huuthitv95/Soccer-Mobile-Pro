public class SectorRadiusMaskController : global::UnityEngine.MonoBehaviour
{
    private static readonly int EnableSectorId;
    private static readonly int InvertSectorId;
    private static readonly int MaskCenterId;
    private static readonly int MaskForwardId;
    private static readonly int HalfAngleDegId;
    private static readonly int AngleFeatherDegId;
    private static readonly int EnableOutsideRadiusId;
    private static readonly int OutsideRadiusId;
    private static readonly int RadiusFeatherId;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer targetRenderer;
    [global::UnityEngine.SerializeField]
    private bool usePropertyBlock;
    [global::UnityEngine.SerializeField]
    private bool autoUpdate;
    [global::UnityEngine.SerializeField]
    private bool enableSector;
    [global::UnityEngine.SerializeField]
    private bool invertSector;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform centerTransform;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector3 centerWorld;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform forwardTransform;
    [global::UnityEngine.SerializeField]
    private float forwardYawDeg;
    [global::UnityEngine.SerializeField]
    public float halfAngleDeg;
    [global::UnityEngine.SerializeField]
    private float angleFeatherDeg;
    [global::UnityEngine.SerializeField]
    private bool enableOutsideRadius;
    [global::UnityEngine.SerializeField]
    public float outsideRadius;
    [global::UnityEngine.SerializeField]
    private float radiusFeather;
    private global::UnityEngine.MaterialPropertyBlock _mpb;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void LateUpdate()
    {
    }

    public void Apply()
    {
    }

    private global::UnityEngine.Vector3 GetForwardXZ()
    {
        return default;
    }

    private void SetProperties(global::UnityEngine.MaterialPropertyBlock block, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 forward)
    {
    }

    private void SetProperties(global::UnityEngine.Material mat, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 forward)
    {
    }

    public void SetCenter(global::UnityEngine.Vector3 worldCenter)
    {
    }

    public void SetCenterTransform(global::UnityEngine.Transform t)
    {
    }

    public void SetForwardYaw(float yawDeg)
    {
    }

    public void SetForwardTransform(global::UnityEngine.Transform t)
    {
    }

    public void SetSectorEnabled(bool enabled)
    {
    }

    public void SetInvertSector(bool invert)
    {
    }

    public void SetHalfAngle(float deg)
    {
    }

    public void SetOutsideRadiusEnabled(bool enabled)
    {
    }

    public void SetOutsideRadius(float radius)
    {
    }
}
public class AITestSimpleCameraFollow : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private AITestMode _targetMode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera _targetCamera;
    private AITestCameraConfig _config;
    private global::UnityEngine.Vector3 _offset;
    public global::UnityEngine.Transform CameraTransform => null;

    private void Awake()
    {
    }

    private void LateUpdate()
    {
    }

    public void Configure(AITestMode targetMode, AITestCameraConfig config)
    {
    }

    private static global::UnityEngine.Vector3 Lerp(global::UnityEngine.Vector3 position, global::UnityEngine.Vector3 target)
    {
        return default;
    }

    private void SetOffset()
    {
    }

    private void UpdateCamera(global::UnityEngine.Transform target, bool smooth)
    {
    }
}
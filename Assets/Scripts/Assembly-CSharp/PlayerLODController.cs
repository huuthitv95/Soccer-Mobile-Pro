public class PlayerLODController : global::UnityEngine.MonoBehaviour
{
    private static float[] _lodDistSQQuality0;
    private static float[] _lodDistSQQuality1;
    private static float[] _lodDistSQQuality3;
    private static float[] _lodDistSQQuality5;
    private static float[][] _lodDistSQs;
    private int _curLevel;
    private const int Highest = 3;
    private bool ForceLOD3;
    private global::UnityEngine.Camera mainCam;
    private float dt;
    private global::UnityEngine.Vector3 screenCenterPos;
    private global::UnityEngine.Rect focusRect;
    [global::UnityEngine.SerializeField]
    private bool distOffsetSwitch;
    [global::UnityEngine.SerializeField]
    private int debugQualityIdx;
    [global::UnityEngine.SerializeField]
    private bool isDebug;
    private static float curOffset;
    private static bool offsetUpdateCompleted;
    public global::System.Action<int> OnSetLodLevel;
    private void Start()
    {
    }

    public void ForceChangeLOD3()
    {
    }

    public void CancelForceLOD3()
    {
    }

    private void Awake()
    {
    }

    private global::UnityEngine.Vector3 RayPlaneIntersection(global::UnityEngine.Ray ray, global::UnityEngine.Vector3 planePos, global::UnityEngine.Vector3 n)
    {
        return default;
    }

    private void updateCurOffset()
    {
    }

    private float calulateDistOffset()
    {
        return 0f;
    }

    private void LateUpdate()
    {
    }

    private void Update()
    {
    }

    internal void SetCurrentLevel(int v)
    {
    }
}
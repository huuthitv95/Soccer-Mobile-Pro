public class DrawMatchRadar : global::UnityEngine.MonoBehaviour
{
    private enum MatchType
    {
        Normal = 0,
        PlayerCareer = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject _dotTemplate;
    [global::UnityEngine.SerializeField]
    private TestSample sample;
    private float radarlength;
    private float radarwidth;
    private global::UnityEngine.RectTransform[, ] _dotPlayers;
    private global::UnityEngine.RectTransform ball;
    private static DrawMatchRadar.MatchType matchType;
    private static string[] saveKeys;
    private global::UnityEngine.Quaternion _defaultRotation;
    private global::UnityEngine.Vector2 _defaultPosition;
    private global::FLMessageSystem.IngameMessages.MatchCameraModeChanged cameraMode;
    public static string CurrentSaveKey => null;

    private void Awake()
    {
    }

    private void Initialize(object sender)
    {
    }

    private void SetUIOrientation(bool vertical, bool faceRight)
    {
    }

    private void OnMatchCameraModeChanged(in global::FLMessageSystem.IngameMessages.MatchCameraModeChanged mode)
    {
    }

    private void OnMatchPhaseChanged(in global::FLMessageSystem.IngameMessages.OnMatchPhaseChanged phase)
    {
    }

    public static bool IsRadarActive()
    {
        return false;
    }

    public static void SaveRadarActive(bool show)
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    private void CheckInitDot(global::Common.PlayerBoneHolder[, ] players)
    {
    }

    private void UpdateFrame(global::Common.PlayerBoneHolder[, ] players)
    {
    }

    private global::UnityEngine.Vector2 TransferPostion(global::UnityEngine.Transform target)
    {
        return default;
    }

    private global::UnityEngine.Vector2 TransferPostion(global::Common.PlayerBoneHolder playerBoneHolder)
    {
        return default;
    }

    private void OnActive(bool show)
    {
    }
}
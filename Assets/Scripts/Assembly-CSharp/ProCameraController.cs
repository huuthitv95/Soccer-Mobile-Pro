[global::System.Serializable]
public class ProCameraController : IGameCameraController, IUseBackupCameraController, IPlayerFocusCameraController
{
    public global::UnityEngine.Transform player;
    public global::UnityEngine.Transform ball;
    public global::UnityEngine.Transform opponentGoal;
    public bool playerHasBall;
    [global::UnityEngine.SerializeField]
    public FirstPersonCameraSettings settings;
    private global::UnityEngine.Camera _camera;
    private FirstPersonCameraState _state;
    private int lastStateUpdateFrame;
    private bool hasCameraVersion;
    private bool useOptimizedCamera;
    private global::Common.PlayerBoneHolder targetBoneHolder;
    private AISampleBase aiMatch;
    public IGameCameraController m_backupCameraController { get; set; }

    public void Init(global::UnityEngine.Transform ball, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
    {
    }

    public void UpdateGameViewSetting(float heightValue)
    {
    }

    private void UpdateTargets(global::UnityEngine.Transform target)
    {
    }

    private void UpdateOpponentGoal()
    {
    }

    public void Refresh()
    {
    }

    public void SetOffset()
    {
    }

    public void SetTarget(global::UnityEngine.Transform ball)
    {
    }

    public void Update(bool smooth)
    {
    }

    public void SetFocusPlayer(global::UnityEngine.Transform player)
    {
    }

    public void UpdatePlayerHasBallState(bool hasBall)
    {
    }
}
public class GameCameraManager : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct CameraListener
    {
        public GameCameraManager.CameraMode mode;
        public MatchListener listener;
    }

    public enum CameraMode
    {
        Game = 0,
        Timeline = 1,
        Replay = 2
    }

    [global::UnityEngine.SerializeField]
    private AISampleBase _aiMatch;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<GameCameraManager.CameraListener> _listener;
    [global::UnityEngine.SerializeField]
    private GameCameraManager.CameraMode FallBack;
    private global::System.Collections.Generic.Dictionary<GameCameraManager.CameraMode, IMatchCameraSwitchHandler> Listener;
    private GameCameraManager.CameraMode currentMode;
    public global::UnityEngine.Camera GetCurrentCamera()
    {
        return null;
    }

    public void Initialize()
    {
    }

    public void SwitchCamera(GameCameraManager.CameraMode mode)
    {
    }
}
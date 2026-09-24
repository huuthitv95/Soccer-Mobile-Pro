public interface IMatchCameraSwitchHandler
{
	void OnCameraSwitch(GameCameraManager.CameraMode mode);

	global::UnityEngine.Camera GetCamera();
}

namespace Cinemachine
{
	public interface ICinemachineCamera
	{
		string Name { get; }

		string Description { get; }

		int Priority { get; set; }

		global::UnityEngine.Transform LookAt { get; set; }

		global::UnityEngine.Transform Follow { get; set; }

		global::Cinemachine.CameraState State { get; }

		global::UnityEngine.GameObject VirtualCameraGameObject { get; }

		global::Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }

		global::Cinemachine.ICinemachineCamera ParentCamera { get; }

		bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam);

		void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime);

		void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime);
	}
}

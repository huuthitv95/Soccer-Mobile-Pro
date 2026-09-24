public interface IGameCameraController
{
	void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch);

	void SetTarget(global::UnityEngine.Transform target);

	void Update(bool smooth);

	void SetOffset();
}

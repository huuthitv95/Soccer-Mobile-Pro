public interface IMatch : ReplayHandler
{
	GamePlayType gamePlayType { get; }

	AISampleBase aiSample { get; }

	void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid);
}

public interface IPlayerFocusCameraController
{
	void SetFocusPlayer(global::UnityEngine.Transform player);

	void UpdatePlayerHasBallState(bool hasBall);

	void Refresh();
}

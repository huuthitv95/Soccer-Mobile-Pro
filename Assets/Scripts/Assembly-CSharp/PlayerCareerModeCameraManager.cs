public class PlayerCareerModeCameraManager
{
    private AISampleBase aiMatch;
    private IPlayerFocusCameraController playerFocusCameraController;
    private bool delayInit;
    private bool needNotify;
    public PlayerCareerModeCameraManager(IPlayerFocusCameraController playerFocusCameraController)
    {
    }

    public void OnAIReady(AISampleBase aiMatch)
    {
    }

    private void OnMatchPhaseChanged(in global::FLMessageSystem.IngameMessages.OnMatchPhaseChanged msg)
    {
    }

    private void Refresh(object obj)
    {
    }

    private void OnBallHoderPlayerChange(int id, global::UnityEngine.Transform player, int teamId)
    {
    }
}
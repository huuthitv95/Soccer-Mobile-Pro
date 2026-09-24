public class CoachController : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private Coach leftCoach;
    [global::UnityEngine.SerializeField]
    private Coach rightCoach;
    [global::UnityEngine.SerializeField]
    private AISampleBase sample;
    private Coach homeCoach;
    private Coach awayCoach;
    private bool inTimeLine;
    private global::EngineMessages.GameMode currentGameMode;
    private void Start()
    {
    }

    private void OnDestroy()
    {
    }

    private void OnPrepareSetPieceOver(global::EngineMessages.PrepareSetPieceEvent prepareSetPieceEvent)
    {
    }

    private void OnPauseResume(bool pause)
    {
    }

    private int RandomChooseCoach()
    {
        return 0;
    }

    private void OnPlayerSlided(int playerId)
    {
    }

    private void OnPlayerFoul(global::FLMessageSystem.IngameMessages.PlayerFoulEvent foulEvent)
    {
    }

    private void OnHalfMatch(object placeholder)
    {
    }

    private void SwitchCoach()
    {
    }

    private void Update()
    {
    }
}
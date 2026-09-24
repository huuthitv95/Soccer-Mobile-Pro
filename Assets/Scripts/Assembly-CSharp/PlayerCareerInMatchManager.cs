public class PlayerCareerInMatchManager : MatchListener
{
    private enum _MatchState
    {
        Start = 0,
        PreparingToLeave = 1,
        OffField = 2,
        End = 3
    }

    private const int RequestSubstitutionLead = 2;
    public bool StaminaBoosted;
    private PlayerCareerInMatchManager._MatchState _state;
    private global::UnityEngine.GameObject debugGo;
    private global::UnityEngine.GameObject debugGo2;
    private global::UnityEngine.Vector3 debugPos;
    private global::UnityEngine.GameObject debugInPositionAreaGo;
    private global::UnityEngine.GameObject debugOutOfPositionAreaGo;
    private bool showDebug;
    private float lastInPositionRadiusSqr;
    private float lastOutOfPositionRadiusSqr;
    private global::UnityEngine.GameObject goalAreaGo;
    private global::UnityEngine.GameObject goalAreaGo2;
    private AISampleBase aISample;
    private int playerRating;
    private float ingameRating;
    private float subInTime;
    private InGameCoachTrustRules inGameCoachTrustRules;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public bool IsPreparingToLeave => false;
    public bool IsOffField => false;
    public bool IsRedCardSentOff { get; private set; }
    public bool CanRequestSubstitution => false;
    public float IngameRating => 0f;

    public override void PreDestroy(IMatch match)
    {
    }

    public void RequestSubstitution()
    {
    }

    private void CheckToPreparingToLeaveState(bool ignoreTime, bool validateRequest = false)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    private global::UnityEngine.GameObject CreateRingMesh(string name, float outerRadius, float innerRadius, global::UnityEngine.Color color, int segments = 64)
    {
        return null;
    }

    private void RebuildRingMeshes()
    {
    }

    private void DebugPlayerDestination(object message)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    private void OnStaminaBoosted(int id)
    {
    }

    private void OnRatingBoosted(int id)
    {
    }

    private void OnIngameRatingChanged(float rating)
    {
    }

    private void LoadRealtimeRatingPrefab()
    {
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    private void CheckChangeToOffFieldState()
    {
    }
}
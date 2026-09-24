public class FreekickMode : global::UnityEngine.MonoBehaviour, IMatch, ReplayHandler
{
    private class FreekickLevel
    {
        public bool isOffensive;
        public global::UnityEngine.Vector2 ballPos;
    }

    private class FreeKickChallengeHandler
    {
        public enum ChallengeState
        {
            InProgress = 0,
            Success = 1,
            Failure = 2
        }

        public int failureCount;
        public int maxFailureCount;
        public global::FL.SmallBuffer8<global::UnityEngine.Vector2> levels;
        public int winCount;
        public int[] playerIds;
        public bool checkGoal;
        public bool onlyPlayersTurn;
        private bool failureFlag;
        public int difficulty;
        public global::System.Action<FreekickMode> OnLevelStartAction;
        public global::System.Action<FreekickMode> OnAwakeAction;
        public FreekickMode.FreeKickChallengeHandler.ChallengeState CurrentState => FreekickMode.FreeKickChallengeHandler.ChallengeState.InProgress;

        public void OnFailure(FreekickMode match)
        {
        }

        public void Check2NextLevel(FreekickMode match)
        {
        }

        public void OnLevelStart(FreekickMode match)
        {
        }

        public void OnAwake(FreekickMode match)
        {
        }

        public void OnWin(FreekickMode match)
        {
        }

        public void CreateLevels(FreekickMode match)
        {
        }

        public void InitSocreUI(FreekickMode match)
        {
        }

        private void UpdateScoreUI(FreekickMode match)
        {
        }

        public static FreekickMode.FreeKickChallengeHandler TryCreate()
        {
            return null;
        }
    }

    [global::UnityEngine.SerializeField]
    private AISampleBase agent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leftTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rightTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text homeScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text awayScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform challengePanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform homeMarks;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform awayMarks;
    private int[] Socres;
    private global::System.Collections.Generic.List<ClubPlayer> homeOrder;
    private global::System.Collections.Generic.List<ClubPlayer> awayOrder;
    private FreekickMode.FreeKickChallengeHandler challengeHandler;
    private bool skipSplash;
    private float countdown;
    private int playerId;
    private bool needShowAd;
    private string adPosition;
    private AdsManager.InterstitialMode interstitialMode;
    private bool needStartAd;
    private bool winFadeClosed;
    private int playedFrameCount;
    private global::System.Collections.Generic.List<int> homePenaltyScore;
    private global::System.Collections.Generic.List<int> awayPenaltyScore;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> homePlayerShootResult;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> awayPlayerShootResult;
    private bool BlockAI;
    private global::System.Collections.Generic.List<FreekickMode.FreekickLevel> freekickLevels;
    private int currentLevel;
    public GamePlayType gamePlayType => GamePlayType.Normal;
    public AISampleBase aiSample => null;
    private CupMatchBase matchData => null;

    private void Awake()
    {
    }

    private void CheckAudioAD()
    {
    }

    private string ButtonStringLoader(string key)
    {
        return null;
    }

    private void UpdateScoreboard()
    {
    }

    private void UpdateTeamInfo(TeamsData leftTeam, TeamsData rightTeam)
    {
    }

    private void OnDestroy()
    {
    }

    private void Start()
    {
    }

    public void OnReplayEnd()
    {
    }

    public void OnReplayReset()
    {
    }

    public void OnReplayStart()
    {
    }

    public void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    private void SendActiveEvent()
    {
    }

    private void CheckTimeout()
    {
    }

    private void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    private global::System.Collections.IEnumerator OnLevelStart()
    {
        return null;
    }

    private void OnLevelStarted()
    {
    }

    private void LevelUpdate()
    {
    }

    private void OnFrameEnd(int currPlayedFrameCount)
    {
    }

    private void SetupMatchConfig(global::EngineMessages.MatchConfig config, FreekickMode.FreekickLevel level)
    {
    }

    private void UpdateSocreUI()
    {
    }

    private void OnMatchEnd()
    {
    }

    private void CheckGameOver()
    {
    }

    private void OnLevelComplete(bool isWin, bool delay = false)
    {
    }

    private void StopMatch(global::System.Action callback)
    {
    }

    private void StartLevel(FreekickMode.FreekickLevel level)
    {
    }

    private void SetupKicker(int teamid, int playerid)
    {
    }

    private void ResetConfig()
    {
    }

    private void Check2NextLevel()
    {
    }

    private void GenerateIintialLevels()
    {
    }

    private void GenerateLevel()
    {
    }
}
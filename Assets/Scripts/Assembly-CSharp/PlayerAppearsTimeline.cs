public class PlayerAppearsTimeline : global::UnityEngine.MonoBehaviour
{
    private enum StadiumTimelineKind
    {
        PlayerAppears = 0,
        Prefab = 1
    }

    private class TimelineRequest
    {
        public PlayerAppearsTimeline.StadiumTimelineKind Type;
        public string PrefabPath;
        public ClubPlayer Player;
        public global::System.Action OnComplete;
        public static PlayerAppearsTimeline.TimelineRequest CreatePlayerAppears(ClubPlayer clubPlayer, global::System.Action onComplete)
        {
            return null;
        }

        public static PlayerAppearsTimeline.TimelineRequest CreatePrefab(string prefabPath, ClubPlayer clubPlayer, global::System.Action onComplete)
        {
            return null;
        }
    }

    private interface ITimelinePlayer
    {
        bool IsFinished { get; }

        void Play();
        void Update(float deltaTime);
        void Stop();
    }

    private class PlayerAppearsTimelinePlayer : PlayerAppearsTimeline.ITimelinePlayer
    {
        private readonly ClubPlayer clubPlayer;
        private readonly global::UnityEngine.Transform cameraMan;
        private readonly global::UnityEngine.Transform cameraBase;
        private PlayerRender playerRender;
        private global::UnityEngine.Animator animator;
        private float timer;
        private bool isFinished;
        public bool IsFinished => false;

        public PlayerAppearsTimelinePlayer(ClubPlayer clubPlayer, global::UnityEngine.Transform cameraMan, global::UnityEngine.Transform cameraBase)
        {
        }

        public void Play()
        {
        }

        public void Update(float deltaTime)
        {
        }

        public void Stop()
        {
        }
    }

    private class PrefabTimelinePlayer : PlayerAppearsTimeline.ITimelinePlayer
    {
        private readonly PlayerAppearsTimeline.TimelineRequest request;
        private global::UnityEngine.GameObject instance;
        private global::UnityEngine.GameObject timelineCamera;
        private global::UnityEngine.Playables.PlayableDirector director;
        private float timer;
        private bool isFinished;
        public bool IsFinished => false;

        public PrefabTimelinePlayer(PlayerAppearsTimeline.TimelineRequest request)
        {
        }

        public void Play()
        {
        }

        public void Update(float deltaTime)
        {
        }

        public void Stop()
        {
        }

        private void ApplyPlayerAvatar(global::UnityEngine.GameObject root)
        {
        }

        private void EnsureTimelineCamera(global::UnityEngine.GameObject root)
        {
        }
    }

    private const string PlayerAppearsPrefabPath = "Assets/Models/player2021/playerAppearsTimeline";
    private const string RetirementPrefabPath = "Assets/Timeline/retirement/retirement.prefab";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_next;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cameraMan;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cameraBase;
    public static ClubPlayer player;
    private static PlayerAppearsTimeline.TimelineRequest pendingRequest;
    private PlayerAppearsTimeline.ITimelinePlayer currentTimeline;
    private PlayerAppearsTimeline.TimelineRequest request;
    private bool returning;
    public static void PlayPlayerAppears(ClubPlayer clubPlayer, global::System.Action onComplete = null)
    {
    }

    public static void PlayRetirement(ClubPlayer clubPlayer, global::System.Action onComplete = null)
    {
    }

    public static void PlayPrefabTimeline(string prefabPath, ClubPlayer clubPlayer, global::System.Action onComplete = null)
    {
    }

    private static void PlayTimeline(PlayerAppearsTimeline.TimelineRequest timelineRequest)
    {
    }

    private void Start()
    {
    }

    private PlayerAppearsTimeline.ITimelinePlayer CreateTimelinePlayer(PlayerAppearsTimeline.TimelineRequest timelineRequest)
    {
        return null;
    }

    private void Update()
    {
    }

    private void OnDestroy()
    {
    }

    private void BackToMainView()
    {
    }
}
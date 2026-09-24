public class StadiumDecoration : global::UnityEngine.MonoBehaviour
{
    private class EventSpecificDecoration
    {
        private MatchManagerType matchManagerType;
        private string eventName;
        private int eventYear;
        private global::UnityEngine.GameObject[] decorations;
        private string prefabPath;
        private string prefabNamePrefix;
        private bool destroyWhenMatchStart;
        private string[] supportedStadiums;
        private string _fullPath;
        public EventSpecificDecoration(MatchManagerType matchManagerType, string eventName, int eventYear, string prefabNamePrefix, bool destroyWhenMatchStart = false, string prefabPath = "Assets/StadiumCommon", string[] supportedStadiums = null)
        {
        }

        public EventSpecificDecoration(MatchManagerType matchManagerType, string eventName, int eventYear, bool destroyWhenMatchStart, string fullPath)
        {
        }

        public void Init(CupMatchBase match)
        {
        }

        public void OnMatchStart()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform showHomeFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform showAwayFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform flags;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.SkinnedMeshRenderer corwd_HomeFlag_Friendly;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.SkinnedMeshRenderer corwd_AwayFlag_Friendly;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.SkinnedMeshRenderer[] corwd_HomeFlag_HomeAway;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject snowField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer banner_ribbonA;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer banner_ribbonB;
    public static bool showFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hideIngame;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform flagMan;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchupInfo;
    private CupMatchBase match;
    private AISampleBase AISample;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] complementaryToUEFA;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hideWhenStartMatch;
    [global::UnityEngine.SerializeField]
    private CheerSloganBanner sloganBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject confetti_floor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer[] banners;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer[] goalCages;
    private global::System.Collections.Generic.List<StadiumDecoration.EventSpecificDecoration> eventSpecificDecorations;
    private TifoManager tifoManager;
    private bool MatchInfoState;
    private ScreenTimeTracker screenTimeTracker;
    private bool needShowMatchInfog;
    private global::UnityEngine.Texture homeFlagTexture;
    private global::UnityEngine.Texture awayFlagTexture;
    public void Init(CupMatchBase match, AISampleBase AISample)
    {
    }

    public void HideMatchInfo()
    {
    }

    public void ShowMatchInfo()
    {
    }

    public void HandleMessage(OpCode opCode, object message)
    {
    }

    public void OnReplayEnd()
    {
    }

    private void ChangeFlagBanners(bool isHomeAwayMode, bool homeIsClub, bool awayisClub)
    {
    }

    private void OnTimelineStart(TimelineType type)
    {
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    private void GenerateFlagTex(TeamsData team, bool isHome)
    {
    }

    private void GenerateFlagTex(CupMatchBase match)
    {
    }

    private void FillShowFlag(global::UnityEngine.Transform root, bool home)
    {
    }
}
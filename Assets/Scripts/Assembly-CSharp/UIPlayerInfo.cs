public class UIPlayerInfo : MatchListener, InputListener, IFLHandler
{
    private const int TeamCount = 2;
    private static readonly global::UnityEngine.Vector3 HiddenSelectedPosition;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera camera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject energyBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PlayerName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PlayerName2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform preSwitchFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform ballTouchGroundFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject player1RedCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject player1YellowCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject player2RedCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject player2YellowCard;
    [global::UnityEngine.SerializeField]
    private OffscreenMatchHUD offscreenUserPlayerHUD;
    [global::UnityEngine.SerializeField]
    private AutoHideable offsideFlag;
    [global::UnityEngine.SerializeField]
    private AutoHideable askBallFlag;
    [global::UnityEngine.SerializeField]
    private GUILocalPVPDecorator localPVPDecorator;
    private global::UnityEngine.Transform offsidePlayer;
    private global::UnityEngine.Transform offsideFlagOriginalParent;
    private global::UnityEngine.Vector3 offsideFlagOriginalLocalPosition;
    private int offsideFlagOriginalSiblingIndex;
    private bool offsideFlagDetached;
    private PlayerSkillHUD playerSkillHUD;
    private PlayerFootHighlightController[] playerFootHighlightControllers;
    private global::UnityEngine.Transform[] preSwitchFlags;
    private int[] preSwitchIds;
    private global::UnityEngine.Transform[] preSwitchPlayers;
    private global::UnityEngine.Transform[] teamPressPlayers;
    private global::UnityEngine.Coroutine[] showPreSwitchFlagCoroutines;
    private global::UnityEngine.GameObject[] energyBars;
    private global::UnityEngine.UI.Image[] energyBarFills;
    private global::UnityEngine.Vector2[] inputDirections;
    private int[] btnPressFrames;
    private float[] maxPressTimes;
    private bool[] powerfulShotCharges;
    private bool[] sprints;
    private bool[] presses;
    private int[] curPlayerIds;
    private global::UnityEngine.Transform[] currentPlayers;
    private global::UnityEngine.Coroutine[] hideEnergyBarCoroutines;
    private InGamePlayer[] selectedPlayers;
    private bool isLocalBattle;
    public static float ShootChargeMaxTime;
    public static float PassChargeMaxTime;
    private bool switchOptimize;
    private global::UnityEngine.Sprite energyBarSprite;
    private global::UnityEngine.Sprite powerfullEnergyBarSprite;
    private global::UnityEngine.Vector3 playerPos;
    private global::UnityEngine.Transform controlledPlayer;
    private int lastId;
    private int lastUpdateFrameCount;
    private IMatch AImatch;
    private InGamePlayer closestToBallPlayer;
    private int lastPlayerTwoId;
    private global::System.Collections.Generic.Queue<(global::UnityEngine.Transform, global::UnityEngine.Vector3, global::UnityEngine.Transform)> FollowPlayerData;
    private float selectedY;
    private InGameCameraModel cameraModel;
    private bool isMy;
    private bool beforeKickOff;
    private global::UnityEngine.Coroutine waitCO;
    private IMatch aiMatch;
    private PlayerFootHighlightController playerFootHighlightController => null;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public override InputListener GetInputListener => null;
    public bool ShowSecondPlayerName { get; set; }
    public float PlayerMarkOffset { get; set; }

    public override void BeforeInit(IMatch match)
    {
    }

    public void InitHUDs(global::UnityEngine.Camera camera)
    {
    }

    public void UpdateHUDs(AISampleBase aiMatch)
    {
    }

    public void HideHUDs()
    {
    }

    private void CacheOffsideFlagOriginalParent()
    {
    }

    private void RestoreOffsideFlagParent()
    {
    }

    private void ShowOffsideFlag(global::UnityEngine.Transform player)
    {
    }

    private void UpdateOffsideFlagPosition()
    {
    }

    private void SetStamina(float value)
    {
    }

    private void SetStamina(global::UnityEngine.Transform playerName, float value, bool useWarmColors)
    {
    }

    public void HandleInput(global::EngineMessages.InputData eventlist)
    {
    }

    private bool TryGetInputMarkerIndex(int deviceId, MatchInputRouter inputRouter, out int markerIndex)
    {
        markerIndex = default;
        return false;
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private void UpdateLocalBattlePlayerTwoInfo()
    {
    }

    private InGamePlayer GetPlayerClosestToBall(IMatch match)
    {
        return null;
    }

    public void SetCamera(global::UnityEngine.Camera camera)
    {
    }

    public void FollowPlayer(global::UnityEngine.Transform target, global::UnityEngine.Vector3 playerPos, global::UnityEngine.Transform player)
    {
    }

    private void FollowPlayerUpdate(object placeholder)
    {
    }

    private void Update()
    {
    }

    private void UpdateEnergyBars()
    {
    }

    private void ShowEnergyBarAt(int markerIndex, global::UnityEngine.Transform player)
    {
    }

    private global::System.Collections.IEnumerator DelayHideEnergyBar(int markerIndex)
    {
        return null;
    }

    private void ResetEnergyBar(int markerIndex, bool resetInput)
    {
    }

    private bool UpdateSelected(global::EngineMessages.FrameDetail frameDetail, IMatch match, out InGamePlayer primarySelectedPlayer)
    {
        primarySelectedPlayer = null;
        return false;
    }

    private bool TryGetSelectedPlayer(global::EngineMessages.FrameDetail frameDetail, int selectedPlayerIndex, IMatch match, out InGamePlayer player)
    {
        player = null;
        return false;
    }

    private void UpdateDefensiveHelpPlayer(IMatch match)
    {
    }

    public override void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel tol, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    private global::System.Collections.IEnumerator ShowPreSwitchFlag(int markerIndex)
    {
        return null;
    }

    private void SetPreSwitchPlayer(int markerIndex, int teamId, int playerId, IMatch match, string messageName)
    {
    }

    private void TryStartPreSwitchFlag(int markerIndex, AISampleBase aiSample)
    {
    }

    private void HidePreSwitchFlag(int markerIndex)
    {
    }

    private void HideAllPreSwitchFlags()
    {
    }

    private void SetTeamPressPlayer(int markerIndex, int teamId, int playerId, IMatch match)
    {
    }

    private bool TryGetPlayerTransform(IMatch match, int teamId, int playerId, string messageName, out global::UnityEngine.Transform playerTransform)
    {
        playerTransform = null;
        return false;
    }

    private bool TryReadTeamPlayerMessage(global::EngineMessages.IntValues data, string messageName, out int teamId, out int playerId)
    {
        teamId = default;
        playerId = default;
        return false;
    }

    private bool TryGetMarkerIndex(int teamId, IMatch match, out int markerIndex)
    {
        markerIndex = default;
        return false;
    }

    private void ResetTeamMarkers()
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    private void OnTimelineStart(TimelineType type)
    {
    }

    public override void OnMatchReset(IMatch match)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public override void OnAIReady(IMatch match)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }

    public global::UnityEngine.Transform GetUserPossessionPlayer()
    {
        return null;
    }

    public void OnVisibleChange(bool isVisible)
    {
    }

    private void OnEnable()
    {
    }
}
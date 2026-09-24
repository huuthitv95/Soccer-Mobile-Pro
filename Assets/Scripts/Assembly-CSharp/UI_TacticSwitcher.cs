public class UI_TacticSwitcher : MatchListener
{
    private const int GoalKickTacticCount = 3;
    private const int CornerTacticCount = 6;
    private static readonly global::UnityEngine.Color SelectedColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform arrow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text labelText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform content;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject sampleTemplate;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::UnityEngine.UI.Button button;
    private AISampleBase aiSample;
    private bool subscribed;
    private bool visible;
    private bool inSetPiece;
    private bool isGoalKick;
    private bool expanded;
    private int goalKickTacticId;
    private int cornerTacticId;
    private global::UnityEngine.Color sampleDefaultColor;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.GameObject> optionItems;
    private static readonly OpCode[] KickOpcodes;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    private int CurrentTacticId => 0;
    private int TacticCount => 0;

    private void Awake()
    {
    }

    private void Start()
    {
    }

    public override void BeforeInit(IMatch match)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public override void OnMatchStart(IMatch match)
    {
    }

    public override void OnMatchReset(IMatch match)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }

    private void EnsureSubscribed(AISampleBase sample = null)
    {
    }

    private void Unsubscribe()
    {
    }

    private void OnPrepareSetPieceOver(global::EngineMessages.PrepareSetPieceEvent data)
    {
    }

    private bool CanConfigureTactic(IMatch match, global::EngineMessages.PrepareSetPieceEvent data)
    {
        return false;
    }

    private bool ShouldHideForMode(IMatch match)
    {
        return false;
    }

    private void Show(bool goalKick)
    {
    }

    private void Hide()
    {
    }

    private void SetVisible(bool show)
    {
    }

    private void SetCurrentTacticId(int id, bool? goalKick = null)
    {
    }

    private string GetTacticKey(int id)
    {
        return null;
    }

    private string GetTacticName(int id)
    {
        return null;
    }

    private void UpdateLabel()
    {
    }

    private void ToggleDropdown()
    {
    }

    private void ExpandDropdown()
    {
    }

    private void RebuildContentLayout()
    {
    }

    private void OnSelectTactic(int id)
    {
    }

    private void ResetAllTacticsToDefault()
    {
    }

    private void ResetTacticToDefault(bool goalKick)
    {
    }

    private void ApplyTactic(int id, bool? goalKick = null)
    {
    }

    private void CollapseDropdown()
    {
    }

    private void ClearOptions()
    {
    }

    private void SetArrowRotation(float z)
    {
    }
}
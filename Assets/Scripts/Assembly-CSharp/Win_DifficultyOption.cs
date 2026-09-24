public class Win_DifficultyOption : global::Common.WindowBase
{
    public enum DifficultyMode
    {
        None = 0,
        Friendly = 1,
        Club = 2,
        Nation = 3,
        Champion = 4,
        Women = 5
    }

    public class OpenParameter
    {
        public readonly IMatchManager MatchManager;
        public readonly Win_DifficultyOption.DifficultyMode Mode;
        public readonly bool ShowCloseButton;
        public readonly bool UseCurrentValue;
        public readonly global::System.Action<int> OnChanged;
        public OpenParameter(IMatchManager matchManager, Win_DifficultyOption.DifficultyMode mode, bool showCloseButton, bool useCurrentValue, global::System.Action<int> onChanged)
        {
        }
    }

    [global::System.Serializable]
    private struct DifficultyOption
    {
        public global::UnityEngine.UI.Text text;
        public global::UnityEngine.UI.Image icon;
        public global::UnityEngine.UI.Toggle toggle;
    }

    private const int DifficultyCount = 5;
    private const int UnselectedDifficulty = -1;
    private const string FriendlyDifficultyKey = "friendlyDifficulty";
    [global::UnityEngine.SerializeField]
    private Win_DifficultyOption.DifficultyOption[] difficultyOptions;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    private IMatchManager matchManager;
    private Win_DifficultyOption.DifficultyMode mode;
    private int selectedDifficulty;
    private int valueWhenInit;
    private bool hasValueWhenInit;
    private global::System.Action<int> onChanged;
    private static bool IsEnabled => false;

    public override void OnOpen(object parameter)
    {
    }

    public static Win_DifficultyOption Show(IMatchManager matchManager, bool showCloseButton, global::System.Action<int> onChanged = null, bool useCurrentValue = true)
    {
        return null;
    }

    public static void CheckShowFirstModeDifficulty(IMatchManager matchManager)
    {
    }

    public static bool TryGetMode(CupMatchBase match, out Win_DifficultyOption.DifficultyMode mode)
    {
        mode = default;
        return false;
    }

    public static bool TryGetMode(IMatchManager matchManager, out Win_DifficultyOption.DifficultyMode mode)
    {
        mode = default;
        return false;
    }

    public static int GetDifficulty(IMatchManager matchManager)
    {
        return 0;
    }

    public static int GetDifficulty(Win_DifficultyOption.DifficultyMode mode)
    {
        return 0;
    }

    public static int GetDifficulty(IMatchManager matchManager, Win_DifficultyOption.DifficultyMode mode)
    {
        return 0;
    }

    public static void SetDifficulty(Win_DifficultyOption.DifficultyMode mode, int difficulty)
    {
    }

    public static void SetDifficulty(IMatchManager matchManager, int difficulty)
    {
    }

    public static bool HasDifficulty(Win_DifficultyOption.DifficultyMode mode)
    {
        return false;
    }

    public static bool HasDifficulty(IMatchManager matchManager, Win_DifficultyOption.DifficultyMode mode)
    {
        return false;
    }

    public static string GetDifficultyText(int difficulty)
    {
        return null;
    }

    public static global::UnityEngine.Sprite GetDifficultyIcon(int difficulty)
    {
        return null;
    }

    private static bool TryGetCupMode(FACup cup, out Win_DifficultyOption.DifficultyMode mode)
    {
        mode = default;
        return false;
    }

    private static bool TryGetArchiveDifficulty(IMatchManager matchManager, out int difficulty)
    {
        difficulty = default;
        return false;
    }

    private static bool TrySetArchiveDifficulty(IMatchManager matchManager, int difficulty)
    {
        return false;
    }

    private static int GetFriendlyDifficulty()
    {
        return 0;
    }

    private static int GetDefaultDifficulty(Win_DifficultyOption.DifficultyMode mode)
    {
        return 0;
    }

    private void InitOptions()
    {
    }

    private void SelectDifficulty(int difficulty)
    {
    }

    private void OnConfirm()
    {
    }

    public static void NotifyDifficultyChanged(int lastDifficulty, int currentDifficulty, global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason reason)
    {
    }
}
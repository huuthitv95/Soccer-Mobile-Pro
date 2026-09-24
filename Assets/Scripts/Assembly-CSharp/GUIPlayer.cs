public class GUIPlayer : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform position;
    [global::UnityEngine.SerializeField]
    private new global::UnityEngine.UI.Text name;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider staminaBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image stateIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage icon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject redCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject yellowCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject suspendFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject mask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject StateBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject iconInjure;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCardBg PlayerCardBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text ageText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loanFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject captainFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject retirementFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform rebirthFlag;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Image cardBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image nationIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image clubIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject engeryBarMask;
    [global::UnityEngine.SerializeField]
    private bool fixedNameColor;
    private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Sprite> Cache;
    private void Awake()
    {
    }

    public void SetMaskVisable(bool visable)
    {
    }

    private void MarkMaskDirty()
    {
    }

    public void ShowContract(ClubPlayer clubPlayer, bool isLoan, int times, bool forceShow = false)
    {
    }

    private global::UnityEngine.Color GetContractTextColor(int times)
    {
        return default;
    }

    private string ColorToHex(global::UnityEngine.Color32 color)
    {
        return null;
    }

    public void ShowContractAnim(int current, int target, global::System.Action onFinish)
    {
    }

    public void UpdateUI(InGamePlayer player, bool isStarter, bool isMyTeam, PlayerDisciplineDatabase disciplineDatabase, AISampleBase aimatch, bool forceUnlicensedAppearance = false)
    {
    }

    public void OnCardBackgroundUpdate(GUIPlayerCardBg.CardBgType type)
    {
    }

    public void UpdateUI(ClubPlayer player, bool isStarter, bool isMyTeam, PlayerDisciplineDatabase disciplineDatabase, AISampleBase aimatch, bool forceUnlicensedAppearance = false)
    {
    }

    private void SetPlayerIconGradientEnabled(bool enabled, ClubPlayer player)
    {
    }

    public static void UpdatePositionUI(ClubPlayer player, global::UnityEngine.Transform position, bool isStarter)
    {
    }

    public static void UpdatePositionUI(FormationTool.UIPosition pos, global::UnityEngine.Transform position)
    {
    }

    public static void UpdateStaminaBar(ClubPlayer player, global::UnityEngine.UI.Slider staminaBar, bool isStarter)
    {
    }

    public static void UpdateStaminaBar(InGamePlayer player, global::UnityEngine.UI.Slider staminaBar, bool isStarter)
    {
    }

    private static void updateStaminaBarColor(global::UnityEngine.UI.Slider staminaBar, float value)
    {
    }

    public void DoStateAnimation()
    {
    }

    public void SetAgeTextColor(int rating, int id)
    {
    }

    public void SetAge(int age)
    {
    }

    public void ShowCaptain(bool Show)
    {
    }

    public void ShowRetirementFlag(bool show)
    {
    }

    public void DoStaminaAnimation(InGamePlayer player)
    {
    }

    public void DoStaminaAnimation(ClubPlayer player)
    {
    }

    public void ShowDisciplineInfo(ClubPlayer player, IMatchManager matchManager, AISampleBase aimatch)
    {
    }

    private void SetActiveWithCheck(global::UnityEngine.GameObject obj, bool active)
    {
    }

    public void ShowDisciplineInfo(ClubPlayer player, PlayerDisciplineDatabase disciplineDatabase, AISampleBase aimatch)
    {
    }
}
public class GUIScheduleItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UIThemes.UnconventionalUIThemeGroup m_uiTheme;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject matchDay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject normalDay;
    [global::UnityEngine.SerializeField]
    private GUITeamIcon teamLogo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject dayoffIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject trainingIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject payIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text time;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject transferIcon;
    public void Init(Schedule schedule, CupMatchBase match, bool today)
    {
    }
}
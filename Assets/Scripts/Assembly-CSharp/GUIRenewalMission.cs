public class GUIRenewalMission : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leagueIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueNameText;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject renewalMissionCompleteMask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject renewalMissionInprogressMask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text renewalBonusValueText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image renewalMissionProgressFill;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic[] leagueLevelGraphics;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text renewalConditionText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text renewalProgressText;
    public void Fill(global::FL.PlayerCareer playerCareer)
    {
    }
}
public class GUIPlayerDetailInfo : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUIPlayer guiPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text age;
    [global::UnityEngine.SerializeField]
    private StringID attr1;
    [global::UnityEngine.SerializeField]
    private StringID attr2;
    [global::UnityEngine.SerializeField]
    private StringID attr3;
    [global::UnityEngine.SerializeField]
    private StringID attr4;
    [global::UnityEngine.SerializeField]
    private StringID attr5;
    [global::UnityEngine.SerializeField]
    private StringID attr6;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject lFoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject rFoot;
    public IFormationDragable proto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image clubIcon;
    public void ShowContract(ClubPlayer player, bool isLoan, int times, bool forceShow = false)
    {
    }

    public void ShowDisciplineInfo(ClubPlayer player, PlayerDisciplineDatabase disciplineDatabase, AISampleBase aimatch)
    {
    }

    public void UpdateUI(InGamePlayer player, bool isStarter, bool isMyTeam, IFormationDragable proto)
    {
    }

    public void ShowClubIcon(TeamsData team)
    {
    }

    public void UpdateUI(ClubPlayer player, bool isStarter, bool isMyTeam, IFormationDragable proto)
    {
    }

    private void SetAbilityColor(global::UnityEngine.UI.Text text, float value)
    {
    }

    public void UpdatePlayerInfo(ClubPlayer player)
    {
    }
}
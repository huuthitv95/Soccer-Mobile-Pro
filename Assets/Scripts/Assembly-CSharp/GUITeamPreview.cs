public class GUITeamPreview : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUITeam teamInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cups;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer homeKit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer awayKit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform locked;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hiddenObjectsOnLock;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text eventText;
    [global::UnityEngine.SerializeField]
    private Gradient2ParamsHolder gradientHolder;
    [global::UnityEngine.SerializeField]
    private ColorParamsHolder colorHolder;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] legendaryTeamObjects;
    public global::UnityEngine.Events.UnityEvent<TeamsData> OnSelectTeam;
    public void Fill(TeamsData team, FixtureListData datas, bool isEventLockedTeam, int teamRating)
    {
    }
}
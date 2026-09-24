public class GUITeam : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    public GUITeamData guiTeamData;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject userFlag;
    public bool useUperCase;
    [global::UnityEngine.SerializeField]
    private bool forceAbbrName;
    public void Init(TeamsData team, bool abbrName = false)
    {
    }

    public void ShowUserFlag(bool show)
    {
    }

    public void SetRating(int rating)
    {
    }
}
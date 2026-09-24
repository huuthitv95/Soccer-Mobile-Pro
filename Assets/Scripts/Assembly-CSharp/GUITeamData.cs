[global::System.Serializable]
public struct GUITeamData
{
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    public GUIRatingStar ratingStar;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Image icon;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Text ratingText;
    private global::UnityEngine.Rect _iconRect;
    private bool inited;
    public void Updater(TeamsData team, bool abbrName = false, bool useUperCase = false)
    {
    }
}
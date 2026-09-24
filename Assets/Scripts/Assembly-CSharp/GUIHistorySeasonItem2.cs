public class GUIHistorySeasonItem2 : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image TeamIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text TeamNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text SeasonNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject topScorerFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject topAssistFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle selectedToggle;
    public global::UnityEngine.UI.Toggle SelectedToggle => null;

    public void Fill(TeamsData teamData, string seasonNameText, bool isTopScorer, bool isTopAssist)
    {
    }
}
public class ChangeUIColorByCompetition : global::UnityEngine.MonoBehaviour
{
    public enum UIColorByCompetition
    {
        leagueColor = 0,
        cupColor = 1,
        superCupColor = 2,
        intercontinentalColor = 3,
        clubWorldCupColor = 4
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic graphics;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color leagueColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color cupColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color superCupColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color intercontinentalColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color clubWorldCupColor;
    public void ChangeColor(IMatchManager matchManager)
    {
    }

    public void ChangeColor(ChangeUIColorByCompetition.UIColorByCompetition color)
    {
    }
}
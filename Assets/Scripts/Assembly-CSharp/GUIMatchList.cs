public class GUIMatchList : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private bool useAbbrTeamName;
    [global::UnityEngine.SerializeField]
    private GUIWheel wheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundName;
    public void Show(global::System.Collections.Generic.List<CupMatchBase> matchs, bool bo2 = false)
    {
    }

    private void scrollToItem(int idx)
    {
    }

    private void CheckWheel(IMatchManager matchManager, int curRound, bool singleRound, bool useWheel)
    {
    }

    public void Show(IMatchManager matchManager, int round, bool singleRound)
    {
    }
}
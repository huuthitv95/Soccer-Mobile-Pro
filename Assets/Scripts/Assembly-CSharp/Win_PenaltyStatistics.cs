public class Win_PenaltyStatistics : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRestart;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text m_score;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image homeIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image awayIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text homeName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text awayName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] userFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    public override void OnOpen(object parameter)
    {
    }

    public void HideTeamInfo()
    {
    }

    public Win_PenaltyStatistics Fill(int[] score, CupMatchBase match, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> homeScore, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> awayScore)
    {
        return null;
    }

    public void SetBtnAction(global::System.Action next, global::System.Action reset, string adPosition)
    {
    }

    public void HideRestartBtn()
    {
    }
}
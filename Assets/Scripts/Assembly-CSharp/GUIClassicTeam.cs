public class GUIClassicTeam : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private Gradient2ParamsHolder gradientHolder;
    [global::UnityEngine.SerializeField]
    private ColorParamsHolder colorHolder;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] classicTeamObjects;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progressText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text yearText;
    [global::UnityEngine.SerializeField]
    private ADButtonStateBase adBtn;
    private RewardWithVideo rewardWithVideo;
    private global::System.Action onVideoSucceed;
    private TeamsData team;
    public void RegistRVBtn(RewardWithVideo rewardWithVideo, global::System.Action onVideoSucceed)
    {
    }

    public void ApplyClassicTeamTheme(TeamsData itemData)
    {
    }

    private void OnVideo()
    {
    }

    public void RestoreClassicTeamTheme()
    {
    }
}
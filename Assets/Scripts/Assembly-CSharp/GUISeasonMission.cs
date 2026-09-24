public class GUISeasonMission : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completeGo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject inprogressGo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject claimedGo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] missionDescTexts;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] missionProgressTexts;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] rewardValueTexts;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button claimBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image[] missionProgressFill;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image rewardIcon;
    private global::Srv.SeasonMission mission;
    private global::System.Action<global::Srv.SeasonMission, GUISeasonMission> onClaim;
    public void Fill(global::Srv.SeasonMission mission, global::System.Action<global::Srv.SeasonMission, GUISeasonMission> onClaim)
    {
    }

    private void OnClaimClicked()
    {
    }

    public global::UnityEngine.RectTransform GetRewardEffectPosition()
    {
        return null;
    }

    public global::UnityEngine.UI.Image GetRewardEffectIconStyle()
    {
        return null;
    }

    public void SetClaimInteractable(bool interactable)
    {
    }

    private static string GetProgressText(global::Srv.SeasonMission mission)
    {
        return null;
    }

    private static void SetProgressFills(global::UnityEngine.UI.Image[] fills, global::Srv.SeasonMission mission)
    {
    }

    private static float GetProgressRate(global::Srv.SeasonMission mission)
    {
        return 0f;
    }

    private static void SetActive(global::UnityEngine.GameObject gameObject, bool active)
    {
    }

    private static void SetTexts(global::UnityEngine.UI.Text[] texts, string value)
    {
    }

    private global::UnityEngine.UI.Text GetActiveRewardValueText()
    {
        return null;
    }
}
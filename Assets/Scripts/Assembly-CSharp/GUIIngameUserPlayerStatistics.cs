public class GUIIngameUserPlayerStatistics : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerRestoreStaminaRV restoreStaminaRV;
    [global::UnityEngine.SerializeField]
    private GUIBoostRatingRV boostRatingRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject boostPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage playerIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text ingameRating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform ratingAttrContainer;
    private global::System.Collections.Generic.List<global::FLMessageSystem.FullPlayerStatisticsType> ratingAttrTypes;
    public void Show(UserPlayerData player, InGamePlayer inGamePlayer, bool boosted, PlayerTemporaryBoostManager manager, float ingameRating, bool showBoost)
    {
    }

    private void UpdatePlayerIcon(ClubPlayer player)
    {
    }

    private void UpdateBoostPanel(PlayerTemporaryBoostManager manager, UserPlayerData player, InGamePlayer inGamePlayer, bool boosted, bool showBoost)
    {
    }

    public string GetRatingAttrString(global::FLMessageSystem.FullPlayerStatisticsType type)
    {
        return null;
    }

    private void UpdateRatingAttrs(InGamePlayer player)
    {
    }
}
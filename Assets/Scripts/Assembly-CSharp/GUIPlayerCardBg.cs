public class GUIPlayerCardBg : global::UnityEngine.MonoBehaviour
{
    public enum CardBgType
    {
        Legend = 0,
        Other = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image bg;
    [global::UnityEngine.SerializeField]
    private string prefixed;
    [global::UnityEngine.SerializeField]
    private bool isDetailCard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<int> OnUpdateRatingBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<int, int> OnUpdateRatingBg2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<GUIPlayerCardBg.CardBgType> OnUpdateBackground;
    [global::UnityEngine.SerializeField]
    private bool isChallengeEventCard;
    public int suffixValue;
    public void MarkChallengeEventCard()
    {
    }

    public void Fill(int rating, bool isUIRating, int playerId)
    {
    }

    private bool DestrotyIAPCard(string skipName)
    {
        return false;
    }

    public void Fill(int rating, int playerId)
    {
    }
}
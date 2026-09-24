public class GUICommonReward : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform rewardMountPoint;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform btnGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn;
    [global::UnityEngine.SerializeField]
    private GUIPlayer _uiPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform _teamsParent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject AnyPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform commonRewardImages;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject effect;
    public void Init(string title, string desc)
    {
    }

    public void ShowCommonRewardImage(global::UnityEngine.Texture[] icon, float[] size, string[] desc)
    {
    }

    public void ShowShopItem(int id)
    {
    }

    public void ShowAnyPlayer()
    {
    }

    public void ShowPlayer(ClubPlayer clubPlayer)
    {
    }

    public void ShowTeam(global::System.Collections.Generic.List<TeamsData> team)
    {
    }

    public void ShowClassicTeam(int teamId)
    {
    }

    public void SetRewardItem(global::UnityEngine.RectTransform item)
    {
    }

    public void SetButton(global::UnityEngine.RectTransform button)
    {
    }

    public void AddButtonListener(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void ShowCommonRewardImage(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> rewards)
    {
    }

    private void GenerateRewardItem(global::UnityEngine.Transform node, global::FLGameData.RewardType rewardType, int rewardId)
    {
    }
}
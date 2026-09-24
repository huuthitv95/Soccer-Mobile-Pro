public class Win_PendingReward : global::Common.WindowBase
{
    private enum DecoImgAlignType
    {
        LeftUp = 0,
        RightUp = 1,
        LeftDown = 2,
        RightDown = 3,
        Center = 4
    }

    [global::System.Serializable]
    private class DecoImgAlignInfo
    {
        public string decoImgName;
        public string atlasName;
        public Win_PendingReward.DecoImgAlignType alignType;
        public global::UnityEngine.Vector2 pos;
        public global::UnityEngine.Vector2 size;
        public bool flipX;
        public bool flipY;
    }

    [global::System.Serializable]
    private class RewardThemeInfo
    {
        public global::System.Collections.Generic.List<Win_PendingReward.DecoImgAlignInfo> decoImgAlignInfos;
        public global::UnityEngine.Gradient backgroundGradient;
        public global::UnityEngine.Color buttonBgColor;
        public global::UnityEngine.Color buttonTextColor;
        public global::UnityEngine.Color descColor;
        public global::UnityEngine.Color titleColor;
        public bool logoVisible;
    }

    private enum UIRewardType
    {
        Coin = 0,
        Player = 1,
        AnyPlayer = 2
    }

    private class UIRewardItem
    {
        public global::UnityEngine.GameObject go;
        public Win_PendingReward.UIRewardType rewardType;
        public int coinAmount;
        public global::System.Collections.Generic.List<ClubPlayer> players;
        public int chance;
        private global::UnityEngine.UI.Text coinCount;
        private global::UnityEngine.UI.Button btnClaim;
        public void Initialize(global::UnityEngine.GameObject go)
        {
        }

        public void Bind(Win_PendingReward.UIRewardType rewardType, int coinAmount, global::System.Collections.Generic.List<ClubPlayer> players, int chance, global::System.Action onClaim)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] templates;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle[] rewardSources;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform itemListParent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descText;
    private global::System.Collections.Generic.Dictionary<Win_PendingReward.UIRewardType, global::System.Collections.Generic.List<Win_PendingReward.UIRewardItem>> itemPool;
    private global::FL.Game.EventRewardDatas.IPendingRewardDatas selectedSourceType;
    private global::System.Collections.Generic.List<Win_PendingReward.UIRewardItem> activeItems;
    private global::System.Collections.Generic.Dictionary<global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType, global::FL.Game.EventRewardDatas.IPendingRewardDatas> sources;
    private global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType selectedSourceKey;
    private bool hasSelectedSourceKey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect scrollRect;
    [global::UnityEngine.SerializeField]
    private Win_PendingReward.RewardThemeInfo[] rewardThemeInfos;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.Gradient2 bgGradient;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject logo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform decoImgParent;
    private RegionalLeague regionalLeague;
    private global::System.Action<int> GainCoinAction;
    private void ClaimReward(Win_PendingReward.UIRewardItem item)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void Fill(RegionalLeague regionalLeague, global::System.Action<int> onGainCoin)
    {
    }

    private void InitSources()
    {
    }

    private void RefreshSourcesAndSelection()
    {
    }

    private void SelectSource(global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType type)
    {
    }

    private void UpdateDecoTheme()
    {
    }

    private void ApplyTheme(Win_PendingReward.RewardThemeInfo themeInfo)
    {
    }

    private void ClearDecoImgs()
    {
    }

    private void ApplyDecoImgAlign(global::UnityEngine.RectTransform rt, Win_PendingReward.DecoImgAlignInfo info)
    {
    }

    private void UpdateTitleAndDesc()
    {
    }

    private void RefreshItems()
    {
    }

    private Win_PendingReward.UIRewardItem CreateItem(Win_PendingReward.UIRewardType type)
    {
        return null;
    }

    private void ApplyItemTheme(Win_PendingReward.UIRewardItem item, Win_PendingReward.RewardThemeInfo themeInfo)
    {
    }

    private void ClearItems()
    {
    }
}
public class Win_PlayerCareerMatchBonus : global::Common.WindowBase
{
    private class PostMatchTrustAnimation
    {
        private static readonly global::UnityEngine.Color IncreasedColor;
        private static readonly global::UnityEngine.Color DecreasedColor;
        private static readonly global::UnityEngine.Color DecreaseBackgroundColor;
        private static readonly int[] TierThresholds;
        private const float ProgressAnimationDuration = 0.85f;
        private const float NumberAnimationDuration = 0.65f;
        private const float AnimationDelay = 0.18f;
        private const float ChangeTextPopDuration = 0.16f;
        private const float LevelPopDuration = 0.2f;
        private const float LevelRecoverDuration = 0.14f;
        private const float BreakthroughFadeInDuration = 0.08f;
        private const float BreakthroughHoldDuration = 0.12f;
        private const float BreakthroughFadeOutDuration = 0.28f;
        private const float ProgressPulseDuration = 0.1f;
        private global::UnityEngine.MonoBehaviour host;
        private Win_PlayerCareerMatchBonus.PostMatchTrustCalculator calculator;
        private global::UnityEngine.UI.Text trustChangeText;
        private GUICoachTrust currentTrust;
        private global::UnityEngine.GameObject trustLevelChangeRoot;
        private global::UnityEngine.GameObject trustLevelUpIcon;
        private global::UnityEngine.GameObject trustLevelDownIcon;
        private global::UnityEngine.UI.Image nextLevelIcon;
        private global::UnityEngine.UI.Text nextLevelText;
        private global::UnityEngine.UI.Image frontProgress;
        private global::UnityEngine.UI.Image backgroundProgress;
        private global::DG.Tweening.Sequence trustAnimationSequence;
        private global::UnityEngine.Vector3 trustChangeTextDefaultScale;
        private global::UnityEngine.Vector3 trustLevelChangeDefaultScale;
        private global::UnityEngine.Vector3 trustProgressRootDefaultScale;
        private bool defaultStateCached;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.GameObject> breakthroughEffects;
        private bool CanPlayAnimation => false;

        public void Fill(global::UnityEngine.MonoBehaviour host, Win_PlayerCareerMatchBonus.PostMatchTrustCalculator calculator, global::UnityEngine.UI.Text trustChangeText, GUICoachTrust currentTrust, global::UnityEngine.GameObject trustLevelChangeRoot, global::UnityEngine.GameObject trustLevelUpIcon, global::UnityEngine.GameObject trustLevelDownIcon, global::UnityEngine.UI.Image nextLevelIcon, global::UnityEngine.UI.Text nextLevelText, global::UnityEngine.UI.Image frontProgress, global::UnityEngine.UI.Image backgroundProgress)
        {
        }

        private void Bind(global::UnityEngine.MonoBehaviour host, Win_PlayerCareerMatchBonus.PostMatchTrustCalculator calculator, global::UnityEngine.UI.Text trustChangeText, GUICoachTrust currentTrust, global::UnityEngine.GameObject trustLevelChangeRoot, global::UnityEngine.GameObject trustLevelUpIcon, global::UnityEngine.GameObject trustLevelDownIcon, global::UnityEngine.UI.Image nextLevelIcon, global::UnityEngine.UI.Text nextLevelText, global::UnityEngine.UI.Image frontProgress, global::UnityEngine.UI.Image backgroundProgress)
        {
        }

        private void ApplyStaticTrustInfo()
        {
        }

        private void SetProgressFinalState(float originalFill, float finalFill, CoachTrustTier originalTier, CoachTrustTier finalTier)
        {
        }

        private void PrepareProgressStartState(float originalFill, CoachTrustTier originalTier)
        {
        }

        private void PlayChangeAnimation(float originalFill, float finalFill, CoachTrustTier originalTier, CoachTrustTier finalTier)
        {
        }

        private void AppendChangeTextAnimation(global::DG.Tweening.Sequence targetSequence)
        {
        }

        private void AppendProgressAnimation(global::DG.Tweening.Sequence targetSequence, float originalFill, float finalFill, CoachTrustTier finalTier)
        {
        }

        private void AppendBreakthroughAnimations(global::DG.Tweening.Sequence targetSequence, float originalFill, float finalFill)
        {
        }

        private global::System.Collections.Generic.List<int> GetCrossedThresholds(int originalTrust, int finalTrust)
        {
            return null;
        }

        private void PlayBreakthroughFeedback(int thresholdTrust)
        {
        }

        private void PlayProgressRootPulse()
        {
        }

        private void PrepareLevelChangeAnimationState()
        {
        }

        private void PlayLevelChangeFeedback()
        {
        }

        private void ShowLevelChangeRootImmediate()
        {
        }

        private string FormatTrustChange(int trustChange)
        {
            return null;
        }

        private float GetTrustFillAmount(int trust)
        {
            return 0f;
        }

        private global::UnityEngine.RectTransform GetProgressRoot()
        {
            return null;
        }

        private global::UnityEngine.CanvasGroup EnsureCanvasGroup(global::UnityEngine.GameObject target)
        {
            return null;
        }

        private void CacheDefaultState()
        {
        }

        public void Kill()
        {
        }

        private void DestroyBreakthroughEffects()
        {
        }
    }

    private class PostMatchTrustCalculator
    {
        public int originalTrust;
        public int trustChange;
        public int finalTrust => 0;
        public bool IsTrustIncreased => false;
        public bool IsLevelChanged => false;

        public void SetSettlement(int originalTrust, int finalTrust)
        {
        }
    }

    private class PostMatchFinancialCalculator
    {
        public int basicEarning;
        public int preformanceBonus;
        public bool enableDoubleRV;
        private global::FL.PlayerCareer playerCareer;
        public int totalEarning => 0;

        public void SetSettlement(global::FL.PlayerCareer playerCareer, int basicEarning, int performanceBonus)
        {
        }

        public void OnDoubleRV()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text ingameRatingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image ingameRatingProgress;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text trustChangeText;
    [global::UnityEngine.SerializeField]
    private GUICoachTrust currentTrust;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject trustLevelChangeRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject trustLevelUpIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject trustLevelDownIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image nextLevelIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nextLevelText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image frontProgress;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image backgroundProgress;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text totalEarningText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text basicEarningText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text performanceBonusText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text doubleRVTipAfterText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject enableDoubleRVRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject RVUsedRoot;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo doubleRVReward;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerBaseInfo playerInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image teamLogo;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject baseBonusBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject doubleBonusBG;
    private Win_PlayerCareerMatchBonus.PostMatchTrustCalculator trustCalculator;
    private Win_PlayerCareerMatchBonus.PostMatchFinancialCalculator financialCalculator;
    private Win_PlayerCareerMatchBonus.PostMatchTrustAnimation trustAnimation;
    private global::UnityEngine.Coroutine totalEarningAnimation;
    private global::UnityEngine.Coroutine basicEarningAnimation;
    private global::UnityEngine.Coroutine performanceBonusAnimation;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(PlayerCareerInMatchManager playerCareerInMatchManager, CupMatchBase matchBase)
    {
    }

    private void UpdatePlayerModel(ClubPlayer player)
    {
    }

    private void FillTrustInfo()
    {
    }

    private static CoachTrustTier GetNextTier(CoachTrustTier tier)
    {
        return CoachTrustTier.TeamFringe;
    }

    private void FillFinancialInfo()
    {
    }

    private void SetupDoubleReward()
    {
    }

    private void OnDoubleRewardSuccess()
    {
    }

    public override void OnClose()
    {
    }
}
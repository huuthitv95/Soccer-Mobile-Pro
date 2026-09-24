namespace FL.TourEvent
{
    public class TourEventManager : global::Common.Singleton<global::FL.TourEvent.TourEventManager>
    {
        private struct PendingRewardPopup
        {
            public global::FLGameData.RewardType RewardType;
            public int Id;
            public int Amount;
            public bool enableDoubleReward;
            public PendingRewardPopup(global::FLGameData.RewardType rewardType, int id, int amount, bool enableDoubleReward)
            {
                RewardType = global::FLGameData.RewardType.Coins;
                Id = 0;
                Amount = 0;
                this.enableDoubleReward = false;
            }
        }

        private class StarterSlot
        {
            public int SlotIndex { get; private set; }
            public FormationTool.UIPosition[] MatchingPositions { get; private set; }
            public FormationTool.UIPosition PrimaryPosition { get; private set; }
            public FormationTool.PlayerCategory Category { get; private set; }
            public ClubPlayer SourcePlayer { get; set; }

            public StarterSlot(int slotIndex, FormationTool.UIPosition[] matchingPositions)
            {
            }
        }

        private class TeamSelectionDraft
        {
            public int TemplateTeamId { get; private set; }
            public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> Formation { get; private set; }
            public global::System.Collections.Generic.List<int> CopiedPlayerIds { get; private set; }

            public TeamSelectionDraft(int templateTeamId, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formation, global::System.Collections.Generic.List<int> copiedPlayerIds)
            {
            }
        }

        private const int InvalidPendingValue = -1;
        private const int StarterCount = 11;
        private const int InitialForwardReplacementCount = 1;
        private const int InitialMidfielderReplacementCount = 2;
        private const int InitialDefenderReplacementCount = 2;
        private const int StaminaRechargeValue = 3;
        private const int DefaultAppearanceId = -1;
        private const string EventTourEventNodePassed = "tour_event_node_passed";
        private const string EventTourEventNodeFailed = "tour_event_node_failed";
        private const string EventClaimedRewardsTourEvent = "claimed_rewards_tour_event";
        private const int ClaimedRewardTypeChapter = 0;
        private const int ClaimedRewardTypeAllChapterCompletion = 1;
        private readonly global::System.Collections.Generic.HashSet<string> validatedConfigKeys;
        private global::FL.TourEvent.TourEventConfig activeConfig;
        private string activeConfigFileName;
        private string loadedPointsShopConfigIndex;
        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> loadedPointsShopConfigs;
        private readonly global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.PendingRewardPopup> pendingRewardPopups;
        private readonly global::System.Collections.Generic.Dictionary<int, global::FL.TourEvent.TourEventManager.TeamSelectionDraft> teamSelectionDrafts;
        private readonly global::System.Collections.Generic.HashSet<int> redrawReplacementExcludedPlayerIds;
        public global::FL.TourEvent.TourEventConfigSwitch EventSwitch { get; private set; }
        public global::FL.PointsStoreMananger PointsStoreMananger { get; private set; }
        public RewardRelay RewardRelay => null;
        public global::Srv.TourEventArchive Archive => null;
        public global::FL.TourEvent.TourEventConfig ActiveConfig => null;
        public bool IsOpen => false;

        public bool HasSelectedTeam()
        {
            return false;
        }

        public Win_Formation OpenFormationView(global::System.Action onWindowClose = null)
        {
            return null;
        }

        public bool IsUnreplacedEventPlayer(ClubPlayer player)
        {
            return false;
        }

        public bool HasClaimableReward()
        {
            return false;
        }

        public bool NeedShowRedPoint()
        {
            return false;
        }

        public bool NeedShowWelcome()
        {
            return false;
        }

        public void MarkEntryOpened()
        {
        }

        public void OpenEventMainView()
        {
        }

        public bool HasPointsShopReward(global::FLGameData.RewardType rewardType, int rewardId)
        {
            return false;
        }

        public bool IsActiveEventId(int eventId)
        {
            return false;
        }

        private void OpenEventMainViewWindow()
        {
        }

        public bool CheckInit()
        {
            return false;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.SelectableTeamTemplateConfig> GetSelectableTeamTemplates()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventChapterConfig> GetChapters()
        {
            return null;
        }

        public global::FL.TourEvent.TourEventChapterConfig GetCurrentChapter()
        {
            return null;
        }

        public int GetCompletedLoopCount()
        {
            return 0;
        }

        public global::FL.TourEvent.TourEventCompletionRewardGroupConfig GetCurrentAllChapterCompletionRewardGroup()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetCurrentAllChapterCompletionRewards()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetChapterRewards(int chapterId)
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetNodeRewards(int nodeId)
        {
            return null;
        }

        public bool TryGetNodeConfig(int nodeId, out global::FL.TourEvent.TourEventChapterConfig chapter, out global::FL.TourEvent.TourEventNodeConfig node)
        {
            chapter = null;
            node = null;
            return false;
        }

        public bool IsChapterCompleted(int chapterId)
        {
            return false;
        }

        public bool IsChapterRewardClaimed(int chapterId)
        {
            return false;
        }

        public bool IsCompletedChapterFinalNode(int nodeId)
        {
            return false;
        }

        public bool AreAllChapterRewardsClaimed()
        {
            return false;
        }

        public bool AreAllChaptersCompleted()
        {
            return false;
        }

        public bool CanClaimChapterReward(int chapterId)
        {
            return false;
        }

        public bool CanClaimAllChapterCompletionReward()
        {
            return false;
        }

        public bool ClaimChapterReward(int chapterId)
        {
            return false;
        }

        public bool ClaimAllChapterCompletionReward()
        {
            return false;
        }

        public global::FL.EventChallengeStateHandler.ChallengeState GetNodeState(int nodeId)
        {
            return global::FL.EventChallengeStateHandler.ChallengeState.Locked;
        }

        public int GetCurrentFatigue()
        {
            return 0;
        }

        public int GetDailyFreeFatigueRechargeRemaining()
        {
            return 0;
        }

        public int GetPoints()
        {
            return 0;
        }

        public global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> GetShopConfigs()
        {
            return null;
        }

        public bool BuyShopItem(int itemId)
        {
            return false;
        }

        public string GetSelectableTeamName(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
            return null;
        }

        public Win_ChallengeTip OpenRewardTipView()
        {
            return null;
        }

        public bool TryOpenPendingRewardPopup(global::System.Action onWindowClose = null)
        {
            return false;
        }

        public bool SelectTeam(int templateTeamId)
        {
            return false;
        }

        public TeamsData GetOrCreateTeamSelectionPreview(int templateTeamId)
        {
            return null;
        }

        public TeamsData RefreshTeamSelectionPreview(int templateTeamId)
        {
            return null;
        }

        public bool ConfirmTeamSelection(int templateTeamId)
        {
            return false;
        }

        private bool TryInitializeSelectedTeam(int templateTeamId)
        {
            return false;
        }

        private global::FL.TourEvent.TourEventManager.TeamSelectionDraft GetOrCreateTeamSelectionDraft(int templateTeamId, bool refresh)
        {
            return null;
        }

        private bool TryLoadTeamSelectionDraft(int templateTeamId, out global::FL.TourEvent.TourEventManager.TeamSelectionDraft draft)
        {
            draft = null;
            return false;
        }

        private void SaveTeamSelectionDraft(global::FL.TourEvent.TourEventManager.TeamSelectionDraft draft)
        {
        }

        private global::Srv.TourEventTeamSelectionDraft GetArchiveTeamSelectionDraft(int templateTeamId)
        {
            return null;
        }

        private void ClearTeamSelectionDrafts()
        {
        }

        private global::FL.TourEvent.TourEventManager.TeamSelectionDraft CreateTeamSelectionDraft(int templateTeamId, bool useRefreshBonusPlayer = false)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> BuildTeamSelectionFormation(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> BuildTeamSelectionDraftSlots()
        {
            return null;
        }

        private global::System.Collections.Generic.List<int> GetShellTeamPlayerIds()
        {
            return null;
        }

        private int GetShellTeamPlayerCount()
        {
            return 0;
        }

        private TeamsData PrepareTeamSelectionShellTeam(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
            return null;
        }

        private TeamsData BuildTeamSelectionPreview(global::FL.TourEvent.TourEventManager.TeamSelectionDraft draft)
        {
            return null;
        }

        private TeamsData CreateTeamSelectionPreviewTeam(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formation)
        {
            return null;
        }

        private global::Srv.ClubTeamData CreateTemporaryTeamArchive(global::SL.TeamsProto shellProto, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formation)
        {
            return null;
        }

        private bool ReplaceWithTemporaryPlayers(TeamsData team, global::SL.TeamsProto shellProto)
        {
            return false;
        }

        private bool ApplyTeamSelectionDraft(global::FL.TourEvent.TourEventManager.TeamSelectionDraft draft)
        {
            return false;
        }

        private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> CopyFormation(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formation)
        {
            return null;
        }

        public TeamsData GetEventTeam()
        {
            return null;
        }

        private void SaveFormationTeam(TeamsData eventTeam)
        {
        }

        public bool CanStartNode(int nodeId)
        {
            return false;
        }

        public bool IsNodeLockedByFatigue(int nodeId)
        {
            return false;
        }

        public bool StartNode(int nodeId)
        {
            return false;
        }

        public bool TryCreateMatchNode(int nodeId, out global::FL.TourEvent.TourEventMatch match)
        {
            match = null;
            return false;
        }

        public global::Srv.TourEventNodeRuntimeData GetOrCreateNodeRuntimeData(int nodeId)
        {
            return null;
        }

        public int GetOrCreateOpponentTeamId(int nodeId)
        {
            return 0;
        }

        public bool TryGetOrCreateMomentChallengeDisplayInfo(int nodeId, out int userScore, out int opponentScore, out int targetTime, out global::FL.MomentChallenge.ChallegeTarget target)
        {
            userScore = default;
            opponentScore = default;
            targetTime = default;
            target = default;
            return false;
        }

        public global::Srv.TourEventNodeRuntimeData GetRandomEventResult(int nodeId)
        {
            return null;
        }

        public global::Srv.TourEventNodeRuntimeData RefreshRandomEventResult(int nodeId)
        {
            return null;
        }

        public bool CompleteMatchNode(int nodeId, CupMatchBase.MatchSettlementData matchData, bool isWin)
        {
            return false;
        }

        public bool CompleteTourEventMatch(global::FL.TourEvent.TourEventMatch match, CupMatchBase.MatchSettlementData matchData, bool isWin)
        {
            return false;
        }

        public bool FailTourEventMatch(global::FL.TourEvent.TourEventMatch match)
        {
            return false;
        }

        public bool CompleteRandomEventNode(int nodeId, int fatigueDelta)
        {
            return false;
        }

        public bool CompleteRandomEventNode(int nodeId)
        {
            return false;
        }

        private void LogNodePassed(global::FL.TourEvent.TourEventNodeConfig node)
        {
        }

        private void LogNodeFailed(global::FL.TourEvent.TourEventNodeConfig node)
        {
        }

        private void LogClaimedRewards(int type, int id)
        {
        }

        public bool GenerateReplacementReward(int nodeId)
        {
            return false;
        }

        private bool IsLastChapterFinalNode(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventNodeConfig node)
        {
            return false;
        }

        public bool ConfirmReplacementReward()
        {
            return false;
        }

        public bool CanRedrawReplacementReward(int currentPlayerId)
        {
            return false;
        }

        public bool TryRedrawReplacementReward(int currentPlayerId, out ClubPlayer replacementPlayer)
        {
            replacementPlayer = null;
            return false;
        }

        public bool TryConsumePendingReplacementReward(out ClubPlayer replacementPlayer)
        {
            replacementPlayer = null;
            return false;
        }

        public void ClearPendingReplacement()
        {
        }

        public bool TryRechargeFatigue(bool useDailyFreeRecharge)
        {
            return false;
        }

        public bool CanRechargeFatigue(bool useDailyFreeRecharge)
        {
            return false;
        }

        public void ResetForEventChanged()
        {
        }

        private void TryConvertExpiredPointsToCoins()
        {
        }

        private void ConvertRemainingPointsToCoins(global::FL.TourEvent.TourEventConfig config)
        {
        }

        private int CalculateExpiredPointCoinValue(int points, global::FL.TourEvent.TourEventConfig config)
        {
            return 0;
        }

        private void ResetArchive(global::FL.TourEvent.TourEventConfig config)
        {
        }

        private global::FL.TourEvent.TourEventConfig LoadActiveConfig(string configFileName)
        {
            return null;
        }

        private void InitializeNodeStates(global::FL.TourEvent.TourEventConfig config)
        {
        }

        private void EnsureArchiveObjects()
        {
        }

        private void EnsureInitialStaminaForFreshArchive()
        {
        }

        private bool HasStartedNodeProgress()
        {
            return false;
        }

        private void ResetLoopProgress()
        {
        }

        private void ClearPendingReplacementState()
        {
        }

        private void ActivateNextChapterAfterRewardClaim(global::FL.TourEvent.TourEventChapterConfig claimedChapter)
        {
        }

        private int GetFirstUnlockedNodeId(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return 0;
        }

        private void EnsurePointsStoreMananger(global::FL.TourEvent.TourEventConfig config)
        {
        }

        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> LoadPointsShopConfigs(string configIndex)
        {
            return null;
        }

        private void OnGainShopReward(global::FLDataTable.PointsShopConfig config)
        {
        }

        private bool ApplyFormation(TeamsData shellTeam, global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
            return false;
        }

        private void ApplyConfiguredTeamName(TeamsData team, global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
        }

        private bool ApplyArchivedFormation(TeamsData shellTeam)
        {
            return false;
        }

        private void ApplyArchivedPlayerOrder(TeamsData shellTeam)
        {
        }

        private bool RestoreTeamPlayersFromProto(TeamsData shellTeam)
        {
            return false;
        }

        private void InitializePlayerTeamArchive(TeamsData shellTeam, int selectedTeamTemplateId)
        {
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> BuildStarterSlots(TeamsData shellTeam, TeamsData selectedTeam)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> BuildAllReplacementSlots(TeamsData shellTeam, TeamsData selectedTeam)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> BuildReplacementSlots(TeamsData shellTeam, TeamsData selectedTeam, int maxSlotCount)
        {
            return null;
        }

        private FormationTool.UIPosition[] CopyPreferredPositions(global::SL.Player player)
        {
            return null;
        }

        private int CompareStarterSlotForSourceSelection(global::FL.TourEvent.TourEventManager.StarterSlot left, global::FL.TourEvent.TourEventManager.StarterSlot right)
        {
            return 0;
        }

        private int GetSourceSelectionOrder(FormationTool.PlayerCategory category)
        {
            return 0;
        }

        private ClubPlayer SelectBestSourcePlayer(TeamsData selectedTeam, global::FL.TourEvent.TourEventManager.StarterSlot starterSlot, global::System.Collections.Generic.HashSet<int> usedPlayerIds)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> SelectInitialReplacementSlots(global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> starterSlots)
        {
            return null;
        }

        private void AddRandomSlotsByCategory(global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> sourceSlots, global::System.Collections.Generic.List<global::FL.TourEvent.TourEventManager.StarterSlot> selectedSlots, FormationTool.PlayerCategory category, int count)
        {
        }

        private bool TryDrawPlayerForSlot(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, global::FL.TourEvent.TourEventManager.StarterSlot starterSlot, global::System.Collections.Generic.HashSet<int> usedPlayerIds, bool useAbilityRange, out ClubPlayer targetPlayer)
        {
            targetPlayer = null;
            return false;
        }

        private void BuildReplacementCandidates(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, global::FL.TourEvent.TourEventManager.StarterSlot starterSlot, global::System.Collections.Generic.HashSet<int> usedPlayerIds, bool useAbilityRange, global::System.Collections.Generic.List<ClubPlayer> exactCandidates, global::System.Collections.Generic.List<ClubPlayer> categoryCandidates)
        {
        }

        private bool IsQualifiedReplacementAbility(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, ClubPlayer candidate, global::FL.TourEvent.TourEventManager.StarterSlot starterSlot, bool useAbilityRange)
        {
            return false;
        }

        private string GetReplacementAbilityText(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, bool useAbilityRange)
        {
            return null;
        }

        private int GetReplacementPositionRating(ClubPlayer player, global::FL.TourEvent.TourEventManager.StarterSlot starterSlot)
        {
            return 0;
        }

        private bool HasMatchingPosition(ClubPlayer candidate, FormationTool.UIPosition[] slotPositions)
        {
            return false;
        }

        private bool HasCategory(ClubPlayer candidate, FormationTool.PlayerCategory sourceCategory)
        {
            return false;
        }

        private void ApplyReplacement(TeamsData shellTeam, int slotIndex, ClubPlayer targetPlayer)
        {
        }

        private void ApplyPlayerToShellSlot(TeamsData shellTeam, int slotIndex, ClubPlayer targetPlayer)
        {
        }

        private global::System.Collections.Generic.HashSet<int> BuildRedrawReplacementUsedPlayerIds()
        {
            return null;
        }

        private int FindCopiedPlayerSlotIndex(int playerId)
        {
            return 0;
        }

        private bool TryGetRedrawReplacementData(int currentPlayerId, out TeamsData shellTeam, out global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate, out global::FL.TourEvent.TourEventManager.StarterSlot starterSlot, out int slotIndex)
        {
            shellTeam = null;
            teamTemplate = null;
            starterSlot = null;
            slotIndex = default;
            return false;
        }

        private bool TryGetReplacementSlot(TeamsData shellTeam, TeamsData selectedTeam, int slotIndex, out global::FL.TourEvent.TourEventManager.StarterSlot starterSlot)
        {
            starterSlot = null;
            return false;
        }

        private void SavePlayerTeamArchive(TeamsData shellTeam)
        {
        }

        private global::System.Collections.Generic.Dictionary<int, int> BuildCopiedPlayerIdMap()
        {
            return null;
        }

        private void EnsureCopiedPlayerIds(int playerCount)
        {
        }

        private global::System.Collections.Generic.HashSet<int> GetCopiedPlayerIdSet()
        {
            return null;
        }

        private global::Srv.TourEventNodeRuntimeData GetOrCreateArchiveNodeRuntimeData(int nodeId)
        {
            return null;
        }

        private global::Srv.TourEventNodeRuntimeData GetArchiveNodeRuntimeData(int nodeId)
        {
            return null;
        }

        private bool TryGetOrCreateMomentChallengeLevel(global::FL.TourEvent.TourEventNodeConfig node, out global::FLDataTable.MomentChallengeLevelConfig levelConfig, out int targetTime)
        {
            levelConfig = null;
            targetTime = default;
            return false;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.MomentChallengeLevelConfig> LoadTourEventMomentChallengeLevels()
        {
            return null;
        }

        private string GetMomentChallengeLevelConfigPath()
        {
            return null;
        }

        private bool EnsureNodeRuntimeData(global::Srv.TourEventNodeRuntimeData runtimeData, global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventNodeConfig node, bool refreshRandomEvent)
        {
            return false;
        }

        private int DrawOpponentTeamId(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventNodeConfig node)
        {
            return 0;
        }

        private int DrawRandomEventFatigueDelta(string randomEventType)
        {
            return 0;
        }

        private string DrawRandomEventTextId(int fatigueDelta)
        {
            return null;
        }

        private string GetRandomEventTextGroupKey(int fatigueDelta)
        {
            return null;
        }

        private void ApplyNodeFatigue(global::FL.TourEvent.TourEventChapterConfig chapter, int fatigueDelta)
        {
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventChapterConfig> GetCurrentLoopChapters()
        {
            return null;
        }

        private void AddLoopChapter(global::System.Collections.Generic.List<global::FL.TourEvent.TourEventChapterConfig> chapters, global::System.Collections.Generic.HashSet<int> addedChapterIds, global::FL.TourEvent.TourEventChapterConfig chapter)
        {
        }

        private void AddNextLoopChapters(global::System.Collections.Generic.List<global::FL.TourEvent.TourEventChapterConfig> chapters, global::System.Collections.Generic.HashSet<int> addedChapterIds, global::FL.TourEvent.TourEventChapterConfig startChapter)
        {
        }

        private global::FL.TourEvent.TourEventChapterConfig GetEntryChapterConfig(global::FL.TourEvent.TourEventConfig config)
        {
            return null;
        }

        private global::FL.TourEvent.TourEventChapterConfig GetCurrentChapterConfig()
        {
            return null;
        }

        private int GetFirstEntryNodeId(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return 0;
        }

        private void UnlockChapterEntryNodes(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
        }

        private int GetChapterDefaultStamina(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return 0;
        }

        private int GetStaminaCapacity(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return 0;
        }

        private void GrantNodeRewards(global::FL.TourEvent.TourEventNodeConfig node)
        {
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetConfiguredNodeRewards(global::FL.TourEvent.TourEventNodeConfig node)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetClaimableChapterRewards(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return null;
        }

        private bool IsChapterCompleted(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return false;
        }

        private void GrantRewards(global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> rewards, string source)
        {
        }

        private void EnqueueRewardPopup(global::FLGameData.RewardType rewardType, int id, int amount, bool enableDoubleReward)
        {
        }

        private void ShowRewardPopup(Win_ChallengeTip win, global::FL.TourEvent.TourEventManager.PendingRewardPopup rewardPopup)
        {
        }

        private void ShowBallOrJerseyRewardPopup(Win_ChallengeTip win, int itemId)
        {
        }

        private ClubPlayer GetRewardPlayer(int playerId)
        {
            return null;
        }

        private void GrantReward(global::FL.TourEvent.TourEventRewardConfig reward, string source)
        {
        }

        private void GrantReward(global::FLGameData.RewardType rewardType, int id, int amount, string source)
        {
        }

        private void UnlockNextNodes(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventNodeConfig node)
        {
        }

        private void UnlockNode(int nodeId)
        {
        }

        private TeamsData LoadTeam(int teamId)
        {
            return null;
        }

        private ClubPlayer GetPlayer(int playerId)
        {
            return null;
        }

        private void ValidateConfigOnce(global::FL.TourEvent.TourEventConfig config)
        {
        }

        private bool IsSupportedRewardType(global::FLGameData.RewardType rewardType)
        {
            return false;
        }

        private void ValidatePlayerPoolForFormation(global::FL.TourEvent.SelectableTeamTemplateConfig teamTemplate)
        {
        }

        private void SaveArchive()
        {
        }
    }
}
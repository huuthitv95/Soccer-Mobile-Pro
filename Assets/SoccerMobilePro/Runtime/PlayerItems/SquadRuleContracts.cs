using System;
using System.Collections.Generic;

namespace SoccerMobilePro.PlayerItems
{
    public enum UpgradeFailureOutcome { Keep = 0, Downgrade = 1, Consume = 2 }

    public enum TeamColorAttribute { Club = 0, Nation = 1, League = 2, Season = 3 }

    public enum SquadCountingScope { StartingXI = 0, MatchSquad = 1 }

    public enum SquadValidationCode
    {
        None = 0,
        FeatureDisabled = 1,
        StaleRules = 2,
        StaleCatalog = 3,
        OwnerMismatch = 4,
        UnknownFormation = 5,
        SquadSlotOutOfRange = 6,
        StartingCountMismatch = 7,
        UnknownPositionSlot = 8,
        DuplicateAssignment = 9,
        ItemNotFound = 10,
        ItemNotAssignable = 11,
        BenchCountMismatch = 12,
        SalaryCapExceeded = 13,
        CaptainNotInStartingXi = 14,
        SetPieceTakerNotInStartingXi = 15,
        PositionProficiencyMismatch = 16
    }

    public sealed class CardSeasonDefinition
    {
        public string SeasonId { get; set; } = string.Empty;
        public string DisplayNameKey { get; set; } = string.Empty;
        public DateTimeOffset ReleasedAt { get; set; }
        public string StatProfileId { get; set; } = string.Empty;
        public string MarketClass { get; set; } = string.Empty;
        public string RightsVersion { get; set; } = string.Empty;
        public string RulesVersion { get; set; } = string.Empty;
    }

    public sealed class MaterialCost
    {
        public string ResourceId { get; set; } = string.Empty;
        public long Amount { get; set; }
    }

    public sealed class UpgradeTierStep
    {
        public int FromTier { get; set; }
        public int SuccessRateBasisPoints { get; set; }
        public long CurrencyCost { get; set; }
        public List<MaterialCost> Materials { get; set; } = new List<MaterialCost>();
        public UpgradeFailureOutcome FailureOutcome { get; set; }
        public string InsuranceResourceId { get; set; } = string.Empty;
        public long InsuranceAmount { get; set; }
    }

    public sealed class StatModifier
    {
        public string AttributeId { get; set; } = string.Empty;
        public int BasisPoints { get; set; }
    }

    public sealed class TeamColorThreshold
    {
        public int MinCount { get; set; }
        public string BonusProfileId { get; set; } = string.Empty;
    }

    public sealed class TeamColorBonusProfile
    {
        public string ProfileId { get; set; } = string.Empty;
        public string TraceLabelKey { get; set; } = string.Empty;
        public List<StatModifier> StatModifiers { get; set; } = new List<StatModifier>();
    }

    public sealed class SalaryBand
    {
        public int MinOverall { get; set; }
        public long BaseSalary { get; set; }
    }

    public sealed class FormationDefinition
    {
        public string FormationId { get; set; } = string.Empty;
        public List<string> PositionSlotIds { get; set; } = new List<string>();
    }

    public interface ICardSeasonRuleSet
    {
        string RulesVersion { get; }
        IReadOnlyList<CardSeasonDefinition> Seasons { get; }
        bool TryGetSeason(string seasonId, out CardSeasonDefinition definition);
        string ResolveSeasonId(string programId);
    }

    public interface IUpgradeTierRuleSet
    {
        string RulesVersion { get; }
        int MaxTier { get; }
        bool TryGetStep(int fromTier, out UpgradeTierStep step);
        int StatScalingBasisPoints(int tier);
    }

    public interface ITrainingRuleSet
    {
        string RulesVersion { get; }
        int MaxLevel { get; }
        bool TryGetPointsRequiredForLevel(int level, out int points);
        int StatGainBasisPoints(int level);
        IReadOnlyList<string> PointSources { get; }
    }

    public interface ITeamColorRuleSet
    {
        string RulesVersion { get; }
        IReadOnlyList<TeamColorAttribute> CountedAttributes { get; }
        SquadCountingScope CountingScope { get; }
        IReadOnlyList<TeamColorThreshold> Thresholds { get; }
        bool TryGetProfile(string profileId, out TeamColorBonusProfile profile);
        string ResolveProfileId(int count);
    }

    public interface ISalaryRuleSet
    {
        string RulesVersion { get; }
        long BaseSalaryForOverall(int overall);
        int TierSalaryScalingBasisPoints(int tier);
    }

    public interface ISquadRuleSet
    {
        string RulesVersion { get; }
        int StartingCount { get; }
        int BenchCount { get; }
        int MaxSquadSlots { get; }
        long SalaryCapBase { get; }
        long SalaryCapExpansionMax { get; }
        SquadCountingScope SalaryCountingScope { get; }
        IReadOnlyList<string> FormationIds { get; }
        bool TryGetFormation(string formationId, out FormationDefinition formation);
    }

    public sealed class TeamColorTag
    {
        public string ClubId { get; set; } = string.Empty;
        public string NationId { get; set; } = string.Empty;
        public string LeagueId { get; set; } = string.Empty;
        public string SeasonId { get; set; } = string.Empty;

        public string ValueFor(TeamColorAttribute attribute)
        {
            switch (attribute)
            {
                case TeamColorAttribute.Club: return ClubId ?? string.Empty;
                case TeamColorAttribute.Nation: return NationId ?? string.Empty;
                case TeamColorAttribute.League: return LeagueId ?? string.Empty;
                case TeamColorAttribute.Season: return SeasonId ?? string.Empty;
                default: return string.Empty;
            }
        }
    }

    public sealed class TeamColorMatch
    {
        public TeamColorAttribute Attribute { get; set; }
        public string ValueId { get; set; } = string.Empty;
        public int Count { get; set; }
        public string BonusProfileId { get; set; } = string.Empty;
    }

    public sealed class TeamColorEvaluation
    {
        public SquadCountingScope Scope { get; set; }
        public int CountedItems { get; set; }
        public List<TeamColorMatch> Matches { get; set; } = new List<TeamColorMatch>();
        public TeamColorMatch Best { get; set; }
    }

    public sealed class SquadSlotAssignment
    {
        public string PositionSlotId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
    }

    public sealed class SetPieceTakers
    {
        public string FreeKickItemId { get; set; } = string.Empty;
        public string PenaltyItemId { get; set; } = string.Empty;
        public string CornerItemId { get; set; } = string.Empty;
        public string ThrowInItemId { get; set; } = string.Empty;
    }

    public sealed class SquadValidationIssue
    {
        public SquadValidationCode Code { get; set; }
        public string PositionSlotId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
    }

    public sealed class SquadValidationResult
    {
        public bool IsValid { get; set; }
        public bool IsPlayable { get; set; }
        public bool CanSave { get; set; }
        public long SalaryTotal { get; set; }
        public long SalaryCap { get; set; }
        public TeamColorEvaluation TeamColor { get; set; }
        public List<SquadValidationIssue> Errors { get; set; } = new List<SquadValidationIssue>();
        public List<SquadValidationIssue> Warnings { get; set; } = new List<SquadValidationIssue>();
    }

    public sealed class SquadDefinition
    {
        public string SquadId { get; set; } = string.Empty;
        public string OwnerId { get; set; } = string.Empty;
        public int SlotIndex { get; set; }
        public string FormationId { get; set; } = string.Empty;
        public List<SquadSlotAssignment> Assignments { get; set; } = new List<SquadSlotAssignment>();
        public List<string> BenchItemIds { get; set; } = new List<string>();
        public string TacticProfileId { get; set; } = string.Empty;
        public SetPieceTakers SetPieceTakers { get; set; } = new SetPieceTakers();
        public string CaptainItemId { get; set; } = string.Empty;
        public string KitId { get; set; } = string.Empty;
        public string StadiumId { get; set; } = string.Empty;
        public string BallId { get; set; } = string.Empty;
        public long SalaryCapExpansion { get; set; }
        public bool IsPlayable { get; set; }
        public long Revision { get; set; }
        public string RulesVersion { get; set; } = string.Empty;
        public string CatalogVersion { get; set; } = string.Empty;

        public SquadDefinition Clone()
        {
            SetPieceTakers takers = SetPieceTakers ?? new SetPieceTakers();
            return new SquadDefinition
            {
                SquadId = SquadId,
                OwnerId = OwnerId,
                SlotIndex = SlotIndex,
                FormationId = FormationId,
                Assignments = new List<SquadSlotAssignment>(CloneAssignments()),
                BenchItemIds = new List<string>(BenchItemIds ?? new List<string>()),
                TacticProfileId = TacticProfileId,
                SetPieceTakers = new SetPieceTakers
                {
                    FreeKickItemId = takers.FreeKickItemId,
                    PenaltyItemId = takers.PenaltyItemId,
                    CornerItemId = takers.CornerItemId,
                    ThrowInItemId = takers.ThrowInItemId
                },
                CaptainItemId = CaptainItemId,
                KitId = KitId,
                StadiumId = StadiumId,
                BallId = BallId,
                SalaryCapExpansion = SalaryCapExpansion,
                IsPlayable = IsPlayable,
                Revision = Revision,
                RulesVersion = RulesVersion,
                CatalogVersion = CatalogVersion
            };
        }

        private IEnumerable<SquadSlotAssignment> CloneAssignments()
        {
            foreach (SquadSlotAssignment assignment in Assignments ?? new List<SquadSlotAssignment>())
            {
                yield return new SquadSlotAssignment { PositionSlotId = assignment.PositionSlotId, ItemId = assignment.ItemId };
            }
        }
    }

    public interface ITeamColorTagResolver
    {
        bool TryResolve(OwnedPlayerItem item, out TeamColorTag tag);
    }

    public interface ITeamColorCalculator
    {
        TeamColorEvaluation Evaluate(IReadOnlyList<OwnedPlayerItem> startingEleven, IReadOnlyList<OwnedPlayerItem> bench);
    }

    public interface ISalaryCalculator
    {
        long SalaryFor(OwnedPlayerItem item);
        long TotalFor(IEnumerable<OwnedPlayerItem> items);
    }

    public interface ISquadValidator
    {
        SquadValidationResult Validate(InventorySnapshot snapshot, SquadDefinition definition);
    }

    public interface ISquadRepository
    {
        bool TryLoad(string ownerId, int slotIndex, out SquadDefinition definition);
        IReadOnlyList<SquadDefinition> LoadAll(string ownerId);
        bool TrySave(SquadDefinition definition, long expectedRevision, bool isPlayable);
    }

    public sealed class PlayerItemsRuleSetException : Exception
    {
        public PlayerItemsRuleSetException(string message) : base(message) { }
        public PlayerItemsRuleSetException(string message, Exception innerException) : base(message, innerException) { }
    }
}

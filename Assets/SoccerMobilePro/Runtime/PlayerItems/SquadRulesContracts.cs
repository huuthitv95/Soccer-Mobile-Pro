using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06: contract cho card season, upgrade tier, training, team color va squad.
    // Toan bo file la domain thuan (khong dung UnityEngine) de chay duoc trong EditMode test va tren server.

    public enum UpgradeFailureOutcome { Keep = 0, Downgrade = 1, Consume = 2 }
    public enum UpgradeAttemptOutcome { Success = 0, Failure = 1 }
    public enum TeamColorAttribute { Club = 0, Nation = 1, Season = 2, League = 3 }
    public enum SquadCountingScope { StartingXI = 0, MatchSquad = 1 }

    public enum SquadValidationCode
    {
        None = 0,
        FeatureDisabled = 1,
        FormationUnknown = 2,
        SlotUnknown = 3,
        SlotEmpty = 4,
        DuplicateItem = 5,
        ItemNotFound = 6,
        OwnerMismatch = 7,
        ItemUnavailable = 8,
        ItemLocked = 9,
        BenchIncomplete = 10,
        SalaryCapExceeded = 11,
        PositionMismatch = 12,
        CaptainNotInStartingXI = 13,
        SetPieceTakerNotInSquad = 14,
        RulesVersionMismatch = 15,
        SquadSlotLimitExceeded = 16
    }

    public static class SquadRulesFeature
    {
        public const string FlagKey = "PlayerItems.SquadRules";
    }

    public interface ISquadRulesFeatureFlag
    {
        bool IsEnabled { get; }
    }

    public sealed class FixedSquadRulesFeatureFlag : ISquadRulesFeatureFlag
    {
        public FixedSquadRulesFeatureFlag(bool isEnabled = false)
        {
            IsEnabled = isEnabled;
        }

        public bool IsEnabled { get; }
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

    public sealed class TeamColorTags
    {
        public string ClubId { get; set; } = string.Empty;
        public string NationId { get; set; } = string.Empty;
        public string SeasonId { get; set; } = string.Empty;
        public string LeagueId { get; set; } = string.Empty;

        public bool TryGetValue(TeamColorAttribute attribute, out string value)
        {
            switch (attribute)
            {
                case TeamColorAttribute.Club: value = ClubId ?? string.Empty; break;
                case TeamColorAttribute.Nation: value = NationId ?? string.Empty; break;
                case TeamColorAttribute.Season: value = SeasonId ?? string.Empty; break;
                case TeamColorAttribute.League: value = LeagueId ?? string.Empty; break;
                default: value = string.Empty; break;
            }

            return value.Length > 0;
        }

        public TeamColorTags Clone()
            => new TeamColorTags { ClubId = ClubId, NationId = NationId, SeasonId = SeasonId, LeagueId = LeagueId };
    }

    public sealed class CardSalaryBand
    {
        public int MinOverall { get; set; }
        public long BaseSalary { get; set; }
    }

    public sealed class CardEconomyOverride
    {
        public string ItemDefinitionId { get; set; } = string.Empty;
        public string SeasonId { get; set; } = string.Empty;
        public long? BaseSalary { get; set; }
    }

    public sealed class CardEconomyProfile
    {
        public string ItemDefinitionId { get; set; } = string.Empty;
        public string SeasonId { get; set; } = string.Empty;
        public long BaseSalary { get; set; }
        public int BaseOverall { get; set; }
        public TeamColorTags Tags { get; set; } = new TeamColorTags();
    }

    public sealed class UpgradeMaterialCost
    {
        public string ResourceId { get; set; } = string.Empty;
        public long Amount { get; set; }
    }

    public sealed class UpgradeTierStep
    {
        public int Tier { get; set; }
        public int SuccessRateBasisPoints { get; set; }
        public long CurrencyCost { get; set; }
        public UpgradeFailureOutcome FailureOutcome { get; set; }
        public string InsuranceItemId { get; set; } = string.Empty;
        public List<UpgradeMaterialCost> MaterialCost { get; set; } = new List<UpgradeMaterialCost>();

        public string CanonicalMaterials()
            => string.Join(",", (MaterialCost ?? new List<UpgradeMaterialCost>())
                .OrderBy(cost => cost.ResourceId, StringComparer.Ordinal)
                .Select(cost => cost.ResourceId + ":" + cost.Amount.ToString(CultureInfo.InvariantCulture)));
    }

    public sealed class UpgradeTierAttemptPreview
    {
        public string OwnerId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public long InventoryRevision { get; set; }
        public long ItemRevision { get; set; }
        public string CatalogVersion { get; set; } = string.Empty;
        public string RulesVersion { get; set; } = string.Empty;
        public int FromTier { get; set; }
        public int ToTier { get; set; }
        public int SuccessRateBasisPoints { get; set; }
        public long CurrencyCost { get; set; }
        public List<UpgradeMaterialCost> MaterialCost { get; set; } = new List<UpgradeMaterialCost>();
        public UpgradeFailureOutcome FailureOutcome { get; set; }
        public string InsuranceItemId { get; set; } = string.Empty;
        public bool InsuranceApplied { get; set; }
        public int StatScalingBasisPoints { get; set; }
        public int SalaryScalingBasisPoints { get; set; }
        public DateTimeOffset ExpiresAt { get; set; }
        public string PreviewHash { get; set; } = string.Empty;

        public string CanonicalValue()
        {
            string materials = string.Join(",", (MaterialCost ?? new List<UpgradeMaterialCost>())
                .OrderBy(cost => cost.ResourceId, StringComparer.Ordinal)
                .Select(cost => cost.ResourceId + ":" + cost.Amount.ToString(CultureInfo.InvariantCulture)));
            return string.Join("|",
                OwnerId,
                ItemId,
                InventoryRevision.ToString(CultureInfo.InvariantCulture),
                ItemRevision.ToString(CultureInfo.InvariantCulture),
                CatalogVersion,
                RulesVersion,
                FromTier.ToString(CultureInfo.InvariantCulture),
                ToTier.ToString(CultureInfo.InvariantCulture),
                SuccessRateBasisPoints.ToString(CultureInfo.InvariantCulture),
                CurrencyCost.ToString(CultureInfo.InvariantCulture),
                materials,
                ((int)FailureOutcome).ToString(CultureInfo.InvariantCulture),
                InsuranceItemId ?? string.Empty,
                InsuranceApplied ? "1" : "0",
                StatScalingBasisPoints.ToString(CultureInfo.InvariantCulture),
                SalaryScalingBasisPoints.ToString(CultureInfo.InvariantCulture),
                ExpiresAt.UtcTicks.ToString(CultureInfo.InvariantCulture));
        }
    }

    public sealed class UpgradeTierAttemptCommand
    {
        public string OwnerId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public long ExpectedInventoryRevision { get; set; }
        public long ExpectedItemRevision { get; set; }
        public string PreviewHash { get; set; } = string.Empty;
        public bool UseInsurance { get; set; }
        public string IdempotencyKey { get; set; } = string.Empty;

        public string CanonicalPayload()
            => string.Join("|",
                OwnerId,
                ItemId,
                ExpectedInventoryRevision.ToString(CultureInfo.InvariantCulture),
                ExpectedItemRevision.ToString(CultureInfo.InvariantCulture),
                PreviewHash,
                UseInsurance ? "1" : "0");
    }

    // TransactionReceipt la sealed nen bien lai tier dung composition thay vi ke thua.
    public sealed class UpgradeTierAttemptReceipt
    {
        public TransactionReceipt Transaction { get; set; }
        public UpgradeAttemptOutcome Outcome { get; set; }
        public int ResultTier { get; set; }
        public UpgradeFailureOutcome AppliedFailureOutcome { get; set; }
        public bool InsuranceConsumed { get; set; }
        public string RollAuditHash { get; set; } = string.Empty;
    }

    public sealed class TrainingAttemptPreview
    {
        public string OwnerId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public long InventoryRevision { get; set; }
        public long ItemRevision { get; set; }
        public string RulesVersion { get; set; } = string.Empty;
        public int FromLevel { get; set; }
        public int ToLevel { get; set; }
        public int PointsSpent { get; set; }
        public int PointsRequired { get; set; }
        public int StatGainBasisPoints { get; set; }
        public DateTimeOffset ExpiresAt { get; set; }
        public string PreviewHash { get; set; } = string.Empty;

        public string CanonicalValue()
            => string.Join("|",
                OwnerId,
                ItemId,
                InventoryRevision.ToString(CultureInfo.InvariantCulture),
                ItemRevision.ToString(CultureInfo.InvariantCulture),
                RulesVersion,
                FromLevel.ToString(CultureInfo.InvariantCulture),
                ToLevel.ToString(CultureInfo.InvariantCulture),
                PointsSpent.ToString(CultureInfo.InvariantCulture),
                PointsRequired.ToString(CultureInfo.InvariantCulture),
                StatGainBasisPoints.ToString(CultureInfo.InvariantCulture),
                ExpiresAt.UtcTicks.ToString(CultureInfo.InvariantCulture));
    }

    public sealed class TrainingCommand
    {
        public string OwnerId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public long ExpectedInventoryRevision { get; set; }
        public long ExpectedItemRevision { get; set; }
        public string PreviewHash { get; set; } = string.Empty;
        public int PointsToSpend { get; set; }
        public string IdempotencyKey { get; set; } = string.Empty;

        public string CanonicalPayload()
            => string.Join("|",
                OwnerId,
                ItemId,
                ExpectedInventoryRevision.ToString(CultureInfo.InvariantCulture),
                ExpectedItemRevision.ToString(CultureInfo.InvariantCulture),
                PreviewHash,
                PointsToSpend.ToString(CultureInfo.InvariantCulture));
    }

    public sealed class TrainingReceipt
    {
        public TransactionReceipt Transaction { get; set; }
        public int ResultLevel { get; set; }
        public int ResultPoints { get; set; }
    }

    public sealed class StatModifier
    {
        public string AttributeId { get; set; } = string.Empty;
        public int BasisPoints { get; set; }
    }

    public sealed class TeamColorBonusProfile
    {
        public string ProfileId { get; set; } = string.Empty;
        public string TraceLabelKey { get; set; } = string.Empty;
        public List<StatModifier> StatModifiers { get; set; } = new List<StatModifier>();
    }

    public sealed class TeamColorThreshold
    {
        public int MinCount { get; set; }
        public string BonusProfileId { get; set; } = string.Empty;
    }

    public sealed class TeamColorResult
    {
        public TeamColorAttribute Attribute { get; set; }
        public string TagValue { get; set; } = string.Empty;
        public int Count { get; set; }
        public SquadCountingScope Scope { get; set; }
        public string BonusProfileId { get; set; } = string.Empty;
    }

    public sealed class FormationSlot
    {
        public string PositionSlotId { get; set; } = string.Empty;
        public string PositionId { get; set; } = string.Empty;
    }

    public sealed class FormationDefinition
    {
        public string FormationId { get; set; } = string.Empty;
        public List<FormationSlot> PositionSlots { get; set; } = new List<FormationSlot>();

        public bool TryGetSlot(string positionSlotId, out FormationSlot slot)
        {
            slot = (PositionSlots ?? new List<FormationSlot>())
                .FirstOrDefault(candidate => string.Equals(candidate.PositionSlotId, positionSlotId, StringComparison.Ordinal));
            return slot != null;
        }
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
        public string LongThrowItemId { get; set; } = string.Empty;

        public IReadOnlyList<string> AssignedItemIds()
            => new[] { FreeKickItemId, PenaltyItemId, CornerItemId, LongThrowItemId }
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .Distinct(StringComparer.Ordinal)
                .ToList();

        public SetPieceTakers Clone()
            => new SetPieceTakers
            {
                FreeKickItemId = FreeKickItemId,
                PenaltyItemId = PenaltyItemId,
                CornerItemId = CornerItemId,
                LongThrowItemId = LongThrowItemId
            };
    }

    public sealed class SquadDefinition
    {
        public string SquadId { get; set; } = string.Empty;
        public string OwnerId { get; set; } = string.Empty;
        public int SlotIndex { get; set; }
        public string FormationId { get; set; } = string.Empty;
        public List<SquadSlotAssignment> Assignments { get; set; } = new List<SquadSlotAssignment>();
        public List<string> BenchItemIds { get; set; } = new List<string>();
        public string CaptainItemId { get; set; } = string.Empty;
        public string TacticProfileId { get; set; } = string.Empty;
        public SetPieceTakers SetPieceTakers { get; set; } = new SetPieceTakers();
        public string KitId { get; set; } = string.Empty;
        public string StadiumId { get; set; } = string.Empty;
        public string BallId { get; set; } = string.Empty;
        public long Revision { get; set; }
        public string RulesVersion { get; set; } = string.Empty;

        public IReadOnlyList<string> StartingItemIds()
            => (Assignments ?? new List<SquadSlotAssignment>())
                .Where(assignment => !string.IsNullOrWhiteSpace(assignment.ItemId))
                .Select(assignment => assignment.ItemId)
                .ToList();

        public IReadOnlyList<string> MatchSquadItemIds()
            => StartingItemIds()
                .Concat((BenchItemIds ?? new List<string>()).Where(value => !string.IsNullOrWhiteSpace(value)))
                .ToList();

        public SquadDefinition Clone()
            => new SquadDefinition
            {
                SquadId = SquadId,
                OwnerId = OwnerId,
                SlotIndex = SlotIndex,
                FormationId = FormationId,
                Assignments = (Assignments ?? new List<SquadSlotAssignment>())
                    .Select(assignment => new SquadSlotAssignment { PositionSlotId = assignment.PositionSlotId, ItemId = assignment.ItemId })
                    .ToList(),
                BenchItemIds = new List<string>(BenchItemIds ?? new List<string>()),
                CaptainItemId = CaptainItemId,
                TacticProfileId = TacticProfileId,
                SetPieceTakers = (SetPieceTakers ?? new SetPieceTakers()).Clone(),
                KitId = KitId,
                StadiumId = StadiumId,
                BallId = BallId,
                Revision = Revision,
                RulesVersion = RulesVersion
            };
    }

    public sealed class SquadValidationIssue
    {
        public SquadValidationCode Code { get; set; }
        public string PositionSlotId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
    }

    public sealed class SquadValidationResult
    {
        public bool IsPlayable { get; set; }
        public long SalaryTotal { get; set; }
        public long SalaryCap { get; set; }
        public List<TeamColorResult> TeamColor { get; set; } = new List<TeamColorResult>();
        public List<SquadValidationIssue> Errors { get; set; } = new List<SquadValidationIssue>();
        public List<SquadValidationIssue> Warnings { get; set; } = new List<SquadValidationIssue>();

        public bool IsValid => Errors == null || Errors.Count == 0;
    }

    public sealed class SquadSnapshot
    {
        public int SchemaVersion { get; set; } = 1;
        public string OwnerId { get; set; } = string.Empty;
        public long Revision { get; set; }
        public string RulesVersion { get; set; } = string.Empty;
        public long SalaryCapExpansion { get; set; }
        public List<SquadDefinition> Squads { get; set; } = new List<SquadDefinition>();

        public SquadDefinition Find(string squadId)
            => (Squads ?? new List<SquadDefinition>())
                .FirstOrDefault(squad => string.Equals(squad.SquadId, squadId, StringComparison.Ordinal));

        public SquadSnapshot Clone()
            => new SquadSnapshot
            {
                SchemaVersion = SchemaVersion,
                OwnerId = OwnerId,
                Revision = Revision,
                RulesVersion = RulesVersion,
                SalaryCapExpansion = SalaryCapExpansion,
                Squads = (Squads ?? new List<SquadDefinition>()).Select(squad => squad.Clone()).ToList()
            };
    }

    public interface ISquadEconomyCatalog
    {
        string DefaultSeasonId { get; }
        bool TryGetProfile(string itemDefinitionId, out CardEconomyProfile profile);
        bool TryGetSeason(string seasonId, out CardSeasonDefinition season);
    }

    public interface IUpgradeTierRuleSet
    {
        string RulesVersion { get; }
        int MaxTier { get; }
        bool TryGetStep(int targetTier, out UpgradeTierStep step);
        int StatScalingBasisPoints(int tier);
        int SalaryScalingBasisPoints(int tier);
    }

    // Roll phai deterministic theo (serverSeed, idempotencyKey, rulesVersion) de retry cung key cho cung ket qua.
    public interface IUpgradeRollSource
    {
        int Roll(string idempotencyKey, string rulesVersion);
        string AuditHash(string idempotencyKey, string rulesVersion);
    }

    public interface ITrainingRuleSet
    {
        string RulesVersion { get; }
        int MaxLevel { get; }
        IReadOnlyList<string> PointSources { get; }
        int PointsRequiredForLevel(int level);
        int StatGainBasisPoints(int level);
    }

    public interface ITeamColorRuleSet
    {
        string RulesVersion { get; }
        SquadCountingScope CountingScope { get; }
        IReadOnlyList<TeamColorAttribute> CountedAttributes { get; }
        IReadOnlyList<TeamColorThreshold> Thresholds { get; }
        bool TryResolveProfileId(int count, out string bonusProfileId);
        bool TryGetProfile(string bonusProfileId, out TeamColorBonusProfile profile);
    }

    public interface ITeamColorCalculator
    {
        IReadOnlyList<TeamColorResult> Evaluate(SquadDefinition squad, InventorySnapshot inventory);
    }

    public interface ISalaryCalculator
    {
        long ItemSalary(OwnedPlayerItem item);
        long SquadSalary(SquadDefinition squad, InventorySnapshot inventory);
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
        bool AllowsInvalidSave(SquadValidationCode code);
    }

    public interface ISquadValidator
    {
        SquadValidationResult Validate(SquadDefinition squad, InventorySnapshot inventory, long salaryCapExpansion);
    }

    public interface ISquadRepository
    {
        bool TryLoad(string ownerId, out SquadSnapshot snapshot);
        bool TryCommit(string ownerId, long expectedRevision, SquadSnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries);
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using SoccerMobilePro.Catalog;

namespace SoccerMobilePro.PlayerItems
{
    public sealed class SquadRulesFixtureException : Exception
    {
        public SquadRulesFixtureException(string message) : base(message)
        {
        }
    }

    public sealed class FixedUpgradeTierRuleSet : IUpgradeTierRuleSet
    {
        private readonly Dictionary<int, UpgradeTierStep> steps;
        private readonly int[] statScaling;
        private readonly int[] salaryScaling;

        public FixedUpgradeTierRuleSet(
            string rulesVersion,
            int maxTier,
            IEnumerable<UpgradeTierStep> steps,
            IEnumerable<int> statScalingPerTier,
            IEnumerable<int> salaryScalingPerTier)
        {
            if (string.IsNullOrWhiteSpace(rulesVersion)) throw new ArgumentException("Rule set version is required.", nameof(rulesVersion));
            if (maxTier <= 0) throw new ArgumentOutOfRangeException(nameof(maxTier), "Max tier must be positive.");
            RulesVersion = rulesVersion;
            MaxTier = maxTier;
            this.steps = (steps ?? Array.Empty<UpgradeTierStep>()).ToDictionary(step => step.Tier);
            statScaling = (statScalingPerTier ?? Array.Empty<int>()).ToArray();
            salaryScaling = (salaryScalingPerTier ?? Array.Empty<int>()).ToArray();
        }

        public string RulesVersion { get; }
        public int MaxTier { get; }

        public bool TryGetStep(int targetTier, out UpgradeTierStep step)
        {
            if (targetTier < 1 || targetTier > MaxTier)
            {
                step = null;
                return false;
            }

            return steps.TryGetValue(targetTier, out step);
        }

        public int StatScalingBasisPoints(int tier) => Lookup(statScaling, tier);
        public int SalaryScalingBasisPoints(int tier) => Lookup(salaryScaling, tier);

        private static int Lookup(int[] table, int tier)
        {
            if (table == null || table.Length == 0) return 0;
            int index = Math.Max(0, Math.Min(tier, table.Length - 1));
            return table[index];
        }
    }

    public sealed class FixedTrainingRuleSet : ITrainingRuleSet
    {
        private readonly int[] pointsPerLevel;
        private readonly int[] statGainPerLevel;
        private readonly string[] pointSources;

        public FixedTrainingRuleSet(
            string rulesVersion,
            int maxLevel,
            IEnumerable<int> pointsRequiredPerLevel,
            IEnumerable<int> statGainPerLevelBasisPoints,
            IEnumerable<string> pointSources)
        {
            if (string.IsNullOrWhiteSpace(rulesVersion)) throw new ArgumentException("Rule set version is required.", nameof(rulesVersion));
            if (maxLevel <= 0) throw new ArgumentOutOfRangeException(nameof(maxLevel), "Max level must be positive.");
            RulesVersion = rulesVersion;
            MaxLevel = maxLevel;
            pointsPerLevel = (pointsRequiredPerLevel ?? Array.Empty<int>()).ToArray();
            statGainPerLevel = (statGainPerLevelBasisPoints ?? Array.Empty<int>()).ToArray();
            this.pointSources = (pointSources ?? Array.Empty<string>()).ToArray();
        }

        public string RulesVersion { get; }
        public int MaxLevel { get; }
        public IReadOnlyList<string> PointSources => pointSources;

        public int PointsRequiredForLevel(int level) => Lookup(pointsPerLevel, level);
        public int StatGainBasisPoints(int level) => Lookup(statGainPerLevel, level);

        private static int Lookup(int[] table, int level)
        {
            if (table == null || table.Length == 0) return 0;
            int index = Math.Max(0, Math.Min(level, table.Length - 1));
            return table[index];
        }
    }

    public sealed class FixedTeamColorRuleSet : ITeamColorRuleSet
    {
        private readonly TeamColorAttribute[] countedAttributes;
        private readonly TeamColorThreshold[] thresholds;
        private readonly Dictionary<string, TeamColorBonusProfile> profiles;

        public FixedTeamColorRuleSet(
            string rulesVersion,
            IEnumerable<TeamColorAttribute> countedAttributes,
            SquadCountingScope countingScope,
            IEnumerable<TeamColorThreshold> thresholds,
            IEnumerable<TeamColorBonusProfile> profiles)
        {
            if (string.IsNullOrWhiteSpace(rulesVersion)) throw new ArgumentException("Rule set version is required.", nameof(rulesVersion));
            RulesVersion = rulesVersion;
            CountingScope = countingScope;
            this.countedAttributes = (countedAttributes ?? Array.Empty<TeamColorAttribute>()).Distinct().ToArray();
            this.thresholds = (thresholds ?? Array.Empty<TeamColorThreshold>()).OrderBy(threshold => threshold.MinCount).ToArray();
            this.profiles = (profiles ?? Array.Empty<TeamColorBonusProfile>()).ToDictionary(profile => profile.ProfileId, StringComparer.Ordinal);
        }

        public string RulesVersion { get; }
        public SquadCountingScope CountingScope { get; }
        public IReadOnlyList<TeamColorAttribute> CountedAttributes => countedAttributes;
        public IReadOnlyList<TeamColorThreshold> Thresholds => thresholds;

        public bool TryResolveProfileId(int count, out string bonusProfileId)
        {
            for (int index = thresholds.Length - 1; index >= 0; index--)
            {
                if (count < thresholds[index].MinCount) continue;
                bonusProfileId = thresholds[index].BonusProfileId;
                return true;
            }

            bonusProfileId = string.Empty;
            return false;
        }

        public bool TryGetProfile(string bonusProfileId, out TeamColorBonusProfile profile)
            => profiles.TryGetValue(bonusProfileId ?? string.Empty, out profile);
    }

    public sealed class FixedSquadRuleSet : ISquadRuleSet
    {
        private readonly Dictionary<string, FormationDefinition> formations;
        private readonly string[] formationIds;
        private readonly HashSet<SquadValidationCode> allowInvalidSave;

        public FixedSquadRuleSet(
            string rulesVersion,
            int startingCount,
            int benchCount,
            int maxSquadSlots,
            long salaryCapBase,
            long salaryCapExpansionMax,
            SquadCountingScope salaryCountingScope,
            IEnumerable<FormationDefinition> formations,
            IEnumerable<SquadValidationCode> allowInvalidSave)
        {
            if (string.IsNullOrWhiteSpace(rulesVersion)) throw new ArgumentException("Rule set version is required.", nameof(rulesVersion));
            RulesVersion = rulesVersion;
            StartingCount = startingCount;
            BenchCount = benchCount;
            MaxSquadSlots = maxSquadSlots;
            SalaryCapBase = salaryCapBase;
            SalaryCapExpansionMax = salaryCapExpansionMax;
            SalaryCountingScope = salaryCountingScope;
            this.formations = (formations ?? Array.Empty<FormationDefinition>()).ToDictionary(formation => formation.FormationId, StringComparer.Ordinal);
            formationIds = this.formations.Keys.OrderBy(value => value, StringComparer.Ordinal).ToArray();
            this.allowInvalidSave = new HashSet<SquadValidationCode>(allowInvalidSave ?? Array.Empty<SquadValidationCode>());
        }

        public string RulesVersion { get; }
        public int StartingCount { get; }
        public int BenchCount { get; }
        public int MaxSquadSlots { get; }
        public long SalaryCapBase { get; }
        public long SalaryCapExpansionMax { get; }
        public SquadCountingScope SalaryCountingScope { get; }
        public IReadOnlyList<string> FormationIds => formationIds;

        public bool TryGetFormation(string formationId, out FormationDefinition formation)
            => formations.TryGetValue(formationId ?? string.Empty, out formation);

        public bool AllowsInvalidSave(SquadValidationCode code) => allowInvalidSave.Contains(code);
    }

    // Nguon roll deterministic: cung (serverSeed, idempotencyKey, rulesVersion) luon cho cung ket qua,
    // va audit hash khong tiet lo server seed.
    public sealed class DeterministicUpgradeRollSource : IUpgradeRollSource
    {
        private const int RollRange = 10000;
        private readonly string serverSeed;

        public DeterministicUpgradeRollSource(string serverSeed)
        {
            if (string.IsNullOrWhiteSpace(serverSeed)) throw new ArgumentException("Server seed is required.", nameof(serverSeed));
            this.serverSeed = serverSeed;
        }

        public int Roll(string idempotencyKey, string rulesVersion)
        {
            string hash = AuditHash(idempotencyKey, rulesVersion);
            long value = long.Parse(hash.Substring(0, 8), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return (int)(value % RollRange);
        }

        public string AuditHash(string idempotencyKey, string rulesVersion)
            => ProgressionHash.ComputePayload(string.Join("|", serverSeed, idempotencyKey ?? string.Empty, rulesVersion ?? string.Empty));
    }

    // Lop nay lam cau noi giua catalog P1-02 va cac truc kinh te P1-06 (mua the, luong, team color tag)
    // nen khong phai doi schema catalog trong batch B1.
    public sealed class FixtureSquadEconomyCatalog : ISquadEconomyCatalog
    {
        private readonly Dictionary<string, CardEconomyProfile> profiles;
        private readonly Dictionary<string, CardSeasonDefinition> seasons;

        public FixtureSquadEconomyCatalog(SquadRulesFixtureBundle bundle, CatalogSnapshot catalog)
        {
            if (bundle == null) throw new ArgumentNullException(nameof(bundle));
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));

            DefaultSeasonId = bundle.DefaultSeasonId;
            seasons = bundle.CardSeasons
                .GroupBy(season => season.SeasonId, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);

            Dictionary<string, PlayerIdentity> identities = (catalog.Players ?? new List<PlayerIdentity>())
                .GroupBy(player => player.PlayerId ?? string.Empty, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);
            Dictionary<string, ClubDefinition> clubs = (catalog.Clubs ?? new List<ClubDefinition>())
                .GroupBy(club => club.ClubId ?? string.Empty, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);
            Dictionary<string, PlayerClubRegistration> registrations = (catalog.Registrations ?? new List<PlayerClubRegistration>())
                .GroupBy(registration => registration.PlayerId ?? string.Empty, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);
            Dictionary<string, CardEconomyOverride> overrides = bundle.EconomyOverrides
                .GroupBy(entry => entry.ItemDefinitionId ?? string.Empty, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);

            profiles = new Dictionary<string, CardEconomyProfile>(StringComparer.Ordinal);
            foreach (PlayerItemDefinition definition in catalog.Items ?? new List<PlayerItemDefinition>())
            {
                if (definition == null || string.IsNullOrWhiteSpace(definition.ItemDefinitionId)) continue;
                string playerId = definition.PlayerId ?? string.Empty;
                string clubId = registrations.TryGetValue(playerId, out PlayerClubRegistration registration) ? registration.ClubId ?? string.Empty : string.Empty;
                string leagueId = clubs.TryGetValue(clubId, out ClubDefinition club) ? club.LeagueId ?? string.Empty : string.Empty;
                string nationId = identities.TryGetValue(playerId, out PlayerIdentity identity) && identity.NationalityIds != null && identity.NationalityIds.Count > 0
                    ? identity.NationalityIds[0]
                    : string.Empty;

                overrides.TryGetValue(definition.ItemDefinitionId, out CardEconomyOverride entryOverride);
                string seasonId = entryOverride != null && !string.IsNullOrWhiteSpace(entryOverride.SeasonId)
                    ? entryOverride.SeasonId
                    : DefaultSeasonId;
                long salary = entryOverride != null && entryOverride.BaseSalary.HasValue
                    ? entryOverride.BaseSalary.Value
                    : SalaryForOverall(bundle.SalaryBands, definition.BaseOverall);

                profiles[definition.ItemDefinitionId] = new CardEconomyProfile
                {
                    ItemDefinitionId = definition.ItemDefinitionId,
                    SeasonId = seasonId,
                    BaseSalary = salary,
                    BaseOverall = definition.BaseOverall,
                    Tags = new TeamColorTags
                    {
                        ClubId = clubId,
                        NationId = nationId,
                        SeasonId = seasonId,
                        LeagueId = leagueId
                    }
                };
            }
        }

        public string DefaultSeasonId { get; }

        public bool TryGetProfile(string itemDefinitionId, out CardEconomyProfile profile)
            => profiles.TryGetValue(itemDefinitionId ?? string.Empty, out profile);

        public bool TryGetSeason(string seasonId, out CardSeasonDefinition season)
            => seasons.TryGetValue(seasonId ?? string.Empty, out season);

        public static long SalaryForOverall(IReadOnlyList<CardSalaryBand> bands, int overall)
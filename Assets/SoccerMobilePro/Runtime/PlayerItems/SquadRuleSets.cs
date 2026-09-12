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

        private static int Lookup(int[] table, int index)
        {
            if (table == null || table.Length == 0) return 0;
            int clamped = Math.Max(0, Math.Min(index, table.Length - 1));
            return table[clamped];
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

        private static int Lookup(int[] table, int index)
        {
            if (table == null || table.Length == 0) return 0;
            int clamped = Math.Max(0, Math.Min(index, table.Length - 1));
            return table[clamped];
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

    // Cung (serverSeed, idempotencyKey, rulesVersion) luon cho cung ket qua; audit hash khong tiet lo seed.
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

    // Cau noi giua catalog P1-02 va cac truc kinh te P1-06 (mua the, luong, team color tag),
    // giup batch B1 khong phai doi schema catalog.
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
                .GroupBy(season => season.SeasonId ?? string.Empty, StringComparer.Ordinal)
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
                string clubId = registrations.TryGetValue(playerId, out PlayerClubRegistration registration)
                    ? registration.ClubId ?? string.Empty
                    : string.Empty;
                string leagueId = clubs.TryGetValue(clubId, out ClubDefinition club)
                    ? club.LeagueId ?? string.Empty
                    : string.Empty;
                string nationId = identities.TryGetValue(playerId, out PlayerIdentity identity)
                    && identity.NationalityIds != null
                    && identity.NationalityIds.Count > 0
                        ? identity.NationalityIds[0]
                        : string.Empty;

                overrides.TryGetValue(definition.ItemDefinitionId, out CardEconomyOverride economyOverride);
                string seasonId = economyOverride != null && !string.IsNullOrWhiteSpace(economyOverride.SeasonId)
                    ? economyOverride.SeasonId
                    : DefaultSeasonId;
                long salary = economyOverride != null && economyOverride.BaseSalary.HasValue
                    ? economyOverride.BaseSalary.Value
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
        {
            CardSalaryBand match = (bands ?? new List<CardSalaryBand>())
                .Where(band => overall >= band.MinOverall)
                .OrderByDescending(band => band.MinOverall)
                .FirstOrDefault();
            return match == null ? 0L : match.BaseSalary;
        }
    }

    public sealed class SquadRulesFixtureBundle
    {
        internal SquadRulesFixtureBundle(
            string fixtureId,
            string claimStatus,
            string rulesVersion,
            string catalogVersion,
            string sourceNote,
            IReadOnlyList<CardSeasonDefinition> cardSeasons,
            string defaultSeasonId,
            IReadOnlyList<CardSalaryBand> salaryBands,
            IReadOnlyList<CardEconomyOverride> economyOverrides,
            IUpgradeTierRuleSet upgradeTiers,
            ITrainingRuleSet training,
            ITeamColorRuleSet teamColor,
            ISquadRuleSet squads)
        {
            FixtureId = fixtureId;
            ClaimStatus = claimStatus;
            RulesVersion = rulesVersion;
            CatalogVersion = catalogVersion;
            SourceNote = sourceNote;
            CardSeasons = cardSeasons;
            DefaultSeasonId = defaultSeasonId;
            SalaryBands = salaryBands;
            EconomyOverrides = economyOverrides;
            UpgradeTiers = upgradeTiers;
            Training = training;
            TeamColor = teamColor;
            Squads = squads;
        }

        public string FixtureId { get; }
        public string ClaimStatus { get; }
        public string RulesVersion { get; }
        public string CatalogVersion { get; }
        public string SourceNote { get; }
        public IReadOnlyList<CardSeasonDefinition> CardSeasons { get; }
        public string DefaultSeasonId { get; }
        public IReadOnlyList<CardSalaryBand> SalaryBands { get; }
        public IReadOnlyList<CardEconomyOverride> EconomyOverrides { get; }
        public IUpgradeTierRuleSet UpgradeTiers { get; }
        public ITrainingRuleSet Training { get; }
        public ITeamColorRuleSet TeamColor { get; }
        public ISquadRuleSet Squads { get; }

        public ISquadEconomyCatalog CreateEconomyCatalog(CatalogSnapshot catalog) => new FixtureSquadEconomyCatalog(this, catalog);
    }

    public static class SquadRulesFixture
    {
        public const string AssetRelativePath = "Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json";
        public const int SupportedSchemaVersion = 1;

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public static SquadRulesFixtureBundle Parse(string json)
        {
            Require(!string.IsNullOrWhiteSpace(json), "Fixture payload is empty.");

            SquadRulesFixtureDocument document;
            try
            {
                document = JsonConvert.DeserializeObject<SquadRulesFixtureDocument>(json, Settings);
            }
            catch (JsonException error)
            {
                throw new SquadRulesFixtureException("Fixture payload is not valid JSON: " + error.Message);
            }

            Require(document != null, "Fixture payload is empty.");
            Require(document.SchemaVersion == SupportedSchemaVersion, "Fixture schema version must be 1.");
            Require(!string.IsNullOrWhiteSpace(document.FixtureId), "Fixture id is required.");
            Require(CatalogVersion.IsCanonical(document.RulesVersion), "Fixture rules version must be canonical.");
            Require(CatalogVersion.IsCanonical(document.CatalogVersion), "Fixture catalog version must be canonical.");
            Require(document.CardSeasons != null && document.CardSeasons.Count > 0, "Fixture needs at least one card season.");
            Require(
                document.CardSeasons.Select(season => season.SeasonId).Distinct(StringComparer.Ordinal).Count() == document.CardSeasons.Count,
                "Card season ids must be unique.");
            foreach (CardSeasonDefinition season in document.CardSeasons)
            {
                Require(!string.IsNullOrWhiteSpace(season.SeasonId), "Card season id is required.");
                Require(
                    string.Equals(season.RulesVersion, document.RulesVersion, StringComparison.Ordinal),
                    "Card season must use the fixture rules version.");
            }

            CardEconomyDocument economy = document.CardEconomy;
            Require(economy != null, "Fixture needs a cardEconomy block.");
            Require(
                document.CardSeasons.Any(season => string.Equals(season.SeasonId, economy.DefaultSeasonId, StringComparison.Ordinal)),
                "Default season must exist in cardSeasons.");
            Require(economy.SalaryBands != null && economy.SalaryBands.Count > 0, "Fixture needs salary bands.");

            List<CardSalaryBand> bands = economy.SalaryBands.OrderBy(band => band.MinOverall).ToList();
            Require(bands[0].MinOverall == 0, "The first salary band must start at overall 0.");
            for (int index = 0; index < bands.Count; index++)
            {
                Require(bands[index].BaseSalary > 0, "Salary bands must be positive.");
                if (index == 0) continue;
                Require(
                    bands[index].MinOverall > bands[index - 1].MinOverall && bands[index].BaseSalary > bands[index - 1].BaseSalary,
                    "Salary bands must ascend by overall and salary.");
            }

            List<CardEconomyOverride> overrides = economy.Overrides ?? new List<CardEconomyOverride>();
            foreach (CardEconomyOverride entry in overrides)
            {
                Require(!string.IsNullOrWhiteSpace(entry.ItemDefinitionId), "Economy override needs an item definition id.");
                Require(
                    string.IsNullOrWhiteSpace(entry.SeasonId) || document.CardSeasons.Any(season => string.Equals(season.SeasonId, entry.SeasonId, StringComparison.Ordinal)),
                    "Economy override references an unknown season.");
                Require(!entry.BaseSalary.HasValue || entry.BaseSalary.Value > 0, "Economy override salary must be positive.");
            }

            return new SquadRulesFixtureBundle(
                document.FixtureId,
                document.ClaimStatus ?? string.Empty,
                document.RulesVersion,
                document.CatalogVersion,
                document.SourceNote ?? string.Empty,
                document.CardSeasons,
                economy.DefaultSeasonId,
                bands,
                overrides,
                BuildUpgrades(document),
                BuildTraining(document),
                BuildTeamColor(document),
                BuildSquads(document));
        }

        private static IUpgradeTierRuleSet BuildUpgrades(SquadRulesFixtureDocument document)
        {
            UpgradeTierRuleSetDocument dto = document.UpgradeTierRuleSet;
            Require(dto != null, "Fixture needs an upgradeTierRuleSet block.");
            Require(string.Equals(dto.RulesVersion, document.RulesVersion, StringComparison.Ordinal), "upgradeTierRuleSet must use the fixture rules version.");
            Require(dto.MaxTier > 0, "maxTier must be positive.");
            Require(dto.Tiers != null && dto.Tiers.Count == dto.MaxTier, "upgradeTierRuleSet needs exactly maxTier tier entries.");

            List<UpgradeTierStep> steps = dto.Tiers.OrderBy(step => step.Tier).ToList();
            for (int index = 0; index < steps.Count; index++)
            {
                UpgradeTierStep step = steps[index];
                Require(step.Tier == index + 1, "Tier entries must cover 1..maxTier without gaps.");
                Require(step.SuccessRateBasisPoints > 0 && step.SuccessRateBasisPoints <= 10000, "Tier success rate must be within 1..10000 basis points.");
                Require(step.CurrencyCost >= 0, "Tier currency cost cannot be negative.");
                Require(step.MaterialCost != null && step.MaterialCost.Count > 0, "Every tier needs at least one material cost.");
                Require(
                    step.MaterialCost.All(cost => !string.IsNullOrWhiteSpace(cost.ResourceId) && cost.Amount > 0),
                    "Material costs must be positive.");
                if (index > 0)
                {
                    Require(step.SuccessRateBasisPoints <= steps[index - 1].SuccessRateBasisPoints, "Success rates must not increase with tier.");
                }

                if (string.IsNullOrWhiteSpace(step.InsuranceItemId)) step.InsuranceItemId = dto.InsuranceItemId ?? string.Empty;
                Require(
                    step.FailureOutcome == UpgradeFailureOutcome.Keep || !string.IsNullOrWhiteSpace(step.InsuranceItemId),
                    "Tiers that can lose progress need an insurance item.");
            }

            Require(steps.Select(step => step.FailureOutcome).Distinct().Count() >= 2, "Fixture must exercise more than one failure outcome.");
            Require(dto.StatScalingPerTierBasisPoints != null && dto.StatScalingPerTierBasisPoints.Count == dto.MaxTier + 1, "statScalingPerTierBasisPoints needs maxTier + 1 entries.");
            Require(dto.SalaryScalingPerTierBasisPoints != null && dto.SalaryScalingPerTierBasisPoints.Count == dto.MaxTier + 1, "salaryScalingPerTierBasisPoints needs maxTier + 1 entries.");
            Require(dto.StatScalingPerTierBasisPoints[0] == 0 && dto.SalaryScalingPerTierBasisPoints[0] == 0, "Tier 0 scaling must be zero.");
            RequireAscending(dto.StatScalingPerTierBasisPoints, "statScalingPerTierBasisPoints");
            RequireAscending(dto.SalaryScalingPerTierBasisPoints, "salaryScalingPerTierBasisPoints");

            return new FixedUpgradeTierRuleSet(
                dto.RulesVersion,
                dto.MaxTier,
                steps,
                dto.StatScalingPerTierBasisPoints,
                dto.SalaryScalingPerTierBasisPoints);
        }

        private static ITrainingRuleSet BuildTraining(SquadRulesFixtureDocument document)
        {
            TrainingRuleSetDocument dto = document.TrainingRuleSet;
            Require(dto != null, "Fixture needs a trainingRuleSet block.");
            Require(string.Equals(dto.RulesVersion, document.RulesVersion, StringComparison.Ordinal), "trainingRuleSet must use the fixture rules version.");
            Require(dto.MaxLevel > 0, "maxLevel must be positive.");
            Require(dto.PointsRequiredPerLevel != null && dto.PointsRequiredPerLevel.Count == dto.MaxLevel + 1, "pointsRequiredPerLevel needs maxLevel + 1 entries.");
            Require(dto.StatGainPerLevelBasisPoints != null && dto.StatGainPerLevelBasisPoints.Count == dto.MaxLevel + 1, "statGainPerLevelBasisPoints needs maxLevel + 1 entries.");
            Require(dto.PointsRequiredPerLevel[0] == 0 && dto.StatGainPerLevelBasisPoints[0] == 0, "Level 0 entries must be zero.");
            RequireAscending(dto.PointsRequiredPerLevel, "pointsRequiredPerLevel");
            RequireAscending(dto.StatGainPerLevelBasisPoints, "statGainPerLevelBasisPoints");
            Require(dto.PointSources != null && dto.PointSources.Count > 0, "trainingRuleSet needs at least one point source.");

            return new FixedTrainingRuleSet(
                dto.RulesVersion,
                dto.MaxLevel,
                dto.PointsRequiredPerLevel,
                dto.StatGainPerLevelBasisPoints,
                dto.PointSources);
        }

        private static ITeamColorRuleSet BuildTeamColor(SquadRulesFixtureDocument document)
        {
            TeamColorRuleSetDocument dto = document.TeamColorRuleSet;
            Require(dto != null, "Fixture needs a teamColorRuleSet block.");
            Require(string.Equals(dto.RulesVersion, document.RulesVersion, StringComparison.Ordinal), "teamColorRuleSet must use the fixture rules version.");
            Require(dto.CountedAttributes != null && dto.CountedAttributes.Count > 0, "teamColorRuleSet needs counted attributes.");
            Require(dto.Thresholds != null && dto.Thresholds.Count > 0, "teamColorRuleSet needs thresholds.");
            Require(dto.BonusProfiles != null && dto.BonusProfiles.Count > 0, "teamColorRuleSet needs bonus profiles.");

            List<TeamColorThreshold> thresholds = dto.Thresholds.OrderBy(threshold => threshold.MinCount).ToList();
            for (int index = 0; index < thresholds.Count; index++)
            {
                Require(thresholds[index].MinCount > 0, "Threshold minCount must be positive.");
                if (index > 0) Require(thresholds[index].MinCount > thresholds[index - 1].MinCount, "Thresholds must ascend by minCount.");
                Require(
                    dto.BonusProfiles.Any(profile => string.Equals(profile.ProfileId, thresholds[index].BonusProfileId, StringComparison.Ordinal)),
                    "Threshold references an unknown bonus profile.");
            }

            foreach (TeamColorBonusProfile profile in dto.BonusProfiles)
            {
                Require(!string.IsNullOrWhiteSpace(profile.ProfileId), "Bonus profile id is required.");
                Require(profile.StatModifiers != null && profile.StatModifiers.Count > 0, "Bonus profile needs stat modifiers.");
                Require(
                    profile.StatModifiers.All(modifier => !string.IsNullOrWhiteSpace(modifier.AttributeId) && modifier.BasisPoints != 0),
                    "Stat modifiers must target an attribute with a non-zero value.");
            }

            return new FixedTeamColorRuleSet(dto.RulesVersion, dto.CountedAttributes, dto.CountingScope, thresholds, dto.BonusProfiles);
        }

        private static ISquadRuleSet BuildSquads(SquadRulesFixtureDocument document)
        {
            SquadRuleSetDocument dto = document.SquadRuleSet;
            Require(dto != null, "Fixture needs a squadRuleSet block.");
            Require(string.Equals(dto.RulesVersion, document.RulesVersion, StringComparison.Ordinal), "squadRuleSet must use the fixture rules version.");
            Require(dto.StartingCount > 0 && dto.BenchCount > 0 && dto.MaxSquadSlots > 0, "Squad counts must be positive.");
            Require(dto.SalaryCapBase > 0 && dto.SalaryCapExpansionMax >= 0, "Salary cap values are invalid.");
            Require(dto.Formations != null && dto.Formations.Count > 0, "squadRuleSet needs at least one formation.");
            Require(
                dto.Formations.Select(formation => formation.FormationId).Distinct(StringComparer.Ordinal).Count() == dto.Formations.Count,
                "Formation ids must be unique.");

            foreach (FormationDefinition formation in dto.Formations)
            {
                Require(!string.IsNullOrWhiteSpace(formation.FormationId), "Formation id is required.");
                Require(
                    formation.PositionSlots != null && formation.PositionSlots.Count == dto.StartingCount,
                    "Every formation must define exactly startingCount slots.");
                Require(
                    formation.PositionSlots.Select(slot => slot.PositionSlotId).Distinct(StringComparer.Ordinal).Count() == formation.PositionSlots.Count,
                    "Formation slot ids must be unique.");
                Require(
                    formation.PositionSlots.All(slot => !string.IsNullOrWhiteSpace(slot.PositionId)),
                    "Formation slots need a position id.");
            }

            return new FixedSquadRuleSet(
                dto.RulesVersion,
                dto.StartingCount,
                dto.BenchCount,
                dto.MaxSquadSlots,
                dto.SalaryCapBase,
                dto.SalaryCapExpansionMax,
                dto.SalaryCountingScope,
                dto.Formations,
                dto.AllowInvalidSave ?? new List<SquadValidationCode>());
        }

        private static void RequireAscending(IReadOnlyList<int> values, string label)
        {
            for (int index = 1; index < values.Count; index++)
            {
                Require(values[index] > values[index - 1], label + " must ascend.");
            }
        }

        private static void Require(bool condition, string message)
        {
            if (!condition) throw new SquadRulesFixtureException(message);
        }
    }

    internal sealed class SquadRulesFixtureDocument
    {
        public int SchemaVersion { get; set; }
        public string FixtureId { get; set; }
        public string ClaimStatus { get; set; }
        public string RulesVersion { get; set; }
        public string CatalogVersion { get; set; }
        public string SourceNote { get; set; }
        public List<CardSeasonDefinition> CardSeasons { get; set; }
        public CardEconomyDocument CardEconomy { get; set; }
        public UpgradeTierRuleSetDocument UpgradeTierRuleSet { get; set; }
        public TrainingRuleSetDocument TrainingRuleSet { get; set; }
        public TeamColorRuleSetDocument TeamColorRuleSet { get; set; }
        public SquadRuleSetDocument SquadRuleSet { get; set; }
    }

    internal sealed class CardEconomyDocument
    {
        public string DefaultSeasonId { get; set; }
        public List<CardSalaryBand> SalaryBands { get; set; }
        public List<CardEconomyOverride> Overrides { get; set; }
    }

    internal sealed class UpgradeTierRuleSetDocument
    {
        public string RulesVersion { get; set; }
        public int MaxTier { get; set; }
        public string InsuranceItemId { get; set; }
        public List<int> StatScalingPerTierBasisPoints { get; set; }
        public List<int> SalaryScalingPerTierBasisPoints { get; set; }
        public List<UpgradeTierStep> Tiers { get; set; }
    }

    internal sealed class TrainingRuleSetDocument
    {
        public string RulesVersion { get; set; }
        public int MaxLevel { get; set; }
        public List<int> PointsRequiredPerLevel { get; set; }
        public List<int> StatGainPerLevelBasisPoints { get; set; }
        public List<string> PointSources { get; set; }
    }

    internal sealed class TeamColorRuleSetDocument
    {
        public string RulesVersion { get; set; }
        public List<TeamColorAttribute> CountedAttributes { get; set; }
        public SquadCountingScope CountingScope { get; set; }
        public List<TeamColorThreshold> Thresholds { get; set; }
        public List<TeamColorBonusProfile> BonusProfiles { get; set; }
    }

    internal sealed class SquadRuleSetDocument
    {
        public string RulesVersion { get; set; }
        public int StartingCount { get; set; }
        public int BenchCount { get; set; }
        public int MaxSquadSlots { get; set; }
        public long SalaryCapBase { get; set; }
        public long SalaryCapExpansionMax { get; set; }
        public SquadCountingScope SalaryCountingScope { get; set; }
        public List<SquadValidationCode> AllowInvalidSave { get; set; }
        public List<FormationDefinition> Formations { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SoccerMobilePro.PlayerItems
{
    public sealed class FixedCardSeasonRuleSet : ICardSeasonRuleSet
    {
        private readonly Dictionary<string, CardSeasonDefinition> seasons;
        private readonly Dictionary<string, string> programSeasons;
        private readonly string defaultSeasonId;

        public FixedCardSeasonRuleSet(
            string rulesVersion,
            IEnumerable<CardSeasonDefinition> seasons,
            IReadOnlyDictionary<string, string> programSeasons,
            string defaultSeasonId)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            this.seasons = (seasons ?? Array.Empty<CardSeasonDefinition>()).ToDictionary(season => season.SeasonId, StringComparer.Ordinal);
            this.programSeasons = (programSeasons ?? new Dictionary<string, string>()).ToDictionary(pair => pair.Key, pair => pair.Value, StringComparer.Ordinal);
            this.defaultSeasonId = defaultSeasonId ?? string.Empty;
            Seasons = this.seasons.Values.OrderBy(season => season.SeasonId, StringComparer.Ordinal).ToList().AsReadOnly();
        }

        public string RulesVersion { get; }
        public IReadOnlyList<CardSeasonDefinition> Seasons { get; }

        public bool TryGetSeason(string seasonId, out CardSeasonDefinition definition) => seasons.TryGetValue(seasonId ?? string.Empty, out definition);

        public string ResolveSeasonId(string programId)
            => programSeasons.TryGetValue(programId ?? string.Empty, out string seasonId) ? seasonId : defaultSeasonId;
    }

    public sealed class FixedUpgradeTierRuleSet : IUpgradeTierRuleSet
    {
        private readonly Dictionary<int, UpgradeTierStep> steps;
        private readonly int[] statScalingBasisPoints;

        public FixedUpgradeTierRuleSet(string rulesVersion, int maxTier, IEnumerable<UpgradeTierStep> steps, IEnumerable<int> statScalingBasisPoints)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            MaxTier = maxTier;
            this.steps = (steps ?? Array.Empty<UpgradeTierStep>()).ToDictionary(step => step.FromTier);
            this.statScalingBasisPoints = (statScalingBasisPoints ?? Array.Empty<int>()).ToArray();
        }

        public string RulesVersion { get; }
        public int MaxTier { get; }

        public bool TryGetStep(int fromTier, out UpgradeTierStep step) => steps.TryGetValue(fromTier, out step);

        public int StatScalingBasisPoints(int tier)
        {
            if (statScalingBasisPoints.Length == 0) return 0;
            int index = Math.Min(Math.Max(tier, 0), statScalingBasisPoints.Length - 1);
            return statScalingBasisPoints[index];
        }
    }

    public sealed class FixedTrainingRuleSet : ITrainingRuleSet
    {
        private readonly int[] pointsRequiredPerLevel;
        private readonly int[] statGainBasisPoints;

        public FixedTrainingRuleSet(
            string rulesVersion,
            int maxLevel,
            IEnumerable<int> pointsRequiredPerLevel,
            IEnumerable<int> statGainBasisPoints,
            IEnumerable<string> pointSources)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            MaxLevel = maxLevel;
            this.pointsRequiredPerLevel = (pointsRequiredPerLevel ?? Array.Empty<int>()).ToArray();
            this.statGainBasisPoints = (statGainBasisPoints ?? Array.Empty<int>()).ToArray();
            PointSources = (pointSources ?? Array.Empty<string>()).OrderBy(value => value, StringComparer.Ordinal).ToList().AsReadOnly();
        }

        public string RulesVersion { get; }
        public int MaxLevel { get; }
        public IReadOnlyList<string> PointSources { get; }

        public bool TryGetPointsRequiredForLevel(int level, out int points)
        {
            if (level < 1 || level > MaxLevel || level > pointsRequiredPerLevel.Length)
            {
                points = 0;
                return false;
            }

            points = pointsRequiredPerLevel[level - 1];
            return true;
        }

        public int StatGainBasisPoints(int level)
        {
            if (statGainBasisPoints.Length == 0) return 0;
            int index = Math.Min(Math.Max(level, 0), statGainBasisPoints.Length - 1);
            return statGainBasisPoints[index];
        }
    }

    public sealed class FixedTeamColorRuleSet : ITeamColorRuleSet
    {
        private readonly Dictionary<string, TeamColorBonusProfile> profiles;
        private readonly List<TeamColorThreshold> thresholds;

        public FixedTeamColorRuleSet(
            string rulesVersion,
            IEnumerable<TeamColorAttribute> countedAttributes,
            SquadCountingScope countingScope,
            IEnumerable<TeamColorThreshold> thresholds,
            IEnumerable<TeamColorBonusProfile> profiles)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            CountedAttributes = (countedAttributes ?? Array.Empty<TeamColorAttribute>()).Distinct().ToList().AsReadOnly();
            CountingScope = countingScope;
            this.thresholds = (thresholds ?? Array.Empty<TeamColorThreshold>()).OrderBy(threshold => threshold.MinCount).ToList();
            this.profiles = (profiles ?? Array.Empty<TeamColorBonusProfile>()).ToDictionary(profile => profile.ProfileId, StringComparer.Ordinal);
            Thresholds = this.thresholds.AsReadOnly();
        }

        public string RulesVersion { get; }
        public IReadOnlyList<TeamColorAttribute> CountedAttributes { get; }
        public SquadCountingScope CountingScope { get; }
        public IReadOnlyList<TeamColorThreshold> Thresholds { get; }

        public bool TryGetProfile(string profileId, out TeamColorBonusProfile profile) => profiles.TryGetValue(profileId ?? string.Empty, out profile);

        public string ResolveProfileId(int count)
        {
            string resolved = string.Empty;
            foreach (TeamColorThreshold threshold in thresholds)
            {
                if (count >= threshold.MinCount) resolved = threshold.BonusProfileId;
            }

            return resolved;
        }
    }

    public sealed class FixedSalaryRuleSet : ISalaryRuleSet
    {
        private readonly List<SalaryBand> bands;
        private readonly int[] tierSalaryScalingBasisPoints;

        public FixedSalaryRuleSet(string rulesVersion, IEnumerable<SalaryBand> bands, IEnumerable<int> tierSalaryScalingBasisPoints)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            this.bands = (bands ?? Array.Empty<SalaryBand>()).OrderBy(band => band.MinOverall).ToList();
            this.tierSalaryScalingBasisPoints = (tierSalaryScalingBasisPoints ?? Array.Empty<int>()).ToArray();
        }

        public string RulesVersion { get; }

        public long BaseSalaryForOverall(int overall)
        {
            long resolved = 0;
            foreach (SalaryBand band in bands)
            {
                if (overall >= band.MinOverall) resolved = band.BaseSalary;
            }

            return resolved;
        }

        public int TierSalaryScalingBasisPoints(int tier)
        {
            if (tierSalaryScalingBasisPoints.Length == 0) return 0;
            int index = Math.Min(Math.Max(tier, 0), tierSalaryScalingBasisPoints.Length - 1);
            return tierSalaryScalingBasisPoints[index];
        }
    }

    public sealed class FixedSquadRuleSet : ISquadRuleSet
    {
        private readonly Dictionary<string, FormationDefinition> formations;
        private readonly Dictionary<string, string> positionSlotGroups;

        public FixedSquadRuleSet(
            string rulesVersion,
            int startingCount,
            int benchCount,
            int maxSquadSlots,
            long salaryCapBase,
            long salaryCapExpansionMax,
            SquadCountingScope salaryCountingScope,
            IEnumerable<FormationDefinition> formations,
            IReadOnlyDictionary<string, string> positionSlotGroups)
        {
            RulesVersion = rulesVersion ?? throw new ArgumentNullException(nameof(rulesVersion));
            StartingCount = startingCount;
            BenchCount = benchCount;
            MaxSquadSlots = maxSquadSlots;
            SalaryCapBase = salaryCapBase;
            SalaryCapExpansionMax = salaryCapExpansionMax;
            SalaryCountingScope = salaryCountingScope;
            this.formations = (formations ?? Array.Empty<FormationDefinition>()).ToDictionary(formation => formation.FormationId, StringComparer.Ordinal);
            this.positionSlotGroups = (positionSlotGroups ?? new Dictionary<string, string>()).ToDictionary(pair => pair.Key, pair => pair.Value, StringComparer.Ordinal);
            FormationIds = this.formations.Keys.OrderBy(value => value, StringComparer.Ordinal).ToList().AsReadOnly();
        }

        public string RulesVersion { get; }
        public int StartingCount { get; }
        public int BenchCount { get; }
        public int MaxSquadSlots { get; }
        public long SalaryCapBase { get; }
        public long SalaryCapExpansionMax { get; }
        public SquadCountingScope SalaryCountingScope { get; }
        public IReadOnlyList<string> FormationIds { get; }

        public bool TryGetFormation(string formationId, out FormationDefinition formation) => formations.TryGetValue(formationId ?? string.Empty, out formation);

        public bool TryGetSlotGroup(string positionSlotId, out string positionGroup) => positionSlotGroups.TryGetValue(positionSlotId ?? string.Empty, out positionGroup);
    }

    public sealed class PlayerItemsRuleBundle
    {
        public PlayerItemsRuleBundle(
            string fixtureVersion,
            string rulesVersion,
            string claimLabel,
            ICardSeasonRuleSet cardSeasons,
            IUpgradeTierRuleSet upgradeTiers,
            ITrainingRuleSet training,
            ITeamColorRuleSet teamColor,
            ISalaryRuleSet salary,
            ISquadRuleSet squad)
        {
            FixtureVersion = fixtureVersion ?? string.Empty;
            RulesVersion = rulesVersion ?? string.Empty;
            ClaimLabel = claimLabel ?? string.Empty;
            CardSeasons = cardSeasons ?? throw new ArgumentNullException(nameof(cardSeasons));
            UpgradeTiers = upgradeTiers ?? throw new ArgumentNullException(nameof(upgradeTiers));
            Training = training ?? throw new ArgumentNullException(nameof(training));
            TeamColor = teamColor ?? throw new ArgumentNullException(nameof(teamColor));
            Salary = salary ?? throw new ArgumentNullException(nameof(salary));
            Squad = squad ?? throw new ArgumentNullException(nameof(squad));
        }

        public string FixtureVersion { get; }
        public string RulesVersion { get; }
        public string ClaimLabel { get; }
        public ICardSeasonRuleSet CardSeasons { get; }
        public IUpgradeTierRuleSet UpgradeTiers { get; }
        public ITrainingRuleSet Training { get; }
        public ITeamColorRuleSet TeamColor { get; }
        public ISalaryRuleSet Salary { get; }
        public ISquadRuleSet Squad { get; }
    }

    public sealed class SquadRulesFixtureDocument
    {
        public string FixtureVersion { get; set; } = string.Empty;
        public string RulesVersion { get; set; } = string.Empty;
        public string ClaimLabel { get; set; } = string.Empty;
        public CardSeasonSection CardSeasons { get; set; }
        public UpgradeSection UpgradeTiers { get; set; }
        public TrainingSection Training { get; set; }
        public TeamColorSection TeamColor { get; set; }
        public SalarySection Salary { get; set; }
        public SquadSection Squad { get; set; }

        public sealed class CardSeasonSection
        {
            public string DefaultSeasonId { get; set; } = string.Empty;
            public List<CardSeasonDefinition> Seasons { get; set; } = new List<CardSeasonDefinition>();
            public Dictionary<string, string> ProgramSeasons { get; set; } = new Dictionary<string, string>(StringComparer.Ordinal);
        }

        public sealed class UpgradeSection
        {
            public int MaxTier { get; set; }
            public List<UpgradeTierStep> Steps { get; set; } = new List<UpgradeTierStep>();
            public List<int> StatScalingBasisPoints { get; set; } = new List<int>();
        }

        public sealed class TrainingSection
        {
            public int MaxLevel { get; set; }
            public List<int> PointsRequiredPerLevel { get; set; } = new List<int>();
            public List<int> StatGainBasisPoints { get; set; } = new List<int>();
            public List<string> PointSources { get; set; } = new List<string>();
        }

        public sealed class TeamColorSection
        {
            public List<TeamColorAttribute> CountedAttributes { get; set; } = new List<TeamColorAttribute>();
            public SquadCountingScope CountingScope { get; set; }
            public List<TeamColorThreshold> Thresholds { get; set; } = new List<TeamColorThreshold>();
            public List<TeamColorBonusProfile> BonusProfiles { get; set; } = new List<TeamColorBonusProfile>();
        }

        public sealed class SalarySection
        {
            public List<SalaryBand> Bands { get; set; } = new List<SalaryBand>();
            public List<int> TierScalingBasisPoints { get; set; } = new List<int>();
        }

        public sealed class SquadSection
        {
            public int StartingCount { get; set; }
            public int BenchCount { get; set; }
            public int MaxSquadSlots { get; set; }
            public long SalaryCapBase { get; set; }
            public long SalaryCapExpansionMax { get; set; }
            public SquadCountingScope SalaryCountingScope { get; set; }
            public string GoalkeeperPositionGroup { get; set; } = string.Empty;
            public List<FormationDefinition> Formations { get; set; } = new List<FormationDefinition>();
            public Dictionary<string, string> PositionSlotGroups { get; set; } = new Dictionary<string, string>(StringComparer.Ordinal);
        }
    }

    public static class SquadRulesFixtureCodec
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public static PlayerItemsRuleBundle Parse(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new PlayerItemsRuleSetException("Squad rules fixture payload is empty.");
            SquadRulesFixtureDocument document;
            try
            {
                document = JsonConvert.DeserializeObject<SquadRulesFixtureDocument>(json, Settings);
            }
            catch (JsonException exception)
            {
                throw new PlayerItemsRuleSetException("Squad rules fixture is invalid JSON.", exception);
            }

            if (document == null) throw new PlayerItemsRuleSetException("Squad rules fixture decoded to null.");
            return Build(document);
        }

        public static SquadRulesFixtureDocument ParseDocument(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new PlayerItemsRuleSetException("Squad rules fixture payload is empty.");
            try
            {
                return JsonConvert.DeserializeObject<SquadRulesFixtureDocument>(json, Settings)
                    ?? throw new PlayerItemsRuleSetException("Squad rules fixture decoded to null.");
            }
            catch (JsonException exception)
            {
                throw new PlayerItemsRuleSetException("Squad rules fixture is invalid JSON.", exception);
            }
        }

        public static PlayerItemsRuleBundle Build(SquadRulesFixtureDocument document)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            string rulesVersion = document.RulesVersion ?? string.Empty;
            if (string.IsNullOrWhiteSpace(rulesVersion)) throw new PlayerItemsRuleSetException("Squad rules fixture needs a rules version.");

            ICardSeasonRuleSet cardSeasons = BuildCardSeasons(document.CardSeasons, rulesVersion);
            IUpgradeTierRuleSet upgradeTiers = BuildUpgradeTiers(document.UpgradeTiers, rulesVersion);
            ITrainingRuleSet training = BuildTraining(document.Training, rulesVersion);
            ITeamColorRuleSet teamColor = BuildTeamColor(document.TeamColor, rulesVersion);
            ISalaryRuleSet salary = BuildSalary(document.Salary, upgradeTiers.MaxTier, rulesVersion);
            ISquadRuleSet squad = BuildSquad(document.Squad, rulesVersion);

            return new PlayerItemsRuleBundle(
                document.FixtureVersion,
                rulesVersion,
                document.ClaimLabel,
                cardSeasons,
                upgradeTiers,
                training,
                teamColor,
                salary,
                squad);
        }

        private static ICardSeasonRuleSet BuildCardSeasons(SquadRulesFixtureDocument.CardSeasonSection section, string rulesVersion)
        {
            if (section == null || section.Seasons == null || section.Seasons.Count == 0) throw new PlayerItemsRuleSetException("Squad rules fixture needs at least one card season.");
            var seasonIds = new HashSet<string>(StringComparer.Ordinal);
            foreach (CardSeasonDefinition season in section.Seasons)
            {
                if (string.IsNullOrWhiteSpace(season.SeasonId)) throw new PlayerItemsRuleSetException("Card season needs an id.");
                if (!seasonIds.Add(season.SeasonId)) throw new PlayerItemsRuleSetException("Card season ids must be unique: " + season.SeasonId);
                if (string.IsNullOrWhiteSpace(season.StatProfileId)) throw new PlayerItemsRuleSetException("Card season needs a stat profile: " + season.SeasonId);
                season.RulesVersion = rulesVersion;
            }

            if (!seasonIds.Contains(section.DefaultSeasonId ?? string.Empty))
                throw new PlayerItemsRuleSetException("Card season default must reference a declared season.");
            foreach (KeyValuePair<string, string> pair in section.ProgramSeasons ?? new Dictionary<string, string>())
            {
                if (!seasonIds.Contains(pair.Value ?? string.Empty))
                    throw new PlayerItemsRuleSetException("Program season mapping must reference a declared season: " + pair.Key);
            }

            return new FixedCardSeasonRuleSet(rulesVersion, section.Seasons, section.ProgramSeasons, section.DefaultSeasonId);
        }

        private static IUpgradeTierRuleSet BuildUpgradeTiers(SquadRulesFixtureDocument.UpgradeSection section, string rulesVersion)
        {
            if (section == null || section.MaxTier < 1) throw new PlayerItemsRuleSetException("Upgrade rule set needs a max tier of at least 1.");
            List<UpgradeTierStep> steps = section.Steps ?? new List<UpgradeTierStep>();
            if (steps.Count != section.MaxTier) throw new PlayerItemsRuleSetException("Upgrade rule set needs exactly one step per tier transition.");
            var seen = new HashSet<int>();
            foreach (UpgradeTierStep step in steps)
            {
                if (step.FromTier < 0 || step.FromTier >= section.MaxTier) throw new PlayerItemsRuleSetException("Upgrade step tier is out of range: " + step.FromTier);
                if (!seen.Add(step.FromTier)) throw new PlayerItemsRuleSetException("Upgrade step tiers must be unique: " + step.FromTier);
                if (step.SuccessRateBasisPoints < 0 || step.SuccessRateBasisPoints > 10000) throw new PlayerItemsRuleSetException("Upgrade success rate must be within 0..10000 basis points.");
                if (step.CurrencyCost < 0) throw new PlayerItemsRuleSetException("Upgrade currency cost cannot be negative.");
                foreach (MaterialCost material in step.Materials ?? new List<MaterialCost>())
                {
                    if (string.IsNullOrWhiteSpace(material.ResourceId) || material.Amount <= 0) throw new PlayerItemsRuleSetException("Upgrade material cost is invalid.");
                }

                if (!string.IsNullOrWhiteSpace(step.InsuranceResourceId) && step.InsuranceAmount <= 0)
                    throw new PlayerItemsRuleSetException("Upgrade insurance amount must be positive when an insurance resource is declared.");
            }

            List<int> statScaling = section.StatScalingBasisPoints ?? new List<int>();
            if (statScaling.Count != section.MaxTier + 1) throw new PlayerItemsRuleSetException("Upgrade stat scaling needs one entry per tier including tier 0.");
            if (statScaling[0] != 0) throw new PlayerItemsRuleSetException("Upgrade stat scaling at tier 0 must be zero.");
            return new FixedUpgradeTierRuleSet(rulesVersion, section.MaxTier, steps, statScaling);
        }

        private static ITrainingRuleSet BuildTraining(SquadRulesFixtureDocument.TrainingSection section, string rulesVersion)
        {
            if (section == null || section.MaxLevel < 1) throw new PlayerItemsRuleSetException("Training rule set needs a max level of at least 1.");
            List<int> required = section.PointsRequiredPerLevel ?? new List<int>();
            if (required.Count != section.MaxLevel) throw new PlayerItemsRuleSetException("Training rule set needs one point threshold per level.");
            int previous = 0;
            foreach (int points in required)
            {
                if (points <= 0) throw new PlayerItemsRuleSetException("Training point thresholds must be positive.");
                if (points < previous) throw new PlayerItemsRuleSetException("Training point thresholds must be non-decreasing.");
                previous = points;
            }

            List<int> gains = section.StatGainBasisPoints ?? new List<int>();
            if (gains.Count != section.MaxLevel + 1) throw new PlayerItemsRuleSetException("Training stat gain needs one entry per level including level 0.");
            if (gains[0] != 0) throw new PlayerItemsRuleSetException("Training stat gain at level 0 must be zero.");
            return new FixedTrainingRuleSet(rulesVersion, section.MaxLevel, required, gains, section.PointSources);
        }

        private static ITeamColorRuleSet BuildTeamColor(SquadRulesFixtureDocument.TeamColorSection section, string rulesVersion)
        {
            if (section == null || section.CountedAttributes == null || section.CountedAttributes.Count == 0)
                throw new PlayerItemsRuleSetException("Team color rule set needs at least one counted attribute.");
            if (section.CountedAttributes.Distinct().Count() != section.CountedAttributes.Count)
                throw new PlayerItemsRuleSetException("Team color counted attributes must be unique.");

            List<TeamColorThreshold> thresholds = section.Thresholds ?? new List<TeamColorThreshold>();
            if (thresholds.Count == 0) throw new PlayerItemsRuleSetException("Team color rule set needs at least one threshold.");
            var profileIds = new HashSet<string>((section.BonusProfiles ?? new List<TeamColorBonusProfile>()).Select(profile => profile.ProfileId), StringComparer.Ordinal);
            int previous = 0;
            foreach (TeamColorThreshold threshold in thresholds.OrderBy(item => item.MinCount))
            {
                if (threshold.MinCount <= previous) throw new PlayerItemsRuleSetException("Team color thresholds must be strictly ascending and positive.");
                if (!profileIds.Contains(threshold.BonusProfileId ?? string.Empty))
                    throw new PlayerItemsRuleSetException("Team color threshold must reference a declared bonus profile: " + threshold.BonusProfileId);
                previous = threshold.MinCount;
            }

            foreach (TeamColorBonusProfile profile in section.BonusProfiles ?? new List<TeamColorBonusProfile>())
            {
                foreach (StatModifier modifier in profile.StatModifiers ?? new List<StatModifier>())
                {
                    if (string.IsNullOrWhiteSpace(modifier.AttributeId)) throw new PlayerItemsRuleSetException("Team color stat modifier needs an attribute id.");
                    if (modifier.BasisPoints < -2000 || modifier.BasisPoints > 2000) throw new PlayerItemsRuleSetException("Team color stat modifier must stay within +/-2000 basis points.");
                }
            }

            return new FixedTeamColorRuleSet(rulesVersion, section.CountedAttributes, section.CountingScope, thresholds, section.BonusProfiles);
        }

        private static ISalaryRuleSet BuildSalary(SquadRulesFixtureDocument.SalarySection section, int maxTier, string rulesVersion)
        {
            if (section == null || section.Bands == null || section.Bands.Count == 0) throw new PlayerItemsRuleSetException("Salary rule set needs at least one band.");
            List<SalaryBand> bands = section.Bands.OrderBy(band => band.MinOverall).ToList();
            if (bands[0].MinOverall != 0) throw new PlayerItemsRuleSetException("Salary bands must start at overall 0.");
            int previous = -1;
            foreach (SalaryBand band in bands)
            {
                if (band.MinOverall <= previous) throw new PlayerItemsRuleSetException("Salary bands must be strictly ascending by overall.");
                if (band.BaseSalary < 0) throw new PlayerItemsRuleSetException("Salary band cannot be negative.");
                previous = band.MinOverall;
            }

            List<int> scaling = section.TierScalingBasisPoints ?? new List<int>();
            if (scaling.Count != maxTier + 1) throw new PlayerItemsRuleSetException("Salary tier scaling needs one entry per tier including tier 0.");
            if (scaling[0] != 0) throw new PlayerItemsRuleSetException("Salary tier scaling at tier 0 must be zero.");
            return new FixedSalaryRuleSet(rulesVersion, bands, scaling);
        }

        private static ISquadRuleSet BuildSquad(SquadRulesFixtureDocument.SquadSection section, string rulesVersion)
        {
            if (section == null || section.StartingCount < 1) throw new PlayerItemsRuleSetException("Squad rule set needs a positive starting count.");
            if (section.BenchCount < 0) throw new PlayerItemsRuleSetException("Squad bench count cannot be negative.");
            if (section.MaxSquadSlots < 1) throw new PlayerItemsRuleSetException("Squad rule set needs at least one squad slot.");
            if (section.SalaryCapBase <= 0) throw new PlayerItemsRuleSetException("Squad salary cap base must be positive.");
            if (section.SalaryCapExpansionMax < 0) throw new PlayerItemsRuleSetException("Squad salary cap expansion cannot be negative.");

            List<FormationDefinition> formations = section.Formations ?? new List<FormationDefinition>();
            if (formations.Count == 0) throw new PlayerItemsRuleSetException("Squad rule set needs at least one formation.");
            Dictionary<string, string> slotGroups = section.PositionSlotGroups ?? new Dictionary<string, string>(StringComparer.Ordinal);
            string goalkeeperGroup = section.GoalkeeperPositionGroup ?? string.Empty;
            if (string.IsNullOrWhiteSpace(goalkeeperGroup)) throw new PlayerItemsRuleSetException("Squad rule set needs a goalkeeper position group.");

            var formationIds = new HashSet<string>(StringComparer.Ordinal);
            foreach (FormationDefinition formation in formations)
            {
                if (string.IsNullOrWhiteSpace(formation.FormationId)) throw new PlayerItemsRuleSetException("Formation needs an id.");
                if (!formationIds.Add(formation.FormationId)) throw new PlayerItemsRuleSetException("Formation ids must be unique: " + formation.FormationId);
                List<string> slots = formation.PositionSlotIds ?? new List<string>();
                if (slots.Count != section.StartingCount) throw new PlayerItemsRuleSetException("Formation slot count must match the starting count: " + formation.FormationId);
                if (slots.Distinct(StringComparer.Ordinal).Count() != slots.Count) throw new PlayerItemsRuleSetException("Formation slot ids must be unique: " + formation.FormationId);
                if (slots.Any(string.IsNullOrWhiteSpace)) throw new PlayerItemsRuleSetException("Formation slot ids cannot be empty: " + formation.FormationId);

                int goalkeepers = 0;
                foreach (string slot in slots)
                {
                    if (!slotGroups.TryGetValue(slot, out string group) || string.IsNullOrWhiteSpace(group))
                        throw new PlayerItemsRuleSetException("Formation slot needs a declared position group: " + slot);
                    if (string.Equals(group, goalkeeperGroup, StringComparison.Ordinal)) goalkeepers++;
                }

                if (goalkeepers != 1) throw new PlayerItemsRuleSetException("Formation needs exactly one goalkeeper slot: " + formation.FormationId);
            }

            return new FixedSquadRuleSet(
                rulesVersion,
                section.StartingCount,
                section.BenchCount,
                section.MaxSquadSlots,
                section.SalaryCapBase,
                section.SalaryCapExpansionMax,
                section.SalaryCountingScope,
                formations,
                slotGroups);
        }
    }
}

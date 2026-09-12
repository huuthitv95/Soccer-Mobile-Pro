using System;
using System.Collections.Generic;
using System.Linq;
using SoccerMobilePro.Catalog;

namespace SoccerMobilePro.PlayerItems
{
    public sealed class CatalogTeamColorTagResolver : ITeamColorTagResolver
    {
        private readonly Dictionary<string, PlayerItemDefinition> definitions;
        private readonly Dictionary<string, PlayerIdentity> players;
        private readonly Dictionary<string, string> playerClubs;
        private readonly Dictionary<string, string> clubLeagues;
        private readonly ICardSeasonRuleSet seasons;

        public CatalogTeamColorTagResolver(CatalogSnapshot catalog, ICardSeasonRuleSet seasons)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            this.seasons = seasons ?? throw new ArgumentNullException(nameof(seasons));
            definitions = (catalog.Items ?? new List<PlayerItemDefinition>())
                .GroupBy(item => item.ItemDefinitionId, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);
            players = (catalog.Players ?? new List<PlayerIdentity>())
                .GroupBy(player => player.PlayerId, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First(), StringComparer.Ordinal);
            clubLeagues = (catalog.Clubs ?? new List<ClubDefinition>())
                .GroupBy(club => club.ClubId, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First().LeagueId ?? string.Empty, StringComparer.Ordinal);
            playerClubs = (catalog.Registrations ?? new List<PlayerClubRegistration>())
                .Where(registration => string.Equals(registration.SeasonId, catalog.Season, StringComparison.Ordinal))
                .GroupBy(registration => registration.PlayerId, StringComparer.Ordinal)
                .ToDictionary(
                    group => group.Key,
                    group => group.OrderBy(registration => registration.RegistrationId, StringComparer.Ordinal).First().ClubId ?? string.Empty,
                    StringComparer.Ordinal);
        }

        public bool TryResolve(OwnedPlayerItem item, out TeamColorTag tag)
        {
            tag = null;
            if (item == null || !definitions.TryGetValue(item.ItemDefinitionId ?? string.Empty, out PlayerItemDefinition definition)) return false;

            string clubId = playerClubs.TryGetValue(definition.PlayerId ?? string.Empty, out string club) ? club : string.Empty;
            string nationId = players.TryGetValue(definition.PlayerId ?? string.Empty, out PlayerIdentity identity)
                ? (identity.NationalityIds ?? new List<string>()).OrderBy(value => value, StringComparer.Ordinal).FirstOrDefault() ?? string.Empty
                : string.Empty;
            tag = new TeamColorTag
            {
                ClubId = clubId,
                NationId = nationId,
                LeagueId = clubLeagues.TryGetValue(clubId, out string leagueId) ? leagueId : string.Empty,
                SeasonId = string.IsNullOrWhiteSpace(item.SeasonId) ? seasons.ResolveSeasonId(definition.ProgramId) : item.SeasonId
            };
            return true;
        }
    }

    public sealed class CatalogPositionGroupResolver : IPositionGroupResolver
    {
        private readonly Dictionary<string, string> groupsByDefinition;

        public CatalogPositionGroupResolver(CatalogSnapshot catalog)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            Dictionary<string, string> primaryByPlayer = (catalog.Ratings ?? new List<PlayerSeasonRating>())
                .Where(rating => string.Equals(rating.SeasonId, catalog.Season, StringComparison.Ordinal))
                .GroupBy(rating => rating.PlayerId, StringComparer.Ordinal)
                .ToDictionary(
                    group => group.Key,
                    group => group.OrderBy(rating => rating.RatingId, StringComparer.Ordinal).First().PrimaryPosition ?? string.Empty,
                    StringComparer.Ordinal);

            groupsByDefinition = new Dictionary<string, string>(StringComparer.Ordinal);
            foreach (PlayerItemDefinition definition in catalog.Items ?? new List<PlayerItemDefinition>())
            {
                if (string.IsNullOrWhiteSpace(definition.ItemDefinitionId) || groupsByDefinition.ContainsKey(definition.ItemDefinitionId)) continue;
                if (!primaryByPlayer.TryGetValue(definition.PlayerId ?? string.Empty, out string group) || string.IsNullOrWhiteSpace(group)) continue;
                groupsByDefinition[definition.ItemDefinitionId] = group;
            }
        }

        public bool TryResolveGroup(string itemDefinitionId, out string positionGroup) => groupsByDefinition.TryGetValue(itemDefinitionId ?? string.Empty, out positionGroup);
    }

    public sealed class CatalogSalaryCalculator : ISalaryCalculator
    {
        private readonly Dictionary<string, int> overallByDefinition;
        private readonly ISalaryRuleSet rules;

        public CatalogSalaryCalculator(CatalogSnapshot catalog, ISalaryRuleSet rules)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            overallByDefinition = (catalog.Items ?? new List<PlayerItemDefinition>())
                .GroupBy(item => item.ItemDefinitionId, StringComparer.Ordinal)
                .ToDictionary(group => group.Key, group => group.First().BaseOverall, StringComparer.Ordinal);
        }

        public long SalaryFor(OwnedPlayerItem item)
        {
            if (item == null) return 0L;
            if (item.SalaryOverride.HasValue) return Math.Max(0L, item.SalaryOverride.Value);

            int overall = overallByDefinition.TryGetValue(item.ItemDefinitionId ?? string.Empty, out int value) ? value : 0;
            long baseSalary = rules.BaseSalaryForOverall(overall);
            long scaled = baseSalary * (10000L + rules.TierSalaryScalingBasisPoints(item.UpgradeTier));
            return (scaled + 5000L) / 10000L;
        }

        public long TotalFor(IEnumerable<OwnedPlayerItem> items)
            => (items ?? Array.Empty<OwnedPlayerItem>()).Where(item => item != null).Sum(SalaryFor);
    }

    public sealed class TeamColorCalculator : ITeamColorCalculator
    {
        private readonly ITeamColorRuleSet rules;
        private readonly ITeamColorTagResolver resolver;

        public TeamColorCalculator(ITeamColorRuleSet rules, ITeamColorTagResolver resolver)
        {
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
        }

        public TeamColorEvaluation Evaluate(IReadOnlyList<OwnedPlayerItem> startingEleven, IReadOnlyList<OwnedPlayerItem> bench)
        {
            List<OwnedPlayerItem> counted = (startingEleven ?? Array.Empty<OwnedPlayerItem>()).Where(item => item != null).ToList();
            if (rules.CountingScope == SquadCountingScope.MatchSquad)
                counted.AddRange((bench ?? Array.Empty<OwnedPlayerItem>()).Where(item => item != null));

            var evaluation = new TeamColorEvaluation { Scope = rules.CountingScope, CountedItems = counted.Count };
            for (int index = 0; index < rules.CountedAttributes.Count; index++)
            {
                TeamColorAttribute attribute = rules.CountedAttributes[index];
                var counts = new Dictionary<string, int>(StringComparer.Ordinal);
                foreach (OwnedPlayerItem item in counted)
                {
                    if (!resolver.TryResolve(item, out TeamColorTag tag)) continue;
                    string valueId = tag.ValueFor(attribute);
                    if (string.IsNullOrWhiteSpace(valueId)) continue;
                    counts[valueId] = (counts.TryGetValue(valueId, out int current) ? current : 0) + 1;
                }

                foreach (KeyValuePair<string, int> pair in counts.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key, StringComparer.Ordinal))
                {
                    string profileId = rules.ResolveProfileId(pair.Value);
                    if (string.IsNullOrEmpty(profileId)) continue;
                    evaluation.Matches.Add(new TeamColorMatch
                    {
                        Attribute = attribute,
                        ValueId = pair.Key,
                        Count = pair.Value,
                        BonusProfileId = profileId
                    });
                }
            }

            evaluation.Matches = evaluation.Matches
                .OrderByDescending(match => match.Count)
                .ThenBy(match => rules.CountedAttributes.ToList().IndexOf(match.Attribute))
                .ThenBy(match => match.ValueId, StringComparer.Ordinal)
                .ToList();
            evaluation.Best = evaluation.Matches.FirstOrDefault();
            return evaluation;
        }
    }

    public sealed class SquadValidator : ISquadValidator
    {
        private readonly ISquadRuleSet squadRules;
        private readonly ISalaryCalculator salary;
        private readonly ITeamColorCalculator teamColor;
        private readonly IPositionGroupResolver positions;
        private readonly bool featureEnabled;

        public SquadValidator(
            ISquadRuleSet squadRules,
            ISalaryCalculator salary,
            ITeamColorCalculator teamColor,
            IPositionGroupResolver positions,
            bool featureEnabled = true)
        {
            this.squadRules = squadRules ?? throw new ArgumentNullException(nameof(squadRules));
            this.salary = salary ?? throw new ArgumentNullException(nameof(salary));
            this.teamColor = teamColor ?? throw new ArgumentNullException(nameof(teamColor));
            this.positions = positions ?? throw new ArgumentNullException(nameof(positions));
            this.featureEnabled = featureEnabled;
        }

        public SquadValidationResult Validate(InventorySnapshot snapshot, SquadDefinition definition)
        {
            if (snapshot == null) throw new ArgumentNullException(nameof(snapshot));
            if (definition == null) throw new ArgumentNullException(nameof(definition));

            var result = new SquadValidationResult { SalaryCap = SalaryCap(definition) };
            if (!featureEnabled)
            {
                result.Errors.Add(Issue(SquadValidationCode.FeatureDisabled));
                return Finish(result);
            }

            if (!string.Equals(definition.OwnerId, snapshot.OwnerId, StringComparison.Ordinal)) result.Errors.Add(Issue(SquadValidationCode.OwnerMismatch));
            if (!string.Equals(definition.RulesVersion, squadRules.RulesVersion, StringComparison.Ordinal)) result.Errors.Add(Issue(SquadValidationCode.StaleRules));
            if (!string.Equals(definition.CatalogVersion, snapshot.CatalogVersion, StringComparison.Ordinal)) result.Errors.Add(Issue(SquadValidationCode.StaleCatalog));
            if (definition.SlotIndex < 0 || definition.SlotIndex >= squadRules.MaxSquadSlots) result.Errors.Add(Issue(SquadValidationCode.SquadSlotOutOfRange));

            if (!squadRules.TryGetFormation(definition.FormationId, out FormationDefinition formation))
            {
                result.Errors.Add(Issue(SquadValidationCode.UnknownFormation));
                return Finish(result);
            }

            List<SquadSlotAssignment> assignments = definition.Assignments ?? new List<SquadSlotAssignment>();
            if (assignments.Count != squadRules.StartingCount) result.Errors.Add(Issue(SquadValidationCode.StartingCountMismatch));

            var formationSlots = new HashSet<string>(formation.PositionSlotIds ?? new List<string>(), StringComparer.Ordinal);
            var usedSlots = new HashSet<string>(StringComparer.Ordinal);
            var usedItems = new HashSet<string>(StringComparer.Ordinal);
            var startingItems = new List<OwnedPlayerItem>();

            foreach (SquadSlotAssignment assignment in assignments)
            {
                string slotId = assignment?.PositionSlotId ?? string.Empty;
                string itemId = assignment?.ItemId ?? string.Empty;
                if (!formationSlots.Contains(slotId))
                {
                    result.Errors.Add(Issue(SquadValidationCode.UnknownPositionSlot, slotId, itemId));
                    continue;
                }

                if (!usedSlots.Add(slotId) || !usedItems.Add(itemId))
                {
                    result.Errors.Add(Issue(SquadValidationCode.DuplicateAssignment, slotId, itemId));
                    continue;
                }

                OwnedPlayerItem item = snapshot.Find(itemId);
                if (item == null)
                {
                    result.Errors.Add(Issue(SquadValidationCode.ItemNotFound, slotId, itemId));
                    continue;
                }

                if (!string.Equals(item.OwnerId, snapshot.OwnerId, StringComparison.Ordinal))
                {
                    result.Errors.Add(Issue(SquadValidationCode.OwnerMismatch, slotId, itemId));
                    continue;
                }

                if (item.State != PlayerItemState.Available && item.State != PlayerItemState.InSquad)
                {
                    result.Errors.Add(Issue(SquadValidationCode.ItemNotAssignable, slotId, itemId));
                    continue;
                }

                if (!positions.TryResolveGroup(item.ItemDefinitionId, out string itemGroup))
                {
                    result.Errors.Add(Issue(SquadValidationCode.StaleCatalog, slotId, itemId));
                    continue;
                }

                startingItems.Add(item);
                if (squadRules.TryGetSlotGroup(slotId, out string slotGroup)
                    && !string.Equals(slotGroup, itemGroup, StringComparison.Ordinal)
                    && !(item.PositionProficiencies ?? new List<string>()).Contains(slotId, StringComparer.Ordinal))
                {
                    result.Warnings.Add(Issue(SquadValidationCode.PositionProficiencyMismatch, slotId, itemId));
                }
            }

            List<OwnedPlayerItem> benchItems = ValidateBench(snapshot, definition, usedItems, result);
            ValidateRoles(definition, usedItems, result);

            result.TeamColor = teamColor.Evaluate(startingItems, benchItems);
            result.SalaryTotal = squadRules.SalaryCountingScope == SquadCountingScope.MatchSquad
                ? salary.TotalFor(startingItems.Concat(benchItems))
                : salary.TotalFor(startingItems);
            if (result.SalaryTotal > result.SalaryCap) result.Errors.Add(Issue(SquadValidationCode.SalaryCapExceeded));
            return Finish(result);
        }

        private List<OwnedPlayerItem> ValidateBench(InventorySnapshot snapshot, SquadDefinition definition, HashSet<string> usedItems, SquadValidationResult result)
        {
            List<string> benchIds = definition.BenchItemIds ?? new List<string>();
            var benchItems = new List<OwnedPlayerItem>();
            if (benchIds.Count != squadRules.BenchCount) result.Errors.Add(Issue(SquadValidationCode.BenchCountMismatch));

            foreach (string itemId in benchIds)
            {
                if (!usedItems.Add(itemId ?? string.Empty))
                {
                    result.Errors.Add(Issue(SquadValidationCode.DuplicateAssignment, string.Empty, itemId));
                    continue;
                }

                OwnedPlayerItem item = snapshot.Find(itemId);
                if (item == null)
                {
                    result.Errors.Add(Issue(SquadValidationCode.ItemNotFound, string.Empty, itemId));
                    continue;
                }

                if (!string.Equals(item.OwnerId, snapshot.OwnerId, StringComparison.Ordinal))
                {
                    result.Errors.Add(Issue(SquadValidationCode.OwnerMismatch, string.Empty, itemId));
                    continue;
                }

                if (item.State != PlayerItemState.Available && item.State != PlayerItemState.InSquad)
                {
                    result.Errors.Add(Issue(SquadValidationCode.ItemNotAssignable, string.Empty, itemId));
                    continue;
                }

                benchItems.Add(item);
            }

            return benchItems;
        }

        private static void ValidateRoles(SquadDefinition definition, HashSet<string> assignedItems, SquadValidationResult result)
        {
            var startingIds = new HashSet<string>((definition.Assignments ?? new List<SquadSlotAssignment>()).Select(assignment => assignment?.ItemId ?? string.Empty), StringComparer.Ordinal);
            if (!string.IsNullOrWhiteSpace(definition.CaptainItemId) && !startingIds.Contains(definition.CaptainItemId))
                result.Errors.Add(Issue(SquadValidationCode.CaptainNotInStartingXi, string.Empty, definition.CaptainItemId));

            SetPieceTakers takers = definition.SetPieceTakers ?? new SetPieceTakers();
            foreach (string takerId in new[] { takers.FreeKickItemId, takers.PenaltyItemId, takers.CornerItemId, takers.ThrowInItemId })
            {
                if (string.IsNullOrWhiteSpace(takerId) || startingIds.Contains(takerId)) continue;
                result.Errors.Add(Issue(SquadValidationCode.SetPieceTakerNotInStartingXi, string.Empty, takerId));
            }
        }

        private long SalaryCap(SquadDefinition definition)
        {
            long expansion = Math.Min(Math.Max(0L, definition.SalaryCapExpansion), squadRules.SalaryCapExpansionMax);
            return squadRules.SalaryCapBase + expansion;
        }

        private static SquadValidationIssue Issue(SquadValidationCode code, string positionSlotId = "", string itemId = "")
            => new SquadValidationIssue { Code = code, PositionSlotId = positionSlotId ?? string.Empty, ItemId = itemId ?? string.Empty };

        private static SquadValidationResult Finish(SquadValidationResult result)
        {
            result.IsValid = result.Errors.Count == 0;
            result.IsPlayable = result.IsValid;
            result.CanSave = result.Errors.All(issue => SquadValidationPolicy.IsSaveable(issue.Code));
            return result;
        }
    }
}

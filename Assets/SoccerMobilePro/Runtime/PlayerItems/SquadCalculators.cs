using System;
using System.Collections.Generic;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B2: bo tinh luong va Team Color.
    // Ca hai la pure function cua (squad + inventory + catalog + rule set): khong giu state,
    // khong ghi ket qua xuong snapshot, de server luon tinh lai duoc tu du lieu goc.

    public static class SquadScope
    {
        // Pham vi dem: danh sach itemId duy nhat, bo qua o trong, giu thu tu khai bao.
        public static IReadOnlyList<string> ItemIds(SquadDefinition squad, SquadCountingScope scope)
        {
            if (squad == null) return new List<string>();
            IEnumerable<string> source = scope == SquadCountingScope.MatchSquad
                ? squad.MatchSquadItemIds()
                : squad.StartingItemIds();
            return source
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .Distinct(StringComparer.Ordinal)
                .ToList();
        }
    }

    public static class SquadSalaryPolicy
    {
        // Cap = salaryCapBase + phan mo rong da clamp vao [0, salaryCapExpansionMax].
        // Giu o mot cho de calculator va validator khong bao gio lech nhau.
        public static long Cap(ISquadRuleSet rules, long salaryCapExpansion)
        {
            if (rules == null) throw new ArgumentNullException(nameof(rules));
            long expansion = Math.Max(0L, Math.Min(salaryCapExpansion, rules.SalaryCapExpansionMax));
            return rules.SalaryCapBase + expansion;
        }
    }

    public sealed class FixedSalaryCalculator : ISalaryCalculator
    {
        private const long BasisPointScale = 10000L;

        private readonly ISquadEconomyCatalog economy;
        private readonly IUpgradeTierRuleSet upgrades;
        private readonly ISquadRuleSet squads;

        public FixedSalaryCalculator(ISquadEconomyCatalog economy, IUpgradeTierRuleSet upgrades, ISquadRuleSet squads)
        {
            this.economy = economy ?? throw new ArgumentNullException(nameof(economy));
            this.upgrades = upgrades ?? throw new ArgumentNullException(nameof(upgrades));
            this.squads = squads ?? throw new ArgumentNullException(nameof(squads));
        }

        // Luong the = luong goc * (1 + salaryScalingPerTier[tier]), lam tron nua len bang so nguyen
        // (khong dung double de ket qua khong phu thuoc thu tu cong hay nen tang).
        public long ItemSalary(OwnedPlayerItem item)
        {
            if (item == null) return 0L;
            long baseSalary = BaseSalary(item);
            if (baseSalary <= 0L) return 0L;
            long scaling = upgrades.SalaryScalingBasisPoints(Math.Max(0, item.UpgradeTier));
            return ((baseSalary * (BasisPointScale + scaling)) + (BasisPointScale / 2L)) / BasisPointScale;
        }

        // The thieu trong inventory duoc bo qua o day; validator chiu trach nhiem bao ItemNotFound.
        public long SquadSalary(SquadDefinition squad, InventorySnapshot inventory)
        {
            if (squad == null || inventory == null) return 0L;
            long total = 0L;
            foreach (string itemId in SquadScope.ItemIds(squad, squads.SalaryCountingScope))
            {
                total += ItemSalary(inventory.Find(itemId));
            }

            return total;
        }

        public long SalaryCap(long salaryCapExpansion) => SquadSalaryPolicy.Cap(squads, salaryCapExpansion);

        private long BaseSalary(OwnedPlayerItem item)
        {
            // salaryOverride tren the so huu thang luong goc cua catalog (the su kien, the thuong).
            if (item.SalaryOverride.HasValue) return Math.Max(0L, item.SalaryOverride.Value);
            CardEconomyProfile profile;
            return economy.TryGetProfile(item.ItemDefinitionId, out profile) ? profile.BaseSalary : 0L;
        }
    }

    public sealed class FixedTeamColorCalculator : ITeamColorCalculator
    {
        private readonly ISquadEconomyCatalog economy;
        private readonly ITeamColorRuleSet rules;

        public FixedTeamColorCalculator(ISquadEconomyCatalog economy, ITeamColorRuleSet rules)
        {
            this.economy = economy ?? throw new ArgumentNullException(nameof(economy));
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
        }

        // Chi tra ve to hop da dat nguong. Thu tu on dinh (so luong giam dan, roi tag theo Ordinal)
        // de UI, trace va test khong phu thuoc thu tu duyet Dictionary.
        public IReadOnlyList<TeamColorResult> Evaluate(SquadDefinition squad, InventorySnapshot inventory)
        {
            var results = new List<TeamColorResult>();
            if (squad == null || inventory == null) return results;

            IReadOnlyList<string> scopeItemIds = SquadScope.ItemIds(squad, rules.CountingScope);
            IReadOnlyList<TeamColorAttribute> attributes = rules.CountedAttributes ?? new List<TeamColorAttribute>();
            foreach (TeamColorAttribute attribute in attributes)
            {
                var counts = new Dictionary<string, int>(StringComparer.Ordinal);
                foreach (string itemId in scopeItemIds)
                {
                    OwnedPlayerItem item = inventory.Find(itemId);
                    if (item == null) continue;
                    string tagValue;
                    if (!TryGetTag(item, attribute, out tagValue)) continue;
                    int current;
                    counts.TryGetValue(tagValue, out current);
                    counts[tagValue] = current + 1;
                }

                foreach (KeyValuePair<string, int> pair in counts
                    .OrderByDescending(entry => entry.Value)
                    .ThenBy(entry => entry.Key, StringComparer.Ordinal))
                {
                    string bonusProfileId;
                    if (!rules.TryResolveProfileId(pair.Value, out bonusProfileId)) continue;
                    results.Add(new TeamColorResult
                    {
                        Attribute = attribute,
                        TagValue = pair.Key,
                        Count = pair.Value,
                        Scope = rules.CountingScope,
                        BonusProfileId = bonusProfileId
                    });
                }
            }

            return results;
        }

        public bool TryGetBonus(TeamColorResult result, out TeamColorBonusProfile profile)
        {
            if (result == null)
            {
                profile = null;
                return false;
            }

            return rules.TryGetProfile(result.BonusProfileId, out profile);
        }

        // Mua ghi tren the so huu uu tien hon mua mac dinh cua catalog: mot the co the doi mua
        // (su kien, nang bac dac biet) ma khong can tao dinh nghia catalog moi.
        private bool TryGetTag(OwnedPlayerItem item, TeamColorAttribute attribute, out string value)
        {
            if (attribute == TeamColorAttribute.Season && !string.IsNullOrWhiteSpace(item.SeasonId))
            {
                value = item.SeasonId;
                return true;
            }

            CardEconomyProfile profile;
            if (!economy.TryGetProfile(item.ItemDefinitionId, out profile) || profile.Tags == null)
            {
                value = string.Empty;
                return false;
            }

            return profile.Tags.TryGetValue(attribute, out value);
        }
    }
}

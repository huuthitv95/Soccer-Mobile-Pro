using System;
using System.Collections.Generic;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B2: bo kiem tra doi hinh.
    //
    // Hai muc do khac nhau, khong duoc lan:
    //   IsValid    = khong con loi nao (Errors rong)  -> dung cho UI "doi hinh sach"
    //   IsPlayable = duoc phep vao tran                -> hien tai bang IsValid
    //   CanSave    = duoc phep ghi xuong storage       -> IsValid, hoac moi loi deu thuoc allowInvalidSave
    //
    // Nho tap allowInvalidSave, nguoi choi co the luu doi hinh con thieu du bi va hoan thien sau,
    // nhung doi hinh do khong ra tran duoc (IsPlayable = false).
    public static class SquadSavePolicy
    {
        public static bool CanSave(ISquadRuleSet rules, SquadValidationResult result)
        {
            if (rules == null) throw new ArgumentNullException(nameof(rules));
            if (result == null) return false;
            if (result.Errors == null || result.Errors.Count == 0) return true;
            return result.Errors.All(issue => rules.AllowsInvalidSave(issue.Code));
        }
    }

    public sealed class SquadValidator : ISquadValidator
    {
        private readonly ISquadRuleSet rules;
        private readonly ISalaryCalculator salary;
        private readonly ITeamColorCalculator teamColor;
        private readonly ISquadRulesFeatureFlag featureFlag;

        public SquadValidator(
            ISquadRuleSet rules,
            ISalaryCalculator salary,
            ITeamColorCalculator teamColor,
            ISquadRulesFeatureFlag featureFlag)
        {
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.salary = salary ?? throw new ArgumentNullException(nameof(salary));
            this.teamColor = teamColor ?? throw new ArgumentNullException(nameof(teamColor));
            this.featureFlag = featureFlag ?? throw new ArgumentNullException(nameof(featureFlag));
        }

        public SquadValidationResult Validate(SquadDefinition squad, InventorySnapshot inventory, long salaryCapExpansion)
        {
            if (squad == null) throw new ArgumentNullException(nameof(squad));
            if (inventory == null) throw new ArgumentNullException(nameof(inventory));

            var result = new SquadValidationResult
            {
                IsPlayable = false,
                SalaryCap = SquadSalaryPolicy.Cap(rules, salaryCapExpansion)
            };

            // Flag tat: khong danh gia gi them de tranh sinh loi gia khi tinh nang chua bat.
            if (!featureFlag.IsEnabled)
            {
                Error(result, SquadValidationCode.FeatureDisabled);
                return result;
            }

            // Lech rules version: client dang giu luat cu, khong the ket luan gi ve doi hinh.
            if (!string.Equals(squad.RulesVersion, rules.RulesVersion, StringComparison.Ordinal))
            {
                Error(result, SquadValidationCode.RulesVersionMismatch);
                return result;
            }

            if (!string.Equals(squad.OwnerId, inventory.OwnerId, StringComparison.Ordinal))
            {
                Error(result, SquadValidationCode.OwnerMismatch);
                return result;
            }

            if (squad.SlotIndex < 0 || squad.SlotIndex >= rules.MaxSquadSlots)
            {
                Error(result, SquadValidationCode.SquadSlotLimitExceeded);
            }

            FormationDefinition formation;
            if (!rules.TryGetFormation(squad.FormationId, out formation))
            {
                Error(result, SquadValidationCode.FormationUnknown);
                return result;
            }

            var seenSlots = new HashSet<string>(StringComparer.Ordinal);
            var seenItems = new HashSet<string>(StringComparer.Ordinal);
            IReadOnlyList<SquadSlotAssignment> assignments = squad.Assignments ?? new List<SquadSlotAssignment>();
            foreach (SquadSlotAssignment assignment in assignments)
            {
                string slotId = assignment == null ? string.Empty : assignment.PositionSlotId ?? string.Empty;
                string itemId = assignment == null ? string.Empty : assignment.ItemId ?? string.Empty;

                // SlotUnknown bao ca hai truong hop khong quy duoc ve mot vi tri hop le:
                // slot khong co trong so do, va slot bi gan hai lan trong cung mot doi hinh.
                FormationSlot slot;
                if (!formation.TryGetSlot(slotId, out slot) || !seenSlots.Add(slotId))
                {
                    Error(result, SquadValidationCode.SlotUnknown, slotId, itemId);
                    continue;
                }

                if (itemId.Length == 0)
                {
                    Error(result, SquadValidationCode.SlotEmpty, slotId);
                    continue;
                }

                if (!seenItems.Add(itemId))
                {
                    Error(result, SquadValidationCode.DuplicateItem, slotId, itemId);
                    continue;
                }

                OwnedPlayerItem item = ValidateMembership(result, inventory, squad.OwnerId, slotId, itemId);
                if (item == null) continue;

                // Lech vi tri chi la canh bao (ke hoach P1-06 muc 5): the van ra san duoc,
                // phan phat chi so se xu ly o lo tinh chi so tran dau.
                if (item.PositionProficiencies != null
                    && item.PositionProficiencies.Count > 0
                    && !item.PositionProficiencies.Contains(slot.PositionId, StringComparer.Ordinal))
                {
                    Warning(result, SquadValidationCode.PositionMismatch, slotId, itemId);
                }
            }

            IReadOnlyList<FormationSlot> formationSlots = formation.PositionSlots ?? new List<FormationSlot>();
            foreach (FormationSlot slot in formationSlots)
            {
                if (!seenSlots.Contains(slot.PositionSlotId)) Error(result, SquadValidationCode.SlotEmpty, slot.PositionSlotId);
            }

            List<string> bench = (squad.BenchItemIds ?? new List<string>())
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .ToList();
            if (bench.Count != rules.BenchCount) Error(result, SquadValidationCode.BenchIncomplete);
            foreach (string itemId in bench)
            {
                if (!seenItems.Add(itemId))
                {
                    Error(result, SquadValidationCode.DuplicateItem, string.Empty, itemId);
                    continue;
                }

                ValidateMembership(result, inventory, squad.OwnerId, string.Empty, itemId);
            }

            var startingItemIds = new HashSet<string>(SquadScope.ItemIds(squad, SquadCountingScope.StartingXI), StringComparer.Ordinal);
            var matchSquadItemIds = new HashSet<string>(SquadScope.ItemIds(squad, SquadCountingScope.MatchSquad), StringComparer.Ordinal);

            // Doi truong bat buoc va phai thuoc doi hinh chinh.
            if (string.IsNullOrWhiteSpace(squad.CaptainItemId) || !startingItemIds.Contains(squad.CaptainItemId))
            {
                Error(result, SquadValidationCode.CaptainNotInStartingXI, string.Empty, squad.CaptainItemId ?? string.Empty);
            }

            // Nguoi thuc hien tinh huong co dinh la tuy chon, nhung neu da chon thi phai nam trong doi hinh ra san.
            SetPieceTakers takers = squad.SetPieceTakers ?? new SetPieceTakers();
            foreach (string itemId in takers.AssignedItemIds())
            {
                if (!matchSquadItemIds.Contains(itemId)) Error(result, SquadValidationCode.SetPieceTakerNotInSquad, string.Empty, itemId);
            }

            result.SalaryTotal = salary.SquadSalary(squad, inventory);
            if (result.SalaryTotal > result.SalaryCap) Error(result, SquadValidationCode.SalaryCapExceeded);

            result.TeamColor = teamColor.Evaluate(squad, inventory).ToList();
            result.IsPlayable = result.IsValid;
            return result;
        }

        private static OwnedPlayerItem ValidateMembership(
            SquadValidationResult result,
            InventorySnapshot inventory,
            string ownerId,
            string slotId,
            string itemId)
        {
            OwnedPlayerItem item = inventory.Find(itemId);
            if (item == null)
            {
                Error(result, SquadValidationCode.ItemNotFound, slotId, itemId);
                return null;
            }

            if (!string.Equals(item.OwnerId, ownerId, StringComparison.Ordinal))
            {
                Error(result, SquadValidationCode.OwnerMismatch, slotId, itemId);
                return null;
            }

            // Consumed = da tieu huy, Reserved = dang bi giao dich khac giu.
            if (item.State == PlayerItemState.Consumed || item.State == PlayerItemState.Reserved)
            {
                Error(result, SquadValidationCode.ItemUnavailable, slotId, itemId);
                return null;
            }

            // Lock bao ve the khoi bi tieu huy, khong chan the ra san -> chi canh bao de UI hien dau khoa.
            if (item.LockState == PlayerItemLockState.Locked) Warning(result, SquadValidationCode.ItemLocked, slotId, itemId);
            return item;
        }

        private static void Error(SquadValidationResult result, SquadValidationCode code, string positionSlotId = "", string itemId = "")
            => result.Errors.Add(Issue(code, positionSlotId, itemId));

        private static void Warning(SquadValidationResult result, SquadValidationCode code, string positionSlotId = "", string itemId = "")
            => result.Warnings.Add(Issue(code, positionSlotId, itemId));

        private static SquadValidationIssue Issue(SquadValidationCode code, string positionSlotId, string itemId)
            => new SquadValidationIssue
            {
                Code = code,
                PositionSlotId = positionSlotId ?? string.Empty,
                ItemId = itemId ?? string.Empty
            };
    }
}

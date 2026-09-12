using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B2: duong ghi doi hinh.
    // Day la diem duy nhat ap dung chinh sach luu: validate -> CanSave -> commit atomic kem receipt + so ke toan.
    // Chua xu ly chuyen trang thai item (Available <-> InSquad) vi viec do cham vao inventory aggregate,
    // can mot giao dich chung voi InventoryTransactionService -> de sang lo sau.

    public static class SquadCanonical
    {
        // Chuoi canonical cho payload hash: sap xep on dinh de client va server luon ra cung hash.
        public static string Value(SquadDefinition squad)
        {
            if (squad == null) return string.Empty;

            string assignments = string.Join(",", (squad.Assignments ?? new List<SquadSlotAssignment>())
                .Where(assignment => assignment != null)
                .OrderBy(assignment => assignment.PositionSlotId ?? string.Empty, StringComparer.Ordinal)
                .Select(assignment => (assignment.PositionSlotId ?? string.Empty) + ":" + (assignment.ItemId ?? string.Empty)));
            string bench = string.Join(",", (squad.BenchItemIds ?? new List<string>())
                .Where(itemId => !string.IsNullOrWhiteSpace(itemId))
                .OrderBy(itemId => itemId, StringComparer.Ordinal));
            SetPieceTakers takers = squad.SetPieceTakers ?? new SetPieceTakers();

            return string.Join(
                "|",
                squad.SquadId ?? string.Empty,
                squad.OwnerId ?? string.Empty,
                squad.SlotIndex.ToString(CultureInfo.InvariantCulture),
                squad.FormationId ?? string.Empty,
                assignments,
                bench,
                squad.CaptainItemId ?? string.Empty,
                squad.TacticProfileId ?? string.Empty,
                takers.FreeKickItemId ?? string.Empty,
                takers.PenaltyItemId ?? string.Empty,
                takers.CornerItemId ?? string.Empty,
                takers.LongThrowItemId ?? string.Empty,
                squad.KitId ?? string.Empty,
                squad.StadiumId ?? string.Empty,
                squad.BallId ?? string.Empty,
                squad.RulesVersion ?? string.Empty);
        }
    }

    public sealed class SquadSaveCommand
    {
        public string OwnerId { get; set; } = string.Empty;
        public long ExpectedRevision { get; set; }
        public SquadDefinition Squad { get; set; }
        public string IdempotencyKey { get; set; } = string.Empty;

        public string CanonicalPayload()
            => string.Join(
                "|",
                OwnerId ?? string.Empty,
                ExpectedRevision.ToString(CultureInfo.InvariantCulture),
                SquadCanonical.Value(Squad));
    }

    public sealed class SquadSaveResult
    {
        public TransactionReceipt Receipt { get; set; }
        public SquadValidationResult Validation { get; set; }

        public bool Committed => Receipt != null && Receipt.Status == TransactionStatus.Committed;

        public TransactionFailureCode FailureCode
            => Receipt == null ? TransactionFailureCode.InvalidRequest : Receipt.FailureCode;
    }

    public sealed class SquadSaveService
    {
        public const string SaveResourceId = "squad.save";

        private readonly ISquadRepository squads;
        private readonly ITransactionReceiptRepository receipts;
        private readonly ISquadRuleSet rules;
        private readonly ISquadValidator validator;
        private readonly bool readOnly;

        public SquadSaveService(
            ISquadRepository squads,
            ITransactionReceiptRepository receipts,
            ISquadRuleSet rules,
            ISquadValidator validator,
            bool readOnly = false)
        {
            this.squads = squads ?? throw new ArgumentNullException(nameof(squads));
            this.receipts = receipts ?? throw new ArgumentNullException(nameof(receipts));
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.validator = validator ?? throw new ArgumentNullException(nameof(validator));
            this.readOnly = readOnly;
        }

        public SquadSaveResult Save(SquadSaveCommand command, InventorySnapshot inventory, DateTimeOffset nowUtc)
        {
            string payloadHash = ProgressionHash.ComputePayload(command == null ? string.Empty : command.CanonicalPayload());

            if (command == null
                || command.Squad == null
                || inventory == null
                || string.IsNullOrWhiteSpace(command.OwnerId)
                || string.IsNullOrWhiteSpace(command.IdempotencyKey)
                || string.IsNullOrWhiteSpace(command.Squad.SquadId))
            {
                return Rejected(command == null ? string.Empty : command.IdempotencyKey, payloadHash, TransactionFailureCode.InvalidRequest, nowUtc, null);
            }

            if (readOnly) return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.ReadOnly, nowUtc, null);

            // Replay: cung key va cung payload thi tra lai receipt cu, khong ghi lan hai.
            TransactionReceipt existing;
            if (receipts.TryGetReceipt(command.IdempotencyKey, out existing))
            {
                return string.Equals(existing.PayloadHash, payloadHash, StringComparison.Ordinal)
                    ? new SquadSaveResult { Receipt = existing }
                    : Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.IdempotencyConflict, nowUtc, null);
            }

            SquadSnapshot current;
            bool exists = squads.TryLoad(command.OwnerId, out current);
            long baseRevision = exists ? current.Revision : -1L;
            if (baseRevision != command.ExpectedRevision)
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRevision, nowUtc, null);
            }

            SquadSnapshot next = exists
                ? current.Clone()
                : new SquadSnapshot { OwnerId = command.OwnerId, Revision = baseRevision, RulesVersion = rules.RulesVersion };

            SquadDefinition draft = command.Squad.Clone();
            draft.OwnerId = command.OwnerId;
            SquadValidationResult validation = validator.Validate(draft, inventory, next.SalaryCapExpansion);
            if (!SquadSavePolicy.CanSave(rules, validation))
            {
                return Rejected(command.IdempotencyKey, payloadHash, FailureFor(validation), nowUtc, validation);
            }

            next.Squads = next.Squads ?? new List<SquadDefinition>();
            int index = next.Squads.FindIndex(squad => string.Equals(squad.SquadId, draft.SquadId, StringComparison.Ordinal));
            draft.Revision = index < 0 ? 0L : next.Squads[index].Revision + 1L;
            draft.RulesVersion = rules.RulesVersion;
            if (index < 0) next.Squads.Add(draft);
            else next.Squads[index] = draft;

            // So o doi hinh la gioi han cua ca snapshot, khong chi cua mot squad.
            if (next.Squads.Count > rules.MaxSquadSlots)
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.SquadInvalid, nowUtc, validation);
            }

            next.Revision = baseRevision + 1L;
            next.RulesVersion = rules.RulesVersion;

            string transactionId = "squad-" + ProgressionHash.ComputePayload(command.IdempotencyKey + "|" + payloadHash).Substring(0, 16);
            var entries = new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = SaveResourceId, Amount = 1L },
                new LedgerEntry { TransactionId = transactionId, AccountId = "system", ResourceId = SaveResourceId, Amount = -1L }
            };
            var receipt = new TransactionReceipt
            {
                TransactionId = transactionId,
                IdempotencyKey = command.IdempotencyKey,
                PayloadHash = payloadHash,
                Status = TransactionStatus.Committed,
                FailureCode = TransactionFailureCode.None,
                LedgerEntries = entries,
                CreatedAt = nowUtc
            };

            return squads.TryCommit(command.OwnerId, baseRevision, next, receipt, entries)
                ? new SquadSaveResult { Receipt = receipt, Validation = validation }
                : Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.AtomicCommitFailed, nowUtc, validation);
        }

        // Anh xa loi doi hinh sang ma loi giao dich de client xu ly giong cac luong P1-03.
        private static TransactionFailureCode FailureFor(SquadValidationResult validation)
        {
            if (validation == null || validation.Errors == null || validation.Errors.Count == 0) return TransactionFailureCode.SquadInvalid;
            if (Has(validation, SquadValidationCode.FeatureDisabled)) return TransactionFailureCode.FeatureDisabled;
            if (Has(validation, SquadValidationCode.RulesVersionMismatch)) return TransactionFailureCode.StaleRules;
            if (Has(validation, SquadValidationCode.OwnerMismatch)) return TransactionFailureCode.OwnerMismatch;
            if (Has(validation, SquadValidationCode.ItemNotFound)) return TransactionFailureCode.ItemNotFound;
            if (Has(validation, SquadValidationCode.DuplicateItem)) return TransactionFailureCode.DuplicateItem;
            if (Has(validation, SquadValidationCode.ItemUnavailable)) return TransactionFailureCode.InvalidState;
            if (Has(validation, SquadValidationCode.SalaryCapExceeded)) return TransactionFailureCode.SalaryCapExceeded;
            if (Has(validation, SquadValidationCode.SquadSlotLimitExceeded)) return TransactionFailureCode.CapExceeded;
            return TransactionFailureCode.SquadInvalid;
        }

        private static bool Has(SquadValidationResult validation, SquadValidationCode code)
            => validation.Errors.Any(issue => issue.Code == code);

        private static SquadSaveResult Rejected(
            string idempotencyKey,
            string payloadHash,
            TransactionFailureCode failureCode,
            DateTimeOffset nowUtc,
            SquadValidationResult validation)
            => new SquadSaveResult
            {
                Receipt = new TransactionReceipt
                {
                    TransactionId = string.Empty,
                    IdempotencyKey = idempotencyKey ?? string.Empty,
                    PayloadHash = payloadHash,
                    Status = TransactionStatus.Rejected,
                    FailureCode = failureCode,
                    CreatedAt = nowUtc
                },
                Validation = validation
            };
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B3: nang bac the (+1..+maxTier).
    //
    // Luong: Preview(item, useInsurance) -> hash canonical + expiry -> Confirm(command, preview):
    //   verify (revision, catalog, rules, hash, insurance, protected, so du) -> roll deterministic theo
    //   (serverSeed, idempotencyKey, rulesVersion) -> ap Success | Keep | Downgrade | Consume -> MOT commit inventory
    //   kem but toan tieu hao (owner -N / sink:upgrade +N) va marker outcome de replay dung lai duoc receipt.
    //
    // So du tai nguyen (vat lieu, tien, bao hiem) KHONG nam trong InventorySnapshot (khong doi schema):
    // so du = tong but toan ledger theo (accountId, resourceId). Grant = but toan owner +N / system -N.

    public interface IResourceBalanceLedger
    {
        long Balance(string accountId, string resourceId);
    }

    public readonly struct UpgradeTierPreviewResult
    {
        public UpgradeTierPreviewResult(UpgradeTierAttemptPreview preview, TransactionFailureCode failureCode)
        {
            Preview = preview;
            FailureCode = failureCode;
        }

        public UpgradeTierAttemptPreview Preview { get; }
        public TransactionFailureCode FailureCode { get; }
        public bool Succeeded => FailureCode == TransactionFailureCode.None && Preview != null;
    }

    public static class UpgradeTierPolicy
    {
        public const string DefaultCurrencyResourceId = "currency.bp";
        public const string SinkAccountId = "sink:upgrade";
        public const string OperationResourceId = "inventory:upgradetier";
        public const string SuccessMarker = OperationResourceId + ".success";
        public const string FailureKeepMarker = OperationResourceId + ".failure.keep";
        public const string FailureDowngradeMarker = OperationResourceId + ".failure.downgrade";
        public const string FailureConsumeMarker = OperationResourceId + ".failure.consume";
        public const string InsuranceMarker = OperationResourceId + ".insurance";
        public const int RollRange = 10000;

        public static readonly TimeSpan PreviewLifetime = TimeSpan.FromMinutes(5);

        // Bao hiem bien moi that bai thanh Keep; khong co bao hiem thi dung outcome cua tier.
        public static UpgradeFailureOutcome EffectiveFailureOutcome(UpgradeTierStep step, bool insuranceApplied)
            => insuranceApplied ? UpgradeFailureOutcome.Keep : step.FailureOutcome;

        // Lock = chong tieu huy; InSquad = dang thi dau. Ca hai khong duoc bien mat vi mot lan roll xui.
        public static bool IsProtected(OwnedPlayerItem item)
            => item != null && (item.LockState == PlayerItemLockState.Locked || item.State == PlayerItemState.InSquad);

        public static bool IsSuccess(int roll, int successRateBasisPoints)
            => roll >= 0 && roll < successRateBasisPoints;

        // Tong chi phi owner phai tra cho mot lan thu, gom theo resourceId, sap xep on dinh.
        public static List<UpgradeMaterialCost> TotalCost(UpgradeTierAttemptPreview preview, string currencyResourceId)
        {
            var totals = new SortedDictionary<string, long>(StringComparer.Ordinal);
            foreach (UpgradeMaterialCost cost in preview.MaterialCost ?? new List<UpgradeMaterialCost>())
            {
                if (cost == null || string.IsNullOrWhiteSpace(cost.ResourceId) || cost.Amount <= 0) continue;
                Add(totals, cost.ResourceId, cost.Amount);
            }

            if (preview.CurrencyCost > 0) Add(totals, currencyResourceId, preview.CurrencyCost);
            if (preview.InsuranceApplied && !string.IsNullOrWhiteSpace(preview.InsuranceItemId)) Add(totals, preview.InsuranceItemId, 1L);

            return totals.Select(pair => new UpgradeMaterialCost { ResourceId = pair.Key, Amount = pair.Value }).ToList();
        }

        public static string MarkerFor(bool success, UpgradeFailureOutcome appliedOutcome)
        {
            if (success) return SuccessMarker;
            switch (appliedOutcome)
            {
                case UpgradeFailureOutcome.Downgrade: return FailureDowngradeMarker;
                case UpgradeFailureOutcome.Consume: return FailureConsumeMarker;
                default: return FailureKeepMarker;
            }
        }

        private static void Add(SortedDictionary<string, long> totals, string resourceId, long amount)
        {
            long current;
            totals[resourceId] = totals.TryGetValue(resourceId, out current) ? current + amount : amount;
        }
    }

    public sealed class UpgradeTierPreviewService
    {
        private readonly IUpgradeTierRuleSet rules;
        private readonly IResourceBalanceLedger balances;
        private readonly string currencyResourceId;

        public UpgradeTierPreviewService(IUpgradeTierRuleSet rules, IResourceBalanceLedger balances, string currencyResourceId = UpgradeTierPolicy.DefaultCurrencyResourceId)
        {
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.balances = balances ?? throw new ArgumentNullException(nameof(balances));
            if (string.IsNullOrWhiteSpace(currencyResourceId)) throw new ArgumentException("Currency resource id is required.", nameof(currencyResourceId));
            this.currencyResourceId = currencyResourceId;
        }

        public UpgradeTierPreviewResult Build(InventorySnapshot snapshot, string itemId, bool useInsurance, DateTimeOffset nowUtc)
        {
            if (snapshot == null || string.IsNullOrWhiteSpace(itemId)) return Fail(TransactionFailureCode.InvalidRequest);

            OwnedPlayerItem item = snapshot.Find(itemId);
            if (item == null) return Fail(TransactionFailureCode.ItemNotFound);
            if (!string.Equals(item.OwnerId, snapshot.OwnerId, StringComparison.Ordinal)) return Fail(TransactionFailureCode.OwnerMismatch);
            if (!string.Equals(item.CatalogVersion, snapshot.CatalogVersion, StringComparison.Ordinal)) return Fail(TransactionFailureCode.StaleCatalog);
            if (item.State == PlayerItemState.Consumed || item.State == PlayerItemState.Reserved) return Fail(TransactionFailureCode.InvalidState);

            int targetTier = item.UpgradeTier + 1;
            UpgradeTierStep step;
            if (item.UpgradeTier >= rules.MaxTier || !rules.TryGetStep(targetTier, out step)) return Fail(TransactionFailureCode.CapExceeded);

            if (useInsurance)
            {
                // Bao hiem chi co y nghia khi tier co the mat tien do; tier Keep thi tu choi de nguoi choi khong phi vat pham.
                if (step.FailureOutcome == UpgradeFailureOutcome.Keep || string.IsNullOrWhiteSpace(step.InsuranceItemId)) return Fail(TransactionFailureCode.InsuranceUnavailable);
                if (balances.Balance(snapshot.OwnerId, step.InsuranceItemId) < 1L) return Fail(TransactionFailureCode.InsuranceUnavailable);
            }

            if (UpgradeTierPolicy.EffectiveFailureOutcome(step, useInsurance) == UpgradeFailureOutcome.Consume && UpgradeTierPolicy.IsProtected(item))
            {
                return Fail(TransactionFailureCode.ProtectedItem);
            }

            var preview = new UpgradeTierAttemptPreview
            {
                OwnerId = snapshot.OwnerId,
                ItemId = item.ItemId,
                InventoryRevision = snapshot.Revision,
                ItemRevision = item.Revision,
                CatalogVersion = snapshot.CatalogVersion,
                RulesVersion = rules.RulesVersion,
                FromTier = item.UpgradeTier,
                ToTier = targetTier,
                SuccessRateBasisPoints = step.SuccessRateBasisPoints,
                CurrencyCost = step.CurrencyCost,
                MaterialCost = (step.MaterialCost ?? new List<UpgradeMaterialCost>())
                    .Select(cost => new UpgradeMaterialCost { ResourceId = cost.ResourceId, Amount = cost.Amount })
                    .ToList(),
                FailureOutcome = UpgradeTierPolicy.EffectiveFailureOutcome(step, useInsurance),
                InsuranceItemId = step.InsuranceItemId ?? string.Empty,
                InsuranceApplied = useInsurance,
                StatScalingBasisPoints = rules.StatScalingBasisPoints(targetTier),
                SalaryScalingBasisPoints = rules.SalaryScalingBasisPoints(targetTier),
                ExpiresAt = nowUtc.Add(UpgradeTierPolicy.PreviewLifetime)
            };

            foreach (UpgradeMaterialCost cost in UpgradeTierPolicy.TotalCost(preview, currencyResourceId))
            {
                if (balances.Balance(snapshot.OwnerId, cost.ResourceId) < cost.Amount) return Fail(TransactionFailureCode.InsufficientMaterials);
            }

            preview.PreviewHash = ProgressionHash.ComputePayload(preview.CanonicalValue());
            return new UpgradeTierPreviewResult(preview, TransactionFailureCode.None);
        }

        private static UpgradeTierPreviewResult Fail(TransactionFailureCode code) => new UpgradeTierPreviewResult(null, code);
    }

    public sealed class UpgradeTierService
    {
        private readonly IInventoryRepository inventory;
        private readonly ITransactionReceiptRepository receipts;
        private readonly IResourceBalanceLedger balances;
        private readonly IUpgradeTierRuleSet rules;
        private readonly IUpgradeRollSource rollSource;
        private readonly string currencyResourceId;
        private readonly bool readOnly;

        public UpgradeTierService(
            IInventoryRepository inventory,
            ITransactionReceiptRepository receipts,
            IResourceBalanceLedger balances,
            IUpgradeTierRuleSet rules,
            IUpgradeRollSource rollSource,
            string currencyResourceId = UpgradeTierPolicy.DefaultCurrencyResourceId,
            bool readOnly = false)
        {
            this.inventory = inventory ?? throw new ArgumentNullException(nameof(inventory));
            this.receipts = receipts ?? throw new ArgumentNullException(nameof(receipts));
            this.balances = balances ?? throw new ArgumentNullException(nameof(balances));
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.rollSource = rollSource ?? throw new ArgumentNullException(nameof(rollSource));
            if (string.IsNullOrWhiteSpace(currencyResourceId)) throw new ArgumentException("Currency resource id is required.", nameof(currencyResourceId));
            this.currencyResourceId = currencyResourceId;
            this.readOnly = readOnly;
        }

        public UpgradeTierAttemptReceipt Confirm(UpgradeTierAttemptCommand command, UpgradeTierAttemptPreview preview, DateTimeOffset nowUtc)
        {
            string payloadHash = ProgressionHash.ComputePayload(command == null ? string.Empty : command.CanonicalPayload());

            if (command == null
                || preview == null
                || string.IsNullOrWhiteSpace(command.IdempotencyKey)
                || string.IsNullOrWhiteSpace(command.OwnerId)
                || string.IsNullOrWhiteSpace(command.ItemId))
            {
                return Reject(command == null ? string.Empty : command.IdempotencyKey, payloadHash, TransactionFailureCode.InvalidRequest, nowUtc);
            }

            if (readOnly) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.ReadOnly, nowUtc);

            // Replay: cung key + cung payload -> dung lai receipt cu tu ledger marker, KHONG roll lai.
            TransactionReceipt existing;
            if (receipts.TryGetReceipt(command.IdempotencyKey, out existing))
            {
                return string.Equals(existing.PayloadHash, payloadHash, StringComparison.Ordinal)
                    ? Replay(existing, command.IdempotencyKey)
                    : Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.IdempotencyConflict, nowUtc);
            }

            InventorySnapshot current;
            if (!inventory.TryLoad(command.OwnerId, out current)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.ItemNotFound, nowUtc);
            if (current.Revision != command.ExpectedInventoryRevision || current.Revision != preview.InventoryRevision) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRevision, nowUtc);

            OwnedPlayerItem item = current.Find(command.ItemId);
            if (item == null) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.ItemNotFound, nowUtc);
            if (item.Revision != command.ExpectedItemRevision || item.Revision != preview.ItemRevision) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRevision, nowUtc);
            if (!string.Equals(preview.OwnerId, command.OwnerId, StringComparison.Ordinal) || !string.Equals(preview.ItemId, command.ItemId, StringComparison.Ordinal)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.PreviewMismatch, nowUtc);
            if (!string.Equals(item.OwnerId, command.OwnerId, StringComparison.Ordinal)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.OwnerMismatch, nowUtc);
            if (!string.Equals(current.CatalogVersion, preview.CatalogVersion, StringComparison.Ordinal)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleCatalog, nowUtc);
            if (!string.Equals(preview.RulesVersion, rules.RulesVersion, StringComparison.Ordinal)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRules, nowUtc);
            if (preview.ExpiresAt < nowUtc) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.PreviewExpired, nowUtc);
            if (!string.Equals(command.PreviewHash, preview.PreviewHash, StringComparison.Ordinal)
                || !string.Equals(preview.PreviewHash, ProgressionHash.ComputePayload(preview.CanonicalValue()), StringComparison.Ordinal))
            {
                return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.PreviewMismatch, nowUtc);
            }

            if (preview.InsuranceApplied != command.UseInsurance) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.PreviewMismatch, nowUtc);
            if (item.UpgradeTier != preview.FromTier || preview.ToTier != preview.FromTier + 1) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.PreviewMismatch, nowUtc);
            if (item.State == PlayerItemState.Consumed || item.State == PlayerItemState.Reserved) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.InvalidState, nowUtc);

            UpgradeTierStep step;
            if (!rules.TryGetStep(preview.ToTier, out step)) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.CapExceeded, nowUtc);

            UpgradeFailureOutcome effectiveOutcome = UpgradeTierPolicy.EffectiveFailureOutcome(step, preview.InsuranceApplied);
            if (preview.InsuranceApplied && (step.FailureOutcome == UpgradeFailureOutcome.Keep || string.IsNullOrWhiteSpace(step.InsuranceItemId)))
            {
                return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.InsuranceUnavailable, nowUtc);
            }

            // ProtectedItem phai duoc tra ve TRUOC roll: khong bao gio de roll quyet dinh so phan the dang bao ve.
            if (effectiveOutcome == UpgradeFailureOutcome.Consume && UpgradeTierPolicy.IsProtected(item))
            {
                return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.ProtectedItem, nowUtc);
            }

            List<UpgradeMaterialCost> costs = UpgradeTierPolicy.TotalCost(preview, currencyResourceId);
            foreach (UpgradeMaterialCost cost in costs)
            {
                if (balances.Balance(command.OwnerId, cost.ResourceId) >= cost.Amount) continue;
                bool isInsurance = preview.InsuranceApplied && string.Equals(cost.ResourceId, preview.InsuranceItemId, StringComparison.Ordinal);
                return Reject(command.IdempotencyKey, payloadHash, isInsurance ? TransactionFailureCode.InsuranceUnavailable : TransactionFailureCode.InsufficientMaterials, nowUtc);
            }

            int roll = rollSource.Roll(command.IdempotencyKey, rules.RulesVersion);
            string rollAuditHash = rollSource.AuditHash(command.IdempotencyKey, rules.RulesVersion);
            bool success = UpgradeTierPolicy.IsSuccess(roll, preview.SuccessRateBasisPoints);

            OwnedPlayerItem after = item.Clone();
            after.Revision = item.Revision + 1L;
            UpgradeFailureOutcome appliedOutcome = UpgradeFailureOutcome.Keep;
            if (success)
            {
                after.UpgradeTier = preview.ToTier;
            }
            else
            {
                appliedOutcome = effectiveOutcome;
                switch (appliedOutcome)
                {
                    case UpgradeFailureOutcome.Downgrade:
                        after.UpgradeTier = Math.Max(0, item.UpgradeTier - 1);
                        break;
                    case UpgradeFailureOutcome.Consume:
                        // Giu ban ghi voi State = Consumed de audit; khong xoa khoi inventory.
                        after.State = PlayerItemState.Consumed;
                        break;
                }
            }

            InventorySnapshot next = current.Clone();
            int index = next.Items.FindIndex(candidate => string.Equals(candidate.ItemId, item.ItemId, StringComparison.Ordinal));
            if (index < 0) return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.AtomicCommitFailed, nowUtc);
            next.Items[index] = after.Clone();
            next.Revision = current.Revision + 1L;

            string transactionId = "upgrade-" + ProgressionHash.ComputePayload(command.IdempotencyKey + "|" + payloadHash).Substring(0, 16);
            var entries = new List<LedgerEntry>();
            foreach (UpgradeMaterialCost cost in costs)
            {
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = cost.ResourceId, Amount = -cost.Amount });
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = UpgradeTierPolicy.SinkAccountId, ResourceId = cost.ResourceId, Amount = cost.Amount });
            }

            string marker = UpgradeTierPolicy.MarkerFor(success, appliedOutcome);
            entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = marker, Amount = 1L });
            entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = "system", ResourceId = marker, Amount = -1L });
            if (preview.InsuranceApplied)
            {
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = UpgradeTierPolicy.InsuranceMarker, Amount = 1L });
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = "system", ResourceId = UpgradeTierPolicy.InsuranceMarker, Amount = -1L });
            }

            var receipt = new TransactionReceipt
            {
                TransactionId = transactionId,
                IdempotencyKey = command.IdempotencyKey,
                PayloadHash = payloadHash,
                Status = TransactionStatus.Committed,
                FailureCode = TransactionFailureCode.None,
                InventoryDelta = new InventoryDelta
                {
                    BaseRevision = current.Revision,
                    TargetRevision = next.Revision,
                    UpsertedItems = new List<OwnedPlayerItem> { after.Clone() },
                    RemovedItemIds = new List<string>()
                },
                LedgerEntries = entries,
                CreatedAt = nowUtc
            };

            if (!inventory.TryCommit(command.OwnerId, current.Revision, next, receipt, entries))
            {
                return Reject(command.IdempotencyKey, payloadHash, TransactionFailureCode.AtomicCommitFailed, nowUtc);
            }

            return new UpgradeTierAttemptReceipt
            {
                Transaction = receipt,
                Outcome = success ? UpgradeAttemptOutcome.Success : UpgradeAttemptOutcome.Failure,
                ResultTier = after.UpgradeTier,
                AppliedFailureOutcome = success ? UpgradeFailureOutcome.Keep : appliedOutcome,
                InsuranceConsumed = preview.InsuranceApplied,
                RollAuditHash = rollAuditHash
            };
        }

        // Dung lai receipt tu du lieu da commit: marker outcome trong ledger + item sau giao dich trong delta.
        private UpgradeTierAttemptReceipt Replay(TransactionReceipt existing, string idempotencyKey)
        {
            IReadOnlyList<LedgerEntry> entries = existing.LedgerEntries ?? new List<LedgerEntry>();
            bool success = entries.Any(entry => string.Equals(entry.ResourceId, UpgradeTierPolicy.SuccessMarker, StringComparison.Ordinal));
            UpgradeFailureOutcome applied = UpgradeFailureOutcome.Keep;
            if (entries.Any(entry => string.Equals(entry.ResourceId, UpgradeTierPolicy.FailureDowngradeMarker, StringComparison.Ordinal))) applied = UpgradeFailureOutcome.Downgrade;
            else if (entries.Any(entry => string.Equals(entry.ResourceId, UpgradeTierPolicy.FailureConsumeMarker, StringComparison.Ordinal))) applied = UpgradeFailureOutcome.Consume;

            OwnedPlayerItem after = existing.InventoryDelta == null || existing.InventoryDelta.UpsertedItems == null
                ? null
                : existing.InventoryDelta.UpsertedItems.FirstOrDefault();

            return new UpgradeTierAttemptReceipt
            {
                Transaction = existing,
                Outcome = success ? UpgradeAttemptOutcome.Success : UpgradeAttemptOutcome.Failure,
                ResultTier = after == null ? 0 : after.UpgradeTier,
                AppliedFailureOutcome = applied,
                InsuranceConsumed = entries.Any(entry => string.Equals(entry.ResourceId, UpgradeTierPolicy.InsuranceMarker, StringComparison.Ordinal)),
                RollAuditHash = rollSource.AuditHash(idempotencyKey, rules.RulesVersion)
            };
        }

        private static UpgradeTierAttemptReceipt Reject(string idempotencyKey, string payloadHash, TransactionFailureCode code, DateTimeOffset nowUtc)
            => new UpgradeTierAttemptReceipt
            {
                Transaction = new TransactionReceipt
                {
                    TransactionId = string.Empty,
                    IdempotencyKey = idempotencyKey ?? string.Empty,
                    PayloadHash = payloadHash ?? string.Empty,
                    Status = TransactionStatus.Rejected,
                    FailureCode = code,
                    CreatedAt = nowUtc
                },
                Outcome = UpgradeAttemptOutcome.Failure,
                ResultTier = 0,
                AppliedFailureOutcome = UpgradeFailureOutcome.Keep,
                InsuranceConsumed = false,
                RollAuditHash = string.Empty
            };
    }
}

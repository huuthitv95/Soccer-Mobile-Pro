namespace FL.IAP
{
	public enum IapTransactionState
	{
		Pending = 0,
		Observed = 1,
		ValidatedLocal = 2,
		Granting = 3,
		Granted = 4,
		FinalizeRequested = 5,
		Finished = 6,
		Retryable = 7,
		Quarantined = 8,
		QuarantinedLegacy = 9
	}
}

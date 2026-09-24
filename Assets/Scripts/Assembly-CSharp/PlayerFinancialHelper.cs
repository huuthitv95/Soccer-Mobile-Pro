public static class PlayerFinancialHelper
{
	public const int MaxContract = 50;

	public const int defaultContract = 30;

	public const int InitialContract = 15;

	public const int legendaryPlayerInitialContract = 10;

	public static int videoContract => 0;

	public static int legendaryPlayerVideoContract => 0;

	public static int CalculatePlayerSellPrice(global::SL.Player player, int honors)
	{
		return 0;
	}

	public static int CalculatePlayerSigningFee(global::SL.Player player, int honors, int currentCoin, int totalExpenses, int userteamRating)
	{
		return 0;
	}

	public static float CalculatePlayerSalary(global::SL.Player player, int honors)
	{
		return 0f;
	}

	public static int CalculateContractFee(ClubPlayer player)
	{
		return 0;
	}

	public static int CalculateRetirementRefundFee(ClubPlayer player)
	{
		return 0;
	}

	private static float OtherCoef(global::SL.Player player, int honors)
	{
		return 0f;
	}

	private static float CapacityCoef(int rating)
	{
		return 0f;
	}

	private static float CalculatePlayerBaseSalary(global::SL.Player player)
	{
		return 0f;
	}
}

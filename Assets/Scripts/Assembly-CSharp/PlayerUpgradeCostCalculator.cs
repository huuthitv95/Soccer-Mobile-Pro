public static class PlayerUpgradeCostCalculator
{
    private struct AbilityRange
    {
        public int Min;
        public int Max;
        public int Span => 0;
    }

    private class CostTableData
    {
        public global::System.Collections.Generic.Dictionary<int, global::FLDataTable.UserPlayerAbilityUpgradeCostRule> CostLookup;
    }

    private struct RatingWeightData
    {
        public float[] Weights;
        public float Divisor;
    }

    private const string UpgradeCostBasePath = "Assets/GameData/excels/gamedata/PlayerCareerMode/upgradeCost/";
    private static readonly global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, PlayerUpgradeCostCalculator.CostTableData> _costTableCache;
    private static readonly global::FL.PlayerAbility[] ShootAbilities;
    private static readonly global::FL.PlayerAbility[] SpeedAbilities;
    private static readonly global::FL.PlayerAbility[] PassingAbilities;
    private static readonly global::FL.PlayerAbility[] DribblingAbilities;
    private static readonly global::FL.PlayerAbility[] DefenceAbilities;
    private static readonly global::FL.PlayerAbility[] PhysicalAbilities;
    public static int CalculateHexagramUpgradeCost(ClubPlayer player, global::FL.UserPlayerType playerType, in global::FL.PlayerExpStruct pendingExp, global::FL.HexagramAttribute hexagramAttribute, out global::FL.PlayerExpStruct expGrowth)
    {
        expGrowth = default;
        return 0;
    }

    public static void ClearCache()
    {
    }

    public static int[] GetMaxHexagramValues(ClubPlayer player, global::FL.UserPlayerType playerType)
    {
        return null;
    }

    private static global::FL.PlayerAbility[] GetSubAbilities(global::FL.HexagramAttribute attribute)
    {
        return null;
    }

    private static short GetAbilityCost(global::FLDataTable.UserPlayerAbilityUpgradeCostRule row, global::FL.PlayerAbility ability)
    {
        return 0;
    }

    private static PlayerUpgradeCostCalculator.CostTableData GetCostTableData(FormationTool.UIPosition position)
    {
        return null;
    }

    private static global::System.Collections.Generic.Dictionary<global::FL.PlayerAbility, PlayerUpgradeCostCalculator.AbilityRange> GetAbilityRanges(FormationTool.UIPosition position, global::FL.UserPlayerType playerType)
    {
        return null;
    }

    private static string GetCostFileName(FormationTool.UIPosition position)
    {
        return null;
    }

    public static global::System.Collections.Generic.Dictionary<global::FL.HexagramAttribute, int> CalculateMultiHexagramUpgradeCost(ClubPlayer player, global::FL.UserPlayerType playerType, global::System.Collections.Generic.Dictionary<global::FL.HexagramAttribute, int> upgrades, out global::FL.PlayerExpStruct expGrowth)
    {
        expGrowth = default;
        return null;
    }

    public static bool GetTop2EfficientAttributes(ClubPlayer player, global::FL.UserPlayerType playerType, in global::FL.PlayerExpStruct pendingExp, out global::FL.HexagramAttribute best1, out global::FL.HexagramAttribute best2)
    {
        best1 = default;
        best2 = default;
        return false;
    }

    public static int AutoUpgrade(ClubPlayer player, global::FL.UserPlayerType playerType, in global::FL.PlayerExpStruct pendingExp, int resources, global::System.Collections.Generic.IReadOnlyDictionary<global::FL.HexagramAttribute, int> maxSteps, out global::System.Collections.Generic.Dictionary<global::FL.HexagramAttribute, int> hexagramSteps)
    {
        hexagramSteps = null;
        return 0;
    }

    private static float ComputeHexagramRatingGain(global::FL.HexagramAttribute attribute, global::System.Collections.Generic.Dictionary<global::FL.PlayerAbility, PlayerUpgradeCostCalculator.AbilityRange> abilityRanges, PlayerUpgradeCostCalculator.RatingWeightData ratingWeights)
    {
        return 0f;
    }

    private static PlayerUpgradeCostCalculator.RatingWeightData GetRatingWeights(FormationTool.UIPosition position)
    {
        return default;
    }
}
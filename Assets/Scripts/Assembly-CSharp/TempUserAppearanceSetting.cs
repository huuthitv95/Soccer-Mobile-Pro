public static class TempUserAppearanceSetting
{
    public class SpecialJerseyConfig
    {
        public int id;
        public TeamAvatarHelper.NumberColorPair coatNumberColor;
        public global::UnityEngine.Vector2 coatNumberPosOffset;
        public float coatNumberScale;
        public global::UnityEngine.Vector2 shortsNumberPosOffset;
        public float shortsNumberScale;
        public int shortsLogo;
        public global::UnityEngine.Color shortsColor;
        public global::UnityEngine.Vector2 shortsLogoPosOffset;
        public float shortsLogoScale;
        public int chestLogo;
        public global::UnityEngine.Color chestColor;
        public global::UnityEngine.Vector2 chestLogoPosOffset;
        public float chestLogoScale;
        public int socksLogo;
        public global::UnityEngine.Color socksColor;
        public global::UnityEngine.Vector2 socksLogoPosOffset;
        public float socksLogoScale;
        public global::UnityEngine.Vector2 flagPosOffset;
        public float flagScale;
        public int collarType;
        public bool IsLicensedAsset;
    }

    public static int userTeamId;
    public static TempField<int> jerseyId;
    public static TempField<int> ballId;
    public static global::System.Collections.Generic.Dictionary<int, TempUserAppearanceSetting.SpecialJerseyConfig> legendaryJerseyConfigs;
    private static global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Mesh> ballMaterialCache;
    private static TeamAvatarHelper.NumberColorPair ParseCoatNumberColorConfig(string rawValue)
    {
        return default;
    }

    private static void LoadConfig()
    {
    }

    public static TempUserAppearanceSetting.SpecialJerseyConfig GetJerseyConfig(int jerseyId)
    {
        return null;
    }

    public static void SetBallMaterial(global::UnityEngine.Renderer renderer, int ballId, string normalMapName = "_Normal")
    {
    }

    public static void SyncAppearanceProfile(int ball, int jersey, global::Srv.UserAppearanceProfile archive)
    {
    }

    public static void GetAppearanceProfile(out int ball, out int jersey, global::Srv.UserAppearanceProfile archive)
    {
        ball = default;
        jersey = default;
    }
}
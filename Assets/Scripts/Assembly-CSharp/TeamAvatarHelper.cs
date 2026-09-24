public class TeamAvatarHelper
{
    public struct NumberColorPair
    {
        public global::UnityEngine.Color MainColor;
        public global::UnityEngine.Color OutlineColor;
        public NumberColorPair(global::UnityEngine.Color mainColor, global::UnityEngine.Color outlineColor)
        {
            MainColor = default;
            OutlineColor = default;
        }
    }

    public struct JerseyNumberColor
    {
        public TeamAvatarHelper.NumberColorPair Coat;
        public TeamAvatarHelper.NumberColorPair Shorts;
        public JerseyNumberColor(TeamAvatarHelper.NumberColorPair coat, TeamAvatarHelper.NumberColorPair shorts)
        {
            Coat = default;
            Shorts = default;
        }
    }

    private struct ClothMatchInfo
    {
        public string Colors;
        public string Style;
        public global::UnityEngine.Color MainColor;
        public global::UnityEngine.Color SecondaryColor;
    }

    private static string coatFolder;
    private static string glassesFolder;
    private static string gloveFolder;
    private static string longHairFolder;
    private static string shoeFolder;
    private static string shorthairFolder;
    private static string shortsFolder;
    private static string skinFolder;
    private static string sockFolder;
    public static string coatNumberFolder;
    public static readonly TeamAvatarHelper.NumberColorPair DefaultNumberColorPair;
    public static readonly TeamAvatarHelper.JerseyNumberColor DefaultJerseyNumberColor;
    private static string hairTexFolder;
    private static string faceFolder;
    private static string eyeFolder;
    private static string eyeBrowFolder;
    private static string beardFolder;
    private static string flagSprite;
    private static string ad_logoSprite;
    private static global::UnityEngine.GameObject uiJersey;
    private static PlayerTextureAtlasData MainPlayerTextureAltasData;
    private static PlayerTextureAtlasData UI_PlayerTextureAltasData;
    private static PlayerTextureAtlasData HighResolutionUI_PlayerTextureAltasData;
    private static PlayerTextureAtlasData PlayerBodyLod1TextureAltasData;
    private static PlayerTextureAtlasData PlayerClothupLod1TextureAltasData;
    private static PlayerTextureAtlasData PlayerClothdownLod1TextureAltasData;
    private static PlayerTextureAtlasData PlayerShoesLod1TextureAltasData;
    private static PlayerTextureAtlasData PlayerFaceLod1TextureAltasData;
    private static PlayerTextureAtlasData PlayerEyeLod1TextureAltasData;
    private static global::LRUCache.LRUCache<int, global::UnityEngine.GameObject> BadgeCache;
    private static readonly global::System.Collections.Generic.Dictionary<int, TeamAvatarHelper.ClothMatchInfo> ClothMatchInfoCache;
    private static readonly global::System.Collections.Generic.HashSet<string> NeedCompare2ndColorCoat;
    private static readonly global::System.Collections.Generic.HashSet<string> NeedCompare2ndColorCoatSame;
    private static global::System.Collections.Generic.List<string> MixedColorCoat;
    private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::UnityEngine.Color>> armSleeveColorMap;
    private static string[] RefereeUniform;
    private static global::UnityEngine.Color[] RefereeUniformColor;
    private static global::System.Collections.Generic.List<string> shoeSet;
    private static global::SL.WeightRandom<string> shoeRandomHelper;
    private static string[] HeadMeshParamTypeString;
    private static uint[] _hairColors;
    private static uint[] _hairDarkColors;
    private static uint[] _hairSpecColors;
    public static int HairColorCount => 0;
    public static int NormalHairColorCount => 0;
    public static int HairSpecColorCount => 0;

    private static PlayerTextureAtlasData BuildScaledAtlasData(PlayerTextureAtlasData source, global::UnityEngine.Vector2Int textureSize, bool useCache)
    {
        return null;
    }

    public static PlayerKitPathInfo GetTeamKitPathInfo(int teamAvatarId, TeamsData teamsData, bool isGK = false)
    {
        return default;
    }

    private static bool LoadBadge(global::UnityEngine.UI.Image flag, TeamsData team, global::UnityEngine.Rect rect)
    {
        return false;
    }

    public static void MakeTeamLogo(global::UnityEngine.UI.Image flag, TeamsData team, bool isHome, global::UnityEngine.Rect rect, int oppTeam = -1, CupMatchBase match = null)
    {
    }

    public static void MakeTeamLogo(global::UnityEngine.Transform root, int teamId, TeamsData team, bool isHome, bool isGK, global::UnityEngine.Rect rect = default(global::UnityEngine.Rect))
    {
    }

    public static void Initialize()
    {
    }

    private static TeamAvatarHelper.ClothMatchInfo GetClothMatchInfo(int avatarId)
    {
        return default;
    }

    private static void ParseClothColors(string value, out global::UnityEngine.Color mainColor, out global::UnityEngine.Color secondaryColor)
    {
        mainColor = default;
        secondaryColor = default;
    }

    private static global::UnityEngine.Color ParseClothColor(string value, ref int index)
    {
        return default;
    }

    private static int ParseColorComponent(string value, ref int index)
    {
        return 0;
    }

    private static void SkipColorWhitespace(string value, ref int index)
    {
    }

    private static float CompareClothColor(TeamAvatarHelper.ClothMatchInfo home, TeamAvatarHelper.ClothMatchInfo away, bool primaryColorsEqual, string primaryHomeColors)
    {
        return 0f;
    }

    private static void UpdateBestClothMatch(float difference, int homeAvatarId, int awayAvatarId, ref float bestDifference, ref int bestHomeAvatarId, ref int bestAwayAvatarId)
    {
    }

    private static (int, int) FixHomeAwayClothColor(int primaryHomeAvatarId, int alternateHomeAvatarId, int primaryAwayAvatarId, int alternateAwayAvatarId)
    {
        return default;
    }

    public static (int, int) FixTeamMyOppClothColor(global::System.Collections.Generic.List<int> myTeamAvatarId, global::System.Collections.Generic.List<int> oppAvatarId)
    {
        return default;
    }

    public static (int, int) FixTeamMyOppClothColor(int primaryMyTeamAvatarId, int alternateMyTeamAvatarId, int primaryOppAvatarId, int alternateOppAvatarId)
    {
        return default;
    }

    private static TeamAvatarHelper.NumberColorPair GetNumberColor(string[] jerseyString, string avatarInfo00)
    {
        return default;
    }

    public static TeamAvatarHelper.JerseyNumberColor GetApproximateNumberColor(int teamAvatarId)
    {
        return default;
    }

    public static bool IsHomeAvatarId(int avatarId)
    {
        return false;
    }

    public static bool IsAwayAvatarId(int avatarId)
    {
        return false;
    }

    public static global::System.Tuple<global::UnityEngine.Color, global::UnityEngine.Color> GetTeamCoatShortColor(int avatarId)
    {
        return null;
    }

    public static global::UnityEngine.Color StringToColor(string color)
    {
        return default;
    }

    public static bool TryParseNumberColorPair(string colorPair, out global::UnityEngine.Color color1, out global::UnityEngine.Color color2)
    {
        color1 = default;
        color2 = default;
        return false;
    }

    public static bool TryParseNumberColorPair(string colorPair, out TeamAvatarHelper.NumberColorPair numberColorPair)
    {
        numberColorPair = default;
        return false;
    }

    private static bool TryParseRgbColor(string value, out global::UnityEngine.Color color)
    {
        color = default;
        return false;
    }

    private static bool IsNumberColorPair(TeamAvatarHelper.NumberColorPair numberColorPair, global::UnityEngine.Color mainColor, global::UnityEngine.Color outlineColor)
    {
        return false;
    }

    private static bool ColorsApproximatelyEqual(global::UnityEngine.Color color1, global::UnityEngine.Color color2)
    {
        return false;
    }

    public static global::System.Tuple<global::UnityEngine.Color, global::UnityEngine.Color> ReadTwoColor(string grid)
    {
        return null;
    }

    private static void SetNumberPathInfo(ref PlayerAppearancePathInfo result, string coatNumFileName, TeamAvatarHelper.JerseyNumberColor numberColor)
    {
    }

    private static void TryApplyStarPlayerAppearance(ref PlayerAppearancePathInfo result, int playerId, bool allowStarAppearance)
    {
    }

    private static PlayerAppearancePathInfo BuildPlayerAppearancePathInfo(global::SL.Player.PlayerApperance appearance, short height, int playerId, bool isGK, bool isFemale, TeamAvatarHelper.JerseyNumberColor numberColor, string coatNumFileName, bool allowStarAppearance)
    {
        return default;
    }

    public static void ApplyUserPlayer(global::UnityEngine.GameObject go, int apperanceID, short height, int weight, bool noTeam, int coatNum, int teamId)
    {
    }

    public static PlayerAppearancePathInfo GetUserPlayerAppearance(int apperanceID, short height, int weight, TeamAvatarHelper.JerseyNumberColor numberColor, string coatNum = null)
    {
        return default;
    }

    public static PlayerAppearancePathInfo GetPlayerAppearanceByClubPlayer(ClubPlayer player, TeamAvatarHelper.JerseyNumberColor numberColor, string coatNum = null)
    {
        return default;
    }

    private static string GetNoHairFromHair(string hairName)
    {
        return null;
    }

    public static void Apply(global::System.Collections.Generic.List<global::UnityEngine.GameObject> players, int teamAvatarId, global::System.Collections.Generic.List<ClubPlayer> clubPlayers, bool hairAtlas, bool OnlyApplyHD = false, bool isPlyaerIcon = false, bool OnlyApplyLD = false, int forceGK = 0)
    {
    }

    private static string MatchArmSleeve(global::UnityEngine.Color color)
    {
        return null;
    }

    public static void Apply(global::System.Collections.Generic.List<global::UnityEngine.GameObject> players, int teamAvatarId, global::System.Collections.Generic.List<ClubPlayer> clubPlayers, global::System.Action<PlayerRender, AppearanceData> action, int forceGK)
    {
    }

    public static void ApplyPlayerForAnyTeam((global::UnityEngine.GameObject, ClubPlayer, int, bool) player, TeamsData team, int teamAvatarId, bool hairAtlas, bool OnlyApplyHD = false, bool OnlyApplyLD = false)
    {
    }

    public static void ApplySinglePlayer(IPlayerRender playerRender, IPlayerTextureSupplier supplie, bool hairAtlas, bool OnlyApplyHD = false, bool isPlyaerIcon = false, bool OnlyApplyLD = false)
    {
    }

    public static void ApplyHD(global::System.Collections.Generic.List<global::UnityEngine.GameObject> players, int teamAvatarId, global::System.Collections.Generic.List<ClubPlayer> clubPlayers, bool hairAtlas)
    {
    }

    public static void ApplyPlayerIcon(global::System.Collections.Generic.List<global::UnityEngine.GameObject> players, int teamAvatarId, global::System.Collections.Generic.List<ClubPlayer> clubPlayers, bool hairAtlas)
    {
    }

    public static void ApplyClubUniform(global::UnityEngine.Renderer renderer, int teamAvatarId, TeamsData teamsData, int? number = null, string name = null, bool noBackLogo = false, bool isGK = false, int? playerId = null, bool useHighResolutionTexture = false)
    {
    }

    public static int FixOfficialCoat(global::UnityEngine.Color myTeamColor, global::UnityEngine.Color oppTeamColor)
    {
        return 0;
    }

    public static int GetNumberByCoatPath(string[] coatPath)
    {
        return 0;
    }

    public static PlayerKitPathInfo ParsePlayerInfo(global::System.Collections.Generic.List<string> row, TeamsData teamsData, bool isGK, bool isHome)
    {
        return default;
    }

    public static string GetClothPathByName(string name)
    {
        return null;
    }

    public static string GetSkinPathByName(string name)
    {
        return null;
    }

    public static string GetShoePathByName(string name)
    {
        return null;
    }

    public static string GetGlassesPathByName(string name)
    {
        return null;
    }

    public static string GetGlovePathByName(string name)
    {
        return null;
    }

    public static string GetFacePathByName(string name)
    {
        return null;
    }

    public static string GetBeardPathByName(string name)
    {
        return null;
    }

    public static Cloth StrToCloth(string str, string path)
    {
        return default;
    }

    public static void InitHairColor(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> allColor)
    {
    }

    public static void InitHairSpecColor(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> specColors)
    {
    }

    public static bool IsValidHairColorIndex(int idx)
    {
        return false;
    }

    public static global::System.Collections.Generic.List<global::UnityEngine.Color> GetHairColorByIndex(int idx)
    {
        return null;
    }

    public static global::UnityEngine.Color GetHairSpecColorByIndex(int idx)
    {
        return default;
    }

    public static global::UnityEngine.Color int2Color(uint c, bool withAlpha = false)
    {
        return default;
    }

    public static void ApplyOfficials(global::UnityEngine.GameObject[] officials, int homeTeamAvatarId, int awayTeamId)
    {
    }

    public static void ApplyOfficials(global::Common.PlayerBoneHolder[] officials, int homeTeamAvatarId, int awayTeamId)
    {
    }
}
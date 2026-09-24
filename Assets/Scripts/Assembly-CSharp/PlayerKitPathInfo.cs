public struct PlayerKitPathInfo
{
    public TempUserAppearanceSetting.SpecialJerseyConfig specialJerseyConfig;
    public Cloth Sock;
    public static string SockBasePath;
    public Cloth Shorts;
    public static string ShortsBasePath;
    public Cloth Coat;
    public static string CoatBasePath;
    public global::UnityEngine.Color CoatColor;
    public string PlayerName;
    public string FlagPath;
    public string ShoulderLogoPath;
    public global::UnityEngine.Color? ShoulderLogoColor;
    public string KitFrontBackLogoPath;
    public string SockLogoPath;
    public global::UnityEngine.Color? SockLogoColor;
    public string ShortsLogoPath;
    public global::UnityEngine.Color? ShortsLogoColor;
    public string ChestLogoPath;
    public global::UnityEngine.Color? ChestLogoColor;
    public string SponsorLogoPath;
    public global::UnityEngine.Color? SponsorLogoColor;
    public global::System.Collections.Generic.List<PlayerTextureAtlasData.PartType> disableColorModificationParts;
    public bool ShowSleeve;
    public string ShoePath;
    public global::UnityEngine.Texture2D customJersey;
    public int JerseyStyle;
    public global::FLDataTable.LicensedJerseyConfig _licensedJerseyConfig;
    public int CollarStyle => 0;
    public global::FLDataTable.LicensedJerseyConfig licensedJerseyConfig => null;

    public void AddDisableColorModificationPart(PlayerTextureAtlasData.PartType part)
    {
    }

    public bool IsColorModificationDisabled(PlayerTextureAtlasData.PartType part)
    {
        return false;
    }

    public void ResetDisableColorModificationParts()
    {
    }

    public void CopyFrom(PlayerKitPathInfo other)
    {
    }

    public override bool Equals(object obj)
    {
        return false;
    }

    public override int GetHashCode()
    {
        return 0;
    }
}
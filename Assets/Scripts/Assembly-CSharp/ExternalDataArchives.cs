public class ExternalDataArchives
{
    public enum ArchivesType
    {
        Cup = 100000,
        League = 200000,
        Team = 10000000,
        Player = 50000000,
        TeamNameAbbr = 100000000,
        Max = 150000000
    }

    public enum ArchivesDetailType
    {
        None = 0,
        HomeJersey = 1,
        AwayJersey = 2,
        HomeGKJersey = 3,
        AwayGKJersey = 4,
        ClubPlayerIcon = 5,
        NationalPlayerIcon = 6
    }

    public static global::Srv.ExternalDataSetting Setting;
    private static bool dirty;
    private static ExternalDataAgent agent;
    public static string Path => null;

    public static void MarkDirty()
    {
    }

    private static void markDirty()
    {
    }

    public static void CheckDirtyFlag()
    {
    }

    public static void Load()
    {
    }

    private static bool LoadFromFile()
    {
        return false;
    }

    private static void InitialSetting()
    {
    }

    public static void Clear()
    {
    }

    public static void SaveToFile()
    {
    }

    public static int CalculateKey(ExternalDataArchives.ArchivesType type, int id)
    {
        return 0;
    }

    public static string CalculateImageSavePath(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType = ExternalDataArchives.ArchivesDetailType.None)
    {
        return null;
    }

    public static void SaveDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType, string data)
    {
    }

    public static string LoadDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType)
    {
        return null;
    }

    public static void RemoveDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType)
    {
    }

    public static void SaveName(ExternalDataArchives.ArchivesType type, int id, string name)
    {
    }

    public static string LoadName(ExternalDataArchives.ArchivesType type, int id)
    {
        return null;
    }

    public static void RemoveName(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public static void SavePath(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public static string LoadPath(ExternalDataArchives.ArchivesType type, int id)
    {
        return null;
    }

    public static void RemovePath(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public static string LoadCoatNumber(int teamId, int playerId)
    {
        return null;
    }

    public static void SaveCoatNumber(int teamId, int playerId, string coatNumber)
    {
    }

    public static void RemoveCoatNumber(int teamId, int playerId)
    {
    }
}
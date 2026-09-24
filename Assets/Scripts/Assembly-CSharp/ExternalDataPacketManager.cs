public static class ExternalDataPacketManager
{
    private static global::System.Collections.Generic.List<ExternalDataPacketArchive> archives;
    public static bool hasDataPacket => false;

    public static void Load()
    {
    }

    public static string LoadName(ExternalDataArchives.ArchivesType type, int id, ExternalDataAgent agent)
    {
        return null;
    }

    public static bool Contains(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType, ExternalDataAgent agent)
    {
        return false;
    }

    public static byte[] LoadDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType, ExternalDataAgent agent)
    {
        return null;
    }

    public static byte[] LoadPath(ExternalDataArchives.ArchivesType type, int id, ExternalDataAgent agent)
    {
        return null;
    }

    public static bool Contains(ExternalDataArchives.ArchivesType type, int id, ExternalDataAgent agent)
    {
        return false;
    }

    public static global::UnityEngine.Color LoadHomeJerseryColor(int id)
    {
        return default;
    }

    public static global::UnityEngine.Color LoadAwayJerseryColor(int id)
    {
        return default;
    }
}
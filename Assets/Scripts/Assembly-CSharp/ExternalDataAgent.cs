public class ExternalDataAgent
{
    private global::Srv.ExternalDataSetting Setting;
    private string SubPath;
    private global::System.Action MarkDirtyAction;
    private static global::System.Collections.Generic.List<ExternalDataArchives.ArchivesType> keyChecker;
    public string ID => null;

    public ExternalDataAgent(global::Srv.ExternalDataSetting Setting, string subPath, global::System.Action MarkDirtyAction)
    {
    }

    public void MarkDirty()
    {
    }

    public static int CalculateKey(ExternalDataArchives.ArchivesType type, int id)
    {
        return 0;
    }

    public string CalculateImageSavePath(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType = ExternalDataArchives.ArchivesDetailType.None)
    {
        return null;
    }

    public void SaveDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType, string data)
    {
    }

    public string LoadDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType)
    {
        return null;
    }

    public void RemoveDetailInfo(ExternalDataArchives.ArchivesType type, int id, ExternalDataArchives.ArchivesDetailType detailType)
    {
    }

    public void SaveName(ExternalDataArchives.ArchivesType type, int id, string name)
    {
    }

    public string LoadName(ExternalDataArchives.ArchivesType type, int id)
    {
        return null;
    }

    public void RemoveName(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public void SavePath(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public string LoadPath(ExternalDataArchives.ArchivesType type, int id)
    {
        return null;
    }

    public void RemovePath(ExternalDataArchives.ArchivesType type, int id)
    {
    }

    public string LoadCoatNumber(int teamId, int playerId)
    {
        return null;
    }

    public void SaveCoatNumber(int teamId, int playerId, string coatNumber)
    {
    }

    public void RemoveCoatNumber(int teamId, int playerId)
    {
    }
}
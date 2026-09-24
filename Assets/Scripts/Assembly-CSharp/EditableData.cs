public class EditableData
{
    protected ExternalDataArchives.ArchivesType ArchivesType;
    protected int id;
    protected ExternalDataAgent archiveAgent;
    public EditableData(ExternalDataArchives.ArchivesType archivesType, int id)
    {
    }

    public void SetArchiveAgent(ExternalDataAgent agent)
    {
    }

    public virtual void Reset()
    {
    }
}
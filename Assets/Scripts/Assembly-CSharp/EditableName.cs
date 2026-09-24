public class EditableName : EditableData
{
    private IEditableNameLocalization forAudit;
    private bool useRealName;
    public string OrgValue { get; set; }

    public string Value
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public bool isCustomName => false;
    public string StrKey { get; set; }

    public EditableName(ExternalDataArchives.ArchivesType archivesType, int id, string orgValue, string strKey, IEditableNameLocalization localization = null, bool useRealName = false) : base((ExternalDataArchives.ArchivesType)0, 0)
    {
    }

    public EditableName CopyTo()
    {
        return null;
    }

    public void UpdateValue(string newValue)
    {
    }

    public void SetUseRealName(bool useRealName)
    {
    }

    public override void Reset()
    {
    }
}
public class EditableCoatNumber : EditableData
{
    private int team;
    private int playerId;
    public int OrgValue { get; set; }

    public int Value
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public bool isCustomName => false;

    public EditableCoatNumber(int team, int player, int orgValue) : base((ExternalDataArchives.ArchivesType)0, 0)
    {
    }

    public override void Reset()
    {
    }
}
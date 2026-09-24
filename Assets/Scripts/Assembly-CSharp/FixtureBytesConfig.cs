public class FixtureBytesConfig
{
    public class Row
    {
        public string[] MatchTypes;
        public FixtureBytesConfig.DateSlot[] DateSlots;
    }

    public struct DateSlot
    {
        public int MonthIndex;
        public int Day;
        public FixtureBytesConfig.TimeSlot[] Times;
    }

    public struct TimeSlot
    {
        public byte Hour;
        public byte Minute;
    }

    private const int Magic = 1180193841;
    private const int Version = 1;
    public int BaseYear;
    public int BaseMonth;
    public int BaseDay;
    public int BaseHourOffset;
    public readonly global::System.Collections.Generic.List<FixtureBytesConfig.Row> Rows;
    public global::System.DateTime BaseTime => default;

    public static FixtureBytesConfig LoadTable(string path)
    {
        return null;
    }

    public static bool TryLoadTable(string path, out FixtureBytesConfig table)
    {
        table = null;
        return false;
    }

    public static FixtureBytesConfig Deserialize(global::System.IO.BinaryReader reader)
    {
        return null;
    }

    public static void Serialize(global::System.IO.BinaryWriter writer, FixtureBytesConfig table)
    {
    }

    public static FixtureBytesConfig FromCsvRows(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> rows)
    {
        return null;
    }
}
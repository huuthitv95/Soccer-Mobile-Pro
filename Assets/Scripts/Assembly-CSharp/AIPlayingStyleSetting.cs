public class AIPlayingStyleSetting
{
    public double configValue { get; set; }
    public global::System.Collections.Generic.List<int> timeSlot { get; set; }
    public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> aiStyleTable { get; set; }
    public int gdOffset { get; set; }
    public int gdMin { get; set; }
    public int gdMax { get; set; }
    public int firstHalfEndSlotIndex { get; set; }
    public int secondHalfEndSlotIndex { get; set; }

    // C# has no syntax for parameterized property 'Item'.
    public int this[int gdIndex, int timeSlotIndex]
    {
        get
        {
            return 0;
        }
    }
}
namespace TMPro
{
    [global::System.Serializable]
    public class KerningTable
    {
        public global::System.Collections.Generic.List<global::TMPro.KerningPair> kerningPairs;
        public void AddKerningPair()
        {
        }

        public int AddKerningPair(uint first, uint second, float offset)
        {
            return 0;
        }

        public int AddGlyphPairAdjustmentRecord(uint first, global::TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, global::TMPro.GlyphValueRecord_Legacy secondAdjustments)
        {
            return 0;
        }

        public void RemoveKerningPair(int left, int right)
        {
        }

        public void RemoveKerningPair(int index)
        {
        }

        public void SortKerningPairs()
        {
        }
    }
}
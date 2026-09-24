namespace TMPro
{
    [global::System.Serializable]
    public class TMP_FontFeatureTable
    {
        [global::UnityEngine.SerializeField]
        internal global::System.Collections.Generic.List<global::TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        internal global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;
        public global::System.Collections.Generic.List<global::TMPro.TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public void SortGlyphPairAdjustmentRecords()
        {
        }
    }
}
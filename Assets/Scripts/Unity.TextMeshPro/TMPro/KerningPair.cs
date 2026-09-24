namespace TMPro
{
    [global::System.Serializable]
    public class KerningPair
    {
        [global::UnityEngine.SerializeField]
        private uint m_FirstGlyph;
        [global::UnityEngine.SerializeField]
        private global::TMPro.GlyphValueRecord_Legacy m_FirstGlyphAdjustments;
        [global::UnityEngine.SerializeField]
        private uint m_SecondGlyph;
        [global::UnityEngine.SerializeField]
        private global::TMPro.GlyphValueRecord_Legacy m_SecondGlyphAdjustments;
        public float xOffset;
        internal static global::TMPro.KerningPair empty;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreSpacingAdjustments;
        public uint firstGlyph
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public global::TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments => default;

        public uint secondGlyph
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public global::TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments => default;
        public bool ignoreSpacingAdjustments => false;

        public KerningPair()
        {
        }

        public KerningPair(uint left, uint right, float offset)
        {
        }

        public KerningPair(uint firstGlyph, global::TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, global::TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments)
        {
        }

        internal void ConvertLegacyKerningData()
        {
        }
    }
}
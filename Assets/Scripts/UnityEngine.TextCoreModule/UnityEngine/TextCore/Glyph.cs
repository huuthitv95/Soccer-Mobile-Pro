namespace UnityEngine.TextCore
{
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0)]
    [global::UnityEngine.Scripting.UsedByNativeCode]
    public class Glyph
    {
        [global::UnityEngine.SerializeField]
        private uint m_Index;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TextCore.GlyphMetrics m_Metrics;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TextCore.GlyphRect m_GlyphRect;
        [global::UnityEngine.SerializeField]
        private float m_Scale;
        [global::UnityEngine.SerializeField]
        private int m_AtlasIndex;
        public uint index
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public global::UnityEngine.TextCore.GlyphMetrics metrics
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.TextCore.GlyphRect glyphRect
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float scale
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int atlasIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public Glyph()
        {
        }

        internal Glyph(global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
        {
        }

        public Glyph(uint index, global::UnityEngine.TextCore.GlyphMetrics metrics, global::UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex)
        {
        }
    }
}
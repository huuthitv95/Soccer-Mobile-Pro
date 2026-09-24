namespace UnityEngine.TextCore.LowLevel
{
    public sealed class FontEngine
    {
        private static global::UnityEngine.TextCore.Glyph[] s_Glyphs;
        private static uint[] s_GlyphIndexes_MarshallingArray_A;
        private static global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;
        private static global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;
        private static global::UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects;
        private static global::UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects;
        private static global::UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;
        private static global::System.Collections.Generic.Dictionary<uint, global::UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;
        public static global::UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine()
        {
            return global::UnityEngine.TextCore.LowLevel.FontEngineError.Success;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static int InitializeFontEngine_Internal()
        {
            return 0;
        }

        public static global::UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(global::UnityEngine.Font font, int pointSize)
        {
            return global::UnityEngine.TextCore.LowLevel.FontEngineError.Success;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static int LoadFontFace_With_Size_FromFont_Internal(global::UnityEngine.Font font, int pointSize)
        {
            return 0;
        }

        public static global::UnityEngine.TextCore.FaceInfo GetFaceInfo()
        {
            return default;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static int GetFaceInfo_Internal(ref global::UnityEngine.TextCore.FaceInfo faceInfo)
        {
            return 0;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        internal static uint GetGlyphIndex(uint unicode)
        {
            return 0u;
        }

        public static bool TryGetGlyphWithUnicodeValue(uint unicode, global::UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, out global::UnityEngine.TextCore.Glyph glyph)
        {
            glyph = null;
            return false;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, global::UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
        {
            return false;
        }

        public static bool TryGetGlyphWithIndexValue(uint glyphIndex, global::UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, out global::UnityEngine.TextCore.Glyph glyph)
        {
            glyph = null;
            return false;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, global::UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
        {
            return false;
        }

        internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, global::UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> freeGlyphRects, global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> usedGlyphRects, global::UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, global::UnityEngine.Texture2D texture, out global::UnityEngine.TextCore.Glyph glyph)
        {
            glyph = null;
            return false;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, global::UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, [global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, global::UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, global::UnityEngine.Texture2D texture, out global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph)
        {
            glyph = default;
            return false;
        }

        internal static bool TryAddGlyphsToTexture(global::System.Collections.Generic.List<uint> glyphIndexes, int padding, global::UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> freeGlyphRects, global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> usedGlyphRects, global::UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, global::UnityEngine.Texture2D texture, out global::UnityEngine.TextCore.Glyph[] glyphs)
        {
            glyphs = null;
            return false;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, global::UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, [global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, global::UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, global::UnityEngine.Texture2D texture, [global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount)
        {
            return false;
        }

        internal static global::UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
        {
            return null;
        }

        internal static global::UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(global::System.Collections.Generic.List<uint> glyphIndexes, out int recordCount)
        {
            recordCount = default;
            return null;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount)
        {
            recordCount = default;
            return 0;
        }

        [global::UnityEngine.Bindings.NativeMethod]
        private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([global::System.Runtime.InteropServices.Out] global::UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords)
        {
            return 0;
        }

        private static void GenericListToMarshallingArray<T>(ref global::System.Collections.Generic.List<T> srcList, ref T[] dstArray)
        {
        }

        private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
        {
        }

        [global::UnityEngine.Bindings.NativeMethod]
        internal static void ResetAtlasTexture(global::UnityEngine.Texture2D texture)
        {
        }
    }
}
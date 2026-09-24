namespace UnityEngine.UI
{
    public static class StencilMaterial
    {
        private class MatEntry
        {
            public global::UnityEngine.Material baseMat;
            public global::UnityEngine.Material customMat;
            public int count;
            public int stencilId;
            public global::UnityEngine.Rendering.StencilOp operation;
            public global::UnityEngine.Rendering.CompareFunction compareFunction;
            public int readMask;
            public int writeMask;
            public bool useAlphaClip;
            public global::UnityEngine.Rendering.ColorWriteMask colorMask;
        }

        private static global::System.Collections.Generic.List<global::UnityEngine.UI.StencilMaterial.MatEntry> m_List;
        [global::System.Obsolete]
        public static global::UnityEngine.Material Add(global::UnityEngine.Material baseMat, int stencilID)
        {
            return null;
        }

        public static global::UnityEngine.Material Add(global::UnityEngine.Material baseMat, int stencilID, global::UnityEngine.Rendering.StencilOp operation, global::UnityEngine.Rendering.CompareFunction compareFunction, global::UnityEngine.Rendering.ColorWriteMask colorWriteMask)
        {
            return null;
        }

        private static void LogWarningWhenNotInBatchmode(string warning, global::UnityEngine.Object context)
        {
        }

        public static global::UnityEngine.Material Add(global::UnityEngine.Material baseMat, int stencilID, global::UnityEngine.Rendering.StencilOp operation, global::UnityEngine.Rendering.CompareFunction compareFunction, global::UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask)
        {
            return null;
        }

        public static void Remove(global::UnityEngine.Material customMat)
        {
        }

        public static void ClearAll()
        {
        }
    }
}
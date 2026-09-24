namespace TMPro
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class TextMeshPro : global::TMPro.TMP_Text, global::UnityEngine.UI.ILayoutElement
    {
        [global::UnityEngine.SerializeField]
        private bool m_hasFontAssetChanged;
        private float m_previousLossyScaleY;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Renderer m_renderer;
        private global::UnityEngine.MeshFilter m_meshFilter;
        private bool m_isFirstAllocation;
        private int m_max_characters;
        private int m_max_numberOfLines;
        private global::TMPro.TMP_SubMesh[] m_subTextObjects;
        [global::UnityEngine.SerializeField]
        private global::TMPro.MaskingTypes m_maskType;
        private global::UnityEngine.Matrix4x4 m_EnvMapMatrix;
        private global::UnityEngine.Vector3[] m_RectTransformCorners;
        [global::System.NonSerialized]
        private bool m_isRegisteredForEvents;
        private static global::Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        private static global::Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;
        private static global::Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;
        private static global::Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;
        private static global::Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;
        private static global::Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;
        private static global::Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;
        private static global::Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;
        private static global::Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;
        private static global::Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;
        private static global::Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;
        private static global::Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        private static global::Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        private static global::Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        [global::UnityEngine.SerializeField]
        internal int _SortingLayer;
        [global::UnityEngine.SerializeField]
        internal int _SortingLayerID;
        [global::UnityEngine.SerializeField]
        internal int _SortingOrder;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private new global::System.Action<global::TMPro.TMP_TextInfo> m_OnPreRenderText;
        private bool m_currentAutoSizeMode;
        public int sortingLayerID
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int sortingOrder
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public override bool autoSizeTextContainer
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::TMPro.TextContainer textContainer => null;
        public new global::UnityEngine.Transform transform => null;
        public global::UnityEngine.Renderer renderer => null;
        public override global::UnityEngine.Mesh mesh => null;
        public global::UnityEngine.MeshFilter meshFilter => null;

        public global::TMPro.MaskingTypes maskType
        {
            get
            {
                return global::TMPro.MaskingTypes.MaskOff;
            }

            set
            {
            }
        }

        public override event global::System.Action<global::TMPro.TMP_TextInfo> OnPreRenderText
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void LoadFontAsset()
        {
        }

        private void UpdateEnvMapMatrix()
        {
        }

        private void SetMask(global::TMPro.MaskingTypes maskType)
        {
        }

        private void SetMaskCoordinates(global::UnityEngine.Vector4 coords)
        {
        }

        private void SetMaskCoordinates(global::UnityEngine.Vector4 coords, float softX, float softY)
        {
        }

        private void EnableMasking()
        {
        }

        private void DisableMasking()
        {
        }

        private void UpdateMask()
        {
        }

        protected override global::UnityEngine.Material GetMaterial(global::UnityEngine.Material mat)
        {
            return null;
        }

        protected override global::UnityEngine.Material[] GetMaterials(global::UnityEngine.Material[] mats)
        {
            return null;
        }

        protected override void SetSharedMaterial(global::UnityEngine.Material mat)
        {
        }

        protected override global::UnityEngine.Material[] GetSharedMaterials()
        {
            return null;
        }

        protected override void SetSharedMaterials(global::UnityEngine.Material[] materials)
        {
        }

        protected override void SetOutlineThickness(float thickness)
        {
        }

        protected override void SetFaceColor(global::UnityEngine.Color32 color)
        {
        }

        protected override void SetOutlineColor(global::UnityEngine.Color32 color)
        {
        }

        private void CreateMaterialInstance()
        {
        }

        protected override void SetShaderDepth()
        {
        }

        protected override void SetCulling()
        {
        }

        private void SetPerspectiveCorrection()
        {
        }

        internal override int SetArraySizes(global::TMPro.TMP_Text.UnicodeChar[] unicodeChars)
        {
            return 0;
        }

        public override void ComputeMarginSize()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        internal override void InternalUpdate()
        {
        }

        private void OnPreRenderObject()
        {
        }

        protected virtual void GenerateTextMesh()
        {
        }

        protected override global::UnityEngine.Vector3[] GetTextContainerLocalCorners()
        {
            return null;
        }

        private void SetMeshFilters(bool state)
        {
        }

        protected override void SetActiveSubMeshes(bool state)
        {
        }

        protected void SetActiveSubTextObjectRenderers(bool state)
        {
        }

        protected override void DestroySubMeshObjects()
        {
        }

        internal void UpdateSubMeshSortingLayerID(int id)
        {
        }

        internal void UpdateSubMeshSortingOrder(int order)
        {
        }

        protected override global::UnityEngine.Bounds GetCompoundBounds()
        {
            return default;
        }

        private void UpdateSDFScale(float scaleDelta)
        {
        }

        public void SetMask(global::TMPro.MaskingTypes type, global::UnityEngine.Vector4 maskCoords)
        {
        }

        public void SetMask(global::TMPro.MaskingTypes type, global::UnityEngine.Vector4 maskCoords, float softnessX, float softnessY)
        {
        }

        public override void SetVerticesDirty()
        {
        }

        public override void SetLayoutDirty()
        {
        }

        public override void SetMaterialDirty()
        {
        }

        public override void SetAllDirty()
        {
        }

        public override void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
        }

        protected override void UpdateMaterial()
        {
        }

        public override void UpdateMeshPadding()
        {
        }

        public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
        {
        }

        public override global::TMPro.TMP_TextInfo GetTextInfo(string text)
        {
            return null;
        }

        public override void ClearMesh(bool updateMesh)
        {
        }

        public override void UpdateGeometry(global::UnityEngine.Mesh mesh, int index)
        {
        }

        public override void UpdateVertexData(global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
        }

        public override void UpdateVertexData()
        {
        }

        public void UpdateFontAsset()
        {
        }

        public void CalculateLayoutInputHorizontal()
        {
        }

        public void CalculateLayoutInputVertical()
        {
        }
    }
}
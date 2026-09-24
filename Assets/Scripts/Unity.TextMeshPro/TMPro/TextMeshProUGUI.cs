namespace TMPro
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class TextMeshProUGUI : global::TMPro.TMP_Text, global::UnityEngine.UI.ILayoutElement
    {
        [global::UnityEngine.SerializeField]
        private bool m_hasFontAssetChanged;
        protected global::TMPro.TMP_SubMeshUI[] m_subTextObjects;
        private float m_previousLossyScaleY;
        private global::UnityEngine.Vector3[] m_RectTransformCorners;
        private global::UnityEngine.CanvasRenderer m_canvasRenderer;
        private global::UnityEngine.Canvas m_canvas;
        private float m_CanvasScaleFactor;
        private bool m_isFirstAllocation;
        private int m_max_characters;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Material m_baseMaterial;
        private bool m_isScrollRegionSet;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector4 m_maskOffset;
        private global::UnityEngine.Matrix4x4 m_EnvMapMatrix;
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
        private bool m_isRebuildingLayout;
        private global::UnityEngine.Coroutine m_DelayedGraphicRebuild;
        private global::UnityEngine.Coroutine m_DelayedMaterialRebuild;
        private global::UnityEngine.Rect m_ClipRect;
        private bool m_ValidRect;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private new global::System.Action<global::TMPro.TMP_TextInfo> m_OnPreRenderText;
        public override global::UnityEngine.Material materialForRendering => null;

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

        public override global::UnityEngine.Mesh mesh => null;
        public new global::UnityEngine.CanvasRenderer canvasRenderer => null;

        public global::UnityEngine.Vector4 maskOffset
        {
            get
            {
                return default;
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

        private global::UnityEngine.Canvas GetCanvas()
        {
            return null;
        }

        private void UpdateEnvMapMatrix()
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

        protected override void SetShaderDepth()
        {
        }

        protected override void SetCulling()
        {
        }

        private void SetPerspectiveCorrection()
        {
        }

        private void SetMeshArrays(int size)
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

        protected override void OnCanvasHierarchyChanged()
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

        private void OnPreRenderCanvas()
        {
        }

        protected virtual void GenerateTextMesh()
        {
        }

        protected override global::UnityEngine.Vector3[] GetTextContainerLocalCorners()
        {
            return null;
        }

        protected override void SetActiveSubMeshes(bool state)
        {
        }

        protected override void DestroySubMeshObjects()
        {
        }

        protected override global::UnityEngine.Bounds GetCompoundBounds()
        {
            return default;
        }

        internal override global::UnityEngine.Rect GetCanvasSpaceClippingRect()
        {
            return default;
        }

        private void UpdateSDFScale(float scaleDelta)
        {
        }

        public void CalculateLayoutInputHorizontal()
        {
        }

        public void CalculateLayoutInputVertical()
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

        private global::System.Collections.IEnumerator DelayedGraphicRebuild()
        {
            return null;
        }

        private global::System.Collections.IEnumerator DelayedMaterialRebuild()
        {
            return null;
        }

        public override void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
        }

        private void UpdateSubObjectPivot()
        {
        }

        public override global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        protected override void UpdateMaterial()
        {
        }

        public override void RecalculateClipping()
        {
        }

        public override void Cull(global::UnityEngine.Rect clipRect, bool validRect)
        {
        }

        internal override void UpdateCulling()
        {
        }

        public override void UpdateMeshPadding()
        {
        }

        protected override void InternalCrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
        }

        protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
        }

        public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
        {
        }

        public override global::TMPro.TMP_TextInfo GetTextInfo(string text)
        {
            return null;
        }

        public override void ClearMesh()
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
    }
}
namespace SL
{
    public class PerfectUIMask : global::UnityEngine.MonoBehaviour
    {
        private struct ChildRenderData
        {
            public global::UnityEngine.Transform transform;
            public global::UnityEngine.Transform originalParent;
            public global::UnityEngine.Vector3 originalPosition;
            public global::UnityEngine.Vector3 originalScale;
            public global::UnityEngine.Quaternion originalRotation;
            public int originalSiblingIndex;
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color maskColor;
        [global::UnityEngine.SerializeField]
        private bool enableMask;
        [global::UnityEngine.SerializeField]
        private bool raycastTarget;
        [global::UnityEngine.SerializeField]
        private float reduce;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.FilterMode filterMode;
        [global::UnityEngine.SerializeField]
        private bool showDebugInfo;
        [global::UnityEngine.SerializeField]
        private long currentMemoryUsage;
        [global::UnityEngine.SerializeField]
        private int activeRenderTextureCount;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector4 offset;
        private global::UnityEngine.RectTransform rectTransform;
        private global::UnityEngine.Canvas parentCanvas;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.RawImage maskImage;
        private global::UnityEngine.RenderTexture maskRenderTexture;
        private global::System.Collections.Generic.List<global::SL.PerfectUIMask.ChildRenderData> originalChildrenData;
        private bool isDirty;
        private int renderTextureWidth;
        private int renderTextureHeight;
        private static global::UnityEngine.Material s_whiteMaskMaterial;
        private static global::UnityEngine.Shader s_whiteMaskShader;
        private static readonly global::System.Collections.Generic.Dictionary<global::SL.PerfectUIMask, long> s_instanceMemoryUsage;
        public global::UnityEngine.Color MaskColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool EnableMask
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public long CurrentMemoryUsage => 0L;
        public static long TotalMemoryUsage => 0L;

        public void SetDirty()
        {
        }

        private void Awake()
        {
        }

        private void InitializeComponents()
        {
        }

        private void CreateMaskNode()
        {
        }

        private static global::UnityEngine.Material GetWhiteMaskMaterial()
        {
            return null;
        }

        private void Start()
        {
        }

        private void OnEnable()
        {
        }

        private void Update()
        {
        }

        private void OnDestroy()
        {
        }

        private void CreateMask()
        {
        }

        private void DisposeMask()
        {
        }

        private bool HasRenderableChildren()
        {
            return false;
        }

        private bool HasRenderableChildrenRecursive(global::UnityEngine.Transform parent)
        {
            return false;
        }

        private bool HasRenderableComponent(global::UnityEngine.Transform t)
        {
            return false;
        }

        private void MoveRootToTempCanvas(global::UnityEngine.Vector2 scale)
        {
        }

        private void RestoreRootPosition()
        {
        }

        private void CalculateOptimalRenderTextureSize()
        {
        }

        private global::UnityEngine.Rect CalculateRootBounds()
        {
            return default;
        }

        private void CreateRenderTexture()
        {
        }

        private void UpdateMemoryUsage(long newUsage)
        {
        }

        private void RenderMask()
        {
        }

        private global::UnityEngine.Vector2 AncestorsScale(global::UnityEngine.RectTransform r)
        {
            return default;
        }

        private void SetupTempCanvas(global::UnityEngine.Vector2 scale)
        {
        }

        private void RenderToTexture()
        {
        }

        private void ApplyMask()
        {
        }

        private global::UnityEngine.Texture2D RenderTextureToTexture2D(global::UnityEngine.RenderTexture renderTexture)
        {
            return null;
        }

        private void UpdateDebugInfo()
        {
        }

        private string FormatBytes(long bytes)
        {
            return null;
        }

        public void RefreshMask()
        {
        }

        public void ForceRefresh()
        {
        }

        public void LogMemoryStats()
        {
        }
    }
}
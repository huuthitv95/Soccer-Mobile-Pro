namespace UnityEngine.UI.Extensions
{
    public class CylinderTextRoller : global::UnityEngine.UI.Text
    {
        public enum CylinderDirection
        {
            Vertical = 0,
            Horizontal = 1
        }

        [global::System.Serializable]
        public class CenterItemChangedEvent : global::UnityEngine.Events.UnityEvent<string, int>
        {
        }

        private const float AutoLineSpacingFactor = 1.2f;
        [global::UnityEngine.SerializeField]
        private string[] _items;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.CylinderTextRoller.CylinderDirection _direction;
        [global::UnityEngine.SerializeField]
        private bool _hideBackface;
        [global::UnityEngine.SerializeField]
        private bool _loop;
        [global::UnityEngine.SerializeField]
        private int _visibleLineCount;
        [global::UnityEngine.SerializeField]
        private int _topVisibleItemIndex;
        [global::UnityEngine.SerializeField]
        private float _scrollOffset;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.CylinderTextRoller.CenterItemChangedEvent _onCenterItemChanged;
        private readonly global::UnityEngine.UIVertex[] _tempVerts;
        private global::System.Func<int, global::UnityEngine.Color?> _itemColorProvider;
        private string[] _bufferedItems;
        private global::UnityEngine.RectTransform _rectTransform;
        private int _currentStep;
        private bool _hasStepState;
        private int _lastCenteredItemIndex;
        private float _lastScrollOffset;
        public global::UnityEngine.UI.Extensions.CylinderTextRoller.CenterItemChangedEvent OnCenterItemChanged => null;
        public int BufferedLineCount => 0;
        public int CenterVisibleOffset => 0;
        public global::UnityEngine.UI.Extensions.CylinderTextRoller.CylinderDirection Direction => global::UnityEngine.UI.Extensions.CylinderTextRoller.CylinderDirection.Vertical;
        public int ItemCount => 0;
        public bool Loop => false;
        public int VisibleLineCount => 0;
        public float StepSize => 0f;
        public float ScrollOffset => 0f;

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        private void LateUpdate()
        {
        }

        public void AddScrollOffset(float delta)
        {
        }

        public void ResetWindow(int topVisibleItemIndex)
        {
        }

        public int GetCenteredItemIndex()
        {
            return 0;
        }

        public string GetCenteredItem()
        {
            return null;
        }

        public void SetLoop(bool loop)
        {
        }

        public void SetItem(int index, string value)
        {
        }

        public void RegisterItemColorProvider(global::System.Func<int, global::UnityEngine.Color?> itemColorProvider)
        {
        }

        public void UnregisterItemColorProvider()
        {
        }

        public void SetItems(string[] items)
        {
        }

        public void SetScrollOffset(float offset)
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        private void CacheComponents()
        {
        }

        private void EnsureBuffer()
        {
        }

        private float GetAxisSize()
        {
            return 0f;
        }

        private float GetLineHeight()
        {
            return 0f;
        }

        private float GetRadius()
        {
            return 0f;
        }

        private int GetWrappedItemIndex(int index)
        {
            return 0;
        }

        private int ResolveItemIndex(int index)
        {
            return 0;
        }

        private global::UnityEngine.Vector2 GetLineExtents(float lineHeight)
        {
            return default;
        }

        private void NotifyCenterItemChanged()
        {
        }

        private void AppendLine(global::UnityEngine.UI.VertexHelper toFill, string content, int itemIndex, int slotIndex, float lineHeight, float localOffset, float visibleHalfHeight, float radius, global::UnityEngine.Vector2 lineExtents)
        {
        }

        private void ApplyCylinderTransform(ref global::UnityEngine.UIVertex vertex, float radius, float visibleHalfHeight)
        {
        }

        private global::UnityEngine.TextGenerationSettings GetLineGenerationSettings(global::UnityEngine.Vector2 extents)
        {
            return default;
        }

        private void RebuildBufferedWindow()
        {
        }

        private void RefreshWindowFromScroll(bool notifyBoundaryChanges)
        {
        }

        private global::UnityEngine.Color32 ResolveItemColor(int itemIndex)
        {
            return default;
        }

        private static global::UnityEngine.Color32 MultiplyVertexColor(global::UnityEngine.Color32 vertexColor, global::UnityEngine.Color32 lineColor)
        {
            return default;
        }

        private void NormalizeSettings()
        {
        }
    }
}
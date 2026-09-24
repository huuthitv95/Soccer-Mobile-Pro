namespace UnityEngine.UI.Extensions
{
    public class TextPic : global::UnityEngine.UI.Text, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.ISelectHandler
    {
        [global::System.Serializable]
        public struct IconName
        {
            public string name;
            public global::UnityEngine.Sprite sprite;
            public global::UnityEngine.Vector2 offset;
            public global::UnityEngine.Vector2 scale;
        }

        [global::System.Serializable]
        public class HrefClickEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        private class HrefInfo
        {
            public int startIndex;
            public int endIndex;
            public string name;
            public readonly global::System.Collections.Generic.List<global::UnityEngine.Rect> boxes;
        }

        private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Image> m_ImagesPool;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.GameObject> culled_ImagesPool;
        private bool clearImages;
        private global::UnityEngine.Object thisLock;
        private readonly global::System.Collections.Generic.List<int> m_ImagesVertexIndex;
        private static readonly global::System.Text.RegularExpressions.Regex s_Regex;
        private string fixedString;
        [global::UnityEngine.SerializeField]
        private bool m_ClickParents;
        private string m_OutputText;
        public global::UnityEngine.UI.Extensions.TextPic.IconName[] inspectorIconList;
        public float ImageScalingFactor;
        public string hyperlinkColor;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.Vector2 imageOffset;
        private global::UnityEngine.UI.Button button;
        private global::UnityEngine.UI.Selectable highlightselectable;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector2> positions;
        private string previousText;
        public bool isCreating_m_HrefInfos;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Extensions.TextPic.HrefInfo> m_HrefInfos;
        private static readonly global::System.Text.StringBuilder s_TextBuilder;
        private static readonly global::System.Text.RegularExpressions.Regex s_HrefRegex;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.TextPic.HrefClickEvent m_OnHrefClick;
        public bool AllowClickParents
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.TextPic.HrefClickEvent onHrefClick
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override void SetVerticesDirty()
        {
        }

        private new void Start()
        {
        }

        protected void UpdateQuadImage()
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        protected string GetOutputText()
        {
            return null;
        }

        public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private void Update()
        {
        }

        private void Reset_m_HrefInfos()
        {
        }
    }
}
namespace UnityEngine.UI.Extensions
{
    public class SegmentedControl : global::UnityEngine.EventSystems.UIBehaviour
    {
        [global::System.Serializable]
        public class SegmentSelectedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        private global::UnityEngine.UI.Selectable[] m_segments;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic m_separator;
        private float m_separatorWidth;
        [global::UnityEngine.SerializeField]
        private bool m_allowSwitchingOff;
        [global::UnityEngine.SerializeField]
        private int m_selectedSegmentIndex;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.SegmentedControl.SegmentSelectedEvent m_onValueChanged;
        protected internal global::UnityEngine.UI.Selectable selectedSegment;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.Color selectedColor;
        protected float SeparatorWidth => 0f;
        public global::UnityEngine.UI.Selectable[] segments => null;

        public global::UnityEngine.UI.Graphic separator
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool allowSwitchingOff
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int selectedSegmentIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.SegmentedControl.SegmentSelectedEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected SegmentedControl()
        {
        }

        protected override void Start()
        {
        }

        private global::UnityEngine.UI.Selectable[] GetChildSegments()
        {
            return null;
        }

        public void SetAllSegmentsOff()
        {
        }

        private void RecreateSprites()
        {
        }

        public void LayoutSegments()
        {
        }
    }
}
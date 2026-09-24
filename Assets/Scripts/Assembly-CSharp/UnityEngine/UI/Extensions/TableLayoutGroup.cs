namespace UnityEngine.UI.Extensions
{
    public class TableLayoutGroup : global::UnityEngine.UI.LayoutGroup
    {
        public enum Corner
        {
            UpperLeft = 0,
            UpperRight = 1,
            LowerLeft = 2,
            LowerRight = 3
        }

        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Extensions.TableLayoutGroup.Corner startCorner;
        [global::UnityEngine.SerializeField]
        protected float[] columnWidths;
        [global::UnityEngine.SerializeField]
        protected float minimumRowHeight;
        [global::UnityEngine.SerializeField]
        protected bool flexibleRowHeight;
        [global::UnityEngine.SerializeField]
        protected float columnSpacing;
        [global::UnityEngine.SerializeField]
        protected float rowSpacing;
        private float[] preferredRowHeights;
        public global::UnityEngine.UI.Extensions.TableLayoutGroup.Corner StartCorner
        {
            get
            {
                return global::UnityEngine.UI.Extensions.TableLayoutGroup.Corner.UpperLeft;
            }

            set
            {
            }
        }

        public float[] ColumnWidths
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float MinimumRowHeight
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool FlexibleRowHeight
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float ColumnSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float RowSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public override void CalculateLayoutInputHorizontal()
        {
        }

        public override void CalculateLayoutInputVertical()
        {
        }

        public override void SetLayoutHorizontal()
        {
        }

        public override void SetLayoutVertical()
        {
        }
    }
}
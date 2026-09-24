namespace UnityEngine.UI
{
    public class GridLayoutGroup : global::UnityEngine.UI.LayoutGroup
    {
        public enum Corner
        {
            UpperLeft = 0,
            UpperRight = 1,
            LowerLeft = 2,
            LowerRight = 3
        }

        public enum Axis
        {
            Horizontal = 0,
            Vertical = 1
        }

        public enum Constraint
        {
            Flexible = 0,
            FixedColumnCount = 1,
            FixedRowCount = 2
        }

        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector2 m_CellSize;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector2 m_Spacing;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;
        [global::UnityEngine.SerializeField]
        protected int m_ConstraintCount;
        public global::UnityEngine.UI.GridLayoutGroup.Corner startCorner
        {
            get
            {
                return global::UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.GridLayoutGroup.Axis startAxis
        {
            get
            {
                return global::UnityEngine.UI.GridLayoutGroup.Axis.Horizontal;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 cellSize
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 spacing
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.GridLayoutGroup.Constraint constraint
        {
            get
            {
                return global::UnityEngine.UI.GridLayoutGroup.Constraint.Flexible;
            }

            set
            {
            }
        }

        public int constraintCount
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        protected GridLayoutGroup()
        {
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

        private void SetCellsAlongAxis(int axis)
        {
        }
    }
}
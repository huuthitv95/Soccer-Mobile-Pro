namespace Coffee.UIEffects
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIGradient : global::Coffee.UIEffects.BaseMeshEffect
    {
        public enum Direction
        {
            Horizontal = 0,
            Vertical = 1,
            Angle = 2,
            Diagonal = 3
        }

        public enum GradientStyle
        {
            Rect = 0,
            Fit = 1,
            Split = 2
        }

        private static readonly global::UnityEngine.Vector2[] s_SplitedCharacterPosition;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.UIGradient.Direction m_Direction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color1;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color2;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color3;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color4;
        [global::UnityEngine.SerializeField]
        private float m_Rotation;
        [global::UnityEngine.SerializeField]
        private float m_Offset1;
        [global::UnityEngine.SerializeField]
        private float m_Offset2;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.UIGradient.GradientStyle m_GradientStyle;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.ColorSpace m_ColorSpace;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreAspectRatio;
        public global::Coffee.UIEffects.UIGradient.Direction direction
        {
            get
            {
                return global::Coffee.UIEffects.UIGradient.Direction.Horizontal;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color color1
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color color2
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color color3
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color color4
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float rotation
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float offset
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 offset2
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.UIGradient.GradientStyle gradientStyle
        {
            get
            {
                return global::Coffee.UIEffects.UIGradient.GradientStyle.Rect;
            }

            set
            {
            }
        }

        public global::UnityEngine.ColorSpace colorSpace
        {
            get
            {
                return global::UnityEngine.ColorSpace.Gamma;
            }

            set
            {
            }
        }

        public bool ignoreAspectRatio
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }
    }
}
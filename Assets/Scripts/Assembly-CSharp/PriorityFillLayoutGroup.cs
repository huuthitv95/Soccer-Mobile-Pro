public class PriorityFillLayoutGroup : global::UnityEngine.UI.LayoutGroup
{
    public enum FillDirection
    {
        Horizontal = 0,
        Vertical = 1
    }

    [global::UnityEngine.SerializeField]
    private PriorityFillLayoutGroup.FillDirection fillDirection;
    [global::UnityEngine.SerializeField]
    private float spacing;
    [global::UnityEngine.SerializeField]
    private float lineSpacing;
    [global::UnityEngine.SerializeField]
    private bool respectChildrenWidth;
    [global::UnityEngine.SerializeField]
    private bool respectChildrenHeight;
    [global::UnityEngine.SerializeField]
    private bool childForceExpandWidth;
    [global::UnityEngine.SerializeField]
    private bool childForceExpandHeight;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_ChildPositions;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_ChildSizes;
    private bool m_PositionsCalculated;
    public PriorityFillLayoutGroup.FillDirection Direction
    {
        get
        {
            return PriorityFillLayoutGroup.FillDirection.Horizontal;
        }

        set
        {
        }
    }

    public float Spacing
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public float LineSpacing
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool RespectChildrenWidth
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool RespectChildrenHeight
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool ChildForceExpandWidth
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool ChildForceExpandHeight
    {
        get
        {
            return false;
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

    private void CalcAlongAxis(int axis)
    {
    }

    private void SetChildrenAlongAxis(int axis)
    {
    }

    private void CalculateChildPositions(float width, float height)
    {
    }

    private float GetChildWidth(global::UnityEngine.RectTransform child)
    {
        return 0f;
    }

    private float GetChildHeight(global::UnityEngine.RectTransform child)
    {
        return 0f;
    }

    private void ApplyRowAlignment(float startX, float y, float availableWidth, float rowHeight, float rowY)
    {
    }

    private void ApplyColumnAlignment(float x, float startY, float colWidth, float availableHeight, float colX)
    {
    }

    protected override void OnEnable()
    {
    }

    protected override void OnDisable()
    {
    }
}
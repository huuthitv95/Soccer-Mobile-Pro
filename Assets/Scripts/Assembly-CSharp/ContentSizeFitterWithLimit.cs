public class ContentSizeFitterWithLimit : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutSelfController, global::UnityEngine.UI.ILayoutController
{
    public enum FitMode
    {
        Unconstrained = 0,
        MinSize = 1,
        PreferredSize = 2
    }

    [global::UnityEngine.SerializeField]
    protected ContentSizeFitterWithLimit.FitMode m_HorizontalFit;
    [global::UnityEngine.SerializeField]
    protected float m_MaxWidth;
    [global::UnityEngine.SerializeField]
    protected ContentSizeFitterWithLimit.FitMode m_VerticalFit;
    [global::UnityEngine.SerializeField]
    protected float m_MaxHeight;
    [global::System.NonSerialized]
    private global::UnityEngine.RectTransform m_Rect;
    private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
    public ContentSizeFitterWithLimit.FitMode horizontalFit
    {
        get
        {
            return ContentSizeFitterWithLimit.FitMode.Unconstrained;
        }

        set
        {
        }
    }

    public float maxWidth
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public ContentSizeFitterWithLimit.FitMode verticalFit
    {
        get
        {
            return ContentSizeFitterWithLimit.FitMode.Unconstrained;
        }

        set
        {
        }
    }

    public float maxHeight
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    private global::UnityEngine.RectTransform rectTransform => null;

    protected override void OnEnable()
    {
    }

    protected override void OnDisable()
    {
    }

    protected override void OnRectTransformDimensionsChange()
    {
    }

    private void HandleSelfFittingAlongAxis(int axis)
    {
    }

    public virtual void SetLayoutHorizontal()
    {
    }

    public virtual void SetLayoutVertical()
    {
    }

    protected void SetDirty()
    {
    }
}
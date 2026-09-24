public class ContentSizeFitterWithMinLimit : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutSelfController, global::UnityEngine.UI.ILayoutController
{
    public enum FitMode
    {
        Unconstrained = 0,
        MinSize = 1,
        PreferredSize = 2
    }

    [global::UnityEngine.SerializeField]
    protected ContentSizeFitterWithMinLimit.FitMode m_HorizontalFit;
    [global::UnityEngine.SerializeField]
    protected float m_MinWidth;
    [global::UnityEngine.SerializeField]
    protected ContentSizeFitterWithMinLimit.FitMode m_VerticalFit;
    [global::UnityEngine.SerializeField]
    protected float m_MinHeight;
    [global::System.NonSerialized]
    private global::UnityEngine.RectTransform m_Rect;
    private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
    public ContentSizeFitterWithMinLimit.FitMode horizontalFit
    {
        get
        {
            return ContentSizeFitterWithMinLimit.FitMode.Unconstrained;
        }

        set
        {
        }
    }

    public float minWidth
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public ContentSizeFitterWithMinLimit.FitMode verticalFit
    {
        get
        {
            return ContentSizeFitterWithMinLimit.FitMode.Unconstrained;
        }

        set
        {
        }
    }

    public float minHeight
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
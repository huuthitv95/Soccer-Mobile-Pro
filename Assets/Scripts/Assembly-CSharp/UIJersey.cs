public class UIJersey : global::UnityEngine.EventSystems.UIBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer target;
    private global::UnityEngine.RectTransform maskRect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform _exclude;
    private global::UnityEngine.Vector3[] m_Corners;
    private int frameCount;
    public global::UnityEngine.RectTransform exclude
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    protected override void Awake()
    {
    }

    public void UpdateCullInfo()
    {
    }

    public void ResetExcludeArea()
    {
    }

    protected override void OnEnable()
    {
    }

    protected void Update()
    {
    }

    protected override void OnRectTransformDimensionsChange()
    {
    }

    protected override void OnBeforeTransformParentChanged()
    {
    }

    protected override void OnTransformParentChanged()
    {
    }

    protected override void OnCanvasGroupChanged()
    {
    }

    protected override void OnCanvasHierarchyChanged()
    {
    }
}
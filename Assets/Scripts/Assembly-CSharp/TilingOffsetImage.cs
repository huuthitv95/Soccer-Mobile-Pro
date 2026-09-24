public class TilingOffsetImage : global::UnityEngine.UI.Image
{
    public enum UvSourceMode
    {
        Manual = 0,
        ReferenceImageCoverage = 1
    }

    private enum ClipEdge
    {
        Left = 0,
        Right = 1,
        Bottom = 2,
        Top = 3
    }

    private const float ClipEpsilon = 0.0001f;
    [global::UnityEngine.SerializeField]
    private TilingOffsetImage.UvSourceMode _uvSourceMode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 _uvTiling;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 _uvOffset;
    [global::UnityEngine.SerializeField]
    private bool _clampUvToSprite;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image _referenceImage;
    [global::UnityEngine.SerializeField]
    private bool _syncReferenceSprite;
    [global::UnityEngine.SerializeField]
    private bool _clipToReferenceRect;
    [global::UnityEngine.SerializeField]
    private bool _refreshReferenceUvEveryFrame;
    private global::UnityEngine.UIVertex _vertex;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector2> _polygon;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector2> _clipBuffer;
    public TilingOffsetImage.UvSourceMode SourceMode
    {
        get
        {
            return TilingOffsetImage.UvSourceMode.Manual;
        }

        set
        {
        }
    }

    public global::UnityEngine.Vector2 UvTiling
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public global::UnityEngine.Vector2 UvOffset
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public bool ClampUvToSprite
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public global::UnityEngine.UI.Image ReferenceImage
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public bool SyncReferenceSprite
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool ClipToReferenceRect
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool RefreshReferenceUvEveryFrame
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public void SetUv(global::UnityEngine.Vector2 tiling, global::UnityEngine.Vector2 offset)
    {
    }

    public global::UnityEngine.UI.Image FindParentImage()
    {
        return null;
    }

    public void RefreshUv()
    {
    }

    public void UseParentImage()
    {
    }

    protected override void OnEnable()
    {
    }

    private void LateUpdate()
    {
    }

    protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
    {
    }

    protected override void OnDidApplyAnimationProperties()
    {
    }

    protected override void OnRectTransformDimensionsChange()
    {
    }

    protected override void OnTransformParentChanged()
    {
    }

    private void AddChildCornerToReferencePolygon(global::UnityEngine.Vector2 childLocalPosition, global::UnityEngine.RectTransform referenceRectTransform)
    {
    }

    private void AddReferenceVertex(global::UnityEngine.UI.VertexHelper vertexHelper, global::UnityEngine.RectTransform referenceRectTransform, global::UnityEngine.Rect referenceRect, global::UnityEngine.Vector4 referenceUv, global::UnityEngine.Vector2 referenceLocalPosition, global::UnityEngine.Color32 vertexColor)
    {
    }

    private void ApplyManualUv(global::UnityEngine.UI.VertexHelper vertexHelper)
    {
    }

    private void ApplyReferenceSprite()
    {
    }

    private void BuildChildPolygonInReferenceSpace(global::UnityEngine.RectTransform referenceRectTransform)
    {
    }

    private void ClipPolygonAgainstEdge(TilingOffsetImage.ClipEdge clipEdge, float edgeValue)
    {
    }

    private void ClipPolygonToRect(global::UnityEngine.Rect rect)
    {
    }

    private void CopyClipBufferToPolygon()
    {
    }

    private global::UnityEngine.UI.Image GetReferenceImage()
    {
        return null;
    }

    private global::UnityEngine.Rect GetReferenceDrawingRect(global::UnityEngine.UI.Image referenceImage)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetReferenceUv(global::UnityEngine.Rect referenceRect, global::UnityEngine.Vector4 referenceUv, global::UnityEngine.Vector2 referenceLocalPosition)
    {
        return default;
    }

    private global::UnityEngine.Vector4 GetReferenceUvBounds(global::UnityEngine.UI.Image referenceImage)
    {
        return default;
    }

    private global::UnityEngine.Rect GetUvBounds(global::UnityEngine.UI.VertexHelper vertexHelper)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetClipIntersection(global::UnityEngine.Vector2 startPoint, global::UnityEngine.Vector2 endPoint, TilingOffsetImage.ClipEdge clipEdge, float edgeValue)
    {
        return default;
    }

    private bool IsInsideClipEdge(global::UnityEngine.Vector2 point, TilingOffsetImage.ClipEdge clipEdge, float edgeValue)
    {
        return false;
    }

    private bool TryPopulateReferenceImageCoverageMesh(global::UnityEngine.UI.VertexHelper vertexHelper)
    {
        return false;
    }
}
public class MirrorSprite : global::UnityEngine.UI.BaseMeshEffect
{
    public enum eMirrorType
    {
        Horizontal = 0,
        Vertical = 1,
        Quarter = 2,
        Flip = 3
    }

    [global::UnityEngine.SerializeField]
    private MirrorSprite.eMirrorType MirrorType;
    private global::System.Collections.Generic.List<global::UnityEngine.UIVertex> mVerts;
    private global::System.Collections.Generic.List<int> mIndices;
    private global::UnityEngine.UIVertex mVertex;
    public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void SetIndice()
    {
    }

    private void FixUV()
    {
    }

    private void Mirror(bool isHorizontal, bool isFlip = false)
    {
    }

    private void DrawSprite()
    {
    }

    private void AutoAdapt()
    {
    }

    private void ChangeChildAnchor(global::UnityEngine.RectTransform parent)
    {
    }

    public void NormalToMirror()
    {
    }
}
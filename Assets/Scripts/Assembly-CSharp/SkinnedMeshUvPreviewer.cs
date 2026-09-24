public class SkinnedMeshUvPreviewer : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.Renderer targetRenderer;
    public string mainTextureProperty;
    public int previewSize;
    public bool autoRefresh;
    [global::UnityEngine.HideInInspector]
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RenderTexture uvPreviewTexture;
    [global::UnityEngine.SerializeField]
    [global::UnityEngine.HideInInspector]
    private global::UnityEngine.Vector2 uvMin;
    [global::UnityEngine.HideInInspector]
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 uvMax;
    [global::UnityEngine.HideInInspector]
    [global::UnityEngine.SerializeField]
    private int uvCount;
    [global::UnityEngine.HideInInspector]
    [global::UnityEngine.SerializeField]
    private string uvInfo;
    public global::UnityEngine.RenderTexture UvPreviewTexture => null;
    public global::UnityEngine.Vector2 UvMin => default;
    public global::UnityEngine.Vector2 UvMax => default;
    public int UvCount => 0;
    public string UvInfo => null;

    private void OnValidate()
    {
    }

    private void OnDisable()
    {
    }

    public void RefreshPreview()
    {
    }

    private static global::UnityEngine.Mesh GetTargetMesh(global::UnityEngine.Renderer renderer)
    {
        return null;
    }

    public void ClearPreview()
    {
    }

    private void UpdateUvStatsAndInfo(global::UnityEngine.Vector2[] uvs)
    {
    }

    private void EnsurePreviewTexture()
    {
    }

    private void DrawUvCrop(global::UnityEngine.Texture mainTex)
    {
    }

    private void ReleasePreviewTexture()
    {
    }
}
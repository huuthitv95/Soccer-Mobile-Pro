public class SharedMeshBaker : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.SkinnedMeshRenderer bakeSource;
    private global::UnityEngine.MeshRenderer _meshRenderer;
    private global::UnityEngine.MeshFilter _meshFilter;
    [global::UnityEngine.SerializeField]
    private string sharedTag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Material[] material;
    private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Mesh> sharedMesh;
    [global::UnityEngine.SerializeField]
    private bool isSupplier;
    private global::UnityEngine.Mesh _mesh;
    public static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Mesh> SharedMesh => null;

    public string SharedTag
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    public void Bake()
    {
    }

    public void SetMaterialProperty(global::UnityEngine.MaterialPropertyBlock props)
    {
    }

    private void OnBecameInvisible()
    {
    }

    private void OnBecameVisible()
    {
    }
}
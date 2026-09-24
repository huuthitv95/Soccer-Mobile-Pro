public class MeshBaker : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.SkinnedMeshRenderer bakeSource;
    private global::UnityEngine.MeshRenderer _meshRenderer;
    private global::UnityEngine.MeshFilter _meshFilter;
    private global::UnityEngine.Mesh _mesh;
    [global::UnityEngine.SerializeField]
    public ShadowMaterialsSupplier materialsSupplier;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void Update()
    {
    }
}
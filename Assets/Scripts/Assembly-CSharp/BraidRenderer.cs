public class BraidRenderer : global::UnityEngine.MonoBehaviour
{
    public int fixedHierarchyLevel;
    public global::UnityEngine.Transform _rootBone;
    public global::UnityEngine.Transform[] _bones;
    private global::UnityEngine.Matrix4x4[] _bindposes;
    public BraidSphereCollider[] _colliders;
    public global::UnityEngine.Matrix4x4[] bindposes => null;

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Update()
    {
    }

    private void LateUpdate()
    {
    }
}
public class RectMaskMeshClipBinder : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer targetRenderer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RectMask2D rectMask;
    [global::UnityEngine.SerializeField]
    private bool updateEveryFrame;
    private static readonly int ClipRectId;
    private const string ClipKeyword = "UNITY_UI_CLIP_RECT";
    private static readonly global::UnityEngine.Vector4 DisabledClipRect;
    private global::UnityEngine.Vector3[] corners;
    private global::UnityEngine.MaterialPropertyBlock propertyBlock;
    private void OnEnable()
    {
    }

    private void LateUpdate()
    {
    }

    private void OnDisable()
    {
    }

    private void CacheReferences()
    {
    }

    private void Apply()
    {
    }

    private void ApplyDisabled()
    {
    }

    private void EnableKeywordOnAllMaterials()
    {
    }

    private void DisableKeywordOnAllMaterials()
    {
    }

    private global::UnityEngine.Material[] GetMaterialsForKeywordUpdate()
    {
        return null;
    }
}
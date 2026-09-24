[global::UnityEngine.DisallowMultipleComponent]
public class WorldSpaceCanvasFrustumFitter : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera targetCamera;
    [global::UnityEngine.SerializeField]
    private bool fitOnEnable;
    [global::UnityEngine.SerializeField]
    private bool fitEveryFrame;
    [global::UnityEngine.SerializeField]
    private bool alignToCameraForward;
    private global::UnityEngine.Canvas canvas;
    private global::UnityEngine.RectTransform rectTransform;
    private readonly global::UnityEngine.Vector3[] viewportCorners;
    private readonly global::UnityEngine.Vector3[] worldCorners;
    private void OnEnable()
    {
    }

    private void OnValidate()
    {
    }

    private void LateUpdate()
    {
    }

    public void FitNow()
    {
    }

    private void CacheReferences()
    {
    }
}
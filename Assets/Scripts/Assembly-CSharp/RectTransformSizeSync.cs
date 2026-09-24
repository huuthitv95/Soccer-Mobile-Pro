[global::UnityEngine.DisallowMultipleComponent]
public class RectTransformSizeSync : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform sourceRect;
    [global::UnityEngine.SerializeField]
    private bool syncLeft;
    [global::UnityEngine.SerializeField]
    private bool syncRight;
    [global::UnityEngine.SerializeField]
    private bool syncTop;
    [global::UnityEngine.SerializeField]
    private bool syncBottom;
    [global::UnityEngine.SerializeField]
    private bool syncOnEnable;
    [global::UnityEngine.SerializeField]
    private bool syncEveryFrame;
    private global::UnityEngine.RectTransform targetRect;
    private global::UnityEngine.RectTransform parentRect;
    private readonly global::UnityEngine.Vector3[] sourceWorldCorners;
    private readonly global::UnityEngine.Vector3[] targetWorldCorners;
    private void OnEnable()
    {
    }

    private void OnValidate()
    {
    }

    private void LateUpdate()
    {
    }

    public void SyncNow()
    {
    }

    private void CacheReferences()
    {
    }
}
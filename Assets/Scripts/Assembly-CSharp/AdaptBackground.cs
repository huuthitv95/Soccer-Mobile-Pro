public class AdaptBackground : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform[] bg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform full;
    private static float WH_rate;
    private static float screenHeight;
    private const float threshold = 1.6f;
    private void Start()
    {
    }
}
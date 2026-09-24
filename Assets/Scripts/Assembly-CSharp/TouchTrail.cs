public class TouchTrail : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private SlideInput slideInput;
    private global::UnityEngine.LineRenderer lineRenderer;
    private float startTime;
    private float fadeSpeed;
    private global::UnityEngine.Color startColor;
    private global::UnityEngine.Camera camera;
    public float m_MinVertexDistance;
    public float duration;
    private const float POSITION_TOLERANCE = 0.01f;
    private int removeCount;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> m_positions;
    private global::System.Collections.Generic.List<float> m_times;
    private bool slide;
    private global::UnityEngine.Vector2 _lastTouch;
    private global::UnityEngine.RaycastHit[] hits;
    private void Awake()
    {
    }

    private void Update()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void ShowFingerTrail(global::UnityEngine.Touch t)
    {
    }

    private void Fade()
    {
    }
}
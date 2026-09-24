public class LineRenderLight : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.LineRenderer baseLine;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color lightColor;
    private float currentProgress;
    [global::UnityEngine.SerializeField]
    private float speed;
    private float time;
    private global::System.Collections.Generic.List<global::UnityEngine.Gradient> gradients;
    private void Awake()
    {
    }

    private void Update()
    {
    }
}
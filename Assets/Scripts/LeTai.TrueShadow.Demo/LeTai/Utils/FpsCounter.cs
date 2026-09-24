namespace LeTai.Utils
{
    public class FpsCounter : global::UnityEngine.MonoBehaviour
    {
        private const long FPS_SAMPLE_PERIOD = 500L;
        private string displayFormat;
        private global::UnityEngine.UI.Text text;
        private int framesSinceLast;
        private global::System.Diagnostics.Stopwatch stopwatch;
        private void Start()
        {
        }

        private void Update()
        {
        }
    }
}
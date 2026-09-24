namespace SL
{
    public class FpsDisplay : global::UnityEngine.MonoBehaviour
    {
        public float fpsMeasuringDelta;
        private float timePassed;
        private int m_FrameCount;
        private float m_FPS;
        private global::UnityEngine.GUIStyle bb;
        private global::UnityEngine.Rect fpstextPos;
        private string fpstext;
        private void Start()
        {
        }

        private void Update()
        {
        }

        private void OnGUI()
        {
        }
    }
}
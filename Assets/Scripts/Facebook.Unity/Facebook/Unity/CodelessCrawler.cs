namespace Facebook.Unity
{
    public class CodelessCrawler : global::UnityEngine.MonoBehaviour
    {
        private static bool isGeneratingSnapshot;
        private static global::UnityEngine.Camera mainCamera;
        public void Awake()
        {
        }

        public void CaptureViewHierarchy(string message)
        {
        }

        private global::System.Collections.IEnumerator GenSnapshot()
        {
            return null;
        }

        private static void SendAndroid(string json)
        {
        }

        private static void SendIos(string json)
        {
        }

        private static string GenBase64Screenshot()
        {
            return null;
        }

        private static string GenViewJson()
        {
            return null;
        }

        private static void GenChild(global::UnityEngine.GameObject curObj, global::System.Text.StringBuilder builder)
        {
        }

        private void onActiveSceneChanged(global::UnityEngine.SceneManagement.Scene arg0, global::UnityEngine.SceneManagement.Scene arg1)
        {
        }

        private static void updateMainCamera()
        {
        }

        private static global::UnityEngine.Vector2 getScreenCoordinate(global::UnityEngine.Vector3 position, global::UnityEngine.RenderMode renderMode)
        {
            return default;
        }

        private static string getClasstypeBitmaskButton()
        {
            return null;
        }

        private static string getVisibility(global::UnityEngine.GameObject gameObj)
        {
            return null;
        }
    }
}
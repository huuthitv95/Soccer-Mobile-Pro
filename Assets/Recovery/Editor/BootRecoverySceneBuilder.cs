// Recovery-only authoring utility; it never changes original scenes or Build Settings.
using System;
using System.IO;
using Soccer.Recovery.Boot;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Soccer.Recovery.Editor
{
    public static class BootRecoverySceneBuilder
    {
        public const string BootLaunchPath = "Assets/Recovery/Scenes/BootLaunch.unity";
        public const string BootStartPath = "Assets/Recovery/Scenes/BootStart.unity";
        private static readonly Color Ink = new Color(0.025f, 0.065f, 0.08f, 1f);
        private static readonly Color Accent = new Color(0.70f, 0.98f, 0.35f, 1f);
        private static Font font;

        [MenuItem("Recovery/Open Boot Recovery")]
        public static void Open()
        {
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                EditorSceneManager.OpenScene(BootLaunchPath);
        }

        public static void GenerateBatch()
        {
            try { Generate(); EditorApplication.Exit(0); }
            catch (Exception exception) { Debug.LogException(exception); EditorApplication.Exit(1); }
        }

        public static void Generate()
        {
            if (File.Exists(BootLaunchPath) || File.Exists(BootStartPath))
                throw new InvalidOperationException("Boot recovery scenes already exist; refusing to overwrite edits.");
            font = AssetDatabase.LoadAssetAtPath<Font>("Assets/ui/font/BAHNSCHRIFT.ttf");
            if (font == null) throw new InvalidOperationException("Recovered font missing.");
            Directory.CreateDirectory(Path.GetDirectoryName(BootLaunchPath));
            GenerateLaunch();
            GenerateStart();
            AssetDatabase.SaveAssets();
        }

        private static void GenerateLaunch()
        {
            var scene = OpenInertReference("Launch");
            var canvas = CanvasRoot("Boot Recovery Canvas");
            var background = Image("Recovered Launch background", canvas.transform, Vector2.zero, Vector2.zero, Color.white);
            background.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/loading_worldcup26.asset");
            if (background.sprite == null) throw new InvalidOperationException("Recovered Launch background missing.");
            background.rectTransform.ToStretch();
            Image("Safe overlay", canvas.transform, Vector2.zero, Vector2.zero, new Color(0.01f, 0.035f, 0.05f, 0.84f)).rectTransform.ToStretch();
            Text("Recovery label", canvas.transform, "SOCCER MOBILE PRO  /  BOOT RECOVERY", new Vector2(0, 340), new Vector2(1420, 42), 27, Accent, TextAnchor.MiddleCenter);
            Text("Heading", canvas.transform, "Launch → Start", new Vector2(0, 145), new Vector2(1420, 130), 82, Color.white, TextAnchor.MiddleCenter);
            Text("Status", canvas.transform, "Offline adapter: cloud callback and frame gate are being verified.", new Vector2(0, 52), new Vector2(1420, 52), 28, new Color(0.76f, 0.84f, 0.85f), TextAnchor.MiddleCenter);
            var slider = Slider("Verified progress", canvas.transform, new Vector2(0, -64), new Vector2(720, 36));
            Text("Scope", canvas.transform, "No account, analytics, advertising, cloud save, or original scene loading is executed.", new Vector2(0, -180), new Vector2(1500, 70), 24, new Color(0.76f, 0.84f, 0.85f), TextAnchor.MiddleCenter);
            Text("Evidence", canvas.transform, "StartGame: Start / Awake / CheckLoadCloudSave / Update / DoNext", new Vector2(0, -285), new Vector2(1500, 40), 21, Accent, TextAnchor.MiddleCenter);
            new GameObject("Boot Recovery EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            var services = new GameObject("Offline boot services", typeof(OfflineBootCloudSaveAdapter), typeof(OfflineBootSceneNavigator));
            var startScript = AssetDatabase.LoadAssetAtPath<MonoScript>("Assets/Scripts/Assembly-CSharp/StartGame.cs");
            if (startScript == null || startScript.GetClass() == null) throw new InvalidOperationException("Recovered StartGame script is unavailable.");
            var start = services.AddComponent(startScript.GetClass());
            var serialized = new SerializedObject(start);
            serialized.FindProperty("_loading").objectReferenceValue = slider;
            serialized.ApplyModifiedPropertiesWithoutUndo();
            services.name = "Offline boot services (recovery only)";
            EditorSceneManager.SaveScene(scene, BootLaunchPath);
        }

        private static void GenerateStart()
        {
            var scene = OpenInertReference("Start");
            var canvas = CanvasRoot("Recovery Start Canvas");
            Image("Background", canvas.transform, Vector2.zero, Vector2.zero, Ink).rectTransform.ToStretch();
            Text("Recovery label", canvas.transform, "SOCCER MOBILE PRO  /  BOOT RECOVERY", new Vector2(0, 270), new Vector2(1420, 42), 27, Accent, TextAnchor.MiddleCenter);
            Text("Heading", canvas.transform, "Start reached.", new Vector2(0, 80), new Vector2(1420, 130), 82, Color.white, TextAnchor.MiddleCenter);
            Text("Stop marker", canvas.transform, "The verified recovery flow ends here. UI_Load and Lobby remain unrecovered.", new Vector2(0, -54), new Vector2(1500, 60), 28, new Color(0.76f, 0.84f, 0.85f), TextAnchor.MiddleCenter);
            new GameObject("Boot Start Marker", typeof(BootStartMarker));
            EditorSceneManager.SaveScene(scene, BootStartPath);
        }

        private static Canvas CanvasRoot(string name)
        {
            var canvas = new GameObject(name, typeof(RectTransform), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster)).GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var scaler = canvas.GetComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 1f;
            return canvas;
        }
        private static UnityEngine.SceneManagement.Scene OpenInertReference(string name)
        {
            var scene = EditorSceneManager.OpenScene("Assets/Recovery/ReferenceScenes/" + name + ".Reference.unity");
            foreach (var root in scene.GetRootGameObjects())
            {
                if (root.activeSelf) throw new InvalidOperationException("Reference root must be inactive before import: " + root.name);
                root.name = "Inert original / " + root.name;
            }
            return scene;
        }
        private static RectTransform Rect(string name, Transform parent, Vector2 position, Vector2 size)
        {
            var value = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
            value.SetParent(parent, false); value.anchorMin = value.anchorMax = new Vector2(0.5f, 0.5f);
            value.anchoredPosition = position; value.sizeDelta = size; return value;
        }
        private static Image Image(string name, Transform parent, Vector2 position, Vector2 size, Color color)
        {
            var value = Rect(name, parent, position, size).gameObject.AddComponent<Image>();
            value.color = color; value.raycastTarget = false; return value;
        }
        private static Text Text(string name, Transform parent, string text, Vector2 position, Vector2 size, int fontSize, Color color, TextAnchor alignment)
        {
            var value = Rect(name, parent, position, size).gameObject.AddComponent<Text>();
            value.font = font; value.text = text; value.fontSize = fontSize; value.color = color; value.alignment = alignment;
            value.raycastTarget = false; return value;
        }
        private static Slider Slider(string name, Transform parent, Vector2 position, Vector2 size)
        {
            var root = Rect(name, parent, position, size);
            var slider = root.gameObject.AddComponent<Slider>();
            var track = Image("Track", root, Vector2.zero, new Vector2(size.x, 8), new Color(0.16f, 0.25f, 0.29f));
            var fillArea = Rect("Fill area", root, Vector2.zero, new Vector2(size.x - 16, 8));
            var fill = Image("Fill", fillArea, Vector2.zero, new Vector2(size.x - 16, 8), Accent);
            fill.rectTransform.anchorMin = Vector2.zero; fill.rectTransform.anchorMax = Vector2.one; fill.rectTransform.offsetMin = fill.rectTransform.offsetMax = Vector2.zero;
            var handleArea = Rect("Handle area", root, Vector2.zero, new Vector2(size.x - 16, size.y));
            var handle = Image("Handle", handleArea, Vector2.zero, new Vector2(20, 30), Color.white);
            slider.fillRect = fill.rectTransform; slider.handleRect = handle.rectTransform; slider.targetGraphic = handle;
            slider.minValue = 0f; slider.maxValue = 1f; slider.value = 0f;
            return slider;
        }
    }

    internal static class RectTransformExtensions
    {
        public static void ToStretch(this RectTransform transform)
        {
            transform.anchorMin = Vector2.zero; transform.anchorMax = Vector2.one;
            transform.offsetMin = transform.offsetMax = Vector2.zero;
        }
    }
}

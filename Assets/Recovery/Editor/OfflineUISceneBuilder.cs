// Recovery-only authoring utility; original scenes and Build Settings are untouched.
using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Soccer.Recovery.Editor
{
    public static class OfflineUISceneBuilder
    {
        public const string ScenePath = "Assets/Recovery/Scenes/OfflineUI.unity";
        private static Font font;
        private static readonly Color Ink = new Color(0.025f, 0.065f, 0.08f, 1);
        private static readonly Color Accent = new Color(0.70f, 0.98f, 0.35f, 1);
        private static readonly Color Muted = new Color(0.69f, 0.77f, 0.78f, 1);

        [MenuItem("Recovery/Open Offline UI")]
        public static void Open()
        {
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                EditorSceneManager.OpenScene(ScenePath);
        }

        public static void GenerateBatch()
        {
            try { Generate(); EditorApplication.Exit(0); }
            catch (Exception e) { Debug.LogException(e); EditorApplication.Exit(1); }
        }

        public static void Generate()
        {
            if (File.Exists(ScenePath)) throw new InvalidOperationException("Offline scene already exists; refusing to overwrite edits.");
            font = AssetDatabase.LoadAssetAtPath<Font>("Assets/ui/font/BAHNSCHRIFT.ttf");
            if (font == null) throw new InvalidOperationException("Recovered font missing.");
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var camera = new GameObject("Offline Camera").AddComponent<Camera>();
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = Ink;
            camera.orthographic = true;
            camera.transform.position = new Vector3(0, 0, -100);
            camera.cullingMask = 1 << 5;
            var canvas = new GameObject("Offline Canvas", typeof(RectTransform), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster)).GetComponent<Canvas>();
            canvas.gameObject.layer = 5;
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = camera;
            canvas.planeDistance = 10;
            var scaler = canvas.GetComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 1;
            new GameObject("Offline EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));

            var background = Image("Recovered Launch background", canvas.transform, Vector2.zero, new Vector2(1920, 1080), Color.white);
            background.sprite = SpriteAsset("loading_worldcup26");
            background.preserveAspect = false;
            Stretch(background.rectTransform);
            var veil = Image("Dark overlay", canvas.transform, Vector2.zero, Vector2.zero, new Color(0.01f, 0.035f, 0.05f, 0.88f));
            Stretch(veil.rectTransform);
            var content = Rect("Content", canvas.transform, Vector2.zero, new Vector2(1728, 900));
            Text("Eyebrow", content, "SOCCER MOBILE PRO  /  RECOVERY LAB", new Vector2(-420, 411), new Vector2(880, 36), 25, Accent);
            Text("Mode", content, "OFFLINE  /  01", new Vector2(684, 411), new Vector2(340, 36), 23, Muted, TextAnchor.MiddleRight);
            Image("Top rule", content, new Vector2(0, 365), new Vector2(1728, 2), new Color(1, 1, 1, 0.16f));
            var welcome = Rect("Welcome", content, new Vector2(-466, -2), new Vector2(790, 640));
            Text("Heading", welcome, "Trở lại\nsân cỏ.", new Vector2(0, 172), new Vector2(790, 260), 88, Color.white);
            Text("Description", welcome, "Khám phá giao diện từ tài nguyên đã khôi phục.\nBản xem trước hoạt động hoàn toàn offline.", new Vector2(0, -17), new Vector2(790, 100), 29, Muted);
            var view = Button("View team", welcome, "Xem đội bóng  →", new Vector2(-158, -147), new Vector2(470, 88), Accent, Ink);
            Text("Disclaimer", welcome, "DỮ LIỆU MẪU  ·  CHƯA KHÔI PHỤC GAMEPLAY", new Vector2(0, -252), new Vector2(790, 44), 21, Muted);

            var team = Rect("Team preview", content, new Vector2(-466, -2), new Vector2(790, 640));
            Text("Heading", team, "Đội bóng\ncủa bạn.", new Vector2(0, 172), new Vector2(790, 250), 82, Color.white);
            Text("Sample label", team, "HỒ SƠ OFFLINE  /  DỮ LIỆU MẪU", new Vector2(0, 5), new Vector2(790, 50), 23, Accent);
            Text("Sample description", team, "Đội hình mẫu: 11 cầu thủ  ·  Sơ đồ: 4–3–3\nChưa có mô phỏng trận đấu hoặc dữ liệu tài khoản.", new Vector2(0, -67), new Vector2(790, 86), 27, Muted);
            Button("Back", team, "←  Quay lại", new Vector2(-158, -192), new Vector2(470, 80), new Color(0.13f, 0.20f, 0.23f, 1), Color.white);

            var card = Image("Team card", content, new Vector2(506, -5), new Vector2(640, 630), new Color(0.045f, 0.105f, 0.13f, 0.97f));
            Image("Card accent", card.transform, new Vector2(0, 313), new Vector2(640, 4), Accent);
            Text("Card label", card.transform, "TỪ BỘ TÀI NGUYÊN GỐC", new Vector2(0, 257), new Vector2(544, 40), 23, Muted);
            var badge = Image("Recovered badge", card.transform, new Vector2(0, 101), new Vector2(194, 194), Color.white);
            badge.sprite = SpriteAsset("badge_mancity"); badge.preserveAspect = true;
            Text("Club", card.transform, "MANCHESTER CITY", new Vector2(0, -42), new Vector2(544, 60), 35, Color.white, TextAnchor.MiddleCenter);
            Text("Card note", card.transform, "Hình ảnh trích từ scene Launch", new Vector2(0, -101), new Vector2(544, 40), 23, Muted, TextAnchor.MiddleCenter);
            Text("Slider label", card.transform, "THỬ TƯƠNG TÁC UI", new Vector2(-56, -180), new Vector2(430, 36), 20, Muted);
            var valueText = Text("Slider value", card.transform, "50%", new Vector2(229, -180), new Vector2(85, 36), 24, Accent, TextAnchor.MiddleRight);
            var sliderRoot = Rect("Preview slider", card.transform, new Vector2(0, -230), new Vector2(544, 48));
            sliderRoot.gameObject.AddComponent<Image>().color = Color.clear;
            var slider = sliderRoot.gameObject.AddComponent<Slider>();
            Image("Track", sliderRoot, Vector2.zero, new Vector2(544, 6), new Color(0.2f, 0.3f, 0.34f));
            var fillArea = Rect("Fill area", sliderRoot, Vector2.zero, new Vector2(520, 6));
            var fill = Image("Fill", fillArea, Vector2.zero, new Vector2(520, 6), Accent);
            Stretch(fill.rectTransform);
            var handleArea = Rect("Handle area", sliderRoot, Vector2.zero, new Vector2(520, 48));
            var handle = Image("Handle", handleArea, Vector2.zero, new Vector2(22, 30), Color.white);
            handle.rectTransform.sizeDelta = new Vector2(22, -18);
            slider.fillRect = fill.rectTransform; slider.handleRect = handle.rectTransform; slider.targetGraphic = handle;
            slider.value = 0.5f;
            Text("Footer", content, "UNITY 2020.3.49f1     /     UI OFFLINE", new Vector2(-420, -418), new Vector2(880, 36), 21, Muted);
            Text("Footer right", content, "ASSET RECOVERY  ·  NO GAME SERVICES", new Vector2(514, -418), new Vector2(700, 36), 19, Muted, TextAnchor.MiddleRight);
            var state = new GameObject("Offline UI Controller");
            state.SetActive(false);
            var controller = state.AddComponent<OfflineUIController>();
            controller.Configure(welcome.gameObject, team.gameObject, view, team.GetComponentInChildren<Button>(), slider, valueText);
            team.gameObject.SetActive(false);
            state.SetActive(true);
            Directory.CreateDirectory(Path.GetDirectoryName(ScenePath));
            EditorSceneManager.SaveScene(scene, ScenePath);
            AssetDatabase.SaveAssets();
            Debug.Log("Offline recovery scene generated: " + ScenePath);
        }

        private static Sprite SpriteAsset(string name)
        {
            var asset = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/" + name + ".asset");
            if (asset == null) throw new InvalidOperationException("Recovered sprite missing: " + name);
            return asset;
        }
        private static RectTransform Rect(string name, Transform parent, Vector2 position, Vector2 size)
        {
            var r = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
            r.gameObject.layer = 5; r.SetParent(parent, false); r.anchorMin = r.anchorMax = new Vector2(0.5f, 0.5f);
            r.anchoredPosition = position; r.sizeDelta = size; return r;
        }
        private static void Stretch(RectTransform r) { r.anchorMin = Vector2.zero; r.anchorMax = Vector2.one; r.offsetMin = r.offsetMax = Vector2.zero; }
        private static Image Image(string name, Transform parent, Vector2 p, Vector2 size, Color color)
        {
            var image = Rect(name, parent, p, size).gameObject.AddComponent<Image>();
            image.color = color; image.raycastTarget = false; return image;
        }
        private static Text Text(string name, Transform parent, string text, Vector2 p, Vector2 size, int fontSize, Color color, TextAnchor alignment = TextAnchor.MiddleLeft)
        {
            var label = Rect(name, parent, p, size).gameObject.AddComponent<Text>();
            label.font = font; label.text = text; label.fontSize = fontSize; label.color = color;
            label.alignment = alignment; label.raycastTarget = false; label.supportRichText = false; return label;
        }
        private static Button Button(string name, Transform parent, string title, Vector2 p, Vector2 size, Color fill, Color ink)
        {
            var image = Image(name, parent, p, size, fill); image.raycastTarget = true;
            var button = image.gameObject.AddComponent<Button>(); button.targetGraphic = image;
            var colors = button.colors; colors.highlightedColor = new Color(0.9f, 1, 0.9f); colors.pressedColor = new Color(0.65f, 0.8f, 0.65f); button.colors = colors;
            Text("Label", image.transform, title, Vector2.zero, size - new Vector2(34, 8), 31, ink, TextAnchor.MiddleCenter);
            return button;
        }
    }
}

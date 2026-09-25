#if UNITY_EDITOR
using System;
using System.IO;
using Soccer.Recovery.Lobby;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Soccer.Recovery.Editor
{
    public static class LobbyRecoverySceneBuilder
    {
        private const string Launch = "Assets/Recovery/Scenes/LobbyLaunch.unity";
        private const string Start = "Assets/Recovery/Scenes/LobbyStart.unity";
        private const string Lobby = "Assets/Recovery/Scenes/LobbyOffline.unity";
        private const string Reference = "Assets/Recovery/ReferenceScenes/Lobby.Reference.unity";
        private const string OriginalPrefab = "Assets/gamedata/ui/windows/mainview/MainViewWithShop.prefab";
        private const string SafePrefab = "Assets/Recovery/Lobby/MainViewWithShop.Offline.prefab";
        private const string Manifest = "Assets/Recovery/Lobby/LobbyContentManifest.asset";
        private static Font font;
        private static readonly Color Ink = new Color(0.025f, 0.065f, 0.08f, 1f);
        private static readonly Color Accent = new Color(0.70f, 0.98f, 0.35f, 1f);

        [MenuItem("Recovery/Open Lobby Recovery")]
        public static void Open()
        {
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                EditorSceneManager.OpenScene(Launch);
        }

        public static void GenerateBatch()
        {
            try { Generate(); EditorApplication.Exit(0); }
            catch (Exception e) { Debug.LogException(e); EditorApplication.Exit(1); }
        }

        public static void Generate()
        {
            foreach (var path in new[] { Launch, Start, Lobby, Reference, SafePrefab, Manifest })
                if (File.Exists(path)) throw new InvalidOperationException("Refusing to overwrite recovery asset: " + path);
            font = AssetDatabase.LoadAssetAtPath<Font>("Assets/ui/font/BAHNSCHRIFT.ttf");
            if (font == null) throw new InvalidOperationException("Recovered font is missing.");
            Directory.CreateDirectory("Assets/Recovery/Scenes");
            Directory.CreateDirectory("Assets/Recovery/ReferenceScenes");
            PrepareSafePrefab();
            CreateManifest();
            CreateLaunch();
            CreateStart();
            CreateLobby();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void PrepareSafePrefab()
        {
            var root = PrefabUtility.LoadPrefabContents(OriginalPrefab);
            try
            {
                root.SetActive(false);
                foreach (var behaviour in root.GetComponentsInChildren<Behaviour>(true))
                {
                    var type = behaviour.GetType();
                    var safeUi = type.Namespace == "UnityEngine.UI";
                    if (!safeUi) behaviour.enabled = false;
                    if (behaviour is Button button)
                    {
                        var serialized = new SerializedObject(button);
                        var calls = serialized.FindProperty("m_OnClick.m_PersistentCalls.m_Calls");
                        if (calls != null) calls.arraySize = 0;
                        serialized.ApplyModifiedPropertiesWithoutUndo();
                        button.interactable = false;
                    }
                }
                if (PrefabUtility.SaveAsPrefabAsset(root, SafePrefab) == null)
                    throw new InvalidOperationException("Could not write isolated prefab copy.");
            }
            finally { PrefabUtility.UnloadPrefabContents(root); }
        }

        private static void CreateManifest()
        {
            var manifest = ScriptableObject.CreateInstance<LobbyContentManifest>();
            manifest.SetEntries(new[] { new LobbyContentManifest.Entry {
                NativeAssetPath = "Assets/GameData/UI/Windows/MainView/MainViewWithShop.prefab",
                LocalPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(SafePrefab),
                Guid = AssetDatabase.AssetPathToGUID(SafePrefab)
            }});
            AssetDatabase.CreateAsset(manifest, Manifest);
        }

        private static void CreateLaunch()
        {
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCanvas("Lobby Recovery Launch");
            StretchImage("Background", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/loading_worldcup26.asset"), 0.28f);
            Label("Recovery heading", "SOCCER MOBILE PRO", new Vector2(0, 180), new Vector2(1300, 120), 78, Color.white);
            Label("Recovery scope", "Start → Lobby / OFFLINE PROFILE", new Vector2(0, 95), new Vector2(1300, 60), 29, Accent);
            Label("Recovery explanation", "Services are simulated in memory. Game actions remain unavailable.", new Vector2(0, 20), new Vector2(1450, 52), 26, Color.white);
            var button = MakeButton("Begin offline startup", "BẮT ĐẦU", new Vector2(0, -120), new Vector2(420, 90));
            button.gameObject.AddComponent<LobbyRecoveryLaunchAction>();
            new GameObject("Recovery EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            var navigator = new GameObject("Lobby recovery navigator"); navigator.AddComponent<LobbyRecoverySceneNavigator>();
            EditorSceneManager.SaveScene(scene, Launch);
        }

        private static void CreateStart()
        {
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCanvas("Verified Start gate");
            StretchImage("Background", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/loading_worldcup26.asset"), 0.3f);
            Label("Start title", "START → LOBBY", new Vector2(0, 170), new Vector2(1200, 110), 72, Color.white);
            Label("Start note", "Offline profile: resource, save, network, AB-test and content gates", new Vector2(0, 55), new Vector2(1500, 70), 27, Accent);
            Label("Teaching note", "Teaching-match branch is recorded and blocked by this recovery harness.", new Vector2(0, -65), new Vector2(1500, 60), 24, Color.white);
            new GameObject("Synthetic startup dependencies", typeof(OfflineLobbyStartupAdapter), typeof(LobbyRecoverySceneNavigator));
            new GameObject("Verified UI_Load gate adapter", typeof(LobbyRecoveryController));
            new GameObject("Recovery EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            EditorSceneManager.SaveScene(scene, Start);
        }

        private static void CreateLobby()
        {
            var scene = EditorSceneManager.OpenScene("Assets/Scenes/UI/Lobby.unity", OpenSceneMode.Single);
            foreach (var root in scene.GetRootGameObjects())
            {
                root.SetActive(false);
                foreach (var behaviour in root.GetComponentsInChildren<Behaviour>(true)) behaviour.enabled = false;
                root.name = "Inert original / " + root.name;
            }
            if (!EditorSceneManager.SaveScene(scene, Reference)) throw new InvalidOperationException("Could not save inert Lobby reference.");
            scene = EditorSceneManager.OpenScene(Reference, OpenSceneMode.Single);
            var canvas = CreateCanvas("Lobby offline overlay");
            canvas.sortingOrder = 20;
            var safePrefab = AssetDatabase.LoadAssetAtPath<GameObject>(SafePrefab);
            if (safePrefab == null) throw new InvalidOperationException("Isolated MainView prefab is missing.");
            var visuals = (GameObject)PrefabUtility.InstantiatePrefab(safePrefab, scene);
            visuals.name = "Recovered MainView visuals (scripts isolated)";
            visuals.transform.SetParent(canvas.transform, false);
            visuals.SetActive(true);
            Label("Offline banner", "LOBBY / OFFLINE RECOVERY", new Vector2(0, 440), new Vector2(1200, 58), 28, Accent);

            var interactionObject = new GameObject("Offline menu interaction");
            var interaction = interactionObject.AddComponent<LobbyOfflineInteraction>();
            var panel = new GameObject("Offline information panel", typeof(RectTransform), typeof(Image));
            panel.transform.SetParent(canvas.transform, false);
            var panelRect = panel.GetComponent<RectTransform>(); panelRect.anchorMin = panelRect.anchorMax = new Vector2(.5f,.5f); panelRect.sizeDelta = new Vector2(780,420);
            panel.GetComponent<Image>().color = Ink;
            var heading = Label("Information title", "OFFLINE INFORMATION", new Vector2(0,130), new Vector2(700,70), 38, Accent, panel.transform);
            var body = Label("Information detail", "", new Vector2(0,25), new Vector2(680,120), 26, Color.white, panel.transform);
            var back = MakeButton("Return to Lobby", "QUAY LẠI", new Vector2(0,-125), new Vector2(340,72), panel.transform);
            panel.SetActive(false);
            interaction.Configure(panel, heading, body, back);

            var names = new[] { "PlayerCareer", "MasterLeague", "Friendly", "Shop", "Training" };
            var titles = new[] { "Sự nghiệp cầu thủ", "Master League", "Giao hữu", "Cửa hàng", "Huấn luyện" };
            var width = 300f;
            for (var i=0;i<names.Length;i++)
            {
                var x = (i - 2) * (width + 16);
                var item = MakeButton(names[i], titles[i], new Vector2(x,-390), new Vector2(width,76));
                var action = item.gameObject.AddComponent<LobbyOfflineAction>(); action.Configure(names[i], titles[i]);
            }
            Label("Offline disclaimer", "Nút menu mở thông tin mẫu; trận đấu, đăng nhập và cửa hàng thật chưa khả dụng.", new Vector2(0,-475), new Vector2(1650,44), 21, Color.white);
            new GameObject("Recovery EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            new GameObject("Lobby recovery load marker", typeof(LobbyLoadedMarker));
            EditorSceneManager.SaveScene(scene, Lobby);
        }

        private static Canvas CreateCanvas(string name)
        {
            var value = new GameObject(name, typeof(RectTransform), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster)).GetComponent<Canvas>();
            value.renderMode = RenderMode.ScreenSpaceOverlay;
            var scale = value.GetComponent<CanvasScaler>(); scale.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scale.referenceResolution = new Vector2(1920,1080); scale.matchWidthOrHeight = .5f;
            return value;
        }
        private static Image StretchImage(string name, Sprite sprite, float alpha)
        {
            var image = new GameObject(name, typeof(RectTransform), typeof(Image)).GetComponent<Image>();
            image.transform.SetParent(GameObject.Find("Lobby Recovery Launch")?.transform ?? GameObject.Find("Verified Start gate")?.transform, false);
            if (image.transform.parent == null) image.transform.SetParent(GameObject.Find("Lobby offline overlay").transform, false);
            image.rectTransform.anchorMin = Vector2.zero; image.rectTransform.anchorMax=Vector2.one; image.rectTransform.offsetMin=image.rectTransform.offsetMax=Vector2.zero;
            image.sprite = sprite; image.color = new Color(1,1,1,alpha); image.raycastTarget=false; return image;
        }
        private static Text Label(string name,string value,Vector2 pos,Vector2 size,int fontSize,Color color,Transform parent=null)
        {
            var text = new GameObject(name,typeof(RectTransform),typeof(Text)).GetComponent<Text>();
            if(parent==null) parent=GameObject.Find("Lobby Recovery Launch")?.transform ?? GameObject.Find("Verified Start gate")?.transform ?? GameObject.Find("Lobby offline overlay").transform;
            text.transform.SetParent(parent,false); text.rectTransform.anchorMin=text.rectTransform.anchorMax=new Vector2(.5f,.5f);
            text.rectTransform.anchoredPosition=pos; text.rectTransform.sizeDelta=size; text.font=font; text.fontSize=fontSize;
            text.color=color; text.alignment=TextAnchor.MiddleCenter; text.horizontalOverflow=HorizontalWrapMode.Wrap; text.verticalOverflow=VerticalWrapMode.Overflow;
            text.raycastTarget=false; text.text=value; return text;
        }
        private static Button MakeButton(string name,string caption,Vector2 pos,Vector2 size,Transform parent=null)
        {
            if(parent==null) parent=GameObject.Find("Lobby Recovery Launch")?.transform ?? GameObject.Find("Lobby offline overlay").transform;
            var button=new GameObject(name,typeof(RectTransform),typeof(Image),typeof(Button));
            button.transform.SetParent(parent,false); var rect=button.GetComponent<RectTransform>(); rect.anchorMin=rect.anchorMax=new Vector2(.5f,.5f); rect.anchoredPosition=pos; rect.sizeDelta=size;
            button.GetComponent<Image>().color=Accent;
            Label("Label",caption,Vector2.zero,size,25,Ink,button.transform);
            var result=button.GetComponent<Button>(); result.targetGraphic=button.GetComponent<Image>(); return result;
        }
    }

}
#endif

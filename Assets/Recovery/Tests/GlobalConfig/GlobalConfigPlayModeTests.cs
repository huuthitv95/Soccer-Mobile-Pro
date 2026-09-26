#if UNITY_EDITOR
using System;
using System.Collections;
using System.IO;
using NUnit.Framework;
using Soccer.Recovery.GlobalConfig;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Soccer.Recovery.Tests
{
    public sealed class GlobalConfigPlayModeTests
    {
        private GameObject root;
        private string directory;
        private OfflineConfigWindow window;
        [UnitySetUp] public IEnumerator Setup()
        {
            foreach(var existing in UnityEngine.Object.FindObjectsOfType<OfflineConfigWindow>()) UnityEngine.Object.Destroy(existing.gameObject);
            foreach(var existing in UnityEngine.Object.FindObjectsOfType<EventSystem>()) UnityEngine.Object.Destroy(existing.gameObject);
            yield return null;
            directory=Path.Combine(Path.GetTempPath(),"SoccerGlobalConfig-"+Guid.NewGuid().ToString("N"));
            root=new GameObject("config-test"); root.AddComponent<EventSystem>(); root.AddComponent<StandaloneInputModule>();
            window=root.AddComponent<OfflineConfigWindow>(); window.Initialize(Path.Combine(directory,"config.json"));
            yield return null;
        }
        [UnityTearDown] public IEnumerator Cleanup()
        { UnityEngine.Object.Destroy(root); yield return null; if(Directory.Exists(directory))Directory.Delete(directory,true); LogAssert.NoUnexpectedReceived(); }
        private T Find<T>(string name) where T:Component { foreach(var c in root.GetComponentsInChildren<T>(true))if(c.name==name)return c;throw new Exception(name); }
        private void Click(string name) { var b=Find<Button>(name); ExecuteEvents.Execute(b.gameObject,new PointerEventData(EventSystem.current){button=PointerEventData.InputButton.Left},ExecuteEvents.pointerClickHandler); }

        [UnityTest] public IEnumerator PointerOpenCloseSearchAndReadOnlyFields()
        {
            Assert.IsFalse(window.IsOpen); Click("Open offline config"); yield return null; Assert.IsTrue(window.IsOpen);
            Find<InputField>("Config search").text="BlockRV"; yield return null;
            Assert.IsTrue(Find<Text>("BlockRV unsupported").gameObject.activeInHierarchy);
            Assert.IsFalse(Find<InputField>("Config name").gameObject.activeInHierarchy);
            Assert.AreEqual(0,Find<Text>("BlockRV unsupported").transform.parent.GetComponentsInChildren<Selectable>().Length);
            Click("Close config"); Assert.IsFalse(window.IsOpen);
        }
        [UnityTest] public IEnumerator SaveChangesAllFourConsumersAndReloads()
        {
            window.Open(); Find<InputField>("Config name").text="Test profile"; Find<InputField>("Config opacity").text="0.70";
            Find<Toggle>("Config showBanner").isOn=false; Click("Config accent"); Click("Save config"); yield return null;
            Assert.IsFalse(window.BannerVisible); Assert.AreEqual("Hồ sơ: Test profile",window.AppliedProfile);
            Assert.AreEqual(.70f,window.AppliedOpacity,.001f); Assert.AreEqual(OfflineAccent.Blue,window.Session.Current.accent);
            Assert.AreEqual(new Color(.35f,.75f,1),window.AppliedAccent);
            var fresh=new OfflineConfigSession(new OfflineConfigStore(window.StoragePath));
            Assert.AreEqual("Test profile",fresh.Current.profileName); Assert.AreEqual(.7f,fresh.Current.panelOpacity); Assert.IsFalse(fresh.Current.showBanner); Assert.AreEqual(OfflineAccent.Blue,fresh.Current.accent);
        }
        [UnityTest] public IEnumerator InvalidNumberAndNameDoNotPersistOrApply()
        {
            window.Open(); Find<InputField>("Config opacity").text="NaN"; Click("Save config"); yield return null;
            Assert.IsFalse(File.Exists(window.StoragePath)); Assert.AreEqual(.96f,window.AppliedOpacity,.001f);
            Find<InputField>("Config opacity").text="0.80"; Find<InputField>("Config name").text=" "; Click("Save config");
            Assert.IsFalse(File.Exists(window.StoragePath)); Assert.AreEqual("Offline",window.Session.Current.profileName);
        }
        [UnityTest] public IEnumerator CancelAndDefaultsAreTransactional()
        {
            window.Open(); Find<InputField>("Config name").text="Saved"; Click("Save config");
            Find<InputField>("Config name").text="Discard"; Click("Cancel config"); window.Open();
            Assert.AreEqual("Saved",Find<InputField>("Config name").text);
            Click("Reset config"); Assert.AreEqual("Saved",window.Session.Current.profileName); Click("Cancel config"); window.Open(); Assert.AreEqual("Saved",Find<InputField>("Config name").text);
            Click("Reset config"); Click("Save config"); yield return null; Assert.AreEqual("Offline",window.Session.Current.profileName);
        }
        [UnityTest] public IEnumerator CorruptAndFutureConfigArePreserved()
        {
            Directory.CreateDirectory(directory);
            foreach(var json in new[]{"{broken", "{}", "{\"version\":2,\"showBanner\":true,\"panelOpacity\":0.8,\"profileName\":\"Future\",\"accent\":0}"})
            { File.WriteAllText(window.StoragePath,json); var store=new OfflineConfigStore(window.StoragePath);Assert.AreEqual("Offline",store.Load().profileName);Assert.IsNotNull(store.LoadNotice);Assert.AreEqual(json,File.ReadAllText(window.StoragePath)); }
            Assert.AreEqual(3,Directory.GetFiles(directory,"*.invalid-*.json").Length); yield return null;
        }
        [UnityTest] public IEnumerator StorageFailureKeepsAppliedConfiguration()
        {
            Directory.CreateDirectory(directory); var path=Path.Combine(directory,"directory-not-file");Directory.CreateDirectory(path);
            var session=new OfflineConfigSession(new OfflineConfigStore(path));session.Draft.profileName="Changed";string error;
            Assert.IsFalse(session.Save(out error));Assert.IsNotEmpty(error);Assert.AreEqual("Offline",session.Current.profileName);
            Assert.AreEqual(0,Directory.GetFiles(directory,"*.tmp-*").Length);yield return null;
        }
        [UnityTest] public IEnumerator OriginalPrefabResolvesReplacementAndLobbyLaunchesIt()
        {
            var prefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/gamedata/ui/windows/Win_GlobalConfig.prefab");
            Assert.AreEqual(0,GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(prefab));
            var component=prefab.GetComponent<OfflineConfigWindow>();Assert.IsNotNull(component);Assert.AreEqual("Win_GlobalConfig",component.GetType().FullName);Assert.AreEqual("Assembly-CSharp",component.GetType().Assembly.GetName().Name);
            UnityEngine.Object.Destroy(root);yield return null;
            EditorSceneManager.LoadSceneInPlayMode("Assets/Recovery/Scenes/LobbyOffline.unity",new UnityEngine.SceneManagement.LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode.Single));
            yield return null;yield return null;
            var live=UnityEngine.Object.FindObjectOfType<OfflineConfigWindow>();Assert.IsNotNull(live);Assert.IsNotNull(live.Session);live.Open();yield return null;Assert.IsTrue(live.IsOpen);
            var report=Environment.GetEnvironmentVariable("SOCCER_GLOBALCONFIG_REPORTS");
            if(!string.IsNullOrEmpty(report)) Capture(live,Path.Combine(report,"globalconfig-lobby.png"));
            live.Cancel();Assert.IsFalse(live.IsOpen);
        }
        private static void Capture(OfflineConfigWindow live,string path)
        {
            var canvas=live.GetComponentInChildren<Canvas>();
            var go=new GameObject("Config evidence camera");var camera=go.AddComponent<Camera>();
            camera.clearFlags=CameraClearFlags.SolidColor;camera.backgroundColor=new Color(.04f,.07f,.1f);
            var target=new RenderTexture(1920,1080,24);camera.targetTexture=target;
            var previous=RenderTexture.active;
            canvas.renderMode=RenderMode.ScreenSpaceCamera;canvas.worldCamera=camera;canvas.planeDistance=1;
            Canvas.ForceUpdateCanvases();camera.Render();RenderTexture.active=target;
            var texture=new Texture2D(1920,1080,TextureFormat.RGB24,false);texture.ReadPixels(new Rect(0,0,1920,1080),0,0);texture.Apply();
            File.WriteAllBytes(path,texture.EncodeToPNG());RenderTexture.active=previous;camera.targetTexture=null;
            canvas.worldCamera=null;canvas.renderMode=RenderMode.ScreenSpaceOverlay;
            UnityEngine.Object.Destroy(texture);UnityEngine.Object.Destroy(target);UnityEngine.Object.Destroy(go);
        }
    }
}
#endif

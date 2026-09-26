#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Soccer.Recovery.Lobby;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Soccer.Recovery.Tests
{
    public sealed class LobbyFlowPlayModeTests
    {
        private sealed class Startup : ILobbyStartupServices
        {
            public LobbyRecoveryProfile Profile { get; } = new LobbyRecoveryProfile();
            public readonly Dictionary<LobbyDependency,LobbyReadiness> States = new Dictionary<LobbyDependency,LobbyReadiness>();
            public Startup(LobbyReadiness initial)
            { foreach (LobbyDependency d in Enum.GetValues(typeof(LobbyDependency))) States[d]=initial; }
            public LobbyReadiness Readiness(LobbyDependency d)=>States[d];
        }
        private sealed class Navigator : ILobbySceneNavigator
        {
            public int LobbyCalls, StartCalls;
            private bool requested;
            public bool TryLoad(string path){if(requested||path!=LobbyRecoveryController.LobbyScenePath)return false; requested=true; LobbyCalls++; return true;}
            public bool TryLoadStart(){if(requested)return false; requested=true; StartCalls++; return true;}
        }
        private Startup startup;
        private Navigator navigator;
        private GameObject fixture;

        [UnitySetUp] public IEnumerator SetUp()
        {
            LobbyRecoveryServices.Reset();
            LobbyRecoveryRunConfiguration.NextProfile=null;
            startup=new Startup(LobbyReadiness.Ready); navigator=new Navigator();
            LobbyRecoveryServices.Register(startup); LobbyRecoveryServices.Register(navigator);
            yield return null;
        }
        [UnityTearDown] public IEnumerator TearDown()
        {
            var traceDirectory = Environment.GetEnvironmentVariable("SOCCER_LOBBY_TRACE_DIR");
            if (!string.IsNullOrEmpty(traceDirectory))
            {
                Directory.CreateDirectory(traceDirectory);
                var name = NUnit.Framework.TestContext.CurrentContext.Test.Name;
                File.WriteAllLines(Path.Combine(traceDirectory, name + ".trace.txt"), LobbyRecoveryTrace.Timeline);
            }
            if(fixture!=null) UnityEngine.Object.Destroy(fixture);
            yield return null; LobbyRecoveryServices.Reset(); LobbyRecoveryRunConfiguration.NextProfile=null; LogAssert.NoUnexpectedReceived();
        }
        private LobbyRecoveryController Controller()
        { fixture=new GameObject("Lobby gate test"); return fixture.AddComponent<LobbyRecoveryController>(); }

        [UnityTest] public IEnumerator PendingDependencyBlocksTransitionAndReportsWhichGate()
        {
            startup.States[LobbyDependency.SaveCallback]=LobbyReadiness.Pending;
            var controller=Controller(); yield return null; yield return null;
            Assert.AreEqual(0,navigator.LobbyCalls);
            Assert.IsTrue(string.Join("\n",LobbyRecoveryTrace.Timeline).Contains("WaitingForDependency / SaveCallback"));
            startup.States[LobbyDependency.SaveCallback]=LobbyReadiness.Ready;
            for(int i=0;i<10 && navigator.LobbyCalls==0;i++) yield return null;
            Assert.AreEqual(1,navigator.LobbyCalls); Assert.IsFalse(controller.Failed);
        }
        [UnityTest] public IEnumerator FailedDependencyStopsAndNamesFailure()
        {
            startup.States[LobbyDependency.CoreContent]=LobbyReadiness.Failed;
            var controller=Controller(); yield return null; yield return null;
            Assert.IsTrue(controller.Failed); Assert.AreEqual(0,navigator.LobbyCalls);
            Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.DependencyFailed));
        }
        [UnityTest] public IEnumerator NativeResourcePressAndNotchGatesEachBlockUntilReady()
        {
            foreach(var gate in new[]{LobbyDependency.ResourceManager,LobbyDependency.PressStart,LobbyDependency.NotchInitialized})
            {
                LobbyRecoveryServices.Reset(); startup=new Startup(LobbyReadiness.Ready); navigator=new Navigator();
                startup.States[gate]=LobbyReadiness.Pending;
                LobbyRecoveryServices.Register(startup); LobbyRecoveryServices.Register(navigator);
                fixture=new GameObject("native gate "+gate); var controller=fixture.AddComponent<LobbyRecoveryController>();
                for(int i=0;i<3;i++) yield return null;
                Assert.AreEqual(0,navigator.LobbyCalls,"Native gate did not block: "+gate);
                Assert.IsFalse(controller.Failed);
                startup.States[gate]=LobbyReadiness.Ready;
                for(int i=0;i<30 && navigator.LobbyCalls==0;i++) yield return null;
                Assert.AreEqual(1,navigator.LobbyCalls,"Native gate did not resume: "+gate);
                UnityEngine.Object.Destroy(fixture); fixture=null; yield return null;
            }
        }
        [UnityTest] public IEnumerator AbTestUsesVerifiedFiveSecondNativeFallback()
        {
            startup.States[LobbyDependency.AbTest]=LobbyReadiness.Pending;
            startup.Profile.AbTestElapsedOverrideSeconds=5f;
            var controller=Controller();
            for(int i=0;i<500 && navigator.LobbyCalls==0;i++) yield return null;
            Assert.IsFalse(controller.Failed); Assert.AreEqual(1,navigator.LobbyCalls);
            Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.AbTestPassed));
            Assert.IsTrue(string.Join("\n",LobbyRecoveryTrace.Timeline).Contains("native 5s default fallback"));
        }
        [UnityTest] public IEnumerator PendingGateWatchdogIsTestOnlyAndHasNoRuntimeTimeout()
        {
            startup.States[LobbyDependency.AbTest]=LobbyReadiness.Pending;
            var controller=Controller();
            for(int i=0;i<20;i++) yield return null;
            Assert.IsFalse(controller.Failed); Assert.AreEqual(0,navigator.LobbyCalls);
            Assert.IsTrue(string.Join("\n",LobbyRecoveryTrace.Timeline).Contains("WaitingForDependency / AbTest"));
        }
        [UnityTest] public IEnumerator AllReadyRequestsLobbyExactlyOnce()
        {
            var controller=Controller(); yield return null; yield return null;
            controller.BeginOfflineStartup(); controller.BeginOfflineStartup(); yield return null;
            Assert.AreEqual(1,navigator.LobbyCalls);
            Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.LobbyTransitionRequested));
        }
        [UnityTest] public IEnumerator TeachingMatchBranchIsBlockedAndNeverLoadsLobby()
        {
            startup.Profile.TeachingMatchSelected=true;
            var controller=Controller(); yield return null; yield return null;
            Assert.IsTrue(controller.Failed); Assert.AreEqual(0,navigator.LobbyCalls);
            Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.TeachingMatchBlocked));
        }
        [UnityTest] public IEnumerator LaunchNavigatorUsesOnlyRecoveryStart()
        {
            fixture=new GameObject("Navigator fixture"); yield return null;
            navigator=new Navigator(); LobbyRecoveryServices.Register(navigator);
            Assert.IsTrue(LobbyRecoveryServices.Navigator.TryLoadStart());
            Assert.IsFalse(LobbyRecoveryServices.Navigator.TryLoadStart());
            Assert.IsFalse(LobbyRecoveryServices.Navigator.TryLoad("Assets/Scenes/UI/Lobby.unity"));
        }
        [UnityTest] public IEnumerator OriginalLobbySceneAndIsolatedPrefabReachableWithoutGameServices()
        {
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode("Assets/Recovery/Scenes/LobbyOffline.unity",new LoadSceneParameters(LoadSceneMode.Single));
            Assert.AreEqual("Assets/Recovery/Scenes/LobbyOffline.unity",SceneManager.GetActiveScene().path);
            Assert.GreaterOrEqual(LobbyRecoveryTrace.Count(LobbyRecoveryEvent.LobbyLoaded),1);
            Assert.IsNotNull(GameObject.Find("Recovered MainView visuals (scripts isolated)"));
            var visuals=GameObject.Find("Recovered MainView visuals (scripts isolated)");
            foreach(var behaviour in visuals.GetComponentsInChildren<Behaviour>(true))
                Assert.IsFalse(behaviour.enabled && behaviour.GetType().Namespace!="UnityEngine.UI",
                    "Non-UI behaviour enabled in isolated prefab: "+behaviour.GetType().FullName);
            foreach(var button in visuals.GetComponentsInChildren<Button>(true))
                Assert.AreEqual(0,button.onClick.GetPersistentEventCount(),"Original prefab Button callback survived sanitization.");
            foreach(var root in SceneManager.GetActiveScene().GetRootGameObjects())
                if(root.name.StartsWith("Inert original /",StringComparison.Ordinal)) Assert.IsFalse(root.activeInHierarchy);
        }
        [UnityTest] public IEnumerator EndToEndLaunchStartLobbyLoadsOnceForEachOfflineProfile()
        {
            foreach(var mode in new[]{LobbyMode.Legacy,LobbyMode.PlayerCareer})
            {
                LobbyRecoveryRunConfiguration.NextProfile=new LobbyRecoveryProfile{Mode=mode};
                yield return EditorSceneManager.LoadSceneAsyncInPlayMode("Assets/Recovery/Scenes/LobbyLaunch.unity",new LoadSceneParameters(LoadSceneMode.Single));
                LobbyRecoveryTrace.Reset();
                var lobbySceneLoaded=false;
                UnityAction<Scene,LoadSceneMode> onSceneLoaded=(scene,loadMode)=>{if(scene.path=="Assets/Recovery/Scenes/LobbyOffline.unity")lobbySceneLoaded=true;};
                SceneManager.sceneLoaded+=onSceneLoaded;
                GameObject.Find("Begin offline startup").GetComponent<Button>().onClick.Invoke();
                var deadline=Time.realtimeSinceStartup+10f;
                while(!lobbySceneLoaded && Time.realtimeSinceStartup<deadline) yield return null;
                SceneManager.sceneLoaded-=onSceneLoaded;
                Assert.AreEqual("Assets/Recovery/Scenes/LobbyOffline.unity",SceneManager.GetActiveScene().path,
                    "Mode="+mode+"; trace="+string.Join(" | ",LobbyRecoveryTrace.Timeline));
                Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.LobbyTransitionRequested));
                Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.LobbyLoaded));
                Assert.AreEqual(mode,LobbyRecoveryServices.Startup.Profile.Mode);
            }
        }
        [UnityTest] public IEnumerator MenuButtonUsesEventSystemAndReturnsToLobby()
        {
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode("Assets/Recovery/Scenes/LobbyOffline.unity",new LoadSceneParameters(LoadSceneMode.Single));
            var button=GameObject.Find("Friendly").GetComponent<Button>();
            var eventSystem=UnityEngine.Object.FindObjectOfType<EventSystem>();
            Assert.IsNotNull(eventSystem);
            var data=new PointerEventData(eventSystem);
            data.button=PointerEventData.InputButton.Left;
            ExecuteEvents.Execute(button.gameObject,data,ExecuteEvents.pointerDownHandler);
            ExecuteEvents.Execute(button.gameObject,data,ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(button.gameObject,data,ExecuteEvents.pointerClickHandler);
            yield return null;
            Assert.AreEqual(1,LobbyRecoveryTrace.Count(LobbyRecoveryEvent.MenuActionOpened));
            var panel=GameObject.Find("Offline information panel"); Assert.IsTrue(panel.activeSelf);
            var back=GameObject.Find("Return to Lobby").GetComponent<Button>(); back.onClick.Invoke();
            Assert.IsFalse(panel.activeSelf);
        }
        [UnityTest] public IEnumerator PlayerCareerAndLegacyProfilesRemainDistinct()
        {
            startup.Profile.Mode=LobbyMode.Legacy; Assert.AreEqual(LobbyMode.Legacy,startup.Profile.Mode);
            startup.Profile.Mode=LobbyMode.PlayerCareer; Assert.AreEqual(LobbyMode.PlayerCareer,startup.Profile.Mode);
            var controller=Controller(); yield return null; yield return null;
            Assert.AreEqual(1,navigator.LobbyCalls); Assert.IsFalse(controller.Failed);
        }
        [UnityTest] public IEnumerator ThreeFreshSessionsDoNotRetainNavigationState()
        {
            for(int i=0;i<3;i++)
            {
                LobbyRecoveryServices.Reset(); startup=new Startup(LobbyReadiness.Ready); navigator=new Navigator();
                LobbyRecoveryServices.Register(startup); LobbyRecoveryServices.Register(navigator);
                fixture=new GameObject("session "+i); fixture.AddComponent<LobbyRecoveryController>();
                yield return null; yield return null;
                Assert.AreEqual(1,navigator.LobbyCalls);
                UnityEngine.Object.Destroy(fixture); fixture=null; yield return null;
            }
        }
    }
}
#endif

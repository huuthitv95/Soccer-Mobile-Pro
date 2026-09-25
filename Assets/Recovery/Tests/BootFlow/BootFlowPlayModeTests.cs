#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using Soccer.Recovery.Boot;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Soccer.Recovery.Tests
{
    public sealed class BootFlowPlayModeTests
    {
        private const string LaunchPath = "Assets/Recovery/Scenes/BootLaunch.unity";
        private const string StartPath = "Assets/Recovery/Scenes/BootStart.unity";
        private GameObject fixture;
        private Component start;
        private OfflineBootCloudSaveAdapter cloud;
        private readonly CountingNavigator navigator = new CountingNavigator();
        private const BindingFlags PrivateInstance = BindingFlags.NonPublic | BindingFlags.Instance;
        private sealed class CountingNavigator : IBootSceneNavigator
        {
            public int Calls;
            public bool TryLoadRecoveryStart() { Calls++; return true; }
        }
        [UnitySetUp]
        public IEnumerator Setup()
        {
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode(StartPath, new LoadSceneParameters(LoadSceneMode.Single));
            BootRecoveryServices.Reset();
            BootRecoveryRunConfiguration.NextProfile = null;
            navigator.Calls = 0;
        }
        [UnityTearDown]
        public IEnumerator Cleanup()
        {
            var reportDir = Environment.GetEnvironmentVariable("SOCCER_BOOT_REPORTS");
            if (!string.IsNullOrEmpty(reportDir))
            {
                Directory.CreateDirectory(reportDir);
                File.WriteAllLines(Path.Combine(reportDir, TestContext.CurrentContext.Test.Name + ".events.txt"), BootRecoveryTrace.Timeline);
            }
            if (fixture != null) UnityEngine.Object.Destroy(fixture);
            yield return null;
            BootRecoveryRunConfiguration.NextProfile = null;
            LogAssert.NoUnexpectedReceived();
        }
        private void Fixture(BootRecoveryProfile profile)
        {
            BootRecoveryRunConfiguration.NextProfile = profile;
            fixture = new GameObject("Boot evidence fixture");
            fixture.SetActive(false);
            cloud = fixture.AddComponent<OfflineBootCloudSaveAdapter>();
            start = fixture.AddComponent(Type.GetType("StartGame, Assembly-CSharp", true));
            fixture.SetActive(true); // Both real Awake methods run, with the adapter first.
            BootRecoveryServices.RegisterNavigator(navigator);
        }
        private T Field<T>(string name) => (T)start.GetType().GetField(name, PrivateInstance).GetValue(start);
        private void Step() => start.GetType().GetMethod("Update", PrivateInstance).Invoke(start, null);
        private int ErrorCode() => Convert.ToInt32(start.GetType().GetField("startError").GetValue(null));
        private static void Watchdog(bool reached, string waitingFor)
        {
            if (!reached) throw new TimeoutException("Boot test watchdog: waiting for " + waitingFor +
                "; trace=" + string.Join(", ", BootRecoveryTrace.Timeline));
        }
        private IEnumerator Load(BootRecoveryProfile profile)
        {
            BootRecoveryRunConfiguration.NextProfile = profile;
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode(LaunchPath, new LoadSceneParameters(LoadSceneMode.Single));
        }
        private static IEnumerator WaitForStart()
        {
            for (var i = 0; i < 200 && SceneManager.GetActiveScene().path != StartPath; i++) yield return null;
            Watchdog(SceneManager.GetActiveScene().path == StartPath, "recovery Start scene");
            Assert.AreEqual(1, BootRecoveryTrace.Count(BootRecoveryEvent.TransitionRequested));
            Assert.AreEqual(1, BootRecoveryTrace.Count(BootRecoveryEvent.StartSceneLoaded));
        }

        [UnityTest]
        public IEnumerator FirstProbeUnreachableOpensGateOnExactlySixtiethUpdate()
        {
            Fixture(new BootRecoveryProfile { SaveRootReady = false });
            Assert.AreEqual(60, Field<int>("frameDelay")); // RVA D42834
            for (var i = 0; i < 59; i++) Step();
            Assert.IsFalse(Field<bool>("CheckNetworkFinish"));
            Assert.AreEqual(1, Field<int>("frameDelay"));
            Step();
            Assert.IsTrue(Field<bool>("CheckNetworkFinish"));
            Assert.AreEqual(-1, Field<int>("frameDelay")); // RVA D42A84
            Assert.AreEqual(0, navigator.Calls, "Network gate alone cannot transition.");
            yield return null;
        }
        [UnityTest]
        public IEnumerator PreviouslyRecordedProbeNeedsNoSixtyFrameDelay()
        {
            Fixture(new BootRecoveryProfile { NetworkProbePreviouslyRecorded = true, SaveRootReady = false });
            Assert.AreEqual(0, Field<int>("frameDelay"));
            Step();
            Assert.IsTrue(Field<bool>("CheckNetworkFinish"));
            Assert.AreEqual(0, navigator.Calls);
            yield return null;
        }
        [UnityTest]
        public IEnumerator ReachabilityShortCircuitsOutstandingDelay()
        {
            Fixture(new BootRecoveryProfile { SimulatedInternetReachable = true, SaveRootReady = false });
            Step();
            Assert.IsTrue(Field<bool>("CheckNetworkFinish"));
            Assert.AreEqual(-1, Field<int>("frameDelay"));
            yield return null;
        }
        [UnityTest]
        public IEnumerator SaveRootReadinessGatesCloudInvocation()
        {
            var profile = new BootRecoveryProfile { SaveRootReady = false, Outcome = OfflineCloudSaveOutcome.Pending };
            Fixture(profile);
            yield return null;
            Assert.AreEqual(0, cloud.BeginCount);
            Assert.AreEqual(1, BootRecoveryTrace.Count(BootRecoveryEvent.WaitingForSaveRoot));
            profile.SaveRootReady = true;
            for (var i = 0; i < 5 && cloud.BeginCount == 0; i++) yield return null;
            Assert.AreEqual(1, cloud.BeginCount);
            Assert.AreEqual(0, navigator.Calls);
        }
        [UnityTest]
        public IEnumerator PendingCallbackWatchdogDiagnosesWithoutAlteringRuntime()
        {
            Fixture(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending });
            for (var i = 0; i < 70; i++) yield return null;
            Assert.IsTrue(Field<bool>("CheckNetworkFinish"));
            Assert.IsFalse(Field<bool>("CheckCloudSaveFinish"));
            var error = Assert.Throws<TimeoutException>(() => Watchdog(navigator.Calls == 1, "cloud callback"));
            StringAssert.Contains("cloud callback", error.Message);
            StringAssert.Contains("CloudSaveStarted", error.Message);
            Assert.AreEqual(0, navigator.Calls);
        }
        [UnityTest]
        public IEnumerator CloudBeforeNetworkCannotSkipGateAndDuplicateCannotReload()
        {
            Fixture(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending });
            yield return null;
            var callback = cloud.CaptureCompletion();
            Assert.NotNull(callback);
            callback(true);
            Assert.IsFalse(Field<bool>("CheckNetworkFinish"));
            Assert.AreEqual(0, navigator.Calls);
            for (var i = 0; i < 60; i++) Step();
            Assert.AreEqual(1, navigator.Calls);
            callback(false);
            Step();
            Assert.AreEqual(1, navigator.Calls);
            Assert.AreEqual(0, ErrorCode(), "Duplicate callback may not change session error.");
        }
        [UnityTest]
        public IEnumerator FailureSetsInstallErrorAndCompletesGate()
        {
            Fixture(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending, NetworkProbePreviouslyRecorded = true });
            yield return null;
            cloud.CaptureCompletion()(false);
            Assert.AreEqual(1, ErrorCode());
            Assert.AreEqual(1, navigator.Calls);
        }
        [UnityTest]
        public IEnumerator FailurePreservesEarlierVersionError()
        {
            Fixture(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending, InitialError = 2, NetworkProbePreviouslyRecorded = true });
            yield return null;
            cloud.CaptureCompletion()(false);
            Assert.AreEqual(2, ErrorCode());
            Assert.AreEqual(1, navigator.Calls);
        }
        [UnityTest]
        public IEnumerator ProgressUsesNativePercentScaleAndStopsAfterCompletion()
        {
            Fixture(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending });
            var slider = fixture.AddComponent<Slider>();
            start.GetType().GetField("_loading", PrivateInstance).SetValue(start, slider);
            yield return null;
            var progress = cloud.CaptureProgress();
            progress(50f); Assert.AreEqual(0.075f, slider.value, 0.00001f);
            progress(100f); Assert.AreEqual(0.15f, slider.value, 0.00001f);
            cloud.CaptureCompletion()(true);
            progress(0f); Assert.AreEqual(0.15f, slider.value, 0.00001f);
        }
        [UnityTest]
        public IEnumerator SuccessLoadsStartAndAllowsOnlyAuditedComponents()
        {
            yield return Load(new BootRecoveryProfile { CallbackDelayFrames = 2 });
            AssertAudited();
            yield return WaitForStart();
            AssertAudited();
        }
        [UnityTest]
        public IEnumerator FailureAlsoLoadsStartAsNativeCallbackSpecifies()
        {
            yield return Load(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Failure, CallbackDelayFrames = 2 });
            yield return WaitForStart();
            Assert.AreEqual(1, BootRecoveryTrace.Count(BootRecoveryEvent.CloudSaveFailed));
        }
        [UnityTest]
        public IEnumerator ThreeRestartsIgnoreCallbacksFromDestroyedSessions()
        {
            Action<bool> oldCallback = null;
            Action<float> oldProgress = null;
            for (var run = 0; run < 3; run++)
            {
                yield return Load(new BootRecoveryProfile { Outcome = OfflineCloudSaveOutcome.Pending });
                var adapter = UnityEngine.Object.FindObjectOfType<OfflineBootCloudSaveAdapter>();
                Assert.NotNull(adapter);
                for (var i = 0; i < 5 && adapter.CaptureCompletion() == null; i++) yield return null;
                oldCallback?.Invoke(false);
                oldProgress?.Invoke(90f);
                Assert.AreEqual(0, BootRecoveryTrace.Count(BootRecoveryEvent.CloudSaveFailed));
                Assert.AreEqual(0, BootRecoveryTrace.Count(BootRecoveryEvent.TransitionRequested));
                oldCallback = adapter.CaptureCompletion();
                oldProgress = adapter.CaptureProgress();
                Assert.NotNull(oldCallback);
                oldCallback(true);
                yield return WaitForStart();
                oldCallback(false);
                Assert.AreEqual(1, BootRecoveryTrace.Count(BootRecoveryEvent.TransitionRequested));
            }
        }
        private static void AssertAudited()
        {
            var allowed = new HashSet<string> { "StartGame",
                typeof(OfflineBootCloudSaveAdapter).FullName, typeof(OfflineBootSceneNavigator).FullName,
                typeof(BootStartMarker).FullName, typeof(CanvasScaler).FullName, typeof(GraphicRaycaster).FullName,
                typeof(Image).FullName, typeof(Text).FullName, typeof(Slider).FullName,
                "UnityEngine.EventSystems.EventSystem", "UnityEngine.EventSystems.StandaloneInputModule" };
            var originalRoots = 0;
            foreach (var root in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                if (root.name.StartsWith("Inert original / "))
                {
                    originalRoots++;
                    Assert.IsFalse(root.activeSelf);
                    foreach (var component in root.GetComponentsInChildren<MonoBehaviour>(true))
                        Assert.IsTrue(component != null && !component.gameObject.activeInHierarchy);
                }
                foreach (var component in root.GetComponentsInChildren<MonoBehaviour>())
                    if (component.gameObject.activeInHierarchy)
                        Assert.IsTrue(allowed.Contains(component.GetType().FullName), "Unaudited active component: " + component.GetType());
            }
            Assert.Greater(originalRoots, 0, "Recovery scene must retain its inactive original scene copy.");
        }
    }
}
#endif

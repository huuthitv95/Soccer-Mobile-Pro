using System.Collections;
using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyRecoveryController : MonoBehaviour
    {
        public const string LobbyScenePath = "Assets/Recovery/Scenes/LobbyOffline.unity";
        private static readonly LobbyDependency[] Gates = {
            LobbyDependency.ResourceManager, LobbyDependency.PressStart,
            LobbyDependency.NotchInitialized, LobbyDependency.AbTest,
            LobbyDependency.SaveCallback, LobbyDependency.NetworkProbe, LobbyDependency.CoreContent
        };
        private const float NativeAbTestWaitSeconds = 5f;
        private bool requested;
        public bool Started { get; private set; }
        public bool Failed { get; private set; }
        private void Start() { BeginOfflineStartup(); }

        public void BeginOfflineStartup()
        {
            if (Started) return;
            Started = true;
            StartCoroutine(RunGates());
        }

        private IEnumerator RunGates()
        {
            var services = LobbyRecoveryServices.Startup;
            if (services == null) { Failed = true; LobbyRecoveryTrace.Record(LobbyRecoveryEvent.DependencyFailed, "startup adapter missing"); yield break; }
            foreach (var gate in Gates)
            {
                LobbyRecoveryTrace.Record(LobbyRecoveryEvent.WaitingForDependency, gate.ToString());
                var nativeAbTestFallback = false;
                if (gate == LobbyDependency.AbTest)
                {
                    LobbyRecoveryTrace.Record(LobbyRecoveryEvent.AbTestWaitStarted, "native wait threshold=5s");
                    var elapsed = services.Profile.AbTestElapsedOverrideSeconds >= 0f
                        ? services.Profile.AbTestElapsedOverrideSeconds : 0f;
                    while (services.Readiness(gate) == LobbyReadiness.Pending && elapsed < NativeAbTestWaitSeconds)
                    {
                        if (services.Profile.AbTestElapsedOverrideSeconds < 0f) elapsed += Time.deltaTime;
                        yield return null;
                    }
                    if (services.Readiness(gate) == LobbyReadiness.Failed)
                    {
                        Failed = true; LobbyRecoveryTrace.Record(LobbyRecoveryEvent.AbTestFailed, "adapter reported failure"); yield break;
                    }
                    nativeAbTestFallback = services.Readiness(gate) == LobbyReadiness.Pending;
                    LobbyRecoveryTrace.Record(LobbyRecoveryEvent.AbTestPassed,
                        nativeAbTestFallback ? "native 5s default fallback" : "AB-test ready");
                }
                while (!nativeAbTestFallback && services.Readiness(gate) == LobbyReadiness.Pending) yield return null;
                var state = nativeAbTestFallback ? LobbyReadiness.Ready : services.Readiness(gate);
                if (state == LobbyReadiness.Failed)
                {
                    Failed = true; LobbyRecoveryTrace.Record(LobbyRecoveryEvent.DependencyFailed, gate.ToString()); yield break;
                }
                LobbyRecoveryTrace.Record(LobbyRecoveryEvent.DependencyReady, gate + "=" + state);
            }
            if (services.Profile.TeachingMatchSelected)
            {
                Failed = true; LobbyRecoveryTrace.Record(LobbyRecoveryEvent.TeachingMatchBlocked, "native Update has a separate teaching-match path"); yield break;
            }
            if (requested) yield break;
            requested = true;
            LobbyRecoveryTrace.Record(LobbyRecoveryEvent.LobbyTransitionRequested, "Scenes/UI/Lobby");
            if (LobbyRecoveryServices.Navigator == null || !LobbyRecoveryServices.Navigator.TryLoad(LobbyScenePath))
            {
                Failed = true; LobbyRecoveryTrace.Record(LobbyRecoveryEvent.DependencyFailed, "scene navigator rejected transition");
            }
        }
    }
}
